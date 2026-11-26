using System;
using System.Drawing;
using System.Windows.Forms;
using DoAnLapTrinhTrucQuan.Helpers;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Forms
{
    public partial class dlgStockVoucher : Form
    {
        private readonly Ingredient _ingredient;
        private readonly bool _isImport;

        public decimal SoLuongNhapXuat => nudSoLuong.Value;
        public decimal DonGiaNhap => nudDonGia.Value;
        public string LyDoXuat => cboLyDoXuat.SelectedItem?.ToString() ?? "Xuất kho";
        public string NguoiThucHien => txtNguoiThucHien.Text.Trim();
        public string GhiChu => txtGhiChu.Text.Trim();
        public string NhaCungCap => txtNhaCungCap.Text.Trim();

        public dlgStockVoucher(Ingredient ingredient, bool isImport, string currentUser = "Nguyễn Văn Hưng")
        {
            InitializeComponent();
            _ingredient = ingredient;
            _isImport = isImport;

            Text = isImport ? "Phiếu nhập kho" : "Phiếu xuất kho";
            lblHeaderTitle.Text = isImport ? "📦 PHIẾU NHẬP KHO" : "📤 PHIẾU XUẤT KHO";
            lblHeaderSub.Text = $"[{ingredient.IngredientId}] {ingredient.IngredientName}";
            lblThongTinTon.Text = $"Tồn kho hiện tại: {ingredient.StockQuantity:N0} {ingredient.Unit}";
            lblDVT.Text = ingredient.Unit;

            txtNguoiThucHien.Text = string.IsNullOrWhiteSpace(currentUser) ? "Nguyễn Văn Hưng" : currentUser;

            if (isImport)
            {
                nudDonGia.Value = ingredient.ImportPrice > 0 ? ingredient.ImportPrice : 1000;
                btnXacNhan.Text = "Xác nhận nhập";
                btnXacNhan.BackColor = Color.FromArgb(85, 55, 34);
            }
            else
            {
                if (cboLyDoXuat.Items.Count > 0)
                {
                    cboLyDoXuat.SelectedIndex = 0;
                }

                nudSoLuong.Maximum = Math.Max(1000000, ingredient.StockQuantity);
                nudSoLuong.Value = Math.Min(ingredient.StockQuantity > 0 ? 1 : 0, ingredient.StockQuantity);

                btnXacNhan.Text = "Xác nhận xuất";
                btnXacNhan.BackColor = Color.FromArgb(180, 50, 40);
            }

            btnXacNhan.Click += BtnXacNhan_Click;
            CapNhatBoCucGiaoDien();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CapNhatBoCucGiaoDien();
        }

        private void CapNhatBoCucGiaoDien()
        {
            pnlBody.SuspendLayout();

            int contentWidth = pnlBody.ClientSize.Width > 100 ? pnlBody.ClientSize.Width - 48 : 416;

            // 1. Thẻ tồn kho hiện tại
            lblThongTinTon.Location = new Point(24, 14);
            lblThongTinTon.Size = new Size(contentWidth, 38);

            // 2. Số lượng nhập/xuất
            lblSoLuong.Location = new Point(24, lblThongTinTon.Bottom + 14);
            nudSoLuong.Location = new Point(24, lblSoLuong.Bottom + 6);
            nudSoLuong.Size = new Size(260, 28);
            lblDVT.Location = new Point(nudSoLuong.Right + 12, nudSoLuong.Top + (nudSoLuong.Height - lblDVT.Height) / 2);

            int currentY = nudSoLuong.Bottom + 16;

            if (_isImport)
            {
                pnlImport.Visible = true;
                pnlExport.Visible = false;

                lblDonGia.Location = new Point(0, 0);
                nudDonGia.Location = new Point(0, lblDonGia.Bottom + 6);
                nudDonGia.Size = new Size(contentWidth, 28);

                lblNhaCungCap.Location = new Point(0, nudDonGia.Bottom + 12);
                txtNhaCungCap.Location = new Point(0, lblNhaCungCap.Bottom + 6);
                txtNhaCungCap.Size = new Size(contentWidth, 28);

                pnlImport.Location = new Point(24, currentY);
                pnlImport.Size = new Size(contentWidth, txtNhaCungCap.Bottom + 4);

                currentY = pnlImport.Bottom + 14;
            }
            else
            {
                pnlImport.Visible = false;
                pnlExport.Visible = true;

                lblLyDo.Location = new Point(0, 0);
                cboLyDoXuat.Location = new Point(0, lblLyDo.Bottom + 6);
                cboLyDoXuat.Size = new Size(contentWidth, 28);

                pnlExport.Location = new Point(24, currentY);
                pnlExport.Size = new Size(contentWidth, cboLyDoXuat.Bottom + 4);

                currentY = pnlExport.Bottom + 14;
            }

            // 3. Người thực hiện
            lblNguoiThucHien.Location = new Point(24, currentY);
            txtNguoiThucHien.Location = new Point(24, lblNguoiThucHien.Bottom + 6);
            txtNguoiThucHien.Size = new Size(contentWidth, 28);

            currentY = txtNguoiThucHien.Bottom + 14;

            // 4. Ghi chú
            lblGhiChu.Location = new Point(24, currentY);
            txtGhiChu.Location = new Point(24, lblGhiChu.Bottom + 6);
            txtGhiChu.Size = new Size(contentWidth, 68);

            currentY = txtGhiChu.Bottom + 18;

            pnlBody.ResumeLayout(true);

            // Điều chỉnh chiều cao form vừa vặn, không bị co giật hay tràn khung
            int totalFormHeight = pnlHeader.Height + currentY + pnlFooter.Height + 10;
            ClientSize = new Size(480, Math.Max(_isImport ? 570 : 510, totalFormHeight));
        }

        private void BtnXacNhan_Click(object? sender, EventArgs e)
        {
            if (nudSoLuong.Value <= 0)
            {
                MessageHelper.ShowWarning("Vui lòng nhập số lượng lớn hơn 0!", "Thông báo");
                nudSoLuong.Focus();
                return;
            }

            if (!_isImport)
            {
                if (nudSoLuong.Value > _ingredient.StockQuantity)
                {
                    var result = MessageBox.Show(
                        $"Số lượng xuất ({nudSoLuong.Value:N0} {_ingredient.Unit}) lớn hơn lượng tồn hiện tại ({_ingredient.StockQuantity:N0} {_ingredient.Unit}).\nBạn có chắc chắn muốn xuất âm / điều chỉnh tồn kho không?",
                        "Cảnh báo xuất kho",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        nudSoLuong.Focus();
                        return;
                    }
                }

                if (cboLyDoXuat.SelectedIndex < 0)
                {
                    MessageHelper.ShowWarning("Vui lòng chọn lý do xuất kho!", "Thông báo");
                    cboLyDoXuat.Focus();
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtNguoiThucHien.Text))
            {
                MessageHelper.ShowWarning("Vui lòng nhập tên người thực hiện!", "Thông báo");
                txtNguoiThucHien.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
