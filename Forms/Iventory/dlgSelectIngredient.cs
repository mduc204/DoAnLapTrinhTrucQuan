using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Dialogs
{
    /// <summary>
    /// Dialog Chọn nguyên liệu và định lượng cho món (dlgSelectIngredient)
    /// </summary>
    public partial class dlgSelectIngredient : Form
    {
        public RecipeBOM? SelectedRecipeBOM { get; private set; }
        public DinhLuongBOM? KetQuaDinhLuong => SelectedRecipeBOM != null ? new DinhLuongBOM
        {
            ProductId = SelectedRecipeBOM.ProductId,
            IngredientId = SelectedRecipeBOM.IngredientId,
            IngredientName = SelectedRecipeBOM.IngredientName,
            WarehouseLocation = SelectedRecipeBOM.WarehouseLocation,
            Quantity = SelectedRecipeBOM.Quantity,
            Unit = SelectedRecipeBOM.Unit,
            UnitPrice = SelectedRecipeBOM.UnitPrice
        } : null;

        private readonly string _productId;
        private List<Ingredient> _ingredients;

        public dlgSelectIngredient(string productId = "")
        {
            InitializeComponent();
            _productId = productId;
            _ingredients = MockDataService.Instance.DanhSachNguyenLieu.Cast<Ingredient>().ToList();

            LoadIngredients();
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            cboIngredient.SelectedIndexChanged += CboIngredient_SelectedIndexChanged;
            nudQuantity.ValueChanged += (s, e) => UpdateEstimatedCost();
        }

        private void LoadIngredients()
        {
            cboIngredient.Items.Clear();
            foreach (var nl in _ingredients)
            {
                cboIngredient.Items.Add($"{nl.IngredientId} - {nl.IngredientName} ({nl.WarehouseLocation})");
            }
            if (cboIngredient.Items.Count > 0)
            {
                cboIngredient.SelectedIndex = 0;
            }
        }

        private void CboIngredient_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboIngredient.SelectedIndex < 0 || cboIngredient.SelectedIndex >= _ingredients.Count) return;
            var nl = _ingredients[cboIngredient.SelectedIndex];
            lblDVT.Text = nl.Unit;
            lblDonGia.Text = $"Đơn giá quy đổi vốn: {FormatHelper.FormatVND(nl.ImportPrice)} / {nl.Unit}";
            UpdateEstimatedCost();
        }

        private void UpdateEstimatedCost()
        {
            if (cboIngredient.SelectedIndex < 0 || cboIngredient.SelectedIndex >= _ingredients.Count) return;
            var nl = _ingredients[cboIngredient.SelectedIndex];
            decimal cost = Math.Round(nudQuantity.Value * nl.ImportPrice, 0);
            lblThanhTienTamTinh.Text = $"Thành tiền giá vốn dự kiến: {FormatHelper.FormatVND(cost)}";
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            if (cboIngredient.SelectedIndex < 0 || cboIngredient.SelectedIndex >= _ingredients.Count)
            {
                MessageHelper.ShowWarning("Vui lòng chọn nguyên liệu!", "Thông báo");
                return;
            }

            var nl = _ingredients[cboIngredient.SelectedIndex];
            SelectedRecipeBOM = new RecipeBOM
            {
                ProductId = _productId,
                IngredientId = nl.IngredientId,
                IngredientName = nl.IngredientName,
                WarehouseLocation = nl.WarehouseLocation,
                Quantity = nudQuantity.Value,
                Unit = nl.Unit,
                UnitPrice = nl.ImportPrice
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
