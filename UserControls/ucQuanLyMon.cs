using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Forms;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    public partial class ucQuanLyMon : UserControl
    {
        private readonly MockDataService _dataService;
        private List<Mon> _hienThiDanhSach = new List<Mon>();
        private Mon? _monDangChon = null;
        private List<DinhLuongBOM> _bomHienTai = new List<DinhLuongBOM>();

        public ucQuanLyMon()
        {
            InitializeComponent();
            _dataService = MockDataService.Instance;

            SetupStyles();
            DangKySuKien();
            LoadDanhMucLenCombobox();
            LoadDuLieuMon();
        }

        #region 1. Khởi tạo Giao diện & Căn lề chuẩn cho DataGridView
        private void SetupStyles()
        {
            UIHelper.StyleDataGridView(dgvMon);
            UIHelper.StyleDataGridView(dgvBOM);

            // Cấu hình DataGridView Danh Sách Món (dgvMon)
            dgvMon.RowTemplate.Height = 52;
            dgvMon.ColumnHeadersHeight = 42;

            // Căn lề giữa cho tất cả các cột trừ Tên món
            dgvMon.Columns["colMa"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMon.Columns["colMa"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMon.Columns["colHinhAnh"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMon.Columns["colHinhAnh"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMon.Columns["colTenMon"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvMon.Columns["colGiaBan"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMon.Columns["colGiaBan"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMon.Columns["colDinhLuong"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMon.Columns["colDinhLuong"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMon.Columns["colTrangThai"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMon.Columns["colTrangThai"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cấu hình DataGridView Định lượng BOM (dgvBOM)
            dgvBOM.RowTemplate.Height = 46;
            dgvBOM.ColumnHeadersHeight = 44;

            dgvBOM.Columns["colBOMTenNL"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Các cột ĐỊNH LƯỢNG, ĐVT, GIÁ VỐN, XÓA căn lề giữa cả TIÊU ĐỀ và NỘI DUNG
            dgvBOM.Columns["colBOMDinhLuong"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBOM.Columns["colBOMDinhLuong"]!.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            dgvBOM.Columns["colBOMDinhLuong"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBOM.Columns["colBOMDVT"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBOM.Columns["colBOMDVT"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBOM.Columns["colBOMGiaVon"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBOM.Columns["colBOMGiaVon"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBOM.Columns["colBOMXoa"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBOM.Columns["colBOMXoa"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadDanhMucLenCombobox()
        {
            // Danh mục lọc: prefix "NHÓM:" đã được thể hiện cố định bằng nhãn màu nhạt
            cboLocDanhMuc.Items.Clear();
            cboLocDanhMuc.Items.Add($"Tất cả danh mục ({_dataService.DanhSachDanhMuc.Count})");
            foreach (var dm in _dataService.DanhSachDanhMuc)
            {
                cboLocDanhMuc.Items.Add(dm.TenDanhMuc);
            }
            cboLocDanhMuc.SelectedIndex = 0;

            // Trạng thái lọc: prefix "TRẠNG THÁI:" đã được thể hiện cố định bằng nhãn màu nhạt
            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("Tất cả trạng thái");
            cboLocTrangThai.Items.Add("Đang bán");
            cboLocTrangThai.Items.Add("Tạm ngưng");
            cboLocTrangThai.SelectedIndex = 0;

            cboDetailDanhMuc.Items.Clear();
            foreach (var dm in _dataService.DanhSachDanhMuc)
            {
                cboDetailDanhMuc.Items.Add(dm.TenDanhMuc);
            }
        }
        #endregion

        #region 2. Xử lý Tỷ lệ Co giãn Tự động (Phóng to / Thu nhỏ không bị vỡ layout)
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CanChinhTyLeSplitter();
        }

        private void CanChinhTyLeSplitter()
        {
            // Tỷ lệ co giãn chiều cao giữa Khu vực trên (Master-Detail) và Khu vực dưới (BOM)
            if (splitMain.Height > 320)
            {
                int targetHDist = (int)(splitMain.Height * 0.58);
                if (targetHDist >= 260 && targetHDist <= splitMain.Height - 160)
                {
                    splitMain.SplitterDistance = targetHDist;
                }
            }

            // Tỷ lệ co giãn chiều ngang giữa Danh sách món (bên trái) và Thông tin món (bên phải)
            if (splitMasterDetail.Width > 550)
            {
                int targetVDist = (int)(splitMasterDetail.Width * 0.56);
                if (targetVDist >= 380 && targetVDist <= splitMasterDetail.Width - 340)
                {
                    splitMasterDetail.SplitterDistance = targetVDist;
                }
            }
        }
        #endregion

        #region 3. Đăng ký Sự kiện (Event Handlers)
        private void DangKySuKien()
        {
            // Tìm kiếm & Lọc
            txtTimKiem.TextChanged += (s, e) => ApDungBoLoc();
            cboLocDanhMuc.SelectedIndexChanged += (s, e) => ApDungBoLoc();
            cboLocTrangThai.SelectedIndexChanged += (s, e) => ApDungBoLoc();

            // Chọn món trong bảng
            dgvMon.SelectionChanged += DgvMon_SelectionChanged;

            // Custom GDI+ Painting
            dgvMon.CellPainting += DgvMon_CellPainting;
            dgvBOM.CellPainting += DgvBOM_CellPainting;

            // Chỉnh sửa định lượng trực tiếp trên bảng BOM (Inline Editing)
            dgvBOM.CellEndEdit += DgvBOM_CellEndEdit;
            dgvBOM.CellClick += DgvBOM_CellClick;

            // Các nút thao tác
            btnLuuMon.Click += BtnLuuMon_Click;
            btnTamNgung.Click += BtnTamNgung_Click;
            btnThemNguyenLieu.Click += BtnThemNguyenLieu_Click;
            btnTinhLaiGia.Click += (s, e) => TinhLaiCOGS();
            btnXuatExcel.Click += BtnXuatExcel_Click;
            btnCapNhatGia.Click += (s, e) => MessageBox.Show("Chức năng cập nhật bảng giá hàng loạt đang sẵn sàng kết nối Module Bán Hàng POS!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đổi ảnh món
            lblKichThuocAnh.Click += ChonAnhMon;
            picMonDetail.Click += ChonAnhMon;
        }
        #endregion

        #region 4. Nạp & Lọc Dữ liệu Món
        private void LoadDuLieuMon()
        {
            _dataService.DanhSachMon = _dataService.DanhSachMon
                .OrderBy(m => m.MaDanhMuc)
                .ThenBy(m => m.MaMon)
                .ToList();
            _hienThiDanhSach = new List<Mon>(_dataService.DanhSachMon);
            HienThiDanhSachLenBang();
            CapNhatThongKeHeader();
            CanChinhTyLeSplitter();
        }

        private void ApDungBoLoc()
        {
            string tuKhoa = (txtTimKiem.Text ?? "").Trim().ToLower();
            string selectedDm = cboLocDanhMuc.SelectedIndex > 0 ? cboLocDanhMuc.SelectedItem?.ToString() ?? "" : "";
            int trangThaiIndex = cboLocTrangThai.SelectedIndex;

            _hienThiDanhSach = _dataService.DanhSachMon.Where(m =>
            {
                bool matchTuKhoa = string.IsNullOrEmpty(tuKhoa) ||
                                  m.MaMon.ToLower().Contains(tuKhoa) ||
                                  m.TenMon.ToLower().Contains(tuKhoa);

                bool matchDanhMuc = string.IsNullOrEmpty(selectedDm) ||
                                   m.TenDanhMuc.Equals(selectedDm, StringComparison.OrdinalIgnoreCase);

                bool matchTrangThai = true;
                if (trangThaiIndex == 1) matchTrangThai = m.TrangThai == "Đang bán";
                else if (trangThaiIndex == 2) matchTrangThai = m.TrangThai == "Tạm ngưng";

                return matchTuKhoa && matchDanhMuc && matchTrangThai;
            }).OrderBy(m => m.MaDanhMuc).ThenBy(m => m.MaMon).ToList();

            HienThiDanhSachLenBang();
        }

        private void HienThiDanhSachLenBang()
        {
            dgvMon.SuspendLayout();
            dgvMon.Rows.Clear();

            foreach (var m in _hienThiDanhSach)
            {
                int rowIndex = dgvMon.Rows.Add(
                    m.MaMon,
                    m.HinhAnh,
                    m.TenMon,
                    UIHelper.FormatVND(m.GiaBan),
                    m.CoDinhLuong ? "OK" : "--",
                    m.TrangThai
                );
                dgvMon.Rows[rowIndex].Tag = m;
            }

            dgvMon.ResumeLayout();

            if (dgvMon.Rows.Count > 0)
            {
                dgvMon.Rows[0].Selected = true;
                DgvMon_SelectionChanged(null, EventArgs.Empty);
            }
            else
            {
                XoaFormThongTin();
            }

            lblPagination.Text = $"Trang 1 / 1 (Tổng {_hienThiDanhSach.Count} món)";
        }

        private void CapNhatThongKeHeader()
        {
            int tongMon = _dataService.DanhSachMon.Count;
            int dangBan = _dataService.DanhSachMon.Count(m => m.TrangThai == "Đang bán");
            int tamNgung = _dataService.DanhSachMon.Count(m => m.TrangThai == "Tạm ngưng");
            int soDM = _dataService.DanhSachDanhMuc.Count;

            lblSubtitle.Text = $"{tongMon} món • {dangBan} đang bán • {tamNgung} tạm ngưng • {soDM} danh mục";
        }
        #endregion

        #region 5. Hiển thị Chi Tiết Món & Định Lượng BOM
        private void DgvMon_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvMon.SelectedRows.Count == 0) return;
            var selectedRow = dgvMon.SelectedRows[0];
            if (selectedRow.Tag is not Mon mon) return;

            _monDangChon = mon;

            // Nạp thông tin sang Panel bên phải
            lblDetailSubHeader.Text = $"Mã món: {mon.MaMon}";
            txtMaMon.Text = mon.MaMon;
            txtTenMon.Text = mon.TenMon;
            txtGiaBan.Text = mon.GiaBan.ToString("N0").Replace(",", ".");
            lblGiaVonBOM.Text = UIHelper.FormatVND(mon.GiaVonBOM);
            rtbMoTa.Text = mon.MoTa;
            picMonDetail.Image = mon.HinhAnh;

            // Danh mục
            int catIdx = cboDetailDanhMuc.FindStringExact(mon.TenDanhMuc);
            if (catIdx >= 0) cboDetailDanhMuc.SelectedIndex = catIdx;

            // Tỷ lệ lãi
            badgeLai.Text = $"Lãi: {mon.TyLeLai}%";
            badgeLai.Style = mon.TyLeLai >= 50 ? BadgeStyle.Success : (mon.TyLeLai > 0 ? BadgeStyle.Warning : BadgeStyle.Danger);

            // Nút Tạm ngưng bán món này (Màu sắc và viền bo góc mượt mà y hệt mockup)
            CapNhatGiaoDienNutTamNgung(mon.TrangThai);

            // Nạp bảng BOM
            LoadBOMChoMon(mon.MaMon);
        }

        private void CapNhatGiaoDienNutTamNgung(string trangThai)
        {
            if (trangThai == "Đang bán")
            {
                btnTamNgung.Text = "Tạm ngưng bán món này";
                btnTamNgung.NormalBackColor = ColorTranslator.FromHtml("#FDF0F0");
                btnTamNgung.HoverBackColor = ColorTranslator.FromHtml("#F9D5D5");
                btnTamNgung.DownBackColor = ColorTranslator.FromHtml("#F5B7B7");
                btnTamNgung.BorderColor = ColorTranslator.FromHtml("#F5C6CB");
                btnTamNgung.BorderWidth = 1;
                btnTamNgung.ForeColor = ColorTranslator.FromHtml("#C0392B");
            }
            else
            {
                btnTamNgung.Text = "Mở bán lại món này";
                btnTamNgung.NormalBackColor = ColorTranslator.FromHtml("#E8F8EE");
                btnTamNgung.HoverBackColor = ColorTranslator.FromHtml("#D4F0DF");
                btnTamNgung.DownBackColor = ColorTranslator.FromHtml("#BEE5CD");
                btnTamNgung.BorderColor = ColorTranslator.FromHtml("#C3E6CB");
                btnTamNgung.BorderWidth = 1;
                btnTamNgung.ForeColor = ColorTranslator.FromHtml("#1B7C3F");
            }
        }

        private void LoadBOMChoMon(string maMon)
        {
            dgvBOM.SuspendLayout();
            dgvBOM.Rows.Clear();

            if (_dataService.DinhLuongMap.TryGetValue(maMon, out var listBOM))
            {
                _bomHienTai = listBOM;
            }
            else
            {
                _bomHienTai = new List<DinhLuongBOM>();
                _dataService.DinhLuongMap[maMon] = _bomHienTai;
            }

            foreach (var item in _bomHienTai)
            {
                int rIdx = dgvBOM.Rows.Add(
                    item.TenNL,
                    item.DinhLuong.ToString("0.##"),
                    item.DVT,
                    UIHelper.FormatVND(item.ThanhTienGiaVon),
                    "🗑"
                );
                dgvBOM.Rows[rIdx].Tag = item;
            }

            dgvBOM.ResumeLayout();
            TinhLaiCOGS();
        }

        private void TinhLaiCOGS()
        {
            decimal tongCOGS = _bomHienTai.Sum(b => b.ThanhTienGiaVon);
            lblCOGSValue.Text = $"{UIHelper.FormatVND(tongCOGS)} / suất";

            if (_monDangChon != null)
            {
                _monDangChon.GiaVonBOM = tongCOGS;
                _monDangChon.CoDinhLuong = _bomHienTai.Count > 0;
                lblGiaVonBOM.Text = UIHelper.FormatVND(tongCOGS);
                badgeLai.Text = $"Lãi: {_monDangChon.TyLeLai}%";
                badgeLai.Style = _monDangChon.TyLeLai >= 50 ? BadgeStyle.Success : (_monDangChon.TyLeLai > 0 ? BadgeStyle.Warning : BadgeStyle.Danger);

                if (dgvMon.SelectedRows.Count > 0)
                {
                    dgvMon.SelectedRows[0].Cells["colDinhLuong"].Value = _monDangChon.CoDinhLuong ? "OK" : "--";
                }
            }
        }

        private void XoaFormThongTin()
        {
            _monDangChon = null;
            lblDetailSubHeader.Text = "Mã món: --";
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtGiaBan.Text = "0";
            lblGiaVonBOM.Text = "0 đ";
            rtbMoTa.Text = "";
            badgeLai.Text = "Lãi: 0%";
            picMonDetail.Image = null;
            dgvBOM.Rows.Clear();
            lblCOGSValue.Text = "0 đ / suất";
        }
        #endregion

        #region 6. Tự vẽ Cell DataGridView (Căn lề giữa chuẩn, xử lý tên dài có dấu ba chấm)
        private void DgvMon_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;
            Rectangle cellBounds = e.CellBounds;
            Graphics? g = e.Graphics;
            if (g == null) return;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Màu nền hàng
            Color rowBg = isSelected ? UIHelper.RowSelected : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(rowBg))
            {
                g.FillRectangle(bgBrush, cellBounds);
            }

            // Đường kẻ đáy hàng
            using (Pen linePen = new Pen(ColorTranslator.FromHtml("#F0EAE1"), 1f))
            {
                g.DrawLine(linePen, cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);
            }

            // Vạch cam Active bên lề trái khi đang chọn (Y hệt mockup M01)
            if (isSelected && e.ColumnIndex == 0)
            {
                using (SolidBrush orangeBrush = new SolidBrush(UIHelper.AccentOrange))
                {
                    g.FillRectangle(orangeBrush, cellBounds.Left, cellBounds.Top, 4, cellBounds.Height);
                }
            }

            // 1. Cột TÊN MÓN / DANH MỤC: Vẽ 2 dòng, tự động cắt chữ gọn gàng với EndEllipsis khi tên dài
            if (dgvMon.Columns[e.ColumnIndex].Name == "colTenMon")
            {
                if (dgvMon.Rows[e.RowIndex].Tag is Mon mon)
                {
                    Rectangle titleRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 22);
                    Rectangle catRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 28, cellBounds.Width - 16, 18);

                    TextRenderer.DrawText(g, mon.TenMon, UIHelper.FontBold, titleRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    TextRenderer.DrawText(g, $"📂 {mon.TenDanhMuc}", UIHelper.FontSmall, catRect, UIHelper.TextMuted,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    e.Handled = true;
                    return;
                }
            }

            // 2. Cột GIÁ BÁN: Căn lề giữa
            if (dgvMon.Columns[e.ColumnIndex].Name == "colGiaBan")
            {
                string val = e.Value?.ToString() ?? "";
                TextRenderer.DrawText(g, val, UIHelper.FontBold, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // 3. Cột ĐL (Định lượng): Badge Pill "OK" hoặc "--" căn giữa
            if (dgvMon.Columns[e.ColumnIndex].Name == "colDinhLuong")
            {
                string val = e.Value?.ToString() ?? "--";
                bool isOk = val == "OK";
                Rectangle badgeRect = new Rectangle(cellBounds.Left + (cellBounds.Width - 38) / 2, cellBounds.Top + (cellBounds.Height - 22) / 2, 38, 22);

                Color bColor = isOk ? UIHelper.BadgeGreenBg : UIHelper.BadgeGrayBg;
                Color tColor = isOk ? UIHelper.BadgeGreenText : UIHelper.BadgeGrayText;

                using (GraphicsPath path = UIHelper.GetCapsulePath(badgeRect))
                using (SolidBrush bgB = new SolidBrush(bColor))
                {
                    g.FillPath(bgB, path);
                }

                TextRenderer.DrawText(g, val, UIHelper.FontSmallBold, badgeRect, tColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // 4. Cột TRẠNG THÁI: Badge Pill "● Đang bán" hoặc "● Tạm ngưng" căn giữa
            if (dgvMon.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                string val = e.Value?.ToString() ?? "Đang bán";
                bool isDangBan = val == "Đang bán";
                Rectangle badgeRect = new Rectangle(cellBounds.Left + (cellBounds.Width - 94) / 2, cellBounds.Top + (cellBounds.Height - 24) / 2, 94, 24);

                Color bColor = isDangBan ? UIHelper.BadgeGreenBg : UIHelper.BadgeRedBg;
                Color tColor = isDangBan ? UIHelper.BadgeGreenText : ColorTranslator.FromHtml("#C0392B");

                using (GraphicsPath path = UIHelper.GetCapsulePath(badgeRect))
                using (SolidBrush bgB = new SolidBrush(bColor))
                {
                    g.FillPath(bgB, path);
                }

                using (SolidBrush dotBrush = new SolidBrush(tColor))
                {
                    g.FillEllipse(dotBrush, badgeRect.Left + 8, badgeRect.Top + (badgeRect.Height - 6) / 2, 6, 6);
                }

                Rectangle textRect = new Rectangle(badgeRect.Left + 14, badgeRect.Top, badgeRect.Width - 14, badgeRect.Height);
                TextRenderer.DrawText(g, val, UIHelper.FontSmallBold, textRect, tColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }
        }

        private void DgvBOM_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;
            Rectangle cellBounds = e.CellBounds;
            Graphics? g = e.Graphics;
            if (g == null) return;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Màu nền hàng
            Color rowBg = isSelected ? UIHelper.RowSelected : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(rowBg))
            {
                g.FillRectangle(bgBrush, cellBounds);
            }

            // Kẻ đáy
            using (Pen linePen = new Pen(ColorTranslator.FromHtml("#F0EAE1"), 1f))
            {
                g.DrawLine(linePen, cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);
            }

            // 1. Cột TÊN NGUYÊN LIỆU: Vẽ 2 dòng (Tên + Mã/Kho)
            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMTenNL")
            {
                if (dgvBOM.Rows[e.RowIndex].Tag is DinhLuongBOM item)
                {
                    Rectangle titleRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);
                    Rectangle subRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 24, cellBounds.Width - 16, 16);

                    TextRenderer.DrawText(g, item.TenNL, UIHelper.FontBold, titleRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    TextRenderer.DrawText(g, $"{item.MaNL} • {item.ViTriKho}", UIHelper.FontSmall, subRect, UIHelper.TextMuted,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    e.Handled = true;
                    return;
                }
            }

            // 2. Cột ĐỊNH LƯỢNG: Vẽ ô số bo góc căn chính xác GIỮA ô
            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMDinhLuong")
            {
                string val = e.Value?.ToString() ?? "0";
                int boxW = 80;
                int boxH = 28;
                Rectangle inputRect = new Rectangle(
                    cellBounds.Left + (cellBounds.Width - boxW) / 2,
                    cellBounds.Top + (cellBounds.Height - boxH) / 2,
                    boxW, boxH);

                using (GraphicsPath path = UIHelper.GetRoundedPath(inputRect, 6))
                {
                    using (SolidBrush fillB = new SolidBrush(Color.FromArgb(250, 248, 245)))
                    {
                        g.FillPath(fillB, path);
                    }
                    using (Pen pen = new Pen(ColorTranslator.FromHtml("#E8DFD5"), 1f))
                    {
                        g.DrawPath(pen, path);
                    }
                }

                TextRenderer.DrawText(g, val, UIHelper.FontBold, inputRect, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // 3. Cột ĐVT: Căn lề GIỮA
            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMDVT")
            {
                string val = e.Value?.ToString() ?? "";
                TextRenderer.DrawText(g, val, UIHelper.FontRegular, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // 4. Cột GIÁ VỐN: Căn lề GIỮA
            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMGiaVon")
            {
                string val = e.Value?.ToString() ?? "";
                TextRenderer.DrawText(g, val, UIHelper.FontBold, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            // 5. Cột Nút XÓA (Thùng rác 🗑): Căn lề GIỮA
            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMXoa")
            {
                Rectangle btnRect = new Rectangle(cellBounds.Left + (cellBounds.Width - 28) / 2, cellBounds.Top + (cellBounds.Height - 28) / 2, 28, 28);
                using (Font iconFont = new Font("Segoe UI", 11f))
                {
                    TextRenderer.DrawText(g, "🗑", iconFont, btnRect, UIHelper.TextMuted,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                e.Handled = true;
                return;
            }
        }
        #endregion

        #region 7. Chỉnh sửa Định Lượng Trực Tiếp & Xóa Dòng BOM
        private void DgvBOM_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBOM.Rows.Count) return;
            if (dgvBOM.Columns[e.ColumnIndex].Name != "colBOMDinhLuong") return;

            var row = dgvBOM.Rows[e.RowIndex];
            if (row.Tag is not DinhLuongBOM item) return;

            string input = row.Cells["colBOMDinhLuong"].Value?.ToString() ?? "0";
            if (decimal.TryParse(input, out decimal soLuongMoi) && soLuongMoi >= 0)
            {
                item.DinhLuong = soLuongMoi;
                row.Cells["colBOMGiaVon"].Value = UIHelper.FormatVND(item.ThanhTienGiaVon);
                TinhLaiCOGS();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng định mức hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.Cells["colBOMDinhLuong"].Value = item.DinhLuong.ToString("0.##");
            }
        }

        private void DgvBOM_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBOM.Rows.Count) return;
            if (dgvBOM.Columns[e.ColumnIndex].Name != "colBOMXoa") return;

            var row = dgvBOM.Rows[e.RowIndex];
            if (row.Tag is not DinhLuongBOM item) return;

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa nguyên liệu '{item.TenNL}' khỏi công thức pha chế món này không?",
                "Xác nhận xóa nguyên liệu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _bomHienTai.Remove(item);
                dgvBOM.Rows.RemoveAt(e.RowIndex);
                TinhLaiCOGS();
            }
        }
        #endregion

        #region 8. Các Chức Năng Chính (Thêm món, Lưu, Đổi trạng thái, Thêm nguyên liệu)
        private void BtnThemMon_Click(object? sender, EventArgs e)
        {
            using (FormThemMon frm = new FormThemMon())
            {
                if (frm.ShowDialog(this) == DialogResult.OK && frm.MonMoi != null)
                {
                    var monMoi = frm.MonMoi;

                    // Thêm món vào danh sách và tự động sắp xếp theo nhóm danh mục & thứ tự mã
                    _dataService.DanhSachMon.Add(monMoi);
                    _dataService.DanhSachMon = _dataService.DanhSachMon
                        .OrderBy(m => m.MaDanhMuc)
                        .ThenBy(m => m.MaMon)
                        .ToList();
                    _dataService.DinhLuongMap[monMoi.MaMon] = new List<DinhLuongBOM>();

                    // Cập nhật số lượng món của danh mục
                    var dm = _dataService.DanhSachDanhMuc.FirstOrDefault(d => d.MaDanhMuc == monMoi.MaDanhMuc);
                    if (dm != null) dm.SoLuongMon++;

                    // Áp dụng bộ lọc và cập nhật thanh thống kê
                    ApDungBoLoc();
                    CapNhatThongKeHeader();

                    // Tìm và chọn ngay dòng món mới tạo trên DataGridView
                    foreach (DataGridViewRow row in dgvMon.Rows)
                    {
                        if (row.Cells["colMa"].Value?.ToString() == monMoi.MaMon)
                        {
                            row.Selected = true;
                            dgvMon.CurrentCell = row.Cells["colTenMon"];
                            break;
                        }
                    }

                    // Tải chi tiết món mới lên Card bên phải và bảng BOM
                    DgvMon_SelectionChanged(null, EventArgs.Empty);

                    string huongDanBOM = monMoi.CoDinhLuong 
                        ? "\n\n💡 Món này có định lượng BOM, bạn có thể nhấn nút '+ Thêm nguyên liệu' ở bảng bên dưới để cấu thành công thức pha chế và tính giá vốn tự động." 
                        : "";

                    MessageBox.Show($"Đã thêm món mới '{monMoi.TenMon}' ({monMoi.MaMon}) thuộc nhóm '{monMoi.TenDanhMuc}' vào thực đơn thành công!{huongDanBOM}", 
                        "Thêm món thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnLuuMon_Click(object? sender, EventArgs e)
        {
            if (_monDangChon == null) return;

            string tenMoi = txtTenMon.Text.Trim();
            if (string.IsNullOrEmpty(tenMoi))
            {
                MessageBox.Show("Tên món không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMon.Focus();
                return;
            }

            string giaBanStr = txtGiaBan.Text.Replace(".", "").Replace(",", "").Trim();
            if (!decimal.TryParse(giaBanStr, out decimal giaBan) || giaBan < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return;
            }

            _monDangChon.TenMon = tenMoi;
            _monDangChon.GiaBan = giaBan;
            _monDangChon.TenDanhMuc = cboDetailDanhMuc.SelectedItem?.ToString() ?? _monDangChon.TenDanhMuc;
            _monDangChon.MoTa = rtbMoTa.Text.Trim();

            TinhLaiCOGS();
            dgvMon.Refresh();
            CapNhatThongKeHeader();

            MessageBox.Show($"Đã lưu thành công thông tin món '{_monDangChon.TenMon}'!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTamNgung_Click(object? sender, EventArgs e)
        {
            if (_monDangChon == null) return;

            if (_monDangChon.TrangThai == "Đang bán")
            {
                _monDangChon.TrangThai = "Tạm ngưng";
            }
            else
            {
                _monDangChon.TrangThai = "Đang bán";
            }

            CapNhatGiaoDienNutTamNgung(_monDangChon.TrangThai);

            // Cập nhật cell trên dgvMon
            if (dgvMon.SelectedRows.Count > 0)
            {
                dgvMon.SelectedRows[0].Cells["colTrangThai"].Value = _monDangChon.TrangThai;
            }

            dgvMon.Refresh();
            CapNhatThongKeHeader();
        }

        private void BtnThemNguyenLieu_Click(object? sender, EventArgs e)
        {
            if (_monDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn/đồ uống cần thêm định lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new FormChonNguyenLieu(_monDangChon.MaMon))
            {
                if (form.ShowDialog(this) == DialogResult.OK && form.KetQuaDinhLuong != null)
                {
                    var itemMoi = form.KetQuaDinhLuong;

                    var daCo = _bomHienTai.FirstOrDefault(b => b.MaNL == itemMoi.MaNL);
                    if (daCo != null)
                    {
                        daCo.DinhLuong += itemMoi.DinhLuong;
                    }
                    else
                    {
                        _bomHienTai.Add(itemMoi);
                    }

                    LoadBOMChoMon(_monDangChon.MaMon);
                    MessageBox.Show($"Đã thêm nguyên liệu '{itemMoi.TenNL}' vào công thức!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ChonAnhMon(object? sender, EventArgs e)
        {
            if (_monDangChon == null) return;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Tệp hình ảnh (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Tất cả tệp (*.*)|*.*";
                ofd.Title = "Chọn hình ảnh đại diện cho món";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(ofd.FileName);
                        _monDangChon.HinhAnh = img;
                        _monDangChon.HinhAnhPath = ofd.FileName;
                        picMonDetail.Image = img;

                        if (dgvMon.SelectedRows.Count > 0)
                        {
                            dgvMon.SelectedRows[0].Cells["colHinhAnh"].Value = img;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể mở hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnXuatExcel_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv|Excel File (*.xlsx)|*.xlsx";
                sfd.FileName = $"DanhSachMon_DoAnLapTrinhTrucQuan_{DateTime.Now:yyyyMMdd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("MaMon,TenMon,DanhMuc,GiaBan,GiaVonBOM,LaiPhanTram,TrangThai");
                            foreach (var m in _hienThiDanhSach)
                            {
                                sw.WriteLine($"\"{m.MaMon}\",\"{m.TenMon}\",\"{m.TenDanhMuc}\",{m.GiaBan},{m.GiaVonBOM},{m.TyLeLai},\"{m.TrangThai}\"");
                            }
                        }
                        MessageBox.Show($"Đã xuất thành công danh sách {_hienThiDanhSach.Count} món ra file:\n{sfd.FileName}", "Xuất Excel thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

    }
}
