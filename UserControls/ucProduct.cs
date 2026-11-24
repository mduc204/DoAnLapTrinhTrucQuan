using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.BLL;
using DoAnLapTrinhTrucQuan.Dialogs;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    /// <summary>
    /// UserControl Quản lý Món ăn / Đồ uống (ucProduct)
    /// </summary>
    public partial class ucProduct : UserControl
    {
        private readonly ProductBLL _productBLL;
        private List<Product> _displayedProducts = new List<Product>();
        private Product? _selectedProduct = null;
        private List<RecipeBOM> _currentBOM = new List<RecipeBOM>();

        public ucProduct()
        {
            InitializeComponent();
            _productBLL = new ProductBLL();

            SetupStyles();
            InitializeEvents();
            LoadCategoriesToComboBox();
            LoadProducts();
        }

        #region 1. Khởi tạo Giao diện & Căn lề chuẩn cho DataGridView
        private void SetupStyles()
        {
            UIHelper.StyleDataGridView(dgvProduct);
            UIHelper.StyleDataGridView(dgvBOM);

            dgvProduct.RowTemplate.Height = 52;
            dgvProduct.ColumnHeadersHeight = 42;

            dgvProduct.Columns["colMa"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["colMa"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduct.Columns["colHinhAnh"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["colHinhAnh"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduct.Columns["colTenMon"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvProduct.Columns["colGiaBan"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["colGiaBan"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProduct.Columns["colTrangThai"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProduct.Columns["colTrangThai"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBOM.RowTemplate.Height = 46;
            dgvBOM.ColumnHeadersHeight = 44;

            dgvBOM.Columns["colBOMTenNL"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

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

        private void LoadCategoriesToComboBox()
        {
            var categories = _productBLL.LoadCategories();

            cboFilterCategory.Items.Clear();
            cboFilterCategory.Items.Add($"Tất cả danh mục ({categories.Count})");
            foreach (var dm in categories)
            {
                cboFilterCategory.Items.Add(dm.CategoryName);
            }
            cboFilterCategory.SelectedIndex = 0;

            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.Add("Tất cả trạng thái");
            cboFilterStatus.Items.Add("Đang bán");
            cboFilterStatus.Items.Add("Tạm ngưng");
            cboFilterStatus.SelectedIndex = 0;

            cboCategory.Items.Clear();
            foreach (var dm in categories)
            {
                cboCategory.Items.Add(dm.CategoryName);
            }
        }
        #endregion

        #region 2. Xử lý Tỷ lệ Co giãn Tự động
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustSplitterRatio();
        }

        private void AdjustSplitterRatio()
        {
            if (splitMain.Height > 320)
            {
                int targetHDist = (int)(splitMain.Height * 0.58);
                if (targetHDist >= 260 && targetHDist <= splitMain.Height - 160)
                {
                    splitMain.SplitterDistance = targetHDist;
                }
            }

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
        private void InitializeEvents()
        {
            txtSearch.TextChanged += (s, e) => ApplyFilter();
            cboFilterCategory.SelectedIndexChanged += (s, e) => ApplyFilter();
            cboFilterStatus.SelectedIndexChanged += (s, e) => ApplyFilter();

            dgvProduct.SelectionChanged += DgvProduct_SelectionChanged;
            dgvProduct.CellPainting += DgvProduct_CellPainting;
            dgvBOM.CellPainting += DgvBOM_CellPainting;

            dgvBOM.CellEndEdit += DgvBOM_CellEndEdit;
            dgvBOM.CellClick += DgvBOM_CellClick;

            btnAddProduct.Click += BtnAddProduct_Click;
            btnSave.Click += BtnSave_Click;
            btnToggleStatus.Click += BtnToggleStatus_Click;
            btnAddIngredient.Click += BtnAddIngredient_Click;
            btnRecalculate.Click += (s, e) => RecalculateCOGS();
            btnExportExcel.Click += BtnExportExcel_Click;
            btnUpdatePrice.Click += (s, e) => MessageHelper.ShowInfo("Chức năng cập nhật bảng giá hàng loạt đang sẵn sàng kết nối Module Bán Hàng POS!");

            lblKichThuocAnh.Click += BtnChooseImage_Click;
            picProductDetail.Click += BtnChooseImage_Click;
        }
        #endregion

        #region 4. Nạp & Lọc Dữ liệu Sản Phẩm
        private void LoadProducts()
        {
            _displayedProducts = _productBLL.LoadProducts()
                .OrderBy(m => m.CategoryId)
                .ThenBy(m => m.ProductId)
                .ToList();

            RenderProductGrid();
            UpdateHeaderStats();
            AdjustSplitterRatio();
        }

        private void ApplyFilter()
        {
            string keyword = (txtSearch.Text ?? "").Trim().ToLower();
            string selectedCat = cboFilterCategory.SelectedIndex > 0 ? cboFilterCategory.SelectedItem?.ToString() ?? "" : "";
            int statusIndex = cboFilterStatus.SelectedIndex;

            _displayedProducts = _productBLL.LoadProducts().Where(m =>
            {
                bool matchKeyword = string.IsNullOrEmpty(keyword) ||
                                   m.ProductId.ToLower().Contains(keyword) ||
                                   m.ProductName.ToLower().Contains(keyword);

                bool matchCategory = string.IsNullOrEmpty(selectedCat) ||
                                     m.CategoryName.Equals(selectedCat, StringComparison.OrdinalIgnoreCase);

                bool matchStatus = true;
                if (statusIndex == 1) matchStatus = m.Status == "Đang bán";
                else if (statusIndex == 2) matchStatus = m.Status == "Tạm ngưng";

                return matchKeyword && matchCategory && matchStatus;
            }).OrderBy(m => m.CategoryId).ThenBy(m => m.ProductId).ToList();

            RenderProductGrid();
        }

        private void RenderProductGrid()
        {
            dgvProduct.SuspendLayout();
            dgvProduct.Rows.Clear();

            foreach (var m in _displayedProducts)
            {
                int rowIndex = dgvProduct.Rows.Add(
                    m.ProductId,
                    m.Image,
                    m.ProductName,
                    FormatHelper.FormatVND(m.Price),
                    m.Status
                );
                dgvProduct.Rows[rowIndex].Tag = m;
            }

            dgvProduct.ResumeLayout();

            if (dgvProduct.Rows.Count > 0)
            {
                dgvProduct.Rows[0].Selected = true;
                DgvProduct_SelectionChanged(null, EventArgs.Empty);
            }
            else
            {
                ClearForm();
            }
        }

        private void UpdateHeaderStats()
        {
            var allProducts = _productBLL.LoadProducts();
            int total = allProducts.Count;
            int active = allProducts.Count(m => m.Status == "Đang bán");
            int suspended = allProducts.Count(m => m.Status == "Tạm ngưng");
            int totalCats = _productBLL.LoadCategories().Count;

            lblSubtitle.Text = $"{total} món • {active} đang bán • {suspended} tạm ngưng • {totalCats} danh mục";
        }
        #endregion

        #region 5. Hiển thị Chi Tiết & BOM
        private void DgvProduct_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0) return;
            var selectedRow = dgvProduct.SelectedRows[0];
            if (selectedRow.Tag is not Product product) return;

            _selectedProduct = product;

            lblDetailSubHeader.Text = $"Mã món: {product.ProductId}";
            txtProductId.Text = product.ProductId;
            txtName.Text = product.ProductName;
            txtPrice.Text = product.Price.ToString("N0").Replace(",", ".");
            lblGiaVonBOM.Text = FormatHelper.FormatVND(product.CostPrice);
            rtbDescription.Text = product.Description;
            picProductDetail.Image = product.Image;

            int catIdx = cboCategory.FindStringExact(product.CategoryName);
            if (catIdx >= 0) cboCategory.SelectedIndex = catIdx;

            badgeLai.Text = $"Lãi: {product.ProfitMargin}%";
            badgeLai.Style = product.ProfitMargin >= 50 ? BadgeStyle.Success : (product.ProfitMargin > 0 ? BadgeStyle.Warning : BadgeStyle.Danger);

            UpdateToggleStatusButtonUI(product.Status);
            LoadBOMForProduct(product.ProductId);
        }

        private void UpdateToggleStatusButtonUI(string status)
        {
            if (status == "Đang bán")
            {
                btnToggleStatus.Text = "Tạm ngưng bán món này";
                btnToggleStatus.NormalBackColor = ColorTranslator.FromHtml("#FDF0F0");
                btnToggleStatus.HoverBackColor = ColorTranslator.FromHtml("#F9D5D5");
                btnToggleStatus.DownBackColor = ColorTranslator.FromHtml("#F5B7B7");
                btnToggleStatus.BorderColor = ColorTranslator.FromHtml("#F5C6CB");
                btnToggleStatus.BorderWidth = 1;
                btnToggleStatus.ForeColor = ColorTranslator.FromHtml("#C0392B");
            }
            else
            {
                btnToggleStatus.Text = "Mở bán lại món này";
                btnToggleStatus.NormalBackColor = ColorTranslator.FromHtml("#E8F8EE");
                btnToggleStatus.HoverBackColor = ColorTranslator.FromHtml("#D4F0DF");
                btnToggleStatus.DownBackColor = ColorTranslator.FromHtml("#BEE5CD");
                btnToggleStatus.BorderColor = ColorTranslator.FromHtml("#C3E6CB");
                btnToggleStatus.BorderWidth = 1;
                btnToggleStatus.ForeColor = ColorTranslator.FromHtml("#1B7C3F");
            }
        }

        private void LoadBOMForProduct(string productId)
        {
            dgvBOM.SuspendLayout();
            dgvBOM.Rows.Clear();

            _currentBOM = _productBLL.LoadBOM(productId);

            foreach (var item in _currentBOM)
            {
                int rIdx = dgvBOM.Rows.Add(
                    item.IngredientName,
                    item.Quantity.ToString("0.##"),
                    item.Unit,
                    FormatHelper.FormatVND(item.CostPrice),
                    "🗑"
                );
                dgvBOM.Rows[rIdx].Tag = item;
            }

            dgvBOM.ResumeLayout();
            RecalculateCOGS();
        }

        private void RecalculateCOGS()
        {
            decimal totalCOGS = _currentBOM.Sum(b => b.CostPrice);
            lblCOGSValue.Text = $"{FormatHelper.FormatVND(totalCOGS)} / suất";

            if (_selectedProduct != null)
            {
                _selectedProduct.CostPrice = totalCOGS;
                _selectedProduct.HasRecipe = _currentBOM.Count > 0;
                lblGiaVonBOM.Text = FormatHelper.FormatVND(totalCOGS);
                badgeLai.Text = $"Lãi: {_selectedProduct.ProfitMargin}%";
                badgeLai.Style = _selectedProduct.ProfitMargin >= 50 ? BadgeStyle.Success : (_selectedProduct.ProfitMargin > 0 ? BadgeStyle.Warning : BadgeStyle.Danger);
            }
        }

        private void ClearForm()
        {
            _selectedProduct = null;
            lblDetailSubHeader.Text = "Mã món: --";
            txtProductId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "0";
            lblGiaVonBOM.Text = "0 đ";
            rtbDescription.Text = "";
            badgeLai.Text = "Lãi: 0%";
            picProductDetail.Image = null;
            dgvBOM.Rows.Clear();
            lblCOGSValue.Text = "0 đ / suất";
        }
        #endregion

        #region 6. Tự vẽ Cell DataGridView (GDI+ Rendering)
        private void DgvProduct_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            bool isSelected = (e.State & DataGridViewElementStates.Selected) != 0;
            Rectangle cellBounds = e.CellBounds;
            Graphics? g = e.Graphics;
            if (g == null) return;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Color rowBg = isSelected ? UIHelper.RowSelected : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(rowBg))
            {
                g.FillRectangle(bgBrush, cellBounds);
            }

            using (Pen linePen = new Pen(ColorTranslator.FromHtml("#F0EAE1"), 1f))
            {
                g.DrawLine(linePen, cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);
            }

            if (isSelected && e.ColumnIndex == 0)
            {
                using (SolidBrush orangeBrush = new SolidBrush(UIHelper.AccentOrange))
                {
                    g.FillRectangle(orangeBrush, cellBounds.Left, cellBounds.Top, 4, cellBounds.Height);
                }
            }

            if (dgvProduct.Columns[e.ColumnIndex].Name == "colTenMon")
            {
                if (dgvProduct.Rows[e.RowIndex].Tag is Product product)
                {
                    Rectangle titleRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 22);
                    Rectangle catRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 28, cellBounds.Width - 16, 18);

                    TextRenderer.DrawText(g, product.ProductName, UIHelper.FontBold, titleRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    TextRenderer.DrawText(g, $"📂 {product.CategoryName}", UIHelper.FontSmall, catRect, UIHelper.TextMuted,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    e.Handled = true;
                    return;
                }
            }

            if (dgvProduct.Columns[e.ColumnIndex].Name == "colGiaBan")
            {
                string val = e.Value?.ToString() ?? "";
                TextRenderer.DrawText(g, val, UIHelper.FontBold, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            if (dgvProduct.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                string val = e.Value?.ToString() ?? "Đang bán";
                bool isDangBan = val == "Đang bán";
                Rectangle badgeRect = new Rectangle(cellBounds.Left + (cellBounds.Width - 100) / 2, cellBounds.Top + (cellBounds.Height - 24) / 2, 100, 24);

                Color bColor = isDangBan ? UIHelper.BadgeGreenBg : UIHelper.BadgeRedBg;
                Color tColor = isDangBan ? UIHelper.BadgeGreenText : ColorTranslator.FromHtml("#C0392B");

                using (GraphicsPath path = UIHelper.GetCapsulePath(badgeRect))
                using (SolidBrush bgB = new SolidBrush(bColor))
                {
                    g.FillPath(bgB, path);
                }

                // Vẽ chữ kèm chấm tròn đồng nhất, không bị đè lên chữ
                string dotText = "● " + val;
                TextRenderer.DrawText(g, dotText, UIHelper.FontSmallBold, badgeRect, tColor,
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

            Color rowBg = isSelected ? UIHelper.RowSelected : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(rowBg))
            {
                g.FillRectangle(bgBrush, cellBounds);
            }

            using (Pen linePen = new Pen(ColorTranslator.FromHtml("#F0EAE1"), 1f))
            {
                g.DrawLine(linePen, cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);
            }

            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMTenNL")
            {
                if (dgvBOM.Rows[e.RowIndex].Tag is RecipeBOM item)
                {
                    Rectangle titleRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 6, cellBounds.Width - 16, 20);
                    Rectangle subRect = new Rectangle(cellBounds.Left + 8, cellBounds.Top + 24, cellBounds.Width - 16, 16);

                    TextRenderer.DrawText(g, item.IngredientName, UIHelper.FontBold, titleRect, UIHelper.TextMain,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    TextRenderer.DrawText(g, $"{item.IngredientId} • {item.WarehouseLocation}", UIHelper.FontSmall, subRect, UIHelper.TextMuted,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                    e.Handled = true;
                    return;
                }
            }

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

            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMDVT")
            {
                string val = e.Value?.ToString() ?? "";
                TextRenderer.DrawText(g, val, UIHelper.FontRegular, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

            if (dgvBOM.Columns[e.ColumnIndex].Name == "colBOMGiaVon")
            {
                string val = e.Value?.ToString() ?? "";
                TextRenderer.DrawText(g, val, UIHelper.FontBold, cellBounds, UIHelper.TextMain,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                e.Handled = true;
                return;
            }

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
            if (row.Tag is not RecipeBOM item) return;

            string input = row.Cells["colBOMDinhLuong"].Value?.ToString() ?? "0";
            if (decimal.TryParse(input, out decimal soLuongMoi) && soLuongMoi >= 0)
            {
                item.Quantity = soLuongMoi;
                row.Cells["colBOMGiaVon"].Value = FormatHelper.FormatVND(item.CostPrice);
                if (_selectedProduct != null)
                {
                    _productBLL.SaveBOM(_selectedProduct.ProductId, _currentBOM);
                }
                RecalculateCOGS();
            }
            else
            {
                MessageHelper.ShowWarning("Vui lòng nhập số lượng định mức hợp lệ!");
                row.Cells["colBOMDinhLuong"].Value = item.Quantity.ToString("0.##");
            }
        }

        private void DgvBOM_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBOM.Rows.Count) return;
            if (dgvBOM.Columns[e.ColumnIndex].Name != "colBOMXoa") return;

            var row = dgvBOM.Rows[e.RowIndex];
            if (row.Tag is not RecipeBOM item) return;

            bool confirmed = MessageHelper.Confirm($"Bạn có chắc chắn muốn xóa nguyên liệu '{item.IngredientName}' khỏi công thức pha chế món này không?", "Xác nhận xóa nguyên liệu");
            if (confirmed)
            {
                _currentBOM.Remove(item);
                dgvBOM.Rows.RemoveAt(e.RowIndex);
                if (_selectedProduct != null)
                {
                    _productBLL.SaveBOM(_selectedProduct.ProductId, _currentBOM);
                }
                RecalculateCOGS();
            }
        }
        #endregion

        #region 8. Các Chức Năng Chính (Thêm món, Lưu, Đổi trạng thái, Thêm nguyên liệu)
        private void BtnAddProduct_Click(object? sender, EventArgs e)
        {
            using (dlgAddProduct dlg = new dlgAddProduct())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK && dlg.NewProduct != null)
                {
                    var newProduct = dlg.NewProduct;

                    if (!_productBLL.SaveProduct(newProduct, out string error))
                    {
                        MessageHelper.ShowError(error);
                        return;
                    }

                    _productBLL.SaveBOM(newProduct.ProductId, new List<RecipeBOM>());

                    ApplyFilter();
                    UpdateHeaderStats();

                    foreach (DataGridViewRow row in dgvProduct.Rows)
                    {
                        if (row.Cells["colMa"].Value?.ToString() == newProduct.ProductId)
                        {
                            row.Selected = true;
                            dgvProduct.CurrentCell = row.Cells["colTenMon"];
                            break;
                        }
                    }

                    DgvProduct_SelectionChanged(null, EventArgs.Empty);

                    string recipeHint = newProduct.HasRecipe
                        ? "\n\n💡 Món này có định lượng BOM, bạn có thể nhấn nút '+ Thêm nguyên liệu' ở bảng bên dưới để cấu thành công thức pha chế và tính giá vốn tự động."
                        : "";

                    MessageHelper.ShowInfo($"Đã thêm món mới '{newProduct.ProductName}' ({newProduct.ProductId}) thuộc nhóm '{newProduct.CategoryName}' vào thực đơn thành công!{recipeHint}", "Thêm món thành công");
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            string newName = txtName.Text.Trim();
            if (string.IsNullOrEmpty(newName))
            {
                MessageHelper.ShowWarning("Tên món không được để trống!", "Lỗi nhập liệu");
                txtName.Focus();
                return;
            }

            string priceStr = txtPrice.Text.Replace(".", "").Replace(",", "").Trim();
            if (!decimal.TryParse(priceStr, out decimal price) || price < 0)
            {
                MessageHelper.ShowWarning("Giá bán không hợp lệ!", "Lỗi nhập liệu");
                txtPrice.Focus();
                return;
            }

            _selectedProduct.ProductName = newName;
            _selectedProduct.Price = price;
            _selectedProduct.CategoryName = cboCategory.SelectedItem?.ToString() ?? _selectedProduct.CategoryName;
            _selectedProduct.Description = rtbDescription.Text.Trim();

            _productBLL.SaveProduct(_selectedProduct, out _);
            RecalculateCOGS();
            dgvProduct.Refresh();
            UpdateHeaderStats();

            MessageHelper.ShowInfo($"Đã lưu thành công thông tin món '{_selectedProduct.ProductName}'!", "Thành công");
        }

        private void BtnToggleStatus_Click(object? sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            _productBLL.ToggleProductStatus(_selectedProduct.ProductId);
            UpdateToggleStatusButtonUI(_selectedProduct.Status);

            if (dgvProduct.SelectedRows.Count > 0)
            {
                dgvProduct.SelectedRows[0].Cells["colTrangThai"].Value = _selectedProduct.Status;
            }

            dgvProduct.Refresh();
            UpdateHeaderStats();
        }

        private void BtnAddIngredient_Click(object? sender, EventArgs e)
        {
            if (_selectedProduct == null)
            {
                MessageHelper.ShowWarning("Vui lòng chọn món ăn/đồ uống cần thêm định lượng!", "Thông báo");
                return;
            }

            using (var dlg = new dlgSelectIngredient(_selectedProduct.ProductId))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK && dlg.SelectedRecipeBOM != null)
                {
                    var newItem = dlg.SelectedRecipeBOM;

                    var existing = _currentBOM.FirstOrDefault(b => b.IngredientId == newItem.IngredientId);
                    if (existing != null)
                    {
                        existing.Quantity += newItem.Quantity;
                    }
                    else
                    {
                        _currentBOM.Add(newItem);
                    }

                    _productBLL.SaveBOM(_selectedProduct.ProductId, _currentBOM);
                    LoadBOMForProduct(_selectedProduct.ProductId);
                    MessageHelper.ShowInfo($"Đã thêm nguyên liệu '{newItem.IngredientName}' vào công thức!", "Thành công");
                }
            }
        }

        private void BtnChooseImage_Click(object? sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Tệp hình ảnh (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Tất cả tệp (*.*)|*.*";
                ofd.Title = "Chọn hình ảnh đại diện cho món";

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(ofd.FileName);
                        _selectedProduct.Image = img;
                        _selectedProduct.ImagePath = ofd.FileName;
                        picProductDetail.Image = img;

                        if (dgvProduct.SelectedRows.Count > 0)
                        {
                            dgvProduct.SelectedRows[0].Cells["colHinhAnh"].Value = img;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowError($"Không thể mở hình ảnh: {ex.Message}", "Lỗi");
                    }
                }
            }
        }

        private void BtnExportExcel_Click(object? sender, EventArgs e)
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
                            sw.WriteLine("ProductId,ProductName,CategoryName,Price,CostPrice,ProfitMargin,Status");
                            foreach (var m in _displayedProducts)
                            {
                                sw.WriteLine($"\"{m.ProductId}\",\"{m.ProductName}\",\"{m.CategoryName}\",{m.Price},{m.CostPrice},{m.ProfitMargin},\"{m.Status}\"");
                            }
                        }
                        MessageHelper.ShowInfo($"Đã xuất thành công danh sách {_displayedProducts.Count} món ra file:\n{sfd.FileName}", "Xuất Excel thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowError($"Lỗi khi xuất file: {ex.Message}", "Lỗi");
                    }
                }
            }
        }
        #endregion
    }
}
