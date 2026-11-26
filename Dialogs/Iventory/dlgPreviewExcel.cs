using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class dlgPreviewExcel : Form
    {
        public dlgPreviewExcel(string title, string subtitle, List<Ingredient> ingredients)
        {
            InitializeComponent();

            lblTitle.Text = title;
            lblSubtitle.Text = subtitle;
            lblCount.Text = $"Tổng cộng: {ingredients.Count} nguyên liệu";

            SetupGrid(ingredients);
            btnDong.Click += (s, e) => Close();
        }

        private void SetupGrid(List<Ingredient> ingredients)
        {
            UIHelper.StyleDataGridView(dgvPreview);

            dgvPreview.Columns.Clear();
            dgvPreview.Columns.Add("colMa", "MÃ NL");
            dgvPreview.Columns.Add("colTen", "TÊN NGUYÊN LIỆU");
            dgvPreview.Columns.Add("colNhom", "NHÓM");
            dgvPreview.Columns.Add("colDVT", "ĐƠN VỊ TÍNH");
            dgvPreview.Columns.Add("colTon", "TỒN KHO");
            dgvPreview.Columns.Add("colMin", "TỐI THIỂU");
            dgvPreview.Columns.Add("colGia", "ĐƠN GIÁ NHẬP");
            dgvPreview.Columns.Add("colTrangThai", "TRẠNG THÁI");

            dgvPreview.Columns["colMa"].Width = 85;
            dgvPreview.Columns["colMa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPreview.Columns["colTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPreview.Columns["colTen"].MinimumWidth = 180;

            dgvPreview.Columns["colNhom"].Width = 110;
            dgvPreview.Columns["colDVT"].Width = 90;
            dgvPreview.Columns["colDVT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPreview.Columns["colTon"].Width = 100;
            dgvPreview.Columns["colTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPreview.Columns["colMin"].Width = 95;
            dgvPreview.Columns["colMin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPreview.Columns["colGia"].Width = 115;
            dgvPreview.Columns["colGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPreview.Columns["colTrangThai"].Width = 110;
            dgvPreview.Columns["colTrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (var ing in ingredients)
            {
                dgvPreview.Rows.Add(
                    ing.IngredientId,
                    ing.IngredientName,
                    ing.GroupName,
                    ing.Unit,
                    ing.StockQuantity.ToString("#,##0"),
                    ing.MinStock.ToString("#,##0"),
                    $"{ing.ImportPrice:#,##0} đ",
                    ing.StockStatus
                );
            }
        }
    }
}
