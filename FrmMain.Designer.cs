namespace DoAnLapTrinhTrucQuan
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            pnlSidebar = new Panel();
            panel1 = new Panel();
            lblThoigian = new Label();
            btnLogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMenuTable = new Button();
            btnMenuOrder = new Button();
            btnMenuOrderList = new Button();
            btnMenuInvoice = new Button();
            btnMenuProduct = new Button();
            btnMenuCategory = new Button();
            btnMenuInventory = new Button();
            btnMenuVoucher = new Button();
            btnMenuStaff = new Button();
            btnMenuShift = new Button();
            btnMenuSchedule = new Button();
            btnMenuTableManage = new Button();
            btnMenuReport = new Button();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lbLogo2 = new Label();
            lbLogo1 = new Label();
            pnlTopbar = new Panel();
            lbRoletopbar = new Label();
            lbTentopbar = new Label();
            picAvttopbar = new PictureBox();
            label1 = new Label();
            picLogotopbar = new PictureBox();
            pnlContent = new Panel();
            btnProfile = new Button();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvttopbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogotopbar).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(85, 55, 34);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Controls.Add(flowLayoutPanel1);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 1033);
            pnlSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 80, 63);
            panel1.Controls.Add(lblThoigian);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 933);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 100);
            panel1.TabIndex = 2;
            // 
            // lblThoigian
            // 
            lblThoigian.AutoSize = true;
            lblThoigian.Font = new Font("Segoe UI", 11F);
            lblThoigian.ForeColor = Color.FromArgb(238, 193, 164);
            lblThoigian.Location = new Point(29, 66);
            lblThoigian.Name = "lblThoigian";
            lblThoigian.Size = new Size(162, 25);
            lblThoigian.TabIndex = 15;
            lblThoigian.Text = "Thứ 3, 17/11/2026";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.ForeColor = Color.FromArgb(238, 193, 164);
            btnLogout.Image = Properties.Resources.Container__12_;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(143, 34);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMenuTable);
            flowLayoutPanel1.Controls.Add(btnMenuOrder);
            flowLayoutPanel1.Controls.Add(btnMenuOrderList);
            flowLayoutPanel1.Controls.Add(btnMenuInvoice);
            flowLayoutPanel1.Controls.Add(btnMenuProduct);
            flowLayoutPanel1.Controls.Add(btnMenuCategory);
            flowLayoutPanel1.Controls.Add(btnMenuInventory);
            flowLayoutPanel1.Controls.Add(btnMenuVoucher);
            flowLayoutPanel1.Controls.Add(btnMenuStaff);
            flowLayoutPanel1.Controls.Add(btnMenuShift);
            flowLayoutPanel1.Controls.Add(btnMenuSchedule);
            flowLayoutPanel1.Controls.Add(btnMenuTableManage);
            flowLayoutPanel1.Controls.Add(btnMenuReport);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 689);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnMenuTable
            // 
            btnMenuTable.FlatAppearance.BorderSize = 0;
            btnMenuTable.FlatStyle = FlatStyle.Flat;
            btnMenuTable.Font = new Font("Segoe UI", 11F);
            btnMenuTable.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuTable.Image = Properties.Resources.Container__1_;
            btnMenuTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuTable.Location = new Point(3, 3);
            btnMenuTable.Name = "btnMenuTable";
            btnMenuTable.Padding = new Padding(15, 0, 0, 0);
            btnMenuTable.Size = new Size(234, 45);
            btnMenuTable.TabIndex = 1;
            btnMenuTable.Text = "Sơ đồ bàn";
            btnMenuTable.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuTable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuTable.UseVisualStyleBackColor = true;
            // 
            // btnMenuOrder
            // 
            btnMenuOrder.FlatAppearance.BorderSize = 0;
            btnMenuOrder.FlatStyle = FlatStyle.Flat;
            btnMenuOrder.Font = new Font("Segoe UI", 11F);
            btnMenuOrder.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuOrder.Image = Properties.Resources.Icon;
            btnMenuOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuOrder.Location = new Point(3, 54);
            btnMenuOrder.Name = "btnMenuOrder";
            btnMenuOrder.Padding = new Padding(15, 0, 0, 0);
            btnMenuOrder.Size = new Size(234, 45);
            btnMenuOrder.TabIndex = 2;
            btnMenuOrder.Text = "Bán hàng";
            btnMenuOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuOrder.UseVisualStyleBackColor = true;
            // 
            // btnMenuOrderList
            // 
            btnMenuOrderList.FlatAppearance.BorderSize = 0;
            btnMenuOrderList.FlatStyle = FlatStyle.Flat;
            btnMenuOrderList.Font = new Font("Segoe UI", 11F);
            btnMenuOrderList.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuOrderList.Image = Properties.Resources.Container__2_;
            btnMenuOrderList.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuOrderList.Location = new Point(3, 105);
            btnMenuOrderList.Name = "btnMenuOrderList";
            btnMenuOrderList.Padding = new Padding(15, 0, 0, 0);
            btnMenuOrderList.Size = new Size(234, 45);
            btnMenuOrderList.TabIndex = 3;
            btnMenuOrderList.Text = "Đơn hàng";
            btnMenuOrderList.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuOrderList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuOrderList.UseVisualStyleBackColor = true;
            // 
            // btnMenuInvoice
            // 
            btnMenuInvoice.FlatAppearance.BorderSize = 0;
            btnMenuInvoice.FlatStyle = FlatStyle.Flat;
            btnMenuInvoice.Font = new Font("Segoe UI", 11F);
            btnMenuInvoice.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuInvoice.Image = Properties.Resources.Container__3_;
            btnMenuInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuInvoice.Location = new Point(3, 156);
            btnMenuInvoice.Name = "btnMenuInvoice";
            btnMenuInvoice.Padding = new Padding(15, 0, 0, 0);
            btnMenuInvoice.Size = new Size(234, 45);
            btnMenuInvoice.TabIndex = 4;
            btnMenuInvoice.Text = "Hóa đơn";
            btnMenuInvoice.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuInvoice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuInvoice.UseVisualStyleBackColor = true;
            // 
            // btnMenuProduct
            // 
            btnMenuProduct.FlatAppearance.BorderSize = 0;
            btnMenuProduct.FlatStyle = FlatStyle.Flat;
            btnMenuProduct.Font = new Font("Segoe UI", 11F);
            btnMenuProduct.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuProduct.Image = Properties.Resources.Container__4_;
            btnMenuProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuProduct.Location = new Point(3, 207);
            btnMenuProduct.Name = "btnMenuProduct";
            btnMenuProduct.Padding = new Padding(15, 0, 0, 0);
            btnMenuProduct.Size = new Size(234, 45);
            btnMenuProduct.TabIndex = 5;
            btnMenuProduct.Text = "Quản lý món";
            btnMenuProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuProduct.UseVisualStyleBackColor = true;
            // 
            // btnMenuCategory
            // 
            btnMenuCategory.FlatAppearance.BorderSize = 0;
            btnMenuCategory.FlatStyle = FlatStyle.Flat;
            btnMenuCategory.Font = new Font("Segoe UI", 11F);
            btnMenuCategory.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuCategory.Image = Properties.Resources.Container__5_;
            btnMenuCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuCategory.Location = new Point(3, 258);
            btnMenuCategory.Name = "btnMenuCategory";
            btnMenuCategory.Padding = new Padding(15, 0, 0, 0);
            btnMenuCategory.Size = new Size(234, 45);
            btnMenuCategory.TabIndex = 6;
            btnMenuCategory.Text = "Danh mục";
            btnMenuCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuCategory.UseVisualStyleBackColor = true;
            // 
            // btnMenuInventory
            // 
            btnMenuInventory.FlatAppearance.BorderSize = 0;
            btnMenuInventory.FlatStyle = FlatStyle.Flat;
            btnMenuInventory.Font = new Font("Segoe UI", 11F);
            btnMenuInventory.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuInventory.Image = Properties.Resources.Container__6_;
            btnMenuInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuInventory.Location = new Point(3, 309);
            btnMenuInventory.Name = "btnMenuInventory";
            btnMenuInventory.Padding = new Padding(15, 0, 0, 0);
            btnMenuInventory.Size = new Size(234, 45);
            btnMenuInventory.TabIndex = 7;
            btnMenuInventory.Text = "Nguyên liệu, Kho";
            btnMenuInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuInventory.UseVisualStyleBackColor = true;
            // 
            // btnMenuVoucher
            // 
            btnMenuVoucher.FlatAppearance.BorderSize = 0;
            btnMenuVoucher.FlatStyle = FlatStyle.Flat;
            btnMenuVoucher.Font = new Font("Segoe UI", 11F);
            btnMenuVoucher.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuVoucher.Image = Properties.Resources.Container__7_;
            btnMenuVoucher.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuVoucher.Location = new Point(3, 360);
            btnMenuVoucher.Name = "btnMenuVoucher";
            btnMenuVoucher.Padding = new Padding(15, 0, 0, 0);
            btnMenuVoucher.Size = new Size(234, 45);
            btnMenuVoucher.TabIndex = 8;
            btnMenuVoucher.Text = "Voucher";
            btnMenuVoucher.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuVoucher.UseVisualStyleBackColor = true;
            // 
            // btnMenuStaff
            // 
            btnMenuStaff.FlatAppearance.BorderSize = 0;
            btnMenuStaff.FlatStyle = FlatStyle.Flat;
            btnMenuStaff.Font = new Font("Segoe UI", 11F);
            btnMenuStaff.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuStaff.Image = Properties.Resources.Container__8_;
            btnMenuStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuStaff.Location = new Point(3, 411);
            btnMenuStaff.Name = "btnMenuStaff";
            btnMenuStaff.Padding = new Padding(15, 0, 0, 0);
            btnMenuStaff.Size = new Size(234, 45);
            btnMenuStaff.TabIndex = 9;
            btnMenuStaff.Text = "Quản lý nhân viên";
            btnMenuStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuStaff.UseVisualStyleBackColor = true;
            // 
            // btnMenuShift
            // 
            btnMenuShift.FlatAppearance.BorderSize = 0;
            btnMenuShift.FlatStyle = FlatStyle.Flat;
            btnMenuShift.Font = new Font("Segoe UI", 11F);
            btnMenuShift.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuShift.Image = Properties.Resources.Icon__1_;
            btnMenuShift.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuShift.Location = new Point(3, 462);
            btnMenuShift.Name = "btnMenuShift";
            btnMenuShift.Padding = new Padding(15, 0, 0, 0);
            btnMenuShift.Size = new Size(234, 45);
            btnMenuShift.TabIndex = 10;
            btnMenuShift.Text = "Xếp lịch ca làm việc";
            btnMenuShift.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuShift.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuShift.UseVisualStyleBackColor = true;
            // 
            // btnMenuSchedule
            // 
            btnMenuSchedule.FlatAppearance.BorderSize = 0;
            btnMenuSchedule.FlatStyle = FlatStyle.Flat;
            btnMenuSchedule.Font = new Font("Segoe UI", 11F);
            btnMenuSchedule.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuSchedule.Image = Properties.Resources.Container__9_;
            btnMenuSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSchedule.Location = new Point(3, 513);
            btnMenuSchedule.Name = "btnMenuSchedule";
            btnMenuSchedule.Padding = new Padding(15, 0, 0, 0);
            btnMenuSchedule.Size = new Size(234, 45);
            btnMenuSchedule.TabIndex = 11;
            btnMenuSchedule.Text = "Lịch làm của tôi";
            btnMenuSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSchedule.UseVisualStyleBackColor = true;
            // 
            // btnMenuTableManage
            // 
            btnMenuTableManage.FlatAppearance.BorderSize = 0;
            btnMenuTableManage.FlatStyle = FlatStyle.Flat;
            btnMenuTableManage.Font = new Font("Segoe UI", 11F);
            btnMenuTableManage.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuTableManage.Image = Properties.Resources.Container__10_;
            btnMenuTableManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuTableManage.Location = new Point(3, 564);
            btnMenuTableManage.Name = "btnMenuTableManage";
            btnMenuTableManage.Padding = new Padding(15, 0, 0, 0);
            btnMenuTableManage.Size = new Size(234, 45);
            btnMenuTableManage.TabIndex = 12;
            btnMenuTableManage.Text = "Quản lý bàn";
            btnMenuTableManage.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuTableManage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuTableManage.UseVisualStyleBackColor = true;
            // 
            // btnMenuReport
            // 
            btnMenuReport.FlatAppearance.BorderSize = 0;
            btnMenuReport.FlatStyle = FlatStyle.Flat;
            btnMenuReport.Font = new Font("Segoe UI", 11F);
            btnMenuReport.ForeColor = Color.FromArgb(238, 193, 164);
            btnMenuReport.Image = Properties.Resources.Container__11_;
            btnMenuReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuReport.Location = new Point(3, 615);
            btnMenuReport.Name = "btnMenuReport";
            btnMenuReport.Padding = new Padding(15, 0, 0, 0);
            btnMenuReport.Size = new Size(234, 45);
            btnMenuReport.TabIndex = 13;
            btnMenuReport.Text = "Báo cáo doanh thu";
            btnMenuReport.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuReport.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lbLogo2);
            pnlLogo.Controls.Add(lbLogo1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(240, 70);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.Background;
            picLogo.Location = new Point(14, 14);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(41, 44);
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lbLogo2
            // 
            lbLogo2.AutoSize = true;
            lbLogo2.Font = new Font("Segoe UI", 11F);
            lbLogo2.ForeColor = Color.FromArgb(238, 193, 164);
            lbLogo2.Location = new Point(61, 35);
            lbLogo2.Name = "lbLogo2";
            lbLogo2.Size = new Size(130, 25);
            lbLogo2.TabIndex = 1;
            lbLogo2.Text = "Hệ thống POS";
            // 
            // lbLogo1
            // 
            lbLogo1.AutoSize = true;
            lbLogo1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbLogo1.ForeColor = Color.White;
            lbLogo1.Location = new Point(61, 9);
            lbLogo1.Name = "lbLogo1";
            lbLogo1.Size = new Size(100, 25);
            lbLogo1.TabIndex = 0;
            lbLogo1.Text = "LTTQ Cafe";
            // 
            // pnlTopbar
            // 
            pnlTopbar.BackColor = Color.White;
            pnlTopbar.Controls.Add(lbRoletopbar);
            pnlTopbar.Controls.Add(lbTentopbar);
            pnlTopbar.Controls.Add(picAvttopbar);
            pnlTopbar.Controls.Add(label1);
            pnlTopbar.Controls.Add(picLogotopbar);
            pnlTopbar.Dock = DockStyle.Top;
            pnlTopbar.Location = new Point(240, 0);
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new Size(1662, 70);
            pnlTopbar.TabIndex = 1;
            // 
            // lbRoletopbar
            // 
            lbRoletopbar.AutoSize = true;
            lbRoletopbar.Font = new Font("Segoe UI", 11F);
            lbRoletopbar.ForeColor = Color.FromArgb(125, 86, 45);
            lbRoletopbar.Location = new Point(1507, 33);
            lbRoletopbar.Name = "lbRoletopbar";
            lbRoletopbar.Size = new Size(77, 25);
            lbRoletopbar.TabIndex = 6;
            lbRoletopbar.Text = "Quản lý";
            // 
            // lbTentopbar
            // 
            lbTentopbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTentopbar.AutoSize = true;
            lbTentopbar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbTentopbar.ForeColor = Color.FromArgb(85, 55, 34);
            lbTentopbar.Location = new Point(1463, 9);
            lbTentopbar.Name = "lbTentopbar";
            lbTentopbar.Size = new Size(121, 25);
            lbTentopbar.TabIndex = 5;
            lbTentopbar.Text = "Trần Văn An";
            // 
            // picAvttopbar
            // 
            picAvttopbar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picAvttopbar.Image = Properties.Resources.Background__1_;
            picAvttopbar.Location = new Point(1590, 12);
            picAvttopbar.Name = "picAvttopbar";
            picAvttopbar.Size = new Size(60, 46);
            picAvttopbar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvttopbar.TabIndex = 4;
            picAvttopbar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(85, 55, 34);
            label1.Location = new Point(65, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "LTTQ Cafe";
            // 
            // picLogotopbar
            // 
            picLogotopbar.Image = Properties.Resources.LLTQ_Café_Logo;
            picLogotopbar.Location = new Point(9, 14);
            picLogotopbar.Name = "picLogotopbar";
            picLogotopbar.Size = new Size(50, 46);
            picLogotopbar.SizeMode = PictureBoxSizeMode.Zoom;
            picLogotopbar.TabIndex = 0;
            picLogotopbar.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(240, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1662, 963);
            pnlContent.TabIndex = 2;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11F);
            btnProfile.ForeColor = Color.FromArgb(238, 193, 164);
            btnProfile.Image = Properties.Resources.Container;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 756);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(15, 0, 0, 0);
            btnProfile.Size = new Size(237, 45);
            btnProfile.TabIndex = 14;
            btnProfile.Text = "Thông tin cá nhân";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 246);
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopbar);
            Controls.Add(pnlSidebar);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LTTQ Cafe - Hệ thống POS";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTopbar.ResumeLayout(false);
            pnlTopbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvttopbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogotopbar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Panel pnlSidebar;
        private Panel pnlTopbar;
        private Panel pnlContent;
        private Panel pnlLogo;
        private Label lbLogo1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbLogo2;
        private PictureBox picLogo;
        private Button btnMenuTable;
        private Button btnMenuOrder;
        private Button btnMenuOrderList;
        private Button btnMenuInvoice;
        private Button btnMenuProduct;
        private Button btnMenuCategory;
        private Button btnMenuInventory;
        private Button btnMenuVoucher;
        private Button btnMenuStaff;
        private Button btnMenuShift;
        private Button btnMenuSchedule;
        private Panel panel1;
        private Button btnLogout;
        private Button btnMenuTableManage;
        private Button btnMenuReport;
        private Label lblThoigian;
        private PictureBox picLogotopbar;
        private PictureBox picAvttopbar;
        private Label label1;
        private Label lbRoletopbar;
        private Label lbTentopbar;
        private Button btnProfile;
    }
}
