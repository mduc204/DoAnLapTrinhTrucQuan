using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class dlgAddIngredient : Form
    {
        public Ingredient? NewIngredient { get; private set; }
        public bool HasImportedData { get; private set; } = false;

        private List<Ingredient> _importedPreviewList = new List<Ingredient>();
        private string _selectedExcelPath = string.Empty;

        public dlgAddIngredient(int initialTab = 0)
        {
            InitializeComponent();
            SetupForm();
            SelectTab(initialTab);
        }

        private void SetupForm()
        {
            // 1. Cấu hình Tab 1: Thêm thủ công
            cboNhom.Items.Clear();
            cboNhom.Items.AddRange(new object[] {
                "Cà phê", "Sữa", "Trà", "Đường", "Topping", "Syrup", "Bột", "Trái cây", "Bao bì", "Khác"
            });
            cboNhom.SelectedIndex = 0;

            txtMaNL.Text = SinhMaNguyenLieuTiepTheo();

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => Close();

            // 2. Cấu hình Tab chuyển đổi
            btnTabManual.Click += (s, e) => SelectTab(0);
            btnTabExcel.Click += (s, e) => SelectTab(1);

            // 3. Cấu hình Tab 2: Nhập / Xuất Excel
            pnlDashedBox.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, pnlDashedBox.Width - 1, pnlDashedBox.Height - 1);
                using (var path = UIHelper.GetRoundedPath(rect, 8))
                {
                    using (var fillBrush = new SolidBrush(Color.FromArgb(254, 252, 249)))
                    {
                        g.FillPath(fillBrush, path);
                    }
                    using (var pen = new Pen(Color.FromArgb(218, 197, 180), 1.5f))
                    {
                        pen.DashStyle = DashStyle.Dash;
                        g.DrawPath(pen, path);
                    }
                }
            };

            btnChonTepExcel.Click += BtnChonTepExcel_Click;
            btnTaiTepMau.Click += BtnTaiTepMau_Click;
            btnXemTruoc.Click += BtnXemTruoc_Click;
            btnNhapNguyenLieu.Click += BtnNhapNguyenLieu_Click;
            btnXuatExcel.Click += BtnXuatExcel_Click;
            btnXemDuLieuXuat.Click += BtnXemDuLieuXuat_Click;

            CapNhatThongKeXuat();
        }

        public void SelectTab(int index)
        {
            SuspendLayout();
            pnlContentArea.SuspendLayout();

            Color activeBg = Color.White;
            Color activeText = Color.FromArgb(85, 55, 34);
            Color activeBorder = Color.FromArgb(220, 210, 200);

            Color inactiveBg = Color.FromArgb(243, 236, 228);
            Color inactiveText = Color.FromArgb(126, 110, 101);

            if (index == 1)
            {
                // Tab 2: Nhập / Xuất Excel
                pnlTabManual.Visible = false;
                pnlTabExcel.Visible = true;
                pnlTabExcel.BringToFront();

                btnTabExcel.NormalBackColor = activeBg;
                btnTabExcel.HoverBackColor = activeBg;
                btnTabExcel.BorderColor = activeBorder;
                btnTabExcel.BorderWidth = 1;
                btnTabExcel.ForeColor = activeText;
                btnTabExcel.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

                btnTabManual.NormalBackColor = inactiveBg;
                btnTabManual.HoverBackColor = Color.FromArgb(238, 230, 220);
                btnTabManual.BorderColor = Color.Transparent;
                btnTabManual.BorderWidth = 0;
                btnTabManual.ForeColor = inactiveText;
                btnTabManual.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

                lblTitle.Text = "⭳ Nhập / Xuất dữ liệu Excel (.XLSX)";
                lblSubTitle.Text = "Chuẩn bị danh sách bằng tệp Excel mẫu hoặc xuất dữ liệu tồn kho hiện tại";

                CapNhatThongKeXuat();
            }
            else
            {
                // Tab 1: Thêm thủ công (Mặc định)
                pnlTabExcel.Visible = false;
                pnlTabManual.Visible = true;
                pnlTabManual.BringToFront();

                btnTabManual.NormalBackColor = activeBg;
                btnTabManual.HoverBackColor = activeBg;
                btnTabManual.BorderColor = activeBorder;
                btnTabManual.BorderWidth = 1;
                btnTabManual.ForeColor = activeText;
                btnTabManual.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

                btnTabExcel.NormalBackColor = inactiveBg;
                btnTabExcel.HoverBackColor = Color.FromArgb(238, 230, 220);
                btnTabExcel.BorderColor = Color.Transparent;
                btnTabExcel.BorderWidth = 0;
                btnTabExcel.ForeColor = inactiveText;
                btnTabExcel.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

                lblTitle.Text = "⊕ Thêm nguyên liệu mới";
                lblSubTitle.Text = "Nhập thông tin nguyên vật liệu để thêm vào danh mục quản lý kho Mộc Café";

                txtMaNL.Text = SinhMaNguyenLieuTiepTheo();
            }

            pnlContentArea.ResumeLayout(true);
            ResumeLayout(true);

            btnTabManual.Invalidate();
            btnTabExcel.Invalidate();
            pnlTabSelector.Invalidate();
        }

        private void CapNhatThongKeXuat()
        {
            int total = MockDataService.Instance.DanhSachNguyenLieu.Count;
            lblAllIngSub.Text = $"{total} nguyên liệu · Tệp Excel (.xlsx)";
        }

        #region Xử lý Tab 1: Thêm thủ công
        private string SinhMaNguyenLieuTiepTheo()
        {
            int maxNum = 0;
            var list = MockDataService.Instance.DanhSachNguyenLieu;
            foreach (var nl in list)
            {
                if (nl.MaNL.StartsWith("NL", StringComparison.OrdinalIgnoreCase))
                {
                    string sub = nl.MaNL.Substring(2);
                    if (int.TryParse(sub, out int n) && n > maxNum)
                    {
                        maxNum = n;
                    }
                }
            }
            return $"NL{maxNum + 1:D3}";
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string maNL = txtMaNL.Text.Trim();
            string tenNL = txtTenNL.Text.Trim();
            string nhom = cboNhom.SelectedItem?.ToString() ?? cboNhom.Text.Trim();
            string dvt = cboDVT.Text.Trim();

            if (string.IsNullOrWhiteSpace(maNL))
            {
                MessageHelper.ShowWarning("Mã nguyên liệu không được để trống!", "Thông báo");
                txtMaNL.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tenNL))
            {
                MessageHelper.ShowWarning("Vui lòng nhập tên nguyên liệu!", "Thông báo");
                txtTenNL.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(dvt))
            {
                MessageHelper.ShowWarning("Vui lòng nhập đơn vị tính!", "Thông báo");
                cboDVT.Focus();
                return;
            }

            // Kiểm tra trùng mã
            if (MockDataService.Instance.DanhSachNguyenLieu.Any(x => x.MaNL.Equals(maNL, StringComparison.OrdinalIgnoreCase)))
            {
                MessageHelper.ShowWarning($"Mã nguyên liệu '{maNL}' đã tồn tại! Vui lòng chọn mã khác.", "Trùng mã");
                txtMaNL.Focus();
                return;
            }

            var ing = new NguyenLieu
            {
                MaNL = maNL,
                TenNL = tenNL,
                NhomNL = nhom,
                DVT = dvt,
                DonGiaNhap = nudDonGiaNhap.Value,
                TonKhoHienTai = nudTonBanDau.Value,
                DinhMucToiThieu = nudMinStock.Value,
                ViTriKho = txtViTriKho.Text.Trim(),
                DangSuDung = true
            };

            MockDataService.Instance.DanhSachNguyenLieu.Add(ing);

            // Ghi nhật ký vào thẻ kho nếu có tồn ban đầu
            if (nudTonBanDau.Value > 0)
            {
                var tx = new InventoryTransaction
                {
                    TransactionId = "TX" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    IngredientId = maNL,
                    TransactionTime = DateTime.Now,
                    DisplayTime = DateTime.Now.ToString("HH:mm") + " hôm nay",
                    TransactionType = "Nhập kho ban đầu",
                    Quantity = nudTonBanDau.Value,
                    BalanceAfter = nudTonBanDau.Value,
                    PerformedBy = "Quản lý ca",
                    Note = "Khởi tạo tồn kho ban đầu khi tạo nguyên liệu"
                };
                MockDataService.Instance.DanhSachLichSuKho.Insert(0, tx);
            }

            NewIngredient = ing;
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Xử lý Tab 2: Nhập / Xuất Excel với ClosedXML
        private void BtnChonTepExcel_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn tệp danh sách nguyên liệu Excel (.xlsx)";
                ofd.Filter = "Tệp Excel (*.xlsx)|*.xlsx|Tất cả tệp (*.*)|*.*";

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    _selectedExcelPath = ofd.FileName;
                    if (ExcelHelper.ImportIngredientsFromExcel(_selectedExcelPath, out var imported, out string err))
                    {
                        _importedPreviewList = imported;
                        lblDropTitle.Text = Path.GetFileName(_selectedExcelPath);
                        lblDropSub.Text = $"Đã tải {_importedPreviewList.Count} dòng dữ liệu hợp lệ";

                        btnNhapNguyenLieu.NormalBackColor = UIHelper.PrimaryCoffee;
                        btnNhapNguyenLieu.Enabled = true;
                        btnXemTruoc.Enabled = true;
                        lblNoteNhap.Text = $"Tệp sẵn sàng: {Path.GetFileName(_selectedExcelPath)}";

                        MessageHelper.ShowInfo($"Đã đọc thành công {_importedPreviewList.Count} nguyên liệu từ tệp Excel!\nBạn có thể nhấn [Xem trước] hoặc [Nhập tệp].", "Tải tệp thành công");
                    }
                    else
                    {
                        MessageHelper.ShowError($"Không thể đọc tệp Excel: {err}", "Lỗi định dạng tệp");
                    }
                }
            }
        }

        private void BtnTaiTepMau_Click(object? sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu tệp mẫu Excel nguyên liệu";
                sfd.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Mau_Nhap_NguyenLieu_MocCafe.xlsx";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    if (ExcelHelper.GenerateTemplateExcel(sfd.FileName, out string err))
                    {
                        MessageHelper.ShowInfo($"Đã tạo tệp mẫu Excel thành công tại:\n{sfd.FileName}\n\nBạn có thể mở tệp và điền dữ liệu theo các cột mẫu.", "Tải tệp mẫu");
                    }
                    else
                    {
                        MessageHelper.ShowError($"Lỗi tạo tệp mẫu: {err}", "Lỗi");
                    }
                }
            }
        }

        private void BtnXemTruoc_Click(object? sender, EventArgs e)
        {
            if (_importedPreviewList.Count == 0)
            {
                MessageHelper.ShowWarning("Vui lòng chọn tệp Excel trước khi xem trước dữ liệu!", "Thông báo");
                return;
            }

            using (var dlg = new dlgPreviewExcel("Xem trước dữ liệu Excel", $"Tệp: {Path.GetFileName(_selectedExcelPath)}", _importedPreviewList))
            {
                dlg.ShowDialog(this);
            }
        }

        private void BtnNhapNguyenLieu_Click(object? sender, EventArgs e)
        {
            if (_importedPreviewList.Count == 0)
            {
                MessageHelper.ShowWarning("Vui lòng chọn tệp Excel có dữ liệu trước khi nhập!", "Thông báo");
                return;
            }

            int countThemMoi = 0;
            int countCapNhat = 0;

            foreach (var item in _importedPreviewList)
            {
                var existing = MockDataService.Instance.DanhSachNguyenLieu
                    .FirstOrDefault(x => (!string.IsNullOrEmpty(item.IngredientId) && x.MaNL.Equals(item.IngredientId, StringComparison.OrdinalIgnoreCase))
                                      || x.TenNL.Equals(item.IngredientName, StringComparison.OrdinalIgnoreCase));

                if (existing != null)
                {
                    decimal oldTon = existing.TonKhoHienTai;
                    existing.TonKhoHienTai = item.StockQuantity;
                    existing.DonGiaNhap = item.ImportPrice > 0 ? item.ImportPrice : existing.DonGiaNhap;
                    existing.NhomNL = !string.IsNullOrEmpty(item.GroupName) ? item.GroupName : existing.NhomNL;
                    existing.DVT = !string.IsNullOrEmpty(item.Unit) ? item.Unit : existing.DVT;

                    MockDataService.Instance.DanhSachLichSuKho.Insert(0, new InventoryTransaction
                    {
                        TransactionId = "TX" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        IngredientId = existing.MaNL,
                        TransactionTime = DateTime.Now,
                        DisplayTime = DateTime.Now.ToString("HH:mm") + " hôm nay",
                        TransactionType = "Nhập kho Excel",
                        Quantity = item.StockQuantity - oldTon,
                        BalanceAfter = item.StockQuantity,
                        PerformedBy = "Quản lý ca",
                        Note = "Đồng bộ cập nhật từ tệp Excel"
                    });

                    countCapNhat++;
                }
                else
                {
                    string maMoi = string.IsNullOrEmpty(item.IngredientId) ? SinhMaNguyenLieuTiepTheo() : item.IngredientId;
                    var newNL = new NguyenLieu
                    {
                        MaNL = maMoi,
                        TenNL = item.IngredientName,
                        NhomNL = item.GroupName,
                        DVT = item.Unit,
                        TonKhoHienTai = item.StockQuantity,
                        DinhMucToiThieu = item.MinStock,
                        DonGiaNhap = item.ImportPrice,
                        ViTriKho = "Kho quầy Bar",
                        DangSuDung = true
                    };
                    MockDataService.Instance.DanhSachNguyenLieu.Add(newNL);

                    if (item.StockQuantity > 0)
                    {
                        MockDataService.Instance.DanhSachLichSuKho.Insert(0, new InventoryTransaction
                        {
                            TransactionId = "TX" + DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                            IngredientId = maMoi,
                            TransactionTime = DateTime.Now,
                            DisplayTime = DateTime.Now.ToString("HH:mm") + " hôm nay",
                            TransactionType = "Nhập kho ban đầu",
                            Quantity = item.StockQuantity,
                            BalanceAfter = item.StockQuantity,
                            PerformedBy = "Quản lý ca",
                            Note = "Tạo mới nguyên liệu từ tệp Excel"
                        });
                    }

                    countThemMoi++;
                }
            }

            HasImportedData = true;
            MessageHelper.ShowInfo($"Hoàn tất nhập dữ liệu từ Excel:\n• Thêm mới: {countThemMoi} nguyên liệu\n• Cập nhật: {countCapNhat} nguyên liệu", "Nhập Excel thành công");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnXuatExcel_Click(object? sender, EventArgs e)
        {
            var allList = MockDataService.Instance.DanhSachNguyenLieu;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách nguyên liệu ra tệp Excel";
                sfd.Filter = "Tệp Excel (*.xlsx)|*.xlsx";
                sfd.FileName = $"DanhSachNguyenLieu_MocCafe_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    if (ExcelHelper.ExportIngredientsToExcel(sfd.FileName, allList, out string err))
                    {
                        var res = MessageBox.Show(
                            $"Xuất tệp Excel thành công!\nĐường dẫn: {sfd.FileName}\n\nBạn có muốn mở tệp ngay không?",
                            "Xuất Excel thành công",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (res == DialogResult.Yes)
                        {
                            try
                            {
                                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        MessageHelper.ShowError($"Lỗi khi xuất tệp Excel: {err}", "Lỗi");
                    }
                }
            }
        }

        private void BtnXemDuLieuXuat_Click(object? sender, EventArgs e)
        {
            var allList = MockDataService.Instance.DanhSachNguyenLieu.Select(x => (Ingredient)x).ToList();

            using (var dlg = new dlgPreviewExcel("Dữ liệu xuất Excel", $"Tổng cộng {allList.Count} nguyên liệu trong kho hiện tại", allList))
            {
                dlg.ShowDialog(this);
            }
        }
        #endregion
    }
}
