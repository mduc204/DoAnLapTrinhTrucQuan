namespace DoAnLapTrinhTrucQuan
{
    partial class UcS01
    {
        private void InitializeComponent()
        {
            tlpHeader = new TableLayoutPanel();
            flpHeaderLeft = new FlowLayoutPanel();
            lblPageTitle = new Label();
            txtSearch = new TextBox();
            flpHeaderRight = new FlowLayoutPanel();
            lblAccount = new Label();
            lblRole = new Label();
            lblPrinter = new Label();
            lblConnection = new Label();
            tlpFilters = new TableLayoutPanel();
            tlpStatusBar = new TableLayoutPanel();
            flpStatuses = new FlowLayoutPanel();
            lblEmptyCount = new Label();
            lblServingCount = new Label();
            lblCleaningCount = new Label();
            lblLockedCount = new Label();
            flpActions = new FlowLayoutPanel();
            btnRefresh = new Button();
            btnConfigureTables = new Button();
            flpAreas = new FlowLayoutPanel();
            btnFilterAllAreas = new Button();
            btnFilterIndoor = new Button();
            btnFilterGarden = new Button();
            btnFilterAirConditioned = new Button();
            flpSearch = new FlowLayoutPanel();
            cboTableStatus = new ComboBox();
            txtSearchTable = new TextBox();
            tlpWorkspace = new TableLayoutPanel();
            pnlTableMap = new Panel();
            flpTables = new FlowLayoutPanel();
            tlpAreaSummary = new TableLayoutPanel();
            lblIndoorSummary = new Label();
            lblGardenSummary = new Label();
            lblAirConditionedSummary = new Label();
            pnlTableDetails = new Panel();
            tlpTableDetails = new TableLayoutPanel();
            tlpHeader.SuspendLayout();
            flpHeaderLeft.SuspendLayout();
            flpHeaderRight.SuspendLayout();
            tlpFilters.SuspendLayout();
            tlpStatusBar.SuspendLayout();
            flpStatuses.SuspendLayout();
            flpActions.SuspendLayout();
            flpAreas.SuspendLayout();
            flpSearch.SuspendLayout();
            tlpWorkspace.SuspendLayout();
            pnlTableMap.SuspendLayout();
            tlpAreaSummary.SuspendLayout();
            pnlTableDetails.SuspendLayout();
            SuspendLayout();
            // 
            // tlpHeader
            // 
            tlpHeader.BackColor = Color.White;
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpHeader.Controls.Add(flpHeaderLeft, 0, 0);
            tlpHeader.Controls.Add(flpHeaderRight, 1, 0);
            tlpHeader.Dock = DockStyle.Top;
            tlpHeader.Location = new Point(0, 0);
            tlpHeader.Margin = new Padding(0);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.Padding = new Padding(8, 8, 4, 2);
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Size = new Size(1050, 47);
            tlpHeader.TabIndex = 2;
            // 
            // flpHeaderLeft
            // 
            flpHeaderLeft.AutoSize = true;
            flpHeaderLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpHeaderLeft.Controls.Add(lblPageTitle);
            flpHeaderLeft.Controls.Add(txtSearch);
            flpHeaderLeft.Dock = DockStyle.Fill;
            flpHeaderLeft.Location = new Point(8, 8);
            flpHeaderLeft.Margin = new Padding(0);
            flpHeaderLeft.Name = "flpHeaderLeft";
            flpHeaderLeft.Size = new Size(570, 37);
            flpHeaderLeft.TabIndex = 0;
            flpHeaderLeft.WrapContents = false;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(47, 25, 17);
            lblPageTitle.Location = new Point(0, 1);
            lblPageTitle.Margin = new Padding(0, 1, 4, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Padding = new Padding(6, 3, 6, 3);
            lblPageTitle.Size = new Size(194, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Mộc Café  /  Quản lý quán";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.ForeColor = Color.FromArgb(47, 25, 17);
            txtSearch.Location = new Point(202, 3);
            txtSearch.Margin = new Padding(4, 3, 6, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm bàn…";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 1;
            // 
            // flpHeaderRight
            // 
            flpHeaderRight.AutoSize = true;
            flpHeaderRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpHeaderRight.Controls.Add(lblAccount);
            flpHeaderRight.Controls.Add(lblRole);
            flpHeaderRight.Controls.Add(lblPrinter);
            flpHeaderRight.Controls.Add(lblConnection);
            flpHeaderRight.Dock = DockStyle.Fill;
            flpHeaderRight.FlowDirection = FlowDirection.RightToLeft;
            flpHeaderRight.Location = new Point(578, 8);
            flpHeaderRight.Margin = new Padding(0);
            flpHeaderRight.Name = "flpHeaderRight";
            flpHeaderRight.Size = new Size(468, 37);
            flpHeaderRight.TabIndex = 1;
            flpHeaderRight.WrapContents = false;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAccount.ForeColor = Color.FromArgb(47, 25, 17);
            lblAccount.Location = new Point(347, 3);
            lblAccount.Margin = new Padding(0, 3, 3, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Padding = new Padding(6, 3, 6, 3);
            lblAccount.Size = new Size(118, 21);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "Nguyễn Văn Hùng";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.FromArgb(255, 239, 233);
            lblRole.ForeColor = Color.FromArgb(47, 25, 17);
            lblRole.Location = new Point(245, 3);
            lblRole.Margin = new Padding(0, 3, 3, 0);
            lblRole.Name = "lblRole";
            lblRole.Padding = new Padding(6, 3, 6, 3);
            lblRole.Size = new Size(99, 21);
            lblRole.TabIndex = 1;
            lblRole.Text = "Vai trò: Quản lý";
            // 
            // lblPrinter
            // 
            lblPrinter.AutoSize = true;
            lblPrinter.BackColor = Color.FromArgb(255, 239, 233);
            lblPrinter.ForeColor = Color.FromArgb(47, 25, 17);
            lblPrinter.Location = new Point(162, 3);
            lblPrinter.Margin = new Padding(0, 3, 3, 0);
            lblPrinter.Name = "lblPrinter";
            lblPrinter.Padding = new Padding(6, 3, 6, 3);
            lblPrinter.Size = new Size(80, 21);
            lblPrinter.TabIndex = 2;
            lblPrinter.Text = "Máy in POS";
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.BackColor = Color.FromArgb(177, 241, 162);
            lblConnection.ForeColor = Color.FromArgb(47, 25, 17);
            lblConnection.Location = new Point(95, 3);
            lblConnection.Margin = new Padding(0, 3, 3, 0);
            lblConnection.Name = "lblConnection";
            lblConnection.Padding = new Padding(6, 3, 6, 3);
            lblConnection.Size = new Size(64, 21);
            lblConnection.TabIndex = 3;
            lblConnection.Text = "● Online";
            // 
            // tlpFilters
            // 
            tlpFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpFilters.BackColor = Color.FromArgb(255, 239, 233);
            tlpFilters.ColumnCount = 1;
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilters.Controls.Add(tlpStatusBar, 0, 0);
            tlpFilters.Controls.Add(flpAreas, 0, 1);
            tlpFilters.Controls.Add(flpSearch, 0, 2);
            tlpFilters.Dock = DockStyle.Top;
            tlpFilters.Location = new Point(0, 47);
            tlpFilters.Margin = new Padding(0);
            tlpFilters.Name = "tlpFilters";
            tlpFilters.Padding = new Padding(10, 6, 7, 5);
            tlpFilters.RowCount = 3;
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.Size = new Size(1050, 103);
            tlpFilters.TabIndex = 1;
            // 
            // tlpStatusBar
            // 
            tlpStatusBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpStatusBar.ColumnCount = 2;
            tlpStatusBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpStatusBar.ColumnStyles.Add(new ColumnStyle());
            tlpStatusBar.Controls.Add(flpStatuses, 0, 0);
            tlpStatusBar.Controls.Add(flpActions, 1, 0);
            tlpStatusBar.Dock = DockStyle.Fill;
            tlpStatusBar.Location = new Point(10, 6);
            tlpStatusBar.Margin = new Padding(0, 0, 0, 4);
            tlpStatusBar.Name = "tlpStatusBar";
            tlpStatusBar.RowCount = 1;
            tlpStatusBar.RowStyles.Add(new RowStyle());
            tlpStatusBar.Size = new Size(1033, 26);
            tlpStatusBar.TabIndex = 0;
            // 
            // flpStatuses
            // 
            flpStatuses.AutoSize = true;
            flpStatuses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpStatuses.Controls.Add(lblEmptyCount);
            flpStatuses.Controls.Add(lblServingCount);
            flpStatuses.Controls.Add(lblCleaningCount);
            flpStatuses.Controls.Add(lblLockedCount);
            flpStatuses.Dock = DockStyle.Fill;
            flpStatuses.Location = new Point(0, 0);
            flpStatuses.Margin = new Padding(0);
            flpStatuses.Name = "flpStatuses";
            flpStatuses.Size = new Size(847, 27);
            flpStatuses.TabIndex = 0;
            // 
            // lblEmptyCount
            // 
            lblEmptyCount.AutoSize = true;
            lblEmptyCount.BackColor = Color.FromArgb(174, 240, 160);
            lblEmptyCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblEmptyCount.Location = new Point(0, 2);
            lblEmptyCount.Margin = new Padding(0, 2, 5, 2);
            lblEmptyCount.Name = "lblEmptyCount";
            lblEmptyCount.Padding = new Padding(6, 3, 6, 3);
            lblEmptyCount.Size = new Size(78, 21);
            lblEmptyCount.TabIndex = 0;
            lblEmptyCount.Text = "● Trống: 12";
            // 
            // lblServingCount
            // 
            lblServingCount.AutoSize = true;
            lblServingCount.BackColor = Color.FromArgb(255, 219, 190);
            lblServingCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblServingCount.Location = new Point(83, 2);
            lblServingCount.Margin = new Padding(0, 2, 5, 2);
            lblServingCount.Name = "lblServingCount";
            lblServingCount.Padding = new Padding(6, 3, 6, 3);
            lblServingCount.Size = new Size(115, 21);
            lblServingCount.TabIndex = 1;
            lblServingCount.Text = "● Đang phục vụ: 5";
            // 
            // lblCleaningCount
            // 
            lblCleaningCount.AutoSize = true;
            lblCleaningCount.BackColor = Color.FromArgb(254, 224, 214);
            lblCleaningCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblCleaningCount.Location = new Point(203, 2);
            lblCleaningCount.Margin = new Padding(0, 2, 5, 2);
            lblCleaningCount.Name = "lblCleaningCount";
            lblCleaningCount.Padding = new Padding(6, 3, 6, 3);
            lblCleaningCount.Size = new Size(87, 21);
            lblCleaningCount.TabIndex = 2;
            lblCleaningCount.Text = "● Chờ dọn: 2";
            // 
            // lblLockedCount
            // 
            lblLockedCount.AutoSize = true;
            lblLockedCount.BackColor = Color.FromArgb(246, 225, 218);
            lblLockedCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblLockedCount.Location = new Point(295, 2);
            lblLockedCount.Margin = new Padding(0, 2, 5, 2);
            lblLockedCount.Name = "lblLockedCount";
            lblLockedCount.Padding = new Padding(6, 3, 6, 3);
            lblLockedCount.Size = new Size(109, 21);
            lblLockedCount.TabIndex = 3;
            lblLockedCount.Text = "● Ngừng dùng: 1";
            // 
            // flpActions
            // 
            flpActions.AutoSize = true;
            flpActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpActions.Controls.Add(btnRefresh);
            flpActions.Controls.Add(btnConfigureTables);
            flpActions.Dock = DockStyle.Fill;
            flpActions.Location = new Point(847, 0);
            flpActions.Margin = new Padding(0);
            flpActions.Name = "flpActions";
            flpActions.Size = new Size(186, 27);
            flpActions.TabIndex = 1;
            flpActions.WrapContents = false;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(47, 25, 17);
            btnRefresh.Location = new Point(0, 0);
            btnRefresh.Margin = new Padding(0, 0, 6, 0);
            btnRefresh.MinimumSize = new Size(0, 27);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(5, 0, 5, 0);
            btnRefresh.Size = new Size(87, 27);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "↻ Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnConfigureTables
            // 
            btnConfigureTables.AutoSize = true;
            btnConfigureTables.BackColor = Color.White;
            btnConfigureTables.FlatAppearance.BorderSize = 0;
            btnConfigureTables.FlatStyle = FlatStyle.Flat;
            btnConfigureTables.ForeColor = Color.FromArgb(47, 25, 17);
            btnConfigureTables.Location = new Point(93, 0);
            btnConfigureTables.Margin = new Padding(0, 0, 6, 0);
            btnConfigureTables.MinimumSize = new Size(0, 27);
            btnConfigureTables.Name = "btnConfigureTables";
            btnConfigureTables.Padding = new Padding(5, 0, 5, 0);
            btnConfigureTables.Size = new Size(87, 27);
            btnConfigureTables.TabIndex = 1;
            btnConfigureTables.Text = "Cài đặt bàn";
            btnConfigureTables.UseVisualStyleBackColor = false;
            // 
            // flpAreas
            // 
            flpAreas.AutoSize = true;
            flpAreas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpAreas.Controls.Add(btnFilterAllAreas);
            flpAreas.Controls.Add(btnFilterIndoor);
            flpAreas.Controls.Add(btnFilterGarden);
            flpAreas.Controls.Add(btnFilterAirConditioned);
            flpAreas.Dock = DockStyle.Fill;
            flpAreas.Location = new Point(10, 36);
            flpAreas.Margin = new Padding(0, 0, 0, 4);
            flpAreas.Name = "flpAreas";
            flpAreas.Size = new Size(1033, 26);
            flpAreas.TabIndex = 1;
            // 
            // btnFilterAllAreas
            // 
            btnFilterAllAreas.AutoSize = true;
            btnFilterAllAreas.BackColor = Color.White;
            btnFilterAllAreas.FlatAppearance.BorderSize = 0;
            btnFilterAllAreas.FlatStyle = FlatStyle.Flat;
            btnFilterAllAreas.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterAllAreas.Location = new Point(0, 0);
            btnFilterAllAreas.Margin = new Padding(0, 0, 6, 0);
            btnFilterAllAreas.MinimumSize = new Size(0, 27);
            btnFilterAllAreas.Name = "btnFilterAllAreas";
            btnFilterAllAreas.Padding = new Padding(5, 0, 5, 0);
            btnFilterAllAreas.Size = new Size(127, 27);
            btnFilterAllAreas.TabIndex = 0;
            btnFilterAllAreas.Text = "Tất cả khu vực (20)";
            btnFilterAllAreas.UseVisualStyleBackColor = false;
            // 
            // btnFilterIndoor
            // 
            btnFilterIndoor.AutoSize = true;
            btnFilterIndoor.BackColor = Color.FromArgb(253, 229, 220);
            btnFilterIndoor.FlatAppearance.BorderSize = 0;
            btnFilterIndoor.FlatStyle = FlatStyle.Flat;
            btnFilterIndoor.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterIndoor.Location = new Point(133, 0);
            btnFilterIndoor.Margin = new Padding(0, 0, 6, 0);
            btnFilterIndoor.MinimumSize = new Size(0, 27);
            btnFilterIndoor.Name = "btnFilterIndoor";
            btnFilterIndoor.Padding = new Padding(5, 0, 5, 0);
            btnFilterIndoor.Size = new Size(145, 27);
            btnFilterIndoor.TabIndex = 1;
            btnFilterIndoor.Text = "Tầng 1 - Trong nhà (8)";
            btnFilterIndoor.UseVisualStyleBackColor = false;
            // 
            // btnFilterGarden
            // 
            btnFilterGarden.AutoSize = true;
            btnFilterGarden.BackColor = Color.FromArgb(253, 229, 220);
            btnFilterGarden.FlatAppearance.BorderSize = 0;
            btnFilterGarden.FlatStyle = FlatStyle.Flat;
            btnFilterGarden.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterGarden.Location = new Point(284, 0);
            btnFilterGarden.Margin = new Padding(0, 0, 6, 0);
            btnFilterGarden.MinimumSize = new Size(0, 27);
            btnFilterGarden.Name = "btnFilterGarden";
            btnFilterGarden.Padding = new Padding(5, 0, 5, 0);
            btnFilterGarden.Size = new Size(140, 27);
            btnFilterGarden.TabIndex = 2;
            btnFilterGarden.Text = "Tầng 1 - Sân vườn (6)";
            btnFilterGarden.UseVisualStyleBackColor = false;
            // 
            // btnFilterAirConditioned
            // 
            btnFilterAirConditioned.AutoSize = true;
            btnFilterAirConditioned.BackColor = Color.FromArgb(253, 229, 220);
            btnFilterAirConditioned.FlatAppearance.BorderSize = 0;
            btnFilterAirConditioned.FlatStyle = FlatStyle.Flat;
            btnFilterAirConditioned.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterAirConditioned.Location = new Point(430, 0);
            btnFilterAirConditioned.Margin = new Padding(0, 0, 6, 0);
            btnFilterAirConditioned.MinimumSize = new Size(0, 27);
            btnFilterAirConditioned.Name = "btnFilterAirConditioned";
            btnFilterAirConditioned.Padding = new Padding(5, 0, 5, 0);
            btnFilterAirConditioned.Size = new Size(140, 27);
            btnFilterAirConditioned.TabIndex = 3;
            btnFilterAirConditioned.Text = "Tầng 2 - Máy lạnh (6)";
            btnFilterAirConditioned.UseVisualStyleBackColor = false;
            // 
            // flpSearch
            // 
            flpSearch.AutoSize = true;
            flpSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSearch.Controls.Add(cboTableStatus);
            flpSearch.Controls.Add(txtSearchTable);
            flpSearch.Dock = DockStyle.Fill;
            flpSearch.Location = new Point(10, 66);
            flpSearch.Margin = new Padding(0);
            flpSearch.Name = "flpSearch";
            flpSearch.Size = new Size(1033, 32);
            flpSearch.TabIndex = 2;
            // 
            // cboTableStatus
            // 
            cboTableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTableStatus.FormattingEnabled = true;
            cboTableStatus.Location = new Point(0, 3);
            cboTableStatus.Margin = new Padding(0, 3, 5, 0);
            cboTableStatus.Name = "cboTableStatus";
            cboTableStatus.Size = new Size(148, 23);
            cboTableStatus.TabIndex = 0;
            // 
            // txtSearchTable
            // 
            txtSearchTable.BackColor = Color.White;
            txtSearchTable.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTable.ForeColor = Color.FromArgb(47, 25, 17);
            txtSearchTable.Location = new Point(157, 3);
            txtSearchTable.Margin = new Padding(4, 3, 6, 0);
            txtSearchTable.Name = "txtSearchTable";
            txtSearchTable.PlaceholderText = "Tìm số bàn…";
            txtSearchTable.Size = new Size(190, 23);
            txtSearchTable.TabIndex = 1;
            // 
            // tlpWorkspace
            // 
            tlpWorkspace.BackColor = Color.FromArgb(253, 246, 243);
            tlpWorkspace.ColumnCount = 2;
            tlpWorkspace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpWorkspace.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tlpWorkspace.Controls.Add(pnlTableMap, 0, 0);
            tlpWorkspace.Controls.Add(pnlTableDetails, 1, 0);
            tlpWorkspace.Dock = DockStyle.Fill;
            tlpWorkspace.Location = new Point(0, 150);
            tlpWorkspace.Margin = new Padding(0);
            tlpWorkspace.Name = "tlpWorkspace";
            tlpWorkspace.Padding = new Padding(10, 10, 8, 6);
            tlpWorkspace.RowCount = 1;
            tlpWorkspace.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpWorkspace.Size = new Size(1050, 625);
            tlpWorkspace.TabIndex = 0;
            // 
            // pnlTableMap
            // 
            pnlTableMap.Controls.Add(flpTables);
            pnlTableMap.Controls.Add(tlpAreaSummary);
            pnlTableMap.Dock = DockStyle.Fill;
            pnlTableMap.Location = new Point(10, 10);
            pnlTableMap.Margin = new Padding(0, 0, 6, 0);
            pnlTableMap.Name = "pnlTableMap";
            pnlTableMap.Size = new Size(716, 609);
            pnlTableMap.TabIndex = 0;
            // 
            // flpTables
            // 
            flpTables.AutoScroll = true;
            flpTables.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpTables.BackColor = Color.FromArgb(253, 246, 243);
            flpTables.Dock = DockStyle.Fill;
            flpTables.Location = new Point(0, 55);
            flpTables.Margin = new Padding(0);
            flpTables.Name = "flpTables";
            flpTables.Padding = new Padding(0, 7, 0, 0);
            flpTables.Size = new Size(716, 554);
            flpTables.TabIndex = 0;
            // 
            // tlpAreaSummary
            // 
            tlpAreaSummary.ColumnCount = 3;
            tlpAreaSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpAreaSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpAreaSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpAreaSummary.Controls.Add(lblIndoorSummary, 0, 0);
            tlpAreaSummary.Controls.Add(lblGardenSummary, 1, 0);
            tlpAreaSummary.Controls.Add(lblAirConditionedSummary, 2, 0);
            tlpAreaSummary.Dock = DockStyle.Top;
            tlpAreaSummary.Location = new Point(0, 0);
            tlpAreaSummary.Margin = new Padding(0);
            tlpAreaSummary.Name = "tlpAreaSummary";
            tlpAreaSummary.RowCount = 1;
            tlpAreaSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAreaSummary.Size = new Size(716, 55);
            tlpAreaSummary.TabIndex = 1;
            // 
            // lblIndoorSummary
            // 
            lblIndoorSummary.BackColor = Color.FromArgb(255, 239, 233);
            lblIndoorSummary.Dock = DockStyle.Fill;
            lblIndoorSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIndoorSummary.ForeColor = Color.FromArgb(47, 25, 17);
            lblIndoorSummary.Location = new Point(0, 0);
            lblIndoorSummary.Margin = new Padding(0, 0, 5, 0);
            lblIndoorSummary.Name = "lblIndoorSummary";
            lblIndoorSummary.Padding = new Padding(8, 0, 4, 0);
            lblIndoorSummary.Size = new Size(233, 55);
            lblIndoorSummary.TabIndex = 0;
            lblIndoorSummary.Text = "TẦNG 1 - TRONG NHÀ";
            lblIndoorSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGardenSummary
            // 
            lblGardenSummary.BackColor = Color.FromArgb(255, 239, 233);
            lblGardenSummary.Dock = DockStyle.Fill;
            lblGardenSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGardenSummary.ForeColor = Color.FromArgb(47, 25, 17);
            lblGardenSummary.Location = new Point(238, 0);
            lblGardenSummary.Margin = new Padding(0, 0, 5, 0);
            lblGardenSummary.Name = "lblGardenSummary";
            lblGardenSummary.Padding = new Padding(8, 0, 4, 0);
            lblGardenSummary.Size = new Size(233, 55);
            lblGardenSummary.TabIndex = 1;
            lblGardenSummary.Text = "TẦNG 1 - SÂN VƯỜN";
            lblGardenSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAirConditionedSummary
            // 
            lblAirConditionedSummary.BackColor = Color.FromArgb(255, 239, 233);
            lblAirConditionedSummary.Dock = DockStyle.Fill;
            lblAirConditionedSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAirConditionedSummary.ForeColor = Color.FromArgb(47, 25, 17);
            lblAirConditionedSummary.Location = new Point(476, 0);
            lblAirConditionedSummary.Margin = new Padding(0, 0, 5, 0);
            lblAirConditionedSummary.Name = "lblAirConditionedSummary";
            lblAirConditionedSummary.Padding = new Padding(8, 0, 4, 0);
            lblAirConditionedSummary.Size = new Size(235, 55);
            lblAirConditionedSummary.TabIndex = 2;
            lblAirConditionedSummary.Text = "TẦNG 2 - MÁY LẠNH";
            lblAirConditionedSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTableDetails
            // 
            pnlTableDetails.AutoScroll = true;
            pnlTableDetails.BackColor = Color.FromArgb(253, 246, 243);
            pnlTableDetails.Controls.Add(tlpTableDetails);
            pnlTableDetails.Dock = DockStyle.Fill;
            pnlTableDetails.Location = new Point(735, 10);
            pnlTableDetails.Margin = new Padding(3, 0, 0, 0);
            pnlTableDetails.Name = "pnlTableDetails";
            pnlTableDetails.Size = new Size(307, 609);
            pnlTableDetails.TabIndex = 1;
            // 
            // tlpTableDetails
            // 
            tlpTableDetails.AutoSize = true;
            tlpTableDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpTableDetails.BackColor = Color.White;
            tlpTableDetails.ColumnCount = 1;
            tlpTableDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTableDetails.Dock = DockStyle.Top;
            tlpTableDetails.Location = new Point(0, 0);
            tlpTableDetails.Margin = new Padding(0);
            tlpTableDetails.Name = "tlpTableDetails";
            tlpTableDetails.Padding = new Padding(9);
            tlpTableDetails.Size = new Size(307, 18);
            tlpTableDetails.TabIndex = 0;
            // 
            // UcS01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 246, 243);
            Controls.Add(tlpWorkspace);
            Controls.Add(tlpFilters);
            // The main window already provides the shared top bar.
            Controls.Add(tlpHeader);
            tlpHeader.Visible = false;
            Name = "UcS01";
            Size = new Size(1050, 775);
            tlpHeader.ResumeLayout(false);
            tlpHeader.PerformLayout();
            flpHeaderLeft.ResumeLayout(false);
            flpHeaderLeft.PerformLayout();
            flpHeaderRight.ResumeLayout(false);
            flpHeaderRight.PerformLayout();
            tlpFilters.ResumeLayout(false);
            tlpFilters.PerformLayout();
            tlpStatusBar.ResumeLayout(false);
            tlpStatusBar.PerformLayout();
            flpStatuses.ResumeLayout(false);
            flpStatuses.PerformLayout();
            flpActions.ResumeLayout(false);
            flpActions.PerformLayout();
            flpAreas.ResumeLayout(false);
            flpAreas.PerformLayout();
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            tlpWorkspace.ResumeLayout(false);
            pnlTableMap.ResumeLayout(false);
            tlpAreaSummary.ResumeLayout(false);
            pnlTableDetails.ResumeLayout(false);
            pnlTableDetails.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tlpHeader = null!;
        private FlowLayoutPanel flpHeaderLeft = null!;
        private FlowLayoutPanel flpHeaderRight = null!;
        private Label lblPageTitle = null!;
        private TextBox txtSearch = null!;
        private Label lblAccount = null!;
        private Label lblRole = null!;
        private Label lblPrinter = null!;
        private Label lblConnection = null!;
        private TableLayoutPanel tlpFilters = null!;
        private TableLayoutPanel tlpStatusBar = null!;
        private FlowLayoutPanel flpStatuses = null!;
        private Label lblEmptyCount = null!;
        private Label lblServingCount = null!;
        private Label lblCleaningCount = null!;
        private Label lblLockedCount = null!;
        private FlowLayoutPanel flpActions = null!;
        private Button btnRefresh = null!;
        private Button btnConfigureTables = null!;
        private FlowLayoutPanel flpAreas = null!;
        private Button btnFilterAllAreas = null!;
        private Button btnFilterIndoor = null!;
        private Button btnFilterGarden = null!;
        private Button btnFilterAirConditioned = null!;
        private FlowLayoutPanel flpSearch = null!;
        private ComboBox cboTableStatus = null!;
        private TextBox txtSearchTable = null!;
        private TableLayoutPanel tlpWorkspace = null!;
        private Panel pnlTableMap = null!;
        private FlowLayoutPanel flpTables = null!;
        private TableLayoutPanel tlpAreaSummary = null!;
        private Label lblIndoorSummary = null!;
        private Label lblGardenSummary = null!;
        private Label lblAirConditionedSummary = null!;
        private Panel pnlTableDetails = null!;
        private TableLayoutPanel tlpTableDetails = null!;
    }
}
