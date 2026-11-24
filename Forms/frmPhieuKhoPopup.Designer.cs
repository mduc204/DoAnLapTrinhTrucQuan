namespace DoAnLapTrinhTrucQuan.Forms
{
    partial class frmPhieuKhoPopup
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            lblHeaderSub = new System.Windows.Forms.Label();
            lblHeaderTitle = new System.Windows.Forms.Label();
            pnlFooter = new System.Windows.Forms.Panel();
            btnXacNhan = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            pnlBody = new System.Windows.Forms.Panel();
            lblThongTinTon = new System.Windows.Forms.Label();
            lblSoLuong = new System.Windows.Forms.Label();
            nudSoLuong = new System.Windows.Forms.NumericUpDown();
            lblDVT = new System.Windows.Forms.Label();
            pnlImport = new System.Windows.Forms.Panel();
            lblDonGia = new System.Windows.Forms.Label();
            nudDonGia = new System.Windows.Forms.NumericUpDown();
            lblNhaCungCap = new System.Windows.Forms.Label();
            txtNhaCungCap = new System.Windows.Forms.TextBox();
            pnlExport = new System.Windows.Forms.Panel();
            lblLyDo = new System.Windows.Forms.Label();
            cboLyDoXuat = new System.Windows.Forms.ComboBox();
            lblNguoiThucHien = new System.Windows.Forms.Label();
            txtNguoiThucHien = new System.Windows.Forms.TextBox();
            lblGhiChu = new System.Windows.Forms.Label();
            txtGhiChu = new System.Windows.Forms.TextBox();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            pnlExport.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(85, 55, 34);
            pnlHeader.Controls.Add(lblHeaderSub);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new System.Windows.Forms.Padding(20, 12, 20, 10);
            pnlHeader.Size = new System.Drawing.Size(464, 72);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.Dock = System.Windows.Forms.DockStyle.Top;
            lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(238, 193, 164);
            lblHeaderSub.Location = new System.Drawing.Point(20, 38);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new System.Drawing.Size(424, 24);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "[NL001] Cà phê hạt Cầu Đất Arabica";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            lblHeaderTitle.Location = new System.Drawing.Point(20, 12);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new System.Drawing.Size(424, 26);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "📦 PHIẾU NHẬP KHO";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.FromArgb(250, 247, 245);
            pnlFooter.Controls.Add(btnXacNhan);
            pnlFooter.Controls.Add(btnHuy);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(0, 480);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new System.Windows.Forms.Padding(0, 12, 20, 12);
            pnlFooter.Size = new System.Drawing.Size(464, 62);
            pnlFooter.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnXacNhan.BackColor = System.Drawing.Color.FromArgb(85, 55, 34);
            btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            btnXacNhan.FlatAppearance.BorderSize = 0;
            btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnXacNhan.ForeColor = System.Drawing.Color.White;
            btnXacNhan.Location = new System.Drawing.Point(294, 12);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new System.Drawing.Size(150, 38);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnHuy.BackColor = System.Drawing.Color.White;
            btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(217, 195, 176);
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnHuy.ForeColor = System.Drawing.Color.FromArgb(85, 55, 34);
            btnHuy.Location = new System.Drawing.Point(184, 12);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(100, 38);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // pnlBody
            // 
            pnlBody.AutoScroll = true;
            pnlBody.BackColor = System.Drawing.Color.White;
            pnlBody.Controls.Add(lblThongTinTon);
            pnlBody.Controls.Add(lblSoLuong);
            pnlBody.Controls.Add(nudSoLuong);
            pnlBody.Controls.Add(lblDVT);
            pnlBody.Controls.Add(pnlImport);
            pnlBody.Controls.Add(pnlExport);
            pnlBody.Controls.Add(lblNguoiThucHien);
            pnlBody.Controls.Add(txtNguoiThucHien);
            pnlBody.Controls.Add(lblGhiChu);
            pnlBody.Controls.Add(txtGhiChu);
            pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBody.Location = new System.Drawing.Point(0, 72);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new System.Windows.Forms.Padding(24, 14, 24, 10);
            pnlBody.Size = new System.Drawing.Size(464, 408);
            pnlBody.TabIndex = 1;
            // 
            // lblThongTinTon
            // 
            lblThongTinTon.BackColor = System.Drawing.Color.FromArgb(250, 247, 245);
            lblThongTinTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblThongTinTon.Dock = System.Windows.Forms.DockStyle.Top;
            lblThongTinTon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblThongTinTon.ForeColor = System.Drawing.Color.FromArgb(85, 55, 34);
            lblThongTinTon.Location = new System.Drawing.Point(24, 14);
            lblThongTinTon.Name = "lblThongTinTon";
            lblThongTinTon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            lblThongTinTon.Size = new System.Drawing.Size(416, 36);
            lblThongTinTon.TabIndex = 0;
            lblThongTinTon.Text = "Tồn kho hiện tại: 1.200 gram (g)";
            lblThongTinTon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(44, 24, 16);
            lblSoLuong.Location = new System.Drawing.Point(24, 60);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new System.Drawing.Size(74, 17);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng *";
            // 
            // nudSoLuong
            // 
            nudSoLuong.DecimalPlaces = 0;
            nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            nudSoLuong.Location = new System.Drawing.Point(24, 80);
            nudSoLuong.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new System.Drawing.Size(260, 27);
            nudSoLuong.TabIndex = 2;
            nudSoLuong.ThousandsSeparator = true;
            nudSoLuong.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblDVT.ForeColor = System.Drawing.Color.FromArgb(125, 110, 101);
            lblDVT.Location = new System.Drawing.Point(292, 85);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new System.Drawing.Size(59, 19);
            lblDVT.TabIndex = 3;
            lblDVT.Text = "gram (g)";
            // 
            // pnlImport
            // 
            pnlImport.Controls.Add(lblDonGia);
            pnlImport.Controls.Add(nudDonGia);
            pnlImport.Controls.Add(lblNhaCungCap);
            pnlImport.Controls.Add(txtNhaCungCap);
            pnlImport.Location = new System.Drawing.Point(24, 115);
            pnlImport.Name = "pnlImport";
            pnlImport.Size = new System.Drawing.Size(416, 115);
            pnlImport.TabIndex = 4;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblDonGia.ForeColor = System.Drawing.Color.FromArgb(44, 24, 16);
            lblDonGia.Location = new System.Drawing.Point(0, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new System.Drawing.Size(126, 17);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Đơn giá nhập (VNĐ)";
            // 
            // nudDonGia
            // 
            nudDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            nudDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudDonGia.Location = new System.Drawing.Point(0, 20);
            nudDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new System.Drawing.Size(416, 25);
            nudDonGia.TabIndex = 1;
            nudDonGia.ThousandsSeparator = true;
            nudDonGia.Value = new decimal(new int[] { 320, 0, 0, 0 });
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.AutoSize = true;
            lblNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(44, 24, 16);
            lblNhaCungCap.Location = new System.Drawing.Point(0, 56);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new System.Drawing.Size(161, 17);
            lblNhaCungCap.TabIndex = 2;
            lblNhaCungCap.Text = "Nhà cung cấp / Nguồn gốc";
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNhaCungCap.Location = new System.Drawing.Point(0, 76);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.Size = new System.Drawing.Size(416, 25);
            txtNhaCungCap.TabIndex = 3;
            txtNhaCungCap.Text = "NCC Cầu Đất Farm";
            // 
            // pnlExport
            // 
            pnlExport.Controls.Add(lblLyDo);
            pnlExport.Controls.Add(cboLyDoXuat);
            pnlExport.Location = new System.Drawing.Point(24, 115);
            pnlExport.Name = "pnlExport";
            pnlExport.Size = new System.Drawing.Size(416, 60);
            pnlExport.TabIndex = 5;
            pnlExport.Visible = false;
            // 
            // lblLyDo
            // 
            lblLyDo.AutoSize = true;
            lblLyDo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblLyDo.ForeColor = System.Drawing.Color.FromArgb(44, 24, 16);
            lblLyDo.Location = new System.Drawing.Point(0, 0);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new System.Drawing.Size(183, 17);
            lblLyDo.TabIndex = 0;
            lblLyDo.Text = "Lý do xuất kho / xuất hủy *";
            // 
            // cboLyDoXuat
            // 
            cboLyDoXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLyDoXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboLyDoXuat.FormattingEnabled = true;
            cboLyDoXuat.Items.AddRange(new object[] {
            "Xuất hủy (ẩm mốc, hư hỏng)",
            "Xuất quầy pha chế",
            "Hao hụt kiểm kê",
            "Hết hạn sử dụng",
            "Xuất điều chuyển kho",
            "Khác"});
            cboLyDoXuat.Location = new System.Drawing.Point(0, 20);
            cboLyDoXuat.Name = "cboLyDoXuat";
            cboLyDoXuat.Size = new System.Drawing.Size(416, 25);
            cboLyDoXuat.TabIndex = 1;
            // 
            // lblNguoiThucHien
            // 
            lblNguoiThucHien.AutoSize = true;
            lblNguoiThucHien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblNguoiThucHien.ForeColor = System.Drawing.Color.FromArgb(44, 24, 16);
            lblNguoiThucHien.Location = new System.Drawing.Point(24, 238);
            lblNguoiThucHien.Name = "lblNguoiThucHien";
            lblNguoiThucHien.Size = new System.Drawing.Size(117, 17);
            lblNguoiThucHien.TabIndex = 6;
            lblNguoiThucHien.Text = "Người thực hiện *";
            // 
            // txtNguoiThucHien
            // 
            txtNguoiThucHien.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNguoiThucHien.Location = new System.Drawing.Point(24, 258);
            txtNguoiThucHien.Name = "txtNguoiThucHien";
            txtNguoiThucHien.Size = new System.Drawing.Size(416, 25);
            txtNguoiThucHien.TabIndex = 7;
            txtNguoiThucHien.Text = "Nguyễn Văn Hưng";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(44, 24, 16);
            lblGhiChu.Location = new System.Drawing.Point(24, 292);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(54, 17);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtGhiChu.Location = new System.Drawing.Point(24, 312);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtGhiChu.Size = new System.Drawing.Size(416, 68);
            txtGhiChu.TabIndex = 9;
            // 
            // frmPhieuKhoPopup
            // 
            AcceptButton = btnXacNhan;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnHuy;
            ClientSize = new System.Drawing.Size(480, 560);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPhieuKhoPopup";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Phiếu kho";
            pnlHeader.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            pnlImport.ResumeLayout(false);
            pnlImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            pnlExport.ResumeLayout(false);
            pnlExport.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblThongTinTon;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.Panel pnlExport;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.ComboBox cboLyDoXuat;
        private System.Windows.Forms.Label lblNguoiThucHien;
        private System.Windows.Forms.TextBox txtNguoiThucHien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}
