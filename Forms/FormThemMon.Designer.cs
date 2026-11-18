namespace DoAnLapTrinhTrucQuan.Forms
{
    partial class FormThemMon
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
            this.pnlCard = new DoAnLapTrinhTrucQuan.RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.pnlAnhBorder = new System.Windows.Forms.Panel();
            this.picAnhMon = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.btnTaoMaTuDong = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.lblGhiChuMa = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.chkCoDinhLuong = new System.Windows.Forms.CheckBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.btnHuy = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.btnLuu = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.pnlCard.SuspendLayout();
            this.pnlAnhBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlCard.BorderRadius = 12;
            this.pnlCard.BorderWidth = 1;
            this.pnlCard.Controls.Add(this.btnLuu);
            this.pnlCard.Controls.Add(this.btnHuy);
            this.pnlCard.Controls.Add(this.pnlDivider2);
            this.pnlCard.Controls.Add(this.txtMoTa);
            this.pnlCard.Controls.Add(this.lblMoTa);
            this.pnlCard.Controls.Add(this.chkCoDinhLuong);
            this.pnlCard.Controls.Add(this.cboTrangThai);
            this.pnlCard.Controls.Add(this.lblTrangThai);
            this.pnlCard.Controls.Add(this.numGiaBan);
            this.pnlCard.Controls.Add(this.lblGiaBan);
            this.pnlCard.Controls.Add(this.txtTenMon);
            this.pnlCard.Controls.Add(this.lblTenMon);
            this.pnlCard.Controls.Add(this.lblGhiChuMa);
            this.pnlCard.Controls.Add(this.btnTaoMaTuDong);
            this.pnlCard.Controls.Add(this.txtMaMon);
            this.pnlCard.Controls.Add(this.lblMaMon);
            this.pnlCard.Controls.Add(this.cboDanhMuc);
            this.pnlCard.Controls.Add(this.lblDanhMuc);
            this.pnlCard.Controls.Add(this.btnChonAnh);
            this.pnlCard.Controls.Add(this.pnlAnhBorder);
            this.pnlCard.Controls.Add(this.pnlDivider1);
            this.pnlCard.Controls.Add(this.lblSubTitle);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(16, 16);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlCard.Size = new System.Drawing.Size(588, 542);
            this.pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🍽️ Thêm món mới vào thực đơn";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.8F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblSubTitle.Location = new System.Drawing.Point(22, 43);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(465, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Chọn loại món để tự động sinh mã, tùy chỉnh thông tin, giá bán và công thức BOM";
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlDivider1.Location = new System.Drawing.Point(20, 66);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(548, 1);
            this.pnlDivider1.TabIndex = 2;
            // 
            // pnlAnhBorder
            // 
            this.pnlAnhBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlAnhBorder.Controls.Add(this.picAnhMon);
            this.pnlAnhBorder.Location = new System.Drawing.Point(20, 78);
            this.pnlAnhBorder.Name = "pnlAnhBorder";
            this.pnlAnhBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlAnhBorder.Size = new System.Drawing.Size(112, 112);
            this.pnlAnhBorder.TabIndex = 3;
            // 
            // picAnhMon
            // 
            this.picAnhMon.BackColor = System.Drawing.Color.White;
            this.picAnhMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnhMon.Location = new System.Drawing.Point(1, 1);
            this.picAnhMon.Name = "picAnhMon";
            this.picAnhMon.Size = new System.Drawing.Size(110, 110);
            this.picAnhMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhMon.TabIndex = 0;
            this.picAnhMon.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
            this.btnChonAnh.BorderRadius = 6;
            this.btnChonAnh.BorderWidth = 1;
            this.btnChonAnh.CustomIcon = null;
            this.btnChonAnh.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btnChonAnh.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnChonAnh.IsOutlined = true;
            this.btnChonAnh.Location = new System.Drawing.Point(20, 196);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.NormalBackColor = System.Drawing.Color.White;
            this.btnChonAnh.Size = new System.Drawing.Size(112, 28);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "📷 Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblDanhMuc.Location = new System.Drawing.Point(148, 76);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(155, 15);
            this.lblDanhMuc.TabIndex = 5;
            this.lblDanhMuc.Text = "LOẠI MÓN / DANH MỤC (*)";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cboDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(148, 95);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(420, 25);
            this.cboDanhMuc.TabIndex = 6;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblMaMon.Location = new System.Drawing.Point(148, 128);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(78, 15);
            this.lblMaMon.TabIndex = 7;
            this.lblMaMon.Text = "MÃ MÓN (*)";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtMaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.txtMaMon.Location = new System.Drawing.Point(148, 147);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(316, 24);
            this.txtMaMon.TabIndex = 8;
            // 
            // btnTaoMaTuDong
            // 
            this.btnTaoMaTuDong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
            this.btnTaoMaTuDong.BorderRadius = 6;
            this.btnTaoMaTuDong.BorderWidth = 1;
            this.btnTaoMaTuDong.CustomIcon = null;
            this.btnTaoMaTuDong.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.btnTaoMaTuDong.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnTaoMaTuDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btnTaoMaTuDong.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnTaoMaTuDong.IsOutlined = true;
            this.btnTaoMaTuDong.Location = new System.Drawing.Point(470, 146);
            this.btnTaoMaTuDong.Name = "btnTaoMaTuDong";
            this.btnTaoMaTuDong.NormalBackColor = System.Drawing.Color.White;
            this.btnTaoMaTuDong.Size = new System.Drawing.Size(98, 26);
            this.btnTaoMaTuDong.TabIndex = 9;
            this.btnTaoMaTuDong.Text = "🔄 Sinh mã";
            this.btnTaoMaTuDong.UseVisualStyleBackColor = true;
            // 
            // lblGhiChuMa
            // 
            this.lblGhiChuMa.AutoSize = true;
            this.lblGhiChuMa.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGhiChuMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(125)))), ((int)(((byte)(115)))));
            this.lblGhiChuMa.Location = new System.Drawing.Point(148, 178);
            this.lblGhiChuMa.Name = "lblGhiChuMa";
            this.lblGhiChuMa.Size = new System.Drawing.Size(419, 13);
            this.lblGhiChuMa.TabIndex = 10;
            this.lblGhiChuMa.Text = "💡 Tiền tố chuẩn: CF (Cà phê), PM (Pha máy), TE (Trà trái cây), TS (Trà sữa), DX (Đá xay), BK (Bánh)";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblTenMon.Location = new System.Drawing.Point(20, 230);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(80, 15);
            this.lblTenMon.TabIndex = 11;
            this.lblTenMon.Text = "TÊN MÓN (*)";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.txtTenMon.Location = new System.Drawing.Point(20, 248);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(548, 25);
            this.txtTenMon.TabIndex = 12;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblGiaBan.Location = new System.Drawing.Point(20, 283);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(161, 15);
            this.lblGiaBan.TabIndex = 13;
            this.lblGiaBan.Text = "GIÁ BÁN NIÊM YẾT (VNĐ) (*)";
            // 
            // numGiaBan
            // 
            this.numGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.numGiaBan.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numGiaBan.Location = new System.Drawing.Point(20, 302);
            this.numGiaBan.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(265, 25);
            this.numGiaBan.TabIndex = 14;
            this.numGiaBan.ThousandsSeparator = true;
            this.numGiaBan.Value = new decimal(new int[] { 35000, 0, 0, 0 });
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblTrangThai.Location = new System.Drawing.Point(303, 283);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(149, 15);
            this.lblTrangThai.TabIndex = 15;
            this.lblTrangThai.Text = "TRẠNG THÁI KINH DOANH";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(303, 302);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(265, 25);
            this.cboTrangThai.TabIndex = 16;
            // 
            // chkCoDinhLuong
            // 
            this.chkCoDinhLuong.AutoSize = true;
            this.chkCoDinhLuong.Checked = true;
            this.chkCoDinhLuong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoDinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkCoDinhLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.chkCoDinhLuong.Location = new System.Drawing.Point(20, 338);
            this.chkCoDinhLuong.Name = "chkCoDinhLuong";
            this.chkCoDinhLuong.Size = new System.Drawing.Size(460, 19);
            this.chkCoDinhLuong.TabIndex = 17;
            this.chkCoDinhLuong.Text = "✔ Thiết lập công thức pha chế / trừ kho nguyên liệu (BOM) cho món này";
            this.chkCoDinhLuong.UseVisualStyleBackColor = true;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblMoTa.Location = new System.Drawing.Point(20, 368);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(206, 15);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "MÔ TẢ HƯƠNG VỊ / GHI CHÚ BARISTA";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.txtMoTa.Location = new System.Drawing.Point(20, 387);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(548, 62);
            this.txtMoTa.TabIndex = 19;
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlDivider2.Location = new System.Drawing.Point(20, 465);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(548, 1);
            this.pnlDivider2.TabIndex = 20;
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.BorderWidth = 1;
            this.btnHuy.CustomIcon = null;
            this.btnHuy.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(219)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.btnHuy.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnHuy.IsOutlined = true;
            this.btnHuy.Location = new System.Drawing.Point(303, 480);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.NormalBackColor = System.Drawing.Color.White;
            this.btnHuy.Size = new System.Drawing.Size(115, 36);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "✕ Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.BorderWidth = 0;
            this.btnLuu.CustomIcon = null;
            this.btnLuu.DownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(50)))), ((int)(((byte)(34)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(63)))), ((int)(((byte)(43)))));
            this.btnLuu.IsOutlined = false;
            this.btnLuu.Location = new System.Drawing.Point(428, 480);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnLuu.Size = new System.Drawing.Size(140, 36);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "💾 Thêm món";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // FormThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(620, 574);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemMon";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LTTQ Cafe - Thêm món mới vào thực đơn";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlAnhBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DoAnLapTrinhTrucQuan.RoundedPanel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Panel pnlAnhBorder;
        private System.Windows.Forms.PictureBox picAnhMon;
        private DoAnLapTrinhTrucQuan.RoundedButton btnChonAnh;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private DoAnLapTrinhTrucQuan.RoundedButton btnTaoMaTuDong;
        private System.Windows.Forms.Label lblGhiChuMa;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.CheckBox chkCoDinhLuong;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Panel pnlDivider2;
        private DoAnLapTrinhTrucQuan.RoundedButton btnHuy;
        private DoAnLapTrinhTrucQuan.RoundedButton btnLuu;
    }
}
