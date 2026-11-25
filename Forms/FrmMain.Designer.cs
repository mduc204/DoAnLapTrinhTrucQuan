namespace DoAnLapTrinhTrucQuan.Forms
{
    partial class FrmMain
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
            pnlContent = new Panel();
            pnlMenu = new Panel();
            pnlMenuScroll = new Panel();
            pnlMenuItems = new Panel();
            btnMenuReports = new Button();
            btnMenuTables = new Button();
            btnMenuMyShifts = new Button();
            btnMenuSchedule = new Button();
            btnMenuStaff = new Button();
            btnMenuVouchers = new Button();
            btnMenuInventory = new Button();
            btnMenuCategories = new Button();
            btnMenuProducts = new Button();
            btnMenuInvoices = new Button();
            btnMenuOrders = new Button();
            btnMenuPos = new Button();
            btnMenuTableMap = new Button();
            btnMenuDashboard = new Button();
            pnlMenuFooter = new Panel();
            btnSignOut = new Button();
            lblOnline = new Label();
            lblNetworkStatus = new Label();
            pnlBrand = new Panel();
            lblBrandSubtitle = new Label();
            lblBrandName = new Label();
            lblBrandIcon = new Label();
            pnlMenu.SuspendLayout();
            pnlMenuScroll.SuspendLayout();
            pnlMenuItems.SuspendLayout();
            pnlMenuFooter.SuspendLayout();
            pnlBrand.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(252, 246, 243);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(980, 760);
            pnlContent.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(82, 54, 34);
            pnlMenu.Controls.Add(pnlMenuScroll);
            pnlMenu.Controls.Add(pnlMenuFooter);
            pnlMenu.Controls.Add(pnlBrand);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 760);
            pnlMenu.TabIndex = 0;
            // 
            // pnlMenuScroll
            // 
            pnlMenuScroll.AutoScroll = true;
            pnlMenuScroll.Controls.Add(pnlMenuItems);
            pnlMenuScroll.Dock = DockStyle.Fill;
            pnlMenuScroll.Location = new Point(0, 74);
            pnlMenuScroll.Name = "pnlMenuScroll";
            pnlMenuScroll.Size = new Size(220, 614);
            pnlMenuScroll.TabIndex = 1;
            // 
            // pnlMenuItems
            // 
            pnlMenuItems.Controls.Add(btnMenuReports);
            pnlMenuItems.Controls.Add(btnMenuTables);
            pnlMenuItems.Controls.Add(btnMenuMyShifts);
            pnlMenuItems.Controls.Add(btnMenuSchedule);
            pnlMenuItems.Controls.Add(btnMenuStaff);
            pnlMenuItems.Controls.Add(btnMenuVouchers);
            pnlMenuItems.Controls.Add(btnMenuInventory);
            pnlMenuItems.Controls.Add(btnMenuCategories);
            pnlMenuItems.Controls.Add(btnMenuProducts);
            pnlMenuItems.Controls.Add(btnMenuInvoices);
            pnlMenuItems.Controls.Add(btnMenuOrders);
            pnlMenuItems.Controls.Add(btnMenuPos);
            pnlMenuItems.Controls.Add(btnMenuTableMap);
            pnlMenuItems.Controls.Add(btnMenuDashboard);
            pnlMenuItems.Dock = DockStyle.Top;
            pnlMenuItems.Location = new Point(0, 0);
            pnlMenuItems.Name = "pnlMenuItems";
            pnlMenuItems.Padding = new Padding(4, 6, 4, 6);
            pnlMenuItems.Size = new Size(220, 488);
            pnlMenuItems.TabIndex = 0;
            // 
            // btnMenuReports
            // 
            btnMenuReports.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuReports.Dock = DockStyle.Top;
            btnMenuReports.FlatAppearance.BorderSize = 0;
            btnMenuReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuReports.FlatStyle = FlatStyle.Flat;
            btnMenuReports.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuReports.Location = new Point(4, 448);
            btnMenuReports.Name = "btnMenuReports";
            btnMenuReports.Padding = new Padding(10, 0, 8, 0);
            btnMenuReports.Size = new Size(212, 34);
            btnMenuReports.TabIndex = 13;
            btnMenuReports.Text = "Báo cáo thống kê";
            btnMenuReports.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuReports.UseMnemonic = false;
            btnMenuReports.UseVisualStyleBackColor = false;
            // 
            // btnMenuTables
            // 
            btnMenuTables.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuTables.Dock = DockStyle.Top;
            btnMenuTables.FlatAppearance.BorderSize = 0;
            btnMenuTables.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuTables.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuTables.FlatStyle = FlatStyle.Flat;
            btnMenuTables.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuTables.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuTables.Location = new Point(4, 414);
            btnMenuTables.Name = "btnMenuTables";
            btnMenuTables.Padding = new Padding(10, 0, 8, 0);
            btnMenuTables.Size = new Size(212, 34);
            btnMenuTables.TabIndex = 12;
            btnMenuTables.Text = "Quản lý bàn";
            btnMenuTables.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuTables.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuTables.UseMnemonic = false;
            btnMenuTables.UseVisualStyleBackColor = false;
            // 
            // btnMenuMyShifts
            // 
            btnMenuMyShifts.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuMyShifts.Dock = DockStyle.Top;
            btnMenuMyShifts.FlatAppearance.BorderSize = 0;
            btnMenuMyShifts.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuMyShifts.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuMyShifts.FlatStyle = FlatStyle.Flat;
            btnMenuMyShifts.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuMyShifts.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuMyShifts.Location = new Point(4, 380);
            btnMenuMyShifts.Name = "btnMenuMyShifts";
            btnMenuMyShifts.Padding = new Padding(10, 0, 8, 0);
            btnMenuMyShifts.Size = new Size(212, 34);
            btnMenuMyShifts.TabIndex = 11;
            btnMenuMyShifts.Text = "Lịch làm của tôi";
            btnMenuMyShifts.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuMyShifts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuMyShifts.UseMnemonic = false;
            btnMenuMyShifts.UseVisualStyleBackColor = false;
            // 
            // btnMenuSchedule
            // 
            btnMenuSchedule.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuSchedule.Dock = DockStyle.Top;
            btnMenuSchedule.FlatAppearance.BorderSize = 0;
            btnMenuSchedule.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuSchedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuSchedule.FlatStyle = FlatStyle.Flat;
            btnMenuSchedule.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSchedule.Location = new Point(4, 346);
            btnMenuSchedule.Name = "btnMenuSchedule";
            btnMenuSchedule.Padding = new Padding(10, 0, 8, 0);
            btnMenuSchedule.Size = new Size(212, 34);
            btnMenuSchedule.TabIndex = 10;
            btnMenuSchedule.Text = "Xếp lịch ca làm việc";
            btnMenuSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSchedule.UseMnemonic = false;
            btnMenuSchedule.UseVisualStyleBackColor = false;
            // 
            // btnMenuStaff
            // 
            btnMenuStaff.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuStaff.Dock = DockStyle.Top;
            btnMenuStaff.FlatAppearance.BorderSize = 0;
            btnMenuStaff.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuStaff.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuStaff.FlatStyle = FlatStyle.Flat;
            btnMenuStaff.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuStaff.Location = new Point(4, 312);
            btnMenuStaff.Name = "btnMenuStaff";
            btnMenuStaff.Padding = new Padding(10, 0, 8, 0);
            btnMenuStaff.Size = new Size(212, 34);
            btnMenuStaff.TabIndex = 9;
            btnMenuStaff.Text = "Quản lý nhân viên";
            btnMenuStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuStaff.UseMnemonic = false;
            btnMenuStaff.UseVisualStyleBackColor = false;
            // 
            // btnMenuVouchers
            // 
            btnMenuVouchers.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuVouchers.Dock = DockStyle.Top;
            btnMenuVouchers.FlatAppearance.BorderSize = 0;
            btnMenuVouchers.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuVouchers.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuVouchers.FlatStyle = FlatStyle.Flat;
            btnMenuVouchers.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuVouchers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuVouchers.Location = new Point(4, 278);
            btnMenuVouchers.Name = "btnMenuVouchers";
            btnMenuVouchers.Padding = new Padding(10, 0, 8, 0);
            btnMenuVouchers.Size = new Size(212, 34);
            btnMenuVouchers.TabIndex = 8;
            btnMenuVouchers.Text = "Voucher";
            btnMenuVouchers.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuVouchers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuVouchers.UseMnemonic = false;
            btnMenuVouchers.UseVisualStyleBackColor = false;
            // 
            // btnMenuInventory
            // 
            btnMenuInventory.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuInventory.Dock = DockStyle.Top;
            btnMenuInventory.FlatAppearance.BorderSize = 0;
            btnMenuInventory.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuInventory.FlatStyle = FlatStyle.Flat;
            btnMenuInventory.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuInventory.Location = new Point(4, 244);
            btnMenuInventory.Name = "btnMenuInventory";
            btnMenuInventory.Padding = new Padding(10, 0, 8, 0);
            btnMenuInventory.Size = new Size(212, 34);
            btnMenuInventory.TabIndex = 7;
            btnMenuInventory.Text = "Nguyên liệu & Kho";
            btnMenuInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuInventory.UseMnemonic = false;
            btnMenuInventory.UseVisualStyleBackColor = false;
            // 
            // btnMenuCategories
            // 
            btnMenuCategories.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuCategories.Dock = DockStyle.Top;
            btnMenuCategories.FlatAppearance.BorderSize = 0;
            btnMenuCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuCategories.FlatStyle = FlatStyle.Flat;
            btnMenuCategories.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuCategories.Location = new Point(4, 210);
            btnMenuCategories.Name = "btnMenuCategories";
            btnMenuCategories.Padding = new Padding(10, 0, 8, 0);
            btnMenuCategories.Size = new Size(212, 34);
            btnMenuCategories.TabIndex = 6;
            btnMenuCategories.Text = "Danh mục";
            btnMenuCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuCategories.UseMnemonic = false;
            btnMenuCategories.UseVisualStyleBackColor = false;
            // 
            // btnMenuProducts
            // 
            btnMenuProducts.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuProducts.Dock = DockStyle.Top;
            btnMenuProducts.FlatAppearance.BorderSize = 0;
            btnMenuProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuProducts.FlatStyle = FlatStyle.Flat;
            btnMenuProducts.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuProducts.Location = new Point(4, 176);
            btnMenuProducts.Name = "btnMenuProducts";
            btnMenuProducts.Padding = new Padding(10, 0, 8, 0);
            btnMenuProducts.Size = new Size(212, 34);
            btnMenuProducts.TabIndex = 5;
            btnMenuProducts.Text = "Quản lý món";
            btnMenuProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuProducts.UseMnemonic = false;
            btnMenuProducts.UseVisualStyleBackColor = false;
            // 
            // btnMenuInvoices
            // 
            btnMenuInvoices.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuInvoices.Dock = DockStyle.Top;
            btnMenuInvoices.FlatAppearance.BorderSize = 0;
            btnMenuInvoices.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuInvoices.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuInvoices.FlatStyle = FlatStyle.Flat;
            btnMenuInvoices.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuInvoices.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuInvoices.Location = new Point(4, 142);
            btnMenuInvoices.Name = "btnMenuInvoices";
            btnMenuInvoices.Padding = new Padding(10, 0, 8, 0);
            btnMenuInvoices.Size = new Size(212, 34);
            btnMenuInvoices.TabIndex = 4;
            btnMenuInvoices.Text = "Hóa đơn";
            btnMenuInvoices.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuInvoices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuInvoices.UseMnemonic = false;
            btnMenuInvoices.UseVisualStyleBackColor = false;
            // 
            // btnMenuOrders
            // 
            btnMenuOrders.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuOrders.Dock = DockStyle.Top;
            btnMenuOrders.FlatAppearance.BorderSize = 0;
            btnMenuOrders.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuOrders.FlatStyle = FlatStyle.Flat;
            btnMenuOrders.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuOrders.Location = new Point(4, 108);
            btnMenuOrders.Name = "btnMenuOrders";
            btnMenuOrders.Padding = new Padding(10, 0, 8, 0);
            btnMenuOrders.Size = new Size(212, 34);
            btnMenuOrders.TabIndex = 3;
            btnMenuOrders.Text = "Đơn hàng";
            btnMenuOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuOrders.UseMnemonic = false;
            btnMenuOrders.UseVisualStyleBackColor = false;
            // 
            // btnMenuPos
            // 
            btnMenuPos.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuPos.Dock = DockStyle.Top;
            btnMenuPos.FlatAppearance.BorderSize = 0;
            btnMenuPos.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuPos.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuPos.FlatStyle = FlatStyle.Flat;
            btnMenuPos.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuPos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuPos.Location = new Point(4, 74);
            btnMenuPos.Name = "btnMenuPos";
            btnMenuPos.Padding = new Padding(10, 0, 8, 0);
            btnMenuPos.Size = new Size(212, 34);
            btnMenuPos.TabIndex = 2;
            btnMenuPos.Text = "Bán hàng (POS)";
            btnMenuPos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuPos.UseMnemonic = false;
            btnMenuPos.UseVisualStyleBackColor = false;
            btnMenuPos.Click += btnMenuPos_Click;
            // 
            // btnMenuTableMap
            // 
            btnMenuTableMap.BackColor = Color.FromArgb(121, 86, 60);
            btnMenuTableMap.Dock = DockStyle.Top;
            btnMenuTableMap.FlatAppearance.BorderSize = 0;
            btnMenuTableMap.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuTableMap.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuTableMap.FlatStyle = FlatStyle.Flat;
            btnMenuTableMap.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuTableMap.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuTableMap.Location = new Point(4, 40);
            btnMenuTableMap.Name = "btnMenuTableMap";
            btnMenuTableMap.Padding = new Padding(10, 0, 8, 0);
            btnMenuTableMap.Size = new Size(212, 34);
            btnMenuTableMap.TabIndex = 1;
            btnMenuTableMap.Text = "Sơ đồ bàn";
            btnMenuTableMap.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuTableMap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuTableMap.UseMnemonic = false;
            btnMenuTableMap.UseVisualStyleBackColor = false;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.BackColor = Color.FromArgb(82, 54, 34);
            btnMenuDashboard.Dock = DockStyle.Top;
            btnMenuDashboard.FlatAppearance.BorderSize = 0;
            btnMenuDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 92, 66);
            btnMenuDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMenuDashboard.ForeColor = Color.FromArgb(248, 218, 195);
            btnMenuDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.Location = new Point(4, 6);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Padding = new Padding(10, 0, 8, 0);
            btnMenuDashboard.Size = new Size(212, 34);
            btnMenuDashboard.TabIndex = 0;
            btnMenuDashboard.Text = "Tổng quan";
            btnMenuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuDashboard.UseMnemonic = false;
            btnMenuDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlMenuFooter
            // 
            pnlMenuFooter.BackColor = Color.FromArgb(91, 62, 41);
            pnlMenuFooter.Controls.Add(btnSignOut);
            pnlMenuFooter.Controls.Add(lblOnline);
            pnlMenuFooter.Controls.Add(lblNetworkStatus);
            pnlMenuFooter.Dock = DockStyle.Bottom;
            pnlMenuFooter.Location = new Point(0, 688);
            pnlMenuFooter.Name = "pnlMenuFooter";
            pnlMenuFooter.Size = new Size(220, 72);
            pnlMenuFooter.TabIndex = 2;
            // 
            // btnSignOut
            // 
            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSignOut.BackColor = Color.FromArgb(91, 62, 41);
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 76, 52);
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.ForeColor = Color.FromArgb(248, 218, 195);
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(4, 32);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(10, 0, 8, 0);
            btnSignOut.Size = new Size(212, 32);
            btnSignOut.TabIndex = 2;
            btnSignOut.Text = "Đăng xuất";
            btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
            btnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignOut.UseVisualStyleBackColor = false;
            // 
            // lblOnline
            // 
            lblOnline.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOnline.Font = new Font("Segoe UI", 9F);
            lblOnline.ForeColor = Color.FromArgb(255, 223, 202);
            lblOnline.Location = new Point(134, 8);
            lblOnline.Name = "lblOnline";
            lblOnline.Size = new Size(71, 21);
            lblOnline.TabIndex = 1;
            lblOnline.Text = "● Online";
            lblOnline.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNetworkStatus
            // 
            lblNetworkStatus.AutoSize = true;
            lblNetworkStatus.Font = new Font("Segoe UI", 9F);
            lblNetworkStatus.ForeColor = Color.FromArgb(237, 197, 168);
            lblNetworkStatus.Location = new Point(15, 10);
            lblNetworkStatus.Name = "lblNetworkStatus";
            lblNetworkStatus.Size = new Size(94, 15);
            lblNetworkStatus.TabIndex = 0;
            lblNetworkStatus.Text = "Trạng thái mạng";
            // 
            // pnlBrand
            // 
            pnlBrand.BackColor = Color.FromArgb(91, 62, 41);
            pnlBrand.Controls.Add(lblBrandSubtitle);
            pnlBrand.Controls.Add(lblBrandName);
            pnlBrand.Controls.Add(lblBrandIcon);
            pnlBrand.Dock = DockStyle.Top;
            pnlBrand.Location = new Point(0, 0);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new Size(220, 74);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 9F);
            lblBrandSubtitle.ForeColor = Color.FromArgb(237, 197, 168);
            lblBrandSubtitle.Location = new Point(69, 40);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(92, 15);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "HỆ THỐNG POS";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBrandName.ForeColor = Color.FromArgb(255, 248, 244);
            lblBrandName.Location = new Point(68, 13);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(97, 25);
            lblBrandName.TabIndex = 1;
            lblBrandName.Text = "Mộc CAFÉ";
            // 
            // lblBrandIcon
            // 
            lblBrandIcon.AccessibleName = "Biểu tượng Mộc Café";
            lblBrandIcon.BackColor = Color.FromArgb(255, 223, 202);
            lblBrandIcon.Font = new Font("Segoe UI Symbol", 16F);
            lblBrandIcon.ForeColor = Color.FromArgb(82, 54, 34);
            lblBrandIcon.Location = new Point(15, 16);
            lblBrandIcon.Name = "lblBrandIcon";
            lblBrandIcon.Size = new Size(42, 42);
            lblBrandIcon.TabIndex = 0;
            lblBrandIcon.Text = "☕";
            lblBrandIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 760);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(760, 520);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mộc Café";
            pnlMenu.ResumeLayout(false);
            pnlMenuScroll.ResumeLayout(false);
            pnlMenuItems.ResumeLayout(false);
            pnlMenuFooter.ResumeLayout(false);
            pnlMenuFooter.PerformLayout();
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Panel pnlMenu;
        private Panel pnlBrand;
        private Label lblBrandIcon;
        private Label lblBrandName;
        private Label lblBrandSubtitle;
        private Panel pnlMenuScroll;
        private Panel pnlMenuItems;
        private Button btnMenuDashboard;
        private Button btnMenuTableMap;
        private Button btnMenuPos;
        private Button btnMenuOrders;
        private Button btnMenuInvoices;
        private Button btnMenuProducts;
        private Button btnMenuCategories;
        private Button btnMenuInventory;
        private Button btnMenuVouchers;
        private Button btnMenuStaff;
        private Button btnMenuSchedule;
        private Button btnMenuMyShifts;
        private Button btnMenuTables;
        private Button btnMenuReports;
        private Panel pnlMenuFooter;
        private Label lblNetworkStatus;
        private Label lblOnline;
        private Button btnSignOut;
    }
}
