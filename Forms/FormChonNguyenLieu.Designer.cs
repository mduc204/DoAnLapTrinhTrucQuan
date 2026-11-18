namespace DoAnLapTrinhTrucQuan.Forms
{
    partial class FormChonNguyenLieu
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
            this.components = new System.ComponentModel.Container();
            this.pnlCard = new DoAnLapTrinhTrucQuan.RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblNguyenLieu = new System.Windows.Forms.Label();
            this.cboNguyenLieu = new System.Windows.Forms.ComboBox();
            this.lblDinhLuong = new System.Windows.Forms.Label();
            this.numDinhLuong = new System.Windows.Forms.NumericUpDown();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblThanhTienTamTinh = new System.Windows.Forms.Label();
            this.btnHuy = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.btnXacNhan = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDinhLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlCard.BorderRadius = 12;
            this.pnlCard.BorderWidth = 1;
            this.pnlCard.Controls.Add(this.btnXacNhan);
            this.pnlCard.Controls.Add(this.btnHuy);
            this.pnlCard.Controls.Add(this.lblThanhTienTamTinh);
            this.pnlCard.Controls.Add(this.lblDonGia);
            this.pnlCard.Controls.Add(this.lblDVT);
            this.pnlCard.Controls.Add(this.numDinhLuong);
            this.pnlCard.Controls.Add(this.lblDinhLuong);
            this.pnlCard.Controls.Add(this.cboNguyenLieu);
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
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguyenLieu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNguyenLieu.FormattingEnabled = true;
            this.cboNguyenLieu.Location = new System.Drawing.Point(25, 96);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Size = new System.Drawing.Size(418, 25);
            this.cboNguyenLieu.TabIndex = 3;
            // 
            // lblDinhLuong
            // 
            this.lblDinhLuong.AutoSize = true;
            this.lblDinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDinhLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblDinhLuong.Location = new System.Drawing.Point(22, 138);
            this.lblDinhLuong.Name = "lblDinhLuong";
            this.lblDinhLuong.Size = new System.Drawing.Size(117, 15);
            this.lblDinhLuong.TabIndex = 4;
            this.lblDinhLuong.Text = "Định lượng (cho 1 ly)";
            // 
            // numDinhLuong
            // 
            this.numDinhLuong.DecimalPlaces = 1;
            this.numDinhLuong.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.numDinhLuong.Location = new System.Drawing.Point(25, 160);
            this.numDinhLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDinhLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDinhLuong.Name = "numDinhLuong";
            this.numDinhLuong.Size = new System.Drawing.Size(130, 26);
            this.numDinhLuong.TabIndex = 5;
            this.numDinhLuong.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDVT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblDVT.Location = new System.Drawing.Point(165, 165);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(59, 17);
            this.lblDVT.TabIndex = 6;
            this.lblDVT.Text = "gram (g)";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblDonGia.Location = new System.Drawing.Point(22, 205);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(126, 15);
            this.lblDonGia.TabIndex = 7;
            this.lblDonGia.Text = "Đơn giá quy đổi vốn: 0";
            // 
            // lblThanhTienTamTinh
            // 
            this.lblThanhTienTamTinh.AutoSize = true;
            this.lblThanhTienTamTinh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblThanhTienTamTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(106)))), ((int)(((byte)(43)))));
            this.lblThanhTienTamTinh.Location = new System.Drawing.Point(22, 230);
            this.lblThanhTienTamTinh.Name = "lblThanhTienTamTinh";
            this.lblThanhTienTamTinh.Size = new System.Drawing.Size(217, 19);
            this.lblThanhTienTamTinh.TabIndex = 8;
            this.lblThanhTienTamTinh.Text = "Thành tiền giá vốn dự kiến: 0 đ";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.BorderWidth = 1;
            this.btnHuy.CustomIcon = null;
            this.btnHuy.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.btnHuy.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnHuy.IsOutlined = true;
            this.btnHuy.Location = new System.Drawing.Point(225, 275);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NormalBackColor = System.Drawing.Color.White;
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.BorderWidth = 0;
            this.btnXacNhan.CustomIcon = null;
            this.btnXacNhan.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(50)))), ((int)(((byte)(34)))));
            this.btnXacNhan.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(63)))), ((int)(((byte)(43)))));
            this.btnXacNhan.IsOutlined = false;
            this.btnXacNhan.Location = new System.Drawing.Point(333, 275);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnXacNhan.Size = new System.Drawing.Size(110, 36);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "+ Thêm vào";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // FormChonNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(500, 370);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChonNguyenLieu";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm định lượng nguyên liệu pha chế";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDinhLuong)).EndInit();
            this.ResumeLayout(false);

        }

        private DoAnLapTrinhTrucQuan.RoundedPanel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblNguyenLieu;
        private System.Windows.Forms.ComboBox cboNguyenLieu;
        private System.Windows.Forms.Label lblDinhLuong;
        private System.Windows.Forms.NumericUpDown numDinhLuong;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblThanhTienTamTinh;
        private DoAnLapTrinhTrucQuan.RoundedButton btnHuy;
        private DoAnLapTrinhTrucQuan.RoundedButton btnXacNhan;
    }
}
