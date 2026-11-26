using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.BLL;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Dialogs;
using DoAnLapTrinhTrucQuan.Forms;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    public partial class ucInventory : UserControl
    {
        private readonly InventoryBLL _bll;
        private List<Ingredient> _allIngredients = new List<Ingredient>();
        private List<Ingredient> _filteredIngredients = new List<Ingredient>();
        private Ingredient? _selectedIngredient = null;
        private bool _isBinding = false;

        public ucInventory()
        {
            InitializeComponent();
            _bll = new InventoryBLL();

            Dock = DockStyle.Fill;
            DoubleBuffered = true;

            SetupCustomUI();
            InitializeEvents();
            LoadData();
        }

        #region 1. Khởi tạo Giao diện & Định dạng Controls
        private void SetupCustomUI()
        {
            // Thiết lập phong cách Mộc Café chuẩn theo UIHelper
            BackColor = UIHelper.BgMain;

            // Áp dụng Style cho cả 2 DataGridView
            UIHelper.StyleDataGridView(dgvNguyenLieu);
            UIHelper.StyleDataGridView(dgvLichSuKho);

            // Tùy chỉnh chi tiết DataGridView Nguyên liệu
            dgvNguyenLieu.ColumnHeadersHeight = 44;
            dgvNguyenLieu.RowTemplate.Height = 48;
            dgvNguyenLieu.ColumnHeadersDefaultCellStyle.SelectionBackColor = UIHelper.HeaderBg;
            dgvNguyenLieu.ColumnHeadersDefaultCellStyle.SelectionForeColor = UIHelper.TextMain;

            if (dgvNguyenLieu.Columns["colMaNL"] != null)
            {
                dgvNguyenLieu.Columns["colMaNL"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvNguyenLieu.Columns["colMaNL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvNguyenLieu.Columns["colDVT"] != null)
            {
                dgvNguyenLieu.Columns["colDVT"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvNguyenLieu.Columns["colDVT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvNguyenLieu.Columns["colTonKho"] != null)
            {
                dgvNguyenLieu.Columns["colTonKho"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNguyenLieu.Columns["colTonKho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvNguyenLieu.Columns["colToiThieu"] != null)
            {
                dgvNguyenLieu.Columns["colToiThieu"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvNguyenLieu.Columns["colToiThieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvNguyenLieu.Columns["colTrangThai"] != null)
            {
                dgvNguyenLieu.Columns["colTrangThai"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvNguyenLieu.Columns["colTrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Tùy chỉnh chi tiết DataGridView Thẻ kho (Lịch sử)
            dgvLichSuKho.ColumnHeadersHeight = 40;
            dgvLichSuKho.RowTemplate.Height = 38;
            dgvLichSuKho.ColumnHeadersDefaultCellStyle.SelectionBackColor = UIHelper.HeaderBg;
            dgvLichSuKho.ColumnHeadersDefaultCellStyle.SelectionForeColor = UIHelper.TextMain;

            if (dgvLichSuKho.Columns["colHistorySoLuong"] != null)
            {
                dgvLichSuKho.Columns["colHistorySoLuong"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLichSuKho.Columns["colHistorySoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvLichSuKho.Columns["colHistoryTonSau"] != null)
            {
                dgvLichSuKho.Columns["colHistoryTonSau"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLichSuKho.Columns["colHistoryTonSau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Danh sách nhóm cho ComboBox lọc & chi tiết
            var nhomList = new List<string> { "Tất cả nhóm", "Cà phê", "Sữa", "Trà", "Đường", "Topping", "Syrup", "Bột", "Trái cây", "Bao bì", "Khác" };
            cboNhom.DataSource = nhomList.ToList();

            var detailNhomList = nhomList.Where(x => x != "Tất cả nhóm").ToList();
            cboDetailNhom.DataSource = detailNhomList;

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Tất cả trạng thái", "An toàn", "Sắp hết", "Hết hàng", "Ngừng sử dụng" });
            cboTrangThai.SelectedIndex = 0;
        }

        private void InitializeEvents()
        {
            // Tìm kiếm & Lọc
            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cboNhom.SelectedIndexChanged += (s, e) => ApplyFilter();
            cboTrangThai.SelectedIndexChanged += (s, e) => ApplyFilter();

            // Chọn dòng nguyên liệu
            dgvNguyenLieu.SelectionChanged += DgvNguyenLieu_SelectionChanged;

            // Vẽ tùy biến badge trạng thái, 2 dòng tên nguyên liệu & vạch cam dòng chọn
            dgvNguyenLieu.CellPainting += DgvNguyenLieu_CellPainting;
            dgvLichSuKho.CellPainting += DgvLichSuKho_CellPainting;

            // Hỗ trợ cuộn chuột mượt mà (MouseWheel)
            dgvNguyenLieu.MouseWheel += (s, e) => HandleMouseWheel(dgvNguyenLieu, e);
            dgvLichSuKho.MouseWheel += (s, e) => HandleMouseWheel(dgvLichSuKho, e);

            // Nút Lưu thông tin nguyên liệu
            btnLuu.Click += BtnLuu_Click;

            // Nút Nhập kho & Xuất kho
            btnNhapKho.Click += (s, e) => MoPopupNhapXuat(isImport: true);
            btnNhapKhoTop.Click += (s, e) => MoPopupNhapXuat(isImport: true);
            btnXuatKho.Click += (s, e) => MoPopupNhapXuat(isImport: false);

            // Nút Ngừng sử dụng / Kích hoạt lại
            btnNgungSuDung.Click += BtnNgungSuDung_Click;

            // Nút Thêm mới nguyên liệu (Mở Form riêng biệt có tự sinh mã)
            btnThemNguyenLieu.Click += BtnThemNguyenLieu_Click;

            // Nút Xuất Excel (CSV)
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustSplitterRatio();
        }

        private void AdjustSplitterRatio()
        {
            if (splitMain.Height > 350)
            {
                int targetH = (int)(splitMain.Height * 0.58);
                if (targetH >= 280 && targetH <= splitMain.Height - 160)
                {
                    splitMain.SplitterDistance = targetH;
                }
            }

            if (splitTop.Width > 550)
            {
                int targetW = (int)(splitTop.Width * 0.62);
                if (targetW >= 420 && targetW <= splitTop.Width - 360)
                {
                    splitTop.SplitterDistance = targetW;
                }
            }
        }
        #endregion

        #region 2. Tải Dữ liệu & Lọc
        public void LoadData()
        {
            _allIngredients = _bll.LoadIngredients();
            CapNhatThongKe();
            ApplyFilter();
            AdjustSplitterRatio();
        }

        private void CapNhatThongKe()
        {
            int total = _allIngredients.Count;
            int sapHet = _allIngredients.Count(x => x.IsActive && x.StockQuantity > 0 && x.StockQuantity <= x.MinStock);
            int hetHang = _allIngredients.Count(x => x.IsActive && x.StockQuantity <= 0);

            lblSubtitle.Text = $"{total} nguyên liệu · {sapHet} sắp hết · {hetHang} hết hàng";
        }

        private void ApplyFilter()
        {
            string keyword = (txtSearch.Text ?? "").Trim().ToLower();
            string selectedNhom = cboNhom.SelectedItem?.ToString() ?? "Tất cả nhóm";
            string selectedStatus = cboTrangThai.SelectedItem?.ToString() ?? "Tất cả trạng thái";

            _filteredIngredients = _allIngredients.Where(ing =>
            {
                // Lọc theo từ khóa
                bool matchKeyword = string.IsNullOrEmpty(keyword)
                    || ing.IngredientId.ToLower().Contains(keyword)
                    || ing.IngredientName.ToLower().Contains(keyword);

                // Lọc theo nhóm
                bool matchNhom = (selectedNhom == "Tất cả nhóm")
                    || ing.GroupName.Equals(selectedNhom, StringComparison.OrdinalIgnoreCase);

                // Lọc theo trạng thái
                bool matchStatus = (selectedStatus == "Tất cả trạng thái");
                if (!matchStatus)
                {
                    if (selectedStatus == "Ngừng sử dụng") matchStatus = !ing.IsActive;
                    else if (selectedStatus == "Hết hàng") matchStatus = ing.IsActive && ing.StockQuantity <= 0;
                    else if (selectedStatus == "Sắp hết") matchStatus = ing.IsActive && ing.StockQuantity > 0 && ing.StockQuantity <= ing.MinStock;
                    else if (selectedStatus == "An toàn") matchStatus = ing.IsActive && ing.StockQuantity > ing.MinStock;
                }

                return matchKeyword && matchNhom && matchStatus;
            }).ToList();

            BindGrid();
        }

        private void BindGrid()
        {
            _isBinding = true;
            dgvNguyenLieu.Rows.Clear();

            foreach (var ing in _filteredIngredients)
            {
                int rowIndex = dgvNguyenLieu.Rows.Add(
                    ing.IngredientId,
                    ing.IngredientName,
                    ing.Unit,
                    ing.StockQuantity.ToString("#,##0"),
                    ing.MinStock.ToString("#,##0"),
                    ing.StockStatus
                );
                dgvNguyenLieu.Rows[rowIndex].Tag = ing;
            }

            _isBinding = false;

            if (dgvNguyenLieu.Rows.Count > 0)
            {
                // Chọn lại nguyên liệu trước đó hoặc chọn dòng đầu tiên
                int selectIndex = 0;
                if (_selectedIngredient != null)
                {
                    for (int i = 0; i < dgvNguyenLieu.Rows.Count; i++)
                    {
                        if (dgvNguyenLieu.Rows[i].Tag is Ingredient ing && ing.IngredientId == _selectedIngredient.IngredientId)
                        {
                            selectIndex = i;
                            break;
                        }
                    }
                }
                dgvNguyenLieu.Rows[selectIndex].Selected = true;
                HienThiChiTiet(dgvNguyenLieu.Rows[selectIndex].Tag as Ingredient);
            }
            else
            {
                XoaTrangChiTiet();
            }
        }
        #endregion

        #region 3. Hiển thị Chi tiết & Lịch sử Thẻ kho
        private void DgvNguyenLieu_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding || dgvNguyenLieu.SelectedRows.Count == 0) return;
            var ing = dgvNguyenLieu.SelectedRows[0].Tag as Ingredient;
            HienThiChiTiet(ing);
        }

        private void HienThiChiTiet(Ingredient? ing)
        {
            _selectedIngredient = ing;
            if (ing == null)
            {
                XoaTrangChiTiet();
                return;
            }

            lblDetailMaNL.Text = $"Mã NL: {ing.IngredientId}";
            txtDetailMaNL.Text = ing.IngredientId;

            // Nhóm
            if (cboDetailNhom.Items.Contains(ing.GroupName))
            {
                cboDetailNhom.SelectedItem = ing.GroupName;
            }
            else
            {
                cboDetailNhom.Text = ing.GroupName;
            }

            txtDetailTenNL.Text = ing.IngredientName;
            txtDetailDVT.Text = ing.Unit;
            txtDetailDonGia.Text = $"{ing.ImportPrice:#,##0} đ";
            txtDetailTonKho.Text = $"{ing.StockQuantity:#,##0} {(ing.Unit.Contains('(') ? ing.Unit.Substring(ing.Unit.IndexOf('(') + 1).TrimEnd(')') : ing.Unit)}";
            nudDetailMucToiThieu.Value = Math.Max(nudDetailMucToiThieu.Minimum, Math.Min(nudDetailMucToiThieu.Maximum, ing.MinStock));

            // Trạng thái nút Ngừng sử dụng
            if (ing.IsActive)
            {
                btnNgungSuDung.Text = "Ngừng sử dụng";
                btnNgungSuDung.ForeColor = Color.FromArgb(229, 57, 53);
                btnNgungSuDung.BorderColor = Color.FromArgb(229, 57, 53);
            }
            else
            {
                btnNgungSuDung.Text = "Kích hoạt lại";
                btnNgungSuDung.ForeColor = Color.FromArgb(46, 125, 50);
                btnNgungSuDung.BorderColor = Color.FromArgb(46, 125, 50);
            }

            // Tải thẻ kho (lịch sử)
            TaiLichSuKho(ing.IngredientId);
        }

        private void XoaTrangChiTiet()
        {
            lblDetailMaNL.Text = "Mã NL: --";
            txtDetailMaNL.Clear();
            txtDetailTenNL.Clear();
            txtDetailDVT.Clear();
            txtDetailDonGia.Clear();
            txtDetailTonKho.Clear();
            nudDetailMucToiThieu.Value = 0;
            dgvLichSuKho.Rows.Clear();
            lblHistoryTitle.Text = "Lịch sử nhập / xuất";
        }

        private void TaiLichSuKho(string maNL)
        {
            lblHistoryTitle.Text = $"Lịch sử nhập / xuất · {maNL}";
            dgvLichSuKho.Rows.Clear();

            var historyList = _bll.LoadHistory(maNL);
            string unitShort = _selectedIngredient?.Unit ?? "g";
            if (unitShort.Contains('(') && unitShort.Contains(')'))
            {
                unitShort = unitShort.Substring(unitShort.IndexOf('(') + 1).TrimEnd(')');
            }

            foreach (var tx in historyList)
            {
                string soLuongStr = tx.Quantity > 0
                    ? $"+{tx.Quantity:#,##0} {unitShort}"
                    : $"{tx.Quantity:#,##0} {unitShort}";

                string tonSauStr = $"{tx.BalanceAfter:#,##0} {unitShort}";

                int rowIndex = dgvLichSuKho.Rows.Add(
                    tx.DisplayTime,
                    tx.TransactionType,
                    soLuongStr,
                    tonSauStr,
                    tx.PerformedBy,
                    tx.Note
                );
                dgvLichSuKho.Rows[rowIndex].Tag = tx;
            }
        }
        #endregion

        #region 4. Xử lý Thao tác: Nhập kho, Xuất kho, Lưu & Đổi trạng thái
        private void MoPopupNhapXuat(bool isImport)
        {
            if (_selectedIngredient == null)
            {
                MessageHelper.ShowWarning("Vui lòng chọn nguyên liệu cần thao tác!", "Thông báo");
                return;
            }

            using (var popup = new dlgStockVoucher(_selectedIngredient, isImport, "Nguyễn Văn Hưng"))
            {
                if (popup.ShowDialog(this) == DialogResult.OK)
                {
                    if (isImport)
                    {
                        if (_bll.ProcessImport(_selectedIngredient.IngredientId, popup.SoLuongNhapXuat, popup.DonGiaNhap, popup.GhiChu, popup.NguoiThucHien, out string err))
                        {
                            MessageHelper.ShowInfo($"Nhập kho thành công +{popup.SoLuongNhapXuat:#,##0} {_selectedIngredient.Unit}!", "Thành công");
                        }
                        else
                        {
                            MessageHelper.ShowError(err, "Lỗi nhập kho");
                            return;
                        }
                    }
                    else
                    {
                        if (_bll.ProcessExport(_selectedIngredient.IngredientId, popup.SoLuongNhapXuat, popup.LyDoXuat, popup.NguoiThucHien, popup.GhiChu, out string err))
                        {
                            MessageHelper.ShowInfo($"Xuất kho thành công -{popup.SoLuongNhapXuat:#,##0} {_selectedIngredient.Unit}!", "Thành công");
                        }
                        else
                        {
                            MessageHelper.ShowError(err, "Lỗi xuất kho");
                            return;
                        }
                    }

                    LoadData();
                }
            }
        }

        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            if (_selectedIngredient == null) return;

            string tenMoi = txtDetailTenNL.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenMoi))
            {
                MessageHelper.ShowWarning("Tên nguyên liệu không được để trống!", "Thông báo");
                txtDetailTenNL.Focus();
                return;
            }

            decimal donGia = _selectedIngredient.ImportPrice;
            string donGiaText = txtDetailDonGia.Text.Replace("đ", "").Replace(",", "").Replace(".", "").Trim();
            if (decimal.TryParse(donGiaText, out decimal dgParsed))
            {
                donGia = dgParsed;
            }

            _selectedIngredient.IngredientName = tenMoi;
            _selectedIngredient.GroupName = cboDetailNhom.SelectedItem?.ToString() ?? cboDetailNhom.Text;
            _selectedIngredient.Unit = txtDetailDVT.Text.Trim();
            _selectedIngredient.ImportPrice = donGia;
            _selectedIngredient.MinStock = nudDetailMucToiThieu.Value;

            if (_bll.SaveIngredient(_selectedIngredient, out string err))
            {
                MessageHelper.ShowInfo("Đã lưu thông tin nguyên liệu thành công!", "Thông báo");
                LoadData();
            }
            else
            {
                MessageHelper.ShowError(err, "Lỗi");
            }
        }

        private void BtnNgungSuDung_Click(object? sender, EventArgs e)
        {
            if (_selectedIngredient == null) return;

            string actionName = _selectedIngredient.IsActive ? "ngừng sử dụng" : "kích hoạt lại";
            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn {actionName} nguyên liệu '{_selectedIngredient.IngredientName}'?",
                "Xác nhận thay đổi trạng thái",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _bll.ToggleActive(_selectedIngredient.IngredientId);
                LoadData();
            }
        }

        private void BtnThemNguyenLieu_Click(object? sender, EventArgs e)
        {
            // Mở popup ở Tab 1 (Thêm thủ công)
            using (var dlg = new dlgAddIngredient(initialTab: 0))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();

                    if (dlg.NewIngredient != null)
                    {
                        for (int i = 0; i < dgvNguyenLieu.Rows.Count; i++)
                        {
                            if (dgvNguyenLieu.Rows[i].Tag is Ingredient ing && ing.IngredientId == dlg.NewIngredient.MaNL)
                            {
                                dgvNguyenLieu.ClearSelection();
                                dgvNguyenLieu.Rows[i].Selected = true;
                                HienThiChiTiet(ing);
                                dgvNguyenLieu.FirstDisplayedScrollingRowIndex = i;
                                break;
                            }
                        }
                        MessageHelper.ShowInfo($"Đã thêm thành công nguyên liệu [{dlg.NewIngredient.MaNL}] {dlg.NewIngredient.TenNL}!", "Thành công");
                    }
                }
            }
        }

        private void BtnXuatExcel_Click(object? sender, EventArgs e)
        {
            // Mở popup ở Tab 2 (Nhập / Xuất Excel)
            using (var dlg = new dlgAddIngredient(initialTab: 1))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
        #endregion

        #region 5. Vẽ Tùy biến DataGridView: Loại bỏ chọn xanh, 2 dòng Tên, Badge Trạng thái, Vạch cam & Cuộn chuột
        private void DgvNguyenLieu_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.Graphics == null) return;

            // 1. Vẽ Header - Tuyệt đối ngăn chặn cột bị chọn màu xanh dương Windows
            if (e.RowIndex < 0)
            {
                using (var brushHeader = new SolidBrush(UIHelper.HeaderBg))
                {
                    e.Graphics.FillRectangle(brushHeader, e.CellBounds);
                }

                using (var penLine = new Pen(UIHelper.BorderColor, 1f))
                {
                    e.Graphics.DrawLine(penLine, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                }

                string headerText = dgvNguyenLieu.Columns[e.ColumnIndex].HeaderText;
                var align = dgvNguyenLieu.Columns[e.ColumnIndex].HeaderCell.Style.Alignment;
                var flags = TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;
                if (align == DataGridViewContentAlignment.MiddleCenter) flags |= TextFormatFlags.HorizontalCenter;
                else if (align == DataGridViewContentAlignment.MiddleRight) flags |= TextFormatFlags.Right;
                else flags |= TextFormatFlags.Left;

                Rectangle textBounds = e.CellBounds;
                textBounds.X += 8;
                textBounds.Width -= 16;
                TextRenderer.DrawText(e.Graphics, headerText, UIHelper.FontBold, textBounds, UIHelper.TextMain, flags);

                e.Handled = true;
                return;
            }

            if (e.RowIndex >= dgvNguyenLieu.Rows.Count) return;

            var ing = dgvNguyenLieu.Rows[e.RowIndex].Tag as Ingredient;
            if (ing == null) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;

            // Nền dòng - dùng màu kem ấm chuẩn Mộc Café
            Color backColor = isSelected ? UIHelper.RowSelected : (e.RowIndex % 2 == 1 ? Color.FromArgb(253, 250, 246) : Color.White);
            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }

            // Đường phân cách mờ nhẹ
            using (var pen = new Pen(Color.FromArgb(242, 236, 230), 1f))
            {
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }

            // Vạch cam bên trái cho dòng đang được chọn (chuẩn thiết kế Mộc Café)
            if (isSelected && e.ColumnIndex == 0)
            {
                using (var barBrush = new SolidBrush(UIHelper.AccentOrange))
                {
                    e.Graphics.FillRectangle(barBrush, e.CellBounds.Left, e.CellBounds.Top, 4, e.CellBounds.Height);
                }
            }

            string colName = dgvNguyenLieu.Columns[e.ColumnIndex].Name;

            // 1. Cột Tên nguyên liệu / Nhóm (Hiển thị 2 dòng)
            if (colName == "colTenNL")
            {
                e.Handled = true;
                Rectangle rect = e.CellBounds;
                rect.X += 8;
                rect.Width -= 12;

                // Dòng 1: Tên nguyên liệu
                var rectTen = new Rectangle(rect.X, rect.Y + 6, rect.Width, 20);
                TextRenderer.DrawText(e.Graphics, ing.IngredientName, UIHelper.FontBold, rectTen, UIHelper.TextMain,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                // Dòng 2: Nhóm nguyên liệu
                var rectNhom = new Rectangle(rect.X, rect.Y + 26, rect.Width, 16);
                TextRenderer.DrawText(e.Graphics, $"📂 {ing.GroupName}", UIHelper.FontSmall, rectNhom, UIHelper.TextMuted,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
                return;
            }

            // 2. Cột Tồn kho (Font Bold)
            if (colName == "colTonKho")
            {
                e.Handled = true;
                Color numColor = ing.StockQuantity <= 0 ? UIHelper.DangerRed : UIHelper.TextMain;
                Rectangle numRect = e.CellBounds;
                numRect.Width -= 8;
                TextRenderer.DrawText(e.Graphics, ing.StockQuantity.ToString("#,##0"), UIHelper.FontBold, numRect, numColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                return;
            }

            // 3. Cột Tối thiểu (Màu xám nhạt)
            if (colName == "colToiThieu")
            {
                e.Handled = true;
                Rectangle minRect = e.CellBounds;
                minRect.Width -= 8;
                TextRenderer.DrawText(e.Graphics, ing.MinStock.ToString("#,##0"), UIHelper.FontRegular, minRect, UIHelper.TextMuted,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                return;
            }

            // 4. Cột Trạng thái (Vẽ Badge bo tròn con nhộng có chấm tròn •)
            if (colName == "colTrangThai")
            {
                e.Handled = true;
                VeBadgeTrangThai(e.Graphics, e.CellBounds, ing);
                return;
            }

            // Các cột thông thường: Mã NL, ĐVT
            e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
            e.Handled = true;
        }

        private void VeBadgeTrangThai(Graphics g, Rectangle cellBounds, Ingredient ing)
        {
            Color bgBadge;
            Color textBadge;
            string text = ing.StockStatus;

            if (!ing.IsActive)
            {
                bgBadge = UIHelper.BadgeGrayBg;
                textBadge = UIHelper.BadgeGrayText;
                text = "Ngừng dùng";
            }
            else if (ing.StockQuantity <= 0)
            {
                // Hết hàng -> Màu đỏ
                bgBadge = UIHelper.BadgeRedBg;
                textBadge = UIHelper.BadgeRedText;
                text = "Hết hàng";
            }
            else if (ing.StockQuantity <= ing.MinStock)
            {
                // Sắp hết -> Màu cam
                bgBadge = UIHelper.BadgeOrangeBg;
                textBadge = UIHelper.BadgeOrangeText;
                text = "Sắp hết";
            }
            else
            {
                // An toàn -> Màu xanh lá
                bgBadge = UIHelper.BadgeGreenBg;
                textBadge = UIHelper.BadgeGreenText;
                text = "An toàn";
            }

            int badgeWidth = Math.Min(cellBounds.Width - 12, 106);
            int badgeHeight = 24;
            int badgeX = cellBounds.X + (cellBounds.Width - badgeWidth) / 2;
            int badgeY = cellBounds.Y + (cellBounds.Height - badgeHeight) / 2;
            var badgeRect = new Rectangle(badgeX, badgeY, badgeWidth, badgeHeight);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ nền bo tròn capsule
            using (var path = UIHelper.GetCapsulePath(badgeRect))
            using (var brush = new SolidBrush(bgBadge))
            {
                g.FillPath(brush, path);
            }

            // Vẽ chữ kèm chấm tròn đồng nhất, không bị đè lên chữ
            string dotText = "● " + text;
            TextRenderer.DrawText(g, dotText, UIHelper.FontSmallBold, badgeRect, textBadge,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void DgvLichSuKho_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.Graphics == null) return;

            // 1. Vẽ Header - Ngăn chặn chọn màu xanh dương
            if (e.RowIndex < 0)
            {
                using (var brushHeader = new SolidBrush(UIHelper.HeaderBg))
                {
                    e.Graphics.FillRectangle(brushHeader, e.CellBounds);
                }

                using (var penLine = new Pen(UIHelper.BorderColor, 1f))
                {
                    e.Graphics.DrawLine(penLine, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                }

                string headerText = dgvLichSuKho.Columns[e.ColumnIndex].HeaderText;
                var align = dgvLichSuKho.Columns[e.ColumnIndex].HeaderCell.Style.Alignment;
                var flags = TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis;
                if (align == DataGridViewContentAlignment.MiddleCenter) flags |= TextFormatFlags.HorizontalCenter;
                else if (align == DataGridViewContentAlignment.MiddleRight) flags |= TextFormatFlags.Right;
                else flags |= TextFormatFlags.Left;

                Rectangle textBounds = e.CellBounds;
                textBounds.X += 8;
                textBounds.Width -= 16;
                TextRenderer.DrawText(e.Graphics, headerText, UIHelper.FontBold, textBounds, UIHelper.TextMain, flags);

                e.Handled = true;
                return;
            }

            if (e.RowIndex >= dgvLichSuKho.Rows.Count) return;

            var tx = dgvLichSuKho.Rows[e.RowIndex].Tag as InventoryTransaction;
            if (tx == null) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;
            Color backColor = isSelected ? UIHelper.RowSelected : (e.RowIndex % 2 == 1 ? Color.FromArgb(254, 252, 250) : Color.White);

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, e.CellBounds);
            }

            using (var pen = new Pen(Color.FromArgb(245, 240, 235), 1f))
            {
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }

            string colName = dgvLichSuKho.Columns[e.ColumnIndex].Name;

            // Tô chữ xanh cho nhập (+), đỏ cho xuất (-)
            if (colName == "colHistorySoLuong")
            {
                e.Handled = true;
                string val = dgvLichSuKho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
                Color color = tx.Quantity > 0 ? UIHelper.BadgeGreenText : UIHelper.DangerRed;

                Rectangle numBounds = e.CellBounds;
                numBounds.Width -= 8;
                TextRenderer.DrawText(e.Graphics, val, UIHelper.FontBold, numBounds, color,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                return;
            }

            e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);
            e.Handled = true;
        }

        private void HandleMouseWheel(DataGridView dgv, MouseEventArgs e)
        {
            if (dgv.Rows.Count == 0) return;
            int lines = e.Delta > 0 ? -1 : 1;
            int newIndex = Math.Max(0, Math.Min(dgv.Rows.Count - 1, dgv.FirstDisplayedScrollingRowIndex + lines));
            dgv.FirstDisplayedScrollingRowIndex = newIndex;
        }
        #endregion
    }
}
