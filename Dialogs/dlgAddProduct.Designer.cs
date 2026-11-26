namespace DoAnLapTrinhTrucQuan.Dialogs
{
    partial class dlgAddProduct
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
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnAutoGenerateCode = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.lblGhiChuMa = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.chkHasRecipe = new System.Windows.Forms.CheckBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.btnCancel = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.btnSave = new DoAnLapTrinhTrucQuan.RoundedButton();
            this.pnlCard.SuspendLayout();
            this.pnlAnhBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlCard.BorderRadius = 12;
            this.pnlCard.BorderWidth = 1;
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.Controls.Add(this.pnlDivider2);
            this.pnlCard.Controls.Add(this.txtDescription);
            this.pnlCard.Controls.Add(this.lblMoTa);
            this.pnlCard.Controls.Add(this.chkHasRecipe);
            this.pnlCard.Controls.Add(this.cboStatus);
            this.pnlCard.Controls.Add(this.lblTrangThai);
            this.pnlCard.Controls.Add(this.nudPrice);
            this.pnlCard.Controls.Add(this.lblGiaBan);
            this.pnlCard.Controls.Add(this.txtProductName);
            this.pnlCard.Controls.Add(this.lblTenMon);
            this.pnlCard.Controls.Add(this.lblGhiChuMa);
            this.pnlCard.Controls.Add(this.btnAutoGenerateCode);
            this.pnlCard.Controls.Add(this.txtProductId);
            this.pnlCard.Controls.Add(this.lblMaMon);
            this.pnlCard.Controls.Add(this.cboCategory);
            this.pnlCard.Controls.Add(this.lblDanhMuc);
            this.pnlCard.Controls.Add(this.btnChooseImage);
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
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblSubTitle.Location = new System.Drawing.Point(21, 43);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(347, 17);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Nhập đầy đủ thông tin để lưu món vào danh sách bán hàng";
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlDivider1.Location = new System.Drawing.Point(20, 68);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(548, 1);
            this.pnlDivider1.TabIndex = 2;
            // 
            // pnlAnhBorder
            // 
            this.pnlAnhBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnhBorder.Controls.Add(this.picProductImage);
            this.pnlAnhBorder.Location = new System.Drawing.Point(24, 82);
            this.pnlAnhBorder.Name = "pnlAnhBorder";
            this.pnlAnhBorder.Size = new System.Drawing.Size(130, 130);
            this.pnlAnhBorder.TabIndex = 3;
            // 
            // picProductImage
            // 
            this.picProductImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.picProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProductImage.Location = new System.Drawing.Point(0, 0);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(128, 128);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 0;
            this.picProductImage.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.White;
            this.btnChooseImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnChooseImage.BorderRadius = 6;
            this.btnChooseImage.BorderWidth = 1;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChooseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnChooseImage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(231)))));
            this.btnChooseImage.Location = new System.Drawing.Point(24, 220);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(130, 32);
            this.btnChooseImage.TabIndex = 4;
            this.btnChooseImage.Text = "📁 Chọn ảnh...";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblDanhMuc.Location = new System.Drawing.Point(176, 82);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(91, 17);
            this.lblDanhMuc.TabIndex = 5;
            this.lblDanhMuc.Text = "Danh mục (*):";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(176, 102);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(392, 25);
            this.cboCategory.TabIndex = 6;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblMaMon.Location = new System.Drawing.Point(176, 137);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(78, 17);
            this.lblMaMon.TabIndex = 7;
            this.lblMaMon.Text = "Mã món (*):";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.txtProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.txtProductId.Location = new System.Drawing.Point(176, 157);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(260, 26);
            this.txtProductId.TabIndex = 8;
            // 
            // btnAutoGenerateCode
            // 
            this.btnAutoGenerateCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.btnAutoGenerateCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.btnAutoGenerateCode.BorderRadius = 6;
            this.btnAutoGenerateCode.BorderWidth = 1;
            this.btnAutoGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoGenerateCode.FlatAppearance.BorderSize = 0;
            this.btnAutoGenerateCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoGenerateCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAutoGenerateCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnAutoGenerateCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(220)))), ((int)(((byte)(205)))));
            this.btnAutoGenerateCode.Location = new System.Drawing.Point(444, 156);
            this.btnAutoGenerateCode.Name = "btnAutoGenerateCode";
            this.btnAutoGenerateCode.Size = new System.Drawing.Size(124, 28);
            this.btnAutoGenerateCode.TabIndex = 9;
            this.btnAutoGenerateCode.Text = "🔄 Sinh mã";
            this.btnAutoGenerateCode.UseVisualStyleBackColor = false;
            // 
            // lblGhiChuMa
            // 
            this.lblGhiChuMa.AutoSize = true;
            this.lblGhiChuMa.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGhiChuMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(110)))), ((int)(((byte)(101)))));
            this.lblGhiChuMa.Location = new System.Drawing.Point(176, 186);
            this.lblGhiChuMa.Name = "lblGhiChuMa";
            this.lblGhiChuMa.Size = new System.Drawing.Size(258, 13);
            this.lblGhiChuMa.TabIndex = 10;
            this.lblGhiChuMa.Text = "Mã tự sinh theo danh mục (VD: CF07, PM06, TE06)";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblTenMon.Location = new System.Drawing.Point(176, 206);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(81, 17);
            this.lblTenMon.TabIndex = 11;
            this.lblTenMon.Text = "Tên món (*):";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProductName.Location = new System.Drawing.Point(176, 226);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(392, 25);
            this.txtProductName.TabIndex = 12;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblGiaBan.Location = new System.Drawing.Point(24, 270);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(103, 17);
            this.lblGiaBan.TabIndex = 13;
            this.lblGiaBan.Text = "Giá bán (VNĐ):";
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.nudPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudPrice.Location = new System.Drawing.Point(24, 290);
            this.nudPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(160, 25);
            this.nudPrice.TabIndex = 14;
            this.nudPrice.ThousandsSeparator = true;
            this.nudPrice.Value = new decimal(new int[] { 35000, 0, 0, 0 });
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblTrangThai.Location = new System.Drawing.Point(206, 270);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(75, 17);
            this.lblTrangThai.TabIndex = 15;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(206, 290);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(160, 25);
            this.cboStatus.TabIndex = 16;
            // 
            // chkHasRecipe
            // 
            this.chkHasRecipe.AutoSize = true;
            this.chkHasRecipe.Checked = true;
            this.chkHasRecipe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHasRecipe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkHasRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.chkHasRecipe.Location = new System.Drawing.Point(390, 292);
            this.chkHasRecipe.Name = "chkHasRecipe";
            this.chkHasRecipe.Size = new System.Drawing.Size(182, 21);
            this.chkHasRecipe.TabIndex = 17;
            this.chkHasRecipe.Text = "Quản lý định lượng (BOM)";
            this.chkHasRecipe.UseVisualStyleBackColor = true;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.lblMoTa.Location = new System.Drawing.Point(24, 330);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(89, 17);
            this.lblMoTa.TabIndex = 18;
            this.lblMoTa.Text = "Mô tả hương vị:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescription.Location = new System.Drawing.Point(24, 350);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(544, 95);
            this.txtDescription.TabIndex = 19;
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(213)))));
            this.pnlDivider2.Location = new System.Drawing.Point(20, 460);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(548, 1);
            this.pnlDivider2.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(232)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(180)))));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderWidth = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.btnCancel.Location = new System.Drawing.Point(324, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 38);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnSave.BorderRadius = 8;
            this.btnSave.BorderWidth = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(63)))), ((int)(((byte)(43)))));
            this.btnSave.Location = new System.Drawing.Point(444, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 38);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "💾 Lưu món";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dlgAddProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(620, 574);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgAddProduct";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm món mới";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlAnhBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DoAnLapTrinhTrucQuan.RoundedPanel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Panel pnlAnhBorder;
        private System.Windows.Forms.PictureBox picProductImage;
        private DoAnLapTrinhTrucQuan.RoundedButton btnChooseImage;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtProductId;
        private DoAnLapTrinhTrucQuan.RoundedButton btnAutoGenerateCode;
        private System.Windows.Forms.Label lblGhiChuMa;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.CheckBox chkHasRecipe;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlDivider2;
        private DoAnLapTrinhTrucQuan.RoundedButton btnCancel;
        private DoAnLapTrinhTrucQuan.RoundedButton btnSave;
    }
}
