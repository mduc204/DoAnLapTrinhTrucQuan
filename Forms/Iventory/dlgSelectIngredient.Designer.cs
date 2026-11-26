using DoAnLapTrinhTrucQuan.Helpers;

namespace DoAnLapTrinhTrucQuan.Dialogs
{
    partial class dlgSelectIngredient
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCard = new DoAnLapTrinhTrucQuan.Helpers.RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblNguyenLieu = new System.Windows.Forms.Label();
            this.cboIngredient = new System.Windows.Forms.ComboBox();
            this.lblDinhLuong = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblThanhTienTamTinh = new System.Windows.Forms.Label();
            this.btnCancel = new DoAnLapTrinhTrucQuan.Helpers.RoundedButton();
            this.btnConfirm = new DoAnLapTrinhTrucQuan.Helpers.RoundedButton();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlCard.BorderRadius = 12;
            this.pnlCard.BorderWidth = 1;
            this.pnlCard.Controls.Add(this.btnConfirm);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.Controls.Add(this.lblThanhTienTamTinh);
            this.pnlCard.Controls.Add(this.lblDonGia);
            this.pnlCard.Controls.Add(this.lblDVT);
            this.pnlCard.Controls.Add(this.nudQuantity);
            this.pnlCard.Controls.Add(this.lblDinhLuong);
            this.pnlCard.Controls.Add(this.cboIngredient);
            this.pnlCard.Controls.Add(this.lblNguyenLieu);
            this.pnlCard.Controls.Add(this.lblSubTitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(16, 16);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlCard.Size = new System.Drawing.Size(468, 338);
            this.pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm nguyên liệu định lượng";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblSubTitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(327, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Chọn từ danh mục kho nguyên vật liệu và nhập định mức 1 ly";
            // 
            // lblNguyenLieu
            // 
            this.lblNguyenLieu.AutoSize = true;
            this.lblNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNguyenLieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblNguyenLieu.Location = new System.Drawing.Point(22, 75);
            this.lblNguyenLieu.Name = "lblNguyenLieu";
            this.lblNguyenLieu.Size = new System.Drawing.Size(127, 15);
            this.lblNguyenLieu.TabIndex = 2;
            this.lblNguyenLieu.Text = "Nguyên vật liệu kho (*)";
            // 
            // cboIngredient
            // 
            this.cboIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngredient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboIngredient.FormattingEnabled = true;
            this.cboIngredient.Location = new System.Drawing.Point(25, 96);
            this.cboIngredient.Name = "cboIngredient";
            this.cboIngredient.Size = new System.Drawing.Size(418, 25);
            this.cboIngredient.TabIndex = 3;
            // 
            // lblDinhLuong
            // 
            this.lblDinhLuong.AutoSize = true;
            this.lblDinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDinhLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblDinhLuong.Location = new System.Drawing.Point(22, 138);
            this.lblDinhLuong.Name = "lblDinhLuong";
            this.lblDinhLuong.Size = new System.Drawing.Size(137, 15);
            this.lblDinhLuong.TabIndex = 4;
            this.lblDinhLuong.Text = "Định mức cho 1 ly (*):";
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 1;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nudQuantity.Location = new System.Drawing.Point(25, 158);
            this.nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(150, 25);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblDVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblDVT.Location = new System.Drawing.Point(185, 163);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(53, 15);
            this.lblDVT.TabIndex = 6;
            this.lblDVT.Text = "gram (g)";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblDonGia.Location = new System.Drawing.Point(22, 196);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(193, 15);
            this.lblDonGia.TabIndex = 7;
            this.lblDonGia.Text = "Đơn giá quy đổi vốn: 250 đ / gram";
            // 
            // lblThanhTienTamTinh
            // 
            this.lblThanhTienTamTinh.AutoSize = true;
            this.lblThanhTienTamTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThanhTienTamTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.lblThanhTienTamTinh.Location = new System.Drawing.Point(22, 222);
            this.lblThanhTienTamTinh.Name = "lblThanhTienTamTinh";
            this.lblThanhTienTamTinh.Size = new System.Drawing.Size(248, 19);
            this.lblThanhTienTamTinh.TabIndex = 8;
            this.lblThanhTienTamTinh.Text = "Thành tiền giá vốn dự kiến: 5.000 đ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(180)))));
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderWidth = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.btnCancel.Location = new System.Drawing.Point(228, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnConfirm.BorderRadius = 6;
            this.btnConfirm.BorderWidth = 1;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(63)))), ((int)(((byte)(43)))));
            this.btnConfirm.Location = new System.Drawing.Point(333, 275);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 36);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "✓ Thêm vào";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // dlgSelectIngredient
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 370);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgSelectIngredient";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn nguyên liệu định lượng";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        private RoundedPanel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblNguyenLieu;
        private System.Windows.Forms.ComboBox cboIngredient;
        private System.Windows.Forms.Label lblDinhLuong;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblThanhTienTamTinh;
        private RoundedButton btnCancel;
        private RoundedButton btnConfirm;
    }
}
