using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    /// <summary>
    /// UserControl Quản lý Voucher & Khuyến mãi (Module M04)
    /// Đáp ứng chính xác mockup M04 của Mộc Café
    /// </summary>
    public partial class ucKhuyenMai : UserControl
    {
        private readonly MockDataService _dataService = MockDataService.Instance;
        private List<Voucher> _hienThiDanhSach = new List<Voucher>();
        private Voucher? _voucherDangChon = null;

        private string _tabLocHienTai = "TatCa"; // "TatCa", "DangHieuLuc", "SapToi", "HetHan"
        private int _trangHienTai = 1;
        private const int SoPhanTuMoiTrang = 6;
        private bool _dangTaoMoi = false;

        public ucKhuyenMai()
        {
            InitializeComponent();
            KhoiTaoSuKien();
            LoadDuLieuVoucher();
        }

        #region 1. Khởi tạo sự kiện giao diện
        private void KhoiTaoSuKien()
        {
            // Các nút Tab lọc trên bảng
            btnTabTatCa.Click += (s, e) => ChonTabLoc("TatCa", btnTabTatCa);
            btnTabDangHieuLuc.Click += (s, e) => ChonTabLoc("DangHieuLuc", btnTabDangHieuLuc);
            btnTabSapToi.Click += (s, e) => ChonTabLoc("SapToi", btnTabSapToi);
            btnTabHetHan.Click += (s, e) => ChonTabLoc("HetHan", btnTabHetHan);

            // Tìm kiếm & Lọc phạm vi
            txtTimKiem.TextChanged += (s, e) => { _trangHienTai = 1; ApDungBoLoc(); };
            cboLocPhamVi.SelectedIndexChanged += (s, e) => { _trangHienTai = 1; ApDungBoLoc(); };

            // Phân trang
            btnPrevPage.Click += (s, e) =>
            {
                if (_trangHienTai > 1)
                {
                    _trangHienTai--;
                    HienThiDanhSachLenBang();
                }
            };
            btnNextPage.Click += (s, e) =>
            {
                int tongTrang = Math.Max(1, (int)Math.Ceiling((double)_hienThiDanhSach.Count / SoPhanTuMoiTrang));
                if (_trangHienTai < tongTrang)
                {
                    _trangHienTai++;
                    HienThiDanhSachLenBang();
                }
            };

            // Sự kiện DataGridView
            dgvVoucher.SelectionChanged += DgvVoucher_SelectionChanged;
            dgvVoucher.CellPainting += DgvVoucher_CellPainting;
            dgvVoucher.CellClick += DgvVoucher_CellClick;

            // Cơ chế giảm giá (RadioButtons)
            rbPhanTram.CheckedChanged += (s, e) => CapNhatGiaoDienCoCheGiam();
            rbTienMat.CheckedChanged += (s, e) => CapNhatGiaoDienCoCheGiam();

            // Toggle Kích hoạt
            toggleKichHoat.CheckedChanged += (s, e) =>
            {
                lblKichHoat.Text = toggleKichHoat.Checked ? "KÍCH HOẠT" : "TẠM NGƯNG";
                lblKichHoat.ForeColor = toggleKichHoat.Checked ? UIHelper.TextMain : ColorTranslator.FromHtml("#C0392B");
            };

            // Các nút thao tác form chi tiết
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += (s, e) => { if (_voucherDangChon != null) HienThiChiTietVoucher(_voucherDangChon); };
            btnTamNgungMa.Click += BtnTamNgungMa_Click;

            // Nút Header trên cùng
            btnTaoVoucher.Click += BtnTaoVoucher_Click;
            btnXuatExcel.Click += (s, e) => MessageBox.Show("Đã xuất danh sách 12 mã Voucher khuyến mãi ra file Excel thành công!", "Xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLichSu.Click += (s, e) => MessageBox.Show("Lịch sử áp dụng: Tổng cộng 215 lượt đơn hàng đã áp dụng voucher trong tháng này, tổng tiền chiết khấu: 4.820.000 đ.", "Lịch sử áp dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 2. Tải & Lọc Dữ Liệu
        private void LoadDuLieuVoucher()
        {
            _trangHienTai = 1;
            ApDungBoLoc();
            CapNhatThongKe();
        }

        private void ChonTabLoc(string tabKey, Button activeBtn)
        {
            _tabLocHienTai = tabKey;
            _trangHienTai = 1;

            // Reset style tất cả các nút tab
            Button[] tabs = { btnTabTatCa, btnTabDangHieuLuc, btnTabSapToi, btnTabHetHan };
            foreach (var b in tabs)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(93, 74, 61);
                b.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            }

            // Kích hoạt tab được chọn
            activeBtn.BackColor = Color.FromArgb(44, 30, 20);
            activeBtn.ForeColor = Color.White;
            activeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            ApDungBoLoc();
        }

        private void ApDungBoLoc()
        {
            string tuKhoa = (txtTimKiem.Text ?? "").Trim().ToLower();
            int phamViIdx = cboLocPhamVi.SelectedIndex;

            _hienThiDanhSach = _dataService.DanhSachVoucher.Where(v =>
            {
                // Lọc theo từ khóa
                bool matchTuKhoa = string.IsNullOrEmpty(tuKhoa) ||
                                  v.MaVoucher.ToLower().Contains(tuKhoa) ||
                                  v.TenChuongTrinh.ToLower().Contains(tuKhoa);

                // Lọc theo Tab trạng thái
                bool matchTab = true;
                if (_tabLocHienTai == "DangHieuLuc") matchTab = v.TrangThai == "Đang hiệu lực";
                else if (_tabLocHienTai == "SapToi") matchTab = v.TrangThai == "Sắp diễn ra";
                else if (_tabLocHienTai == "HetHan") matchTab = v.TrangThai == "Hết hạn" || v.TrangThai == "Hết lượt" || v.TrangThai == "Tạm dừng";

                // Lọc theo phạm vi áp dụng
                bool matchPhamVi = true;
                if (phamViIdx == 1) matchPhamVi = v.PhamVi == "Tại quán" || v.PhamVi == "Tất cả";
                else if (phamViIdx == 2) matchPhamVi = v.PhamVi == "Mang về" || v.PhamVi == "Tất cả";

                return matchTuKhoa && matchTab && matchPhamVi;
            }).ToList();

            HienThiDanhSachLenBang();
        }

        private void HienThiDanhSachLenBang()
        {
            dgvVoucher.SuspendLayout();
            dgvVoucher.Rows.Clear();

            int tongSo = _hienThiDanhSach.Count;
            int tongTrang = Math.Max(1, (int)Math.Ceiling((double)tongSo / SoPhanTuMoiTrang));
            if (_trangHienTai > tongTrang) _trangHienTai = tongTrang;

            int skip = (_trangHienTai - 1) * SoPhanTuMoiTrang;
            var danhSachTrang = _hienThiDanhSach.Skip(skip).Take(SoPhanTuMoiTrang).ToList();

            int stt = skip + 1;
            foreach (var v in danhSachTrang)
            {
                int rowIndex = dgvVoucher.Rows.Add(
                    stt++,
                    v.MaVoucher,
                    v.TenChuongTrinh,
                    v.UuDaiDisplay,
                    v.LuotDungDisplay,
                    v.PhamVi,
                    v.TrangThai,
                    "❐   ✎"
                );
                dgvVoucher.Rows[rowIndex].Tag = v;
            }

            dgvVoucher.ResumeLayout();

            // Cập nhật phân trang
            lblPagination.Text = $"Hiển thị {danhSachTrang.Count} trên {tongSo} mã voucher";
            lblCurrentPage.Text = $"{_trangHienTai} / {tongTrang}";
            btnPrevPage.Enabled = _trangHienTai > 1;
            btnNextPage.Enabled = _trangHienTai < tongTrang;

            // Tự động chọn dòng đầu tiên nếu có dữ liệu
            if (dgvVoucher.Rows.Count > 0)
            {
                dgvVoucher.Rows[0].Selected = true;
                DgvVoucher_SelectionChanged(null, EventArgs.Empty);
            }
        }

        private void CapNhatThongKe()
        {
            int tong = _dataService.DanhSachVoucher.Count;
            int dangHieuLuc = _dataService.DanhSachVoucher.Count(v => v.TrangThai == "Đang hiệu lực");
            int sapToi = _dataService.DanhSachVoucher.Count(v => v.TrangThai == "Sắp diễn ra");
            int hetHan = _dataService.DanhSachVoucher.Count(v => v.TrangThai == "Hết hạn" || v.TrangThai == "Hết lượt" || v.TrangThai == "Tạm dừng");

            lblQuickStats.Text = $"{tong} voucher • {dangHieuLuc} đang hiệu lực • {sapToi} sắp diễn ra • {hetHan} hết hạn / tạm dừng   |   Đã giảm tháng này: 4.820.000 đ - 215 hóa đơn";

            btnTabTatCa.Text = $"Tất cả ({tong})";
            btnTabDangHieuLuc.Text = $"Đang hiệu lực ({dangHieuLuc})";
            btnTabSapToi.Text = $"Sắp tới ({sapToi})";
            btnTabHetHan.Text = $"Hết hạn ({hetHan})";
        }
        #endregion

        #region 3. Hiển Thị Chi Tiết Voucher Lên Form
        private void DgvVoucher_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVoucher.SelectedRows.Count == 0) return;

            var row = dgvVoucher.SelectedRows[0];
            if (row.Tag is Voucher v)
            {
                _voucherDangChon = v;
                _dangTaoMoi = false;
                HienThiChiTietVoucher(v);
            }
        }

        private void HienThiChiTietVoucher(Voucher v)
        {
            lblDetailTitle.Text = $"🏷 Chi tiết Voucher: {v.MaVoucher}";
            toggleKichHoat.Checked = v.KichHoat;

            txtMaVoucher.Text = v.MaVoucher;
            txtMaVoucher.ReadOnly = true;
            txtTenChuongTrinh.Text = v.TenChuongTrinh;

            if (v.LoaiGiamGia == "PhanTram")
            {
                rbPhanTram.Checked = true;
                numMucGiam.Value = Math.Min(100, Math.Max(0, v.GiaTriGiam));
                numGiamToiDa.Value = Math.Max(0, v.GiamToiDa);
            }
            else
            {
                rbTienMat.Checked = true;
                numMucGiam.Value = Math.Max(0, v.GiaTriGiam);
                numGiamToiDa.Value = 0;
            }

            CapNhatGiaoDienCoCheGiam();

            numDonToiThieu.Value = Math.Max(0, v.DonToiThieu);

            // Phạm vi áp dụng
            if (v.PhamVi == "Tại quán") cboPhamVi.SelectedIndex = 1;
            else if (v.PhamVi == "Mang về") cboPhamVi.SelectedIndex = 2;
            else cboPhamVi.SelectedIndex = 0;

            dtpNgayBatDau.Value = v.NgayBatDau;
            dtpNgayKetThuc.Value = v.NgayKetThuc;

            numTongLuot.Value = v.TongLuotPhatHanh;
            numGioiHanMoiHD.Value = Math.Max(1, v.GioiHanMoiHoaDon);

            int conLai = v.TongLuotPhatHanh > 0 ? Math.Max(0, v.TongLuotPhatHanh - v.DaDung) : 9999;
            lblThongKeLuot.Text = v.TongLuotPhatHanh > 0 
                ? $"Đã dùng: {v.DaDung}       Còn lại: {conLai}"
                : $"Đã dùng: {v.DaDung}       (Không giới hạn)";

            txtGhiChu.Text = v.GhiChu;
        }

        private void CapNhatGiaoDienCoCheGiam()
        {
            if (rbPhanTram.Checked)
            {
                lblMucGiam.Text = "Mức giảm";
                lblMucGiamUnit.Text = "%";
                numMucGiam.Maximum = 100;

                pnlGiamToiDa.Visible = true;
                pnlGiamToiDa.Enabled = true;
            }
            else
            {
                lblMucGiam.Text = "Số tiền giảm";
                lblMucGiamUnit.Text = "đ";
                numMucGiam.Maximum = 10000000;

                // Tự động ẩn/khóa ô Giảm tối đa (theo đúng yêu cầu mockup)
                pnlGiamToiDa.Visible = false;
                pnlGiamToiDa.Enabled = false;
            }
        }
        #endregion

        #region 4. Tự Vẽ DataGridView (ProgressBar Lượt Dùng, Badges, Mã Vé)
        private void DgvVoucher_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;
            Rectangle cellBounds = e.CellBounds;
            Graphics? g = e.Graphics;
            if (g == null) return;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // 1. Nền hàng
            Color rowBg = isSelected ? UIHelper.RowSelected : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(rowBg))
            {
                g.FillRectangle(bgBrush, cellBounds);
            }

            // 2. Kẻ đáy dòng
            using (Pen linePen = new Pen(ColorTranslator.FromHtml("#F0EAE1"), 1f))
            {
                g.DrawLine(linePen, cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);
            }

            // 3. Vạch cam chỉ thị hàng được chọn ở cột #
            if (isSelected && e.ColumnIndex == 0)
            {
                using (SolidBrush orangeBrush = new SolidBrush(UIHelper.AccentOrange))
                {
                    g.FillRectangle(orangeBrush, cellBounds.Left, cellBounds.Top, 4, cellBounds.Height);
                }
            }

            if (dgvVoucher.Rows[e.RowIndex].Tag is not Voucher v) return;

            string colName = dgvVoucher.Columns[e.ColumnIndex].Name;

            // --- Cột 1: STT ---
            if (colName == "colSTT")
            {
                TextRenderer.DrawText(g, e.Value?.ToString() ?? "", UIHelper.FontRegular, cellBounds, UIHelper.TextMuted,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // --- Cột 2: MÃ VOUCHER (Tag vé coupon bo góc) ---
            if (colName == "colMaVoucher")
            {
                int badgeW = Math.Min(cellBounds.Width - 16, 125);
                int badgeH = 28;
                Rectangle badgeRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + (cellBounds.Height - badgeH) / 2, badgeW, badgeH);

                using (GraphicsPath path = UIHelper.GetRoundedPath(badgeRect, 6))
                {
                    using (SolidBrush fillB = new SolidBrush(ColorTranslator.FromHtml("#F5EDE4")))
                    {
                        g.FillPath(fillB, path);
                    }
                    using (Pen pen = new Pen(ColorTranslator.FromHtml("#D5C7B8"), 1f))
                    {
                        g.DrawPath(pen, path);
                    }
                }

                TextRenderer.DrawText(g, $"🎫 {v.MaVoucher}", UIHelper.FontBold, badgeRect, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // --- Cột 3: TÊN CHƯƠNG TRÌNH (2 dòng: Tên đậm + Thời gian xám) ---
            if (colName == "colTenChuongTrinh")
            {
                Rectangle titleRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);
                Rectangle subRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 26, cellBounds.Width - 16, 16);

                TextRenderer.DrawText(g, v.TenChuongTrinh, UIHelper.FontBold, titleRect, UIHelper.TextMain,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                TextRenderer.DrawText(g, v.LichTrinhText, UIHelper.FontSmall, subRect, UIHelper.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                e.Handled = true;
                return;
            }

            // --- Cột 4: ƯU ĐÃI / ĐIỀU KIỆN (2 dòng: Mức giảm + Đơn tối thiểu) ---
            if (colName == "colUuDai")
            {
                Rectangle line1Rect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);
                Rectangle line2Rect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 26, cellBounds.Width - 16, 16);

                TextRenderer.DrawText(g, v.UuDaiDisplay, UIHelper.FontBold, line1Rect, UIHelper.TextMain,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                TextRenderer.DrawText(g, v.DieuKienDisplay, UIHelper.FontSmall, line2Rect, UIHelper.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                e.Handled = true;
                return;
            }

            // --- Cột 5: LƯỢT DÙNG (Số lượng + ProgressBar nhỏ chuẩn mockup) ---
            if (colName == "colLuotDung")
            {
                Rectangle textRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);

                if (v.TongLuotPhatHanh > 0)
                {
                    // Dòng 1: Số lượng (ví dụ: 68 / 200 (34%))
                    TextRenderer.DrawText(g, v.LuotDungDisplay, UIHelper.FontBold, textRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                    // Dòng 2: Thanh ProgressBar nhỏ bo góc
                    int barW = cellBounds.Width - 20;
                    int barH = 5;
                    Rectangle barTrack = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 30, barW, barH);

                    using (GraphicsPath trackPath = UIHelper.GetCapsulePath(barTrack))
                    using (SolidBrush trackBrush = new SolidBrush(ColorTranslator.FromHtml("#EFE8E1")))
                    {
                        g.FillPath(trackBrush, trackPath);
                    }

                    double pt = v.PhanTramLuotDung;
                    int fillW = (int)Math.Max(barH, barW * (pt / 100.0));
                    if (fillW > 0)
                    {
                        Rectangle barFill = new Rectangle(barTrack.X, barTrack.Y, Math.Min(barW, fillW), barH);

                        Color fillColor = ColorTranslator.FromHtml("#6F4E37"); // Nâu mặc định
                        if (pt >= 100) fillColor = ColorTranslator.FromHtml("#C0392B"); // Đỏ nếu hết lượt (100%)
                        else if (pt >= 80) fillColor = ColorTranslator.FromHtml("#E67E22"); // Cam nếu sắp hết

                        using (GraphicsPath fillPath = UIHelper.GetCapsulePath(barFill))
                        using (SolidBrush fillBrush = new SolidBrush(fillColor))
                        {
                            g.FillPath(fillBrush, fillPath);
                        }
                    }
                }
                else
                {
                    // Trường hợp không giới hạn lượt dùng
                    TextRenderer.DrawText(g, "Không giới hạn", UIHelper.FontBold, textRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

                    Rectangle subRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 26, cellBounds.Width - 16, 16);
                    TextRenderer.DrawText(g, $"Đã dùng {v.DaDung} lượt", UIHelper.FontSmall, subRect, UIHelper.TextMuted,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                }

                e.Handled = true;
                return;
            }

            // --- Cột 6: PHẠM VI (Căn lề giữa) ---
            if (colName == "colPhamVi")
            {
                TextRenderer.DrawText(g, v.PhamVi, UIHelper.FontRegular, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // --- Cột 7: TRẠNG THÁI (Badge Pill màu sắc có dấu chấm ●) ---
            if (colName == "colTrangThai")
            {
                Color bgPill;
                Color textPill;
                string dotText;

                switch (v.TrangThai)
                {
                    case "Đang hiệu lực":
                        bgPill = UIHelper.BadgeGreenBg;
                        textPill = UIHelper.BadgeGreenText;
                        dotText = "● Đang hiệu lực";
                        break;
                    case "Sắp diễn ra":
                        bgPill = UIHelper.BadgeOrangeBg;
                        textPill = UIHelper.BadgeOrangeText;
                        dotText = "● Sắp diễn ra";
                        break;
                    case "Hết lượt":
                    case "Hết hạn":
                        bgPill = UIHelper.BadgeRedBg;
                        textPill = UIHelper.BadgeRedText;
                        dotText = "● Hết lượt";
                        break;
                    default: // Tạm dừng
                        bgPill = UIHelper.BadgeGrayBg;
                        textPill = UIHelper.BadgeGrayText;
                        dotText = "● Tạm dừng";
                        break;
                }

                int pillW = Math.Min(cellBounds.Width - 16, 115);
                int pillH = 26;
                Rectangle pillRect = new Rectangle(cellBounds.Left + (cellBounds.Width - pillW) / 2, cellBounds.Top + (cellBounds.Height - pillH) / 2, pillW, pillH);

                using (GraphicsPath path = UIHelper.GetCapsulePath(pillRect))
                using (SolidBrush pillBrush = new SolidBrush(bgPill))
                {
                    g.FillPath(pillBrush, path);
                }

                TextRenderer.DrawText(g, dotText, UIHelper.FontSmallBold, pillRect, textPill,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
                return;
            }

            // --- Cột 8: THAO TÁC (Icon copy ❐ và sửa ✎) ---
            if (colName == "colThaoTac")
            {
                using (Font iconFont = new Font("Segoe UI", 10.5F))
                {
                    TextRenderer.DrawText(g, "❐   ✎", iconFont, cellBounds, UIHelper.TextMuted,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                e.Handled = true;
                return;
            }
        }

        private void DgvVoucher_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvVoucher.Rows.Count) return;

            // Nhấn vào cột thao tác để Copy mã hoặc kích hoạt chỉnh sửa
            if (dgvVoucher.Columns[e.ColumnIndex].Name == "colThaoTac")
            {
                if (dgvVoucher.Rows[e.RowIndex].Tag is Voucher v)
                {
                    Clipboard.SetText(v.MaVoucher);
                    MessageBox.Show($"Đã sao chép mã voucher '{v.MaVoucher}' vào bộ nhớ tạm!", "Sao chép thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 5. Thao Tác Lưu & Quản Lý Voucher
        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            string ma = txtMaVoucher.Text.Trim().ToUpper();
            string ten = txtTenChuongTrinh.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng nhập Mã Voucher!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVoucher.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập Tên chương trình khuyến mãi!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuongTrinh.Focus();
                return;
            }

            if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
            {
                MessageBox.Show("Thời gian kết thúc không được nhỏ hơn thời gian bắt đầu!", "Lỗi thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKetThuc.Focus();
                return;
            }

            // Xác định trạng thái tự động dựa trên thời gian & lượt dùng
            string trangThaiMoi = "Đang hiệu lực";
            if (!toggleKichHoat.Checked)
            {
                trangThaiMoi = "Tạm dừng";
            }
            else if (numTongLuot.Value > 0 && (_voucherDangChon?.DaDung ?? 0) >= (int)numTongLuot.Value)
            {
                trangThaiMoi = "Hết lượt";
            }
            else if (DateTime.Now < dtpNgayBatDau.Value)
            {
                trangThaiMoi = "Sắp diễn ra";
            }
            else if (DateTime.Now > dtpNgayKetThuc.Value)
            {
                trangThaiMoi = "Hết hạn";
            }

            string phamViMoi = cboPhamVi.SelectedIndex switch
            {
                1 => "Tại quán",
                2 => "Mang về",
                _ => "Tất cả"
            };

            if (_dangTaoMoi || _voucherDangChon == null)
            {
                // Kiểm tra trùng mã
                if (_dataService.DanhSachVoucher.Any(v => v.MaVoucher.Equals(ma, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show($"Mã voucher '{ma}' đã tồn tại trong hệ thống. Vui lòng chọn mã khác!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Voucher vMoi = new Voucher
                {
                    MaVoucher = ma,
                    TenChuongTrinh = ten,
                    LichTrinhText = $"{dtpNgayBatDau.Value:dd/MM} - {dtpNgayKetThuc.Value:dd/MM/yyyy}",
                    LoaiGiamGia = rbPhanTram.Checked ? "PhanTram" : "TienMat",
                    GiaTriGiam = numMucGiam.Value,
                    GiamToiDa = rbPhanTram.Checked ? numGiamToiDa.Value : 0,
                    DonToiThieu = numDonToiThieu.Value,
                    PhamVi = phamViMoi,
                    NgayBatDau = dtpNgayBatDau.Value,
                    NgayKetThuc = dtpNgayKetThuc.Value,
                    TongLuotPhatHanh = (int)numTongLuot.Value,
                    DaDung = 0,
                    GioiHanMoiHoaDon = (int)numGioiHanMoiHD.Value,
                    TrangThai = trangThaiMoi,
                    KichHoat = toggleKichHoat.Checked,
                    GhiChu = txtGhiChu.Text.Trim()
                };

                _dataService.DanhSachVoucher.Insert(0, vMoi);
                _voucherDangChon = vMoi;
                _dangTaoMoi = false;

                ApDungBoLoc();
                CapNhatThongKe();

                MessageBox.Show($"Đã tạo mới mã voucher '{vMoi.MaVoucher}' thành công!", "Tạo voucher thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật voucher hiện tại
                _voucherDangChon.TenChuongTrinh = ten;
                _voucherDangChon.LoaiGiamGia = rbPhanTram.Checked ? "PhanTram" : "TienMat";
                _voucherDangChon.GiaTriGiam = numMucGiam.Value;
                _voucherDangChon.GiamToiDa = rbPhanTram.Checked ? numGiamToiDa.Value : 0;
                _voucherDangChon.DonToiThieu = numDonToiThieu.Value;
                _voucherDangChon.PhamVi = phamViMoi;
                _voucherDangChon.NgayBatDau = dtpNgayBatDau.Value;
                _voucherDangChon.NgayKetThuc = dtpNgayKetThuc.Value;
                _voucherDangChon.TongLuotPhatHanh = (int)numTongLuot.Value;
                _voucherDangChon.GioiHanMoiHoaDon = (int)numGioiHanMoiHD.Value;
                _voucherDangChon.TrangThai = trangThaiMoi;
                _voucherDangChon.KichHoat = toggleKichHoat.Checked;
                _voucherDangChon.GhiChu = txtGhiChu.Text.Trim();

                ApDungBoLoc();
                CapNhatThongKe();

                MessageBox.Show($"Đã cập nhật thay đổi cho mã voucher '{_voucherDangChon.MaVoucher}' thành công!", "Lưu thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTamNgungMa_Click(object? sender, EventArgs e)
        {
            if (_voucherDangChon == null) return;

            string hanhDong = _voucherDangChon.KichHoat ? "tạm ngưng" : "kích hoạt lại";
            var result = MessageBox.Show($"Bạn có chắc chắn muốn {hanhDong} mã voucher '{_voucherDangChon.MaVoucher}' không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _voucherDangChon.KichHoat = !_voucherDangChon.KichHoat;
                _voucherDangChon.TrangThai = _voucherDangChon.KichHoat ? "Đang hiệu lực" : "Tạm dừng";

                toggleKichHoat.Checked = _voucherDangChon.KichHoat;
                btnTamNgungMa.Text = _voucherDangChon.KichHoat ? "🚫 Tạm ngưng mã này" : "✔ Kích hoạt lại mã";

                ApDungBoLoc();
                CapNhatThongKe();

                MessageBox.Show($"Mã voucher '{_voucherDangChon.MaVoucher}' đã được chuyển sang trạng thái: {_voucherDangChon.TrangThai}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnTaoVoucher_Click(object? sender, EventArgs e)
        {
            _dangTaoMoi = true;
            _voucherDangChon = null;

            lblDetailTitle.Text = "🏷 Tạo Voucher mới";
            toggleKichHoat.Checked = true;

            string maMoi = _dataService.SinhMaVoucherTuDong();
            txtMaVoucher.Text = maMoi;
            txtMaVoucher.ReadOnly = false;
            txtTenChuongTrinh.Text = "Khuyến mãi mới - Mộc Café";

            rbPhanTram.Checked = true;
            numMucGiam.Value = 10;
            numGiamToiDa.Value = 20000;
            numDonToiThieu.Value = 50000;
            cboPhamVi.SelectedIndex = 0;

            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now.AddDays(30);

            numTongLuot.Value = 100;
            numGioiHanMoiHD.Value = 1;
            lblThongKeLuot.Text = "Đã dùng: 0       Còn lại: 100";
            txtGhiChu.Text = "Áp dụng cho hóa đơn đạt giá trị tối thiểu.";

            txtMaVoucher.Focus();
        }
        #endregion
    }
}
