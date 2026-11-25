namespace DoAnLapTrinhTrucQuan.UserControls.Sales
{
    partial class ucTableMap
    {
        private void InitializeComponent()
        {
            tlpHeader = new TableLayoutPanel();
            flpHeaderLeft = new FlowLayoutPanel();
            flpHeaderRight = new FlowLayoutPanel();
            lblPageTitle = new Label();
            txtSearch = new TextBox();
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
            SuspendLayout();
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

            // tlpHeader
            tlpHeader.Dock = DockStyle.Top;
            tlpHeader.Margin = new Padding(0);
            tlpHeader.Height = 47;
            tlpHeader.BackColor = Color.White;
            tlpHeader.Padding = new Padding(8, 8, 4, 2);
            tlpHeader.Name = "tlpHeader";
            tlpHeader.ColumnCount = 2;
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpHeader.RowCount = 1;
            tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHeader.Controls.Add(flpHeaderLeft, 0, 0);
            tlpHeader.Controls.Add(flpHeaderRight, 1, 0);

            // flpHeaderLeft
            flpHeaderLeft.AutoSize = true;
            flpHeaderLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpHeaderLeft.Dock = DockStyle.Fill;
            flpHeaderLeft.Margin = new Padding(0);
            flpHeaderLeft.WrapContents = false;
            flpHeaderLeft.Name = "flpHeaderLeft";
            flpHeaderLeft.Controls.Add(lblPageTitle);
            flpHeaderLeft.Controls.Add(txtSearch);

            // flpHeaderRight
            flpHeaderRight.AutoSize = true;
            flpHeaderRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpHeaderRight.Dock = DockStyle.Fill;
            flpHeaderRight.Margin = new Padding(0);
            flpHeaderRight.FlowDirection = FlowDirection.RightToLeft;
            flpHeaderRight.WrapContents = false;
            flpHeaderRight.Name = "flpHeaderRight";
            flpHeaderRight.Controls.Add(lblAccount);
            flpHeaderRight.Controls.Add(lblRole);
            flpHeaderRight.Controls.Add(lblPrinter);
            flpHeaderRight.Controls.Add(lblConnection);

            // lblPageTitle
            lblPageTitle.AutoSize = true;
            lblPageTitle.ForeColor = Color.FromArgb(47, 25, 17);
            lblPageTitle.Text = "Mộc Café  /  Quản lý quán";
            lblPageTitle.Margin = new Padding(0, 1, 4, 0);
            lblPageTitle.Padding = new Padding(6, 3, 6, 3);
            lblPageTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageTitle.Name = "lblPageTitle";

            // txtSearch
            txtSearch.PlaceholderText = "Tìm kiếm bàn…";
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.BackColor = Color.White;
            txtSearch.ForeColor = Color.FromArgb(47, 25, 17);
            txtSearch.Margin = new Padding(4, 3, 6, 0);
            txtSearch.Size = new Size(150, 23);
            txtSearch.Name = "txtSearch";

            // lblAccount
            lblAccount.AutoSize = true;
            lblAccount.ForeColor = Color.FromArgb(47, 25, 17);
            lblAccount.Text = "Nguyễn Văn Hùng";
            lblAccount.Margin = new Padding(0, 3, 3, 0);
            lblAccount.Padding = new Padding(6, 3, 6, 3);
            lblAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAccount.Name = "lblAccount";

            // lblRole
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.FromArgb(47, 25, 17);
            lblRole.Text = "Vai trò: Quản lý";
            lblRole.Margin = new Padding(0, 3, 3, 0);
            lblRole.Padding = new Padding(6, 3, 6, 3);
            lblRole.BackColor = Color.FromArgb(255, 239, 233);
            lblRole.Name = "lblRole";

            // lblPrinter
            lblPrinter.AutoSize = true;
            lblPrinter.ForeColor = Color.FromArgb(47, 25, 17);
            lblPrinter.Text = "Máy in POS";
            lblPrinter.Margin = new Padding(0, 3, 3, 0);
            lblPrinter.Padding = new Padding(6, 3, 6, 3);
            lblPrinter.BackColor = Color.FromArgb(255, 239, 233);
            lblPrinter.Name = "lblPrinter";

            // lblConnection
            lblConnection.AutoSize = true;
            lblConnection.ForeColor = Color.FromArgb(47, 25, 17);
            lblConnection.Text = "● Online";
            lblConnection.Margin = new Padding(0, 3, 3, 0);
            lblConnection.Padding = new Padding(6, 3, 6, 3);
            lblConnection.BackColor = Color.FromArgb(177, 241, 162);
            lblConnection.Name = "lblConnection";

            // tlpFilters
            tlpFilters.Dock = DockStyle.Top;
            tlpFilters.Margin = new Padding(0);
            tlpFilters.Height = 103;
            tlpFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpFilters.BackColor = Color.FromArgb(255, 239, 233);
            tlpFilters.Padding = new Padding(10, 6, 7, 5);
            tlpFilters.Name = "tlpFilters";
            tlpFilters.ColumnCount = 1;
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilters.RowCount = 3;
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFilters.Controls.Add(tlpStatusBar, 0, 0);
            tlpFilters.Controls.Add(flpAreas, 0, 1);
            tlpFilters.Controls.Add(flpSearch, 0, 2);

            // tlpStatusBar
            tlpStatusBar.Dock = DockStyle.Fill;
            tlpStatusBar.Margin = new Padding(0, 0, 0, 4);
            tlpStatusBar.AutoSize = false;
            tlpStatusBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpStatusBar.Name = "tlpStatusBar";
            tlpStatusBar.ColumnCount = 2;
            tlpStatusBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpStatusBar.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpStatusBar.RowCount = 1;
            tlpStatusBar.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpStatusBar.Controls.Add(flpStatuses, 0, 0);
            tlpStatusBar.Controls.Add(flpActions, 1, 0);

            // flpStatuses
            flpStatuses.AutoSize = true;
            flpStatuses.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpStatuses.Dock = DockStyle.Fill;
            flpStatuses.Margin = new Padding(0);
            flpStatuses.Name = "flpStatuses";
            flpStatuses.Controls.Add(lblEmptyCount);
            flpStatuses.Controls.Add(lblServingCount);
            flpStatuses.Controls.Add(lblCleaningCount);
            flpStatuses.Controls.Add(lblLockedCount);

            // lblEmptyCount
            lblEmptyCount.AutoSize = true;
            lblEmptyCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblEmptyCount.Text = "● Trống: 12";
            lblEmptyCount.Margin = new Padding(0, 2, 5, 2);
            lblEmptyCount.Padding = new Padding(6, 3, 6, 3);
            lblEmptyCount.BackColor = Color.FromArgb(174, 240, 160);
            lblEmptyCount.Name = "lblEmptyCount";

            // lblServingCount
            lblServingCount.AutoSize = true;
            lblServingCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblServingCount.Text = "● Đang phục vụ: 5";
            lblServingCount.Margin = new Padding(0, 2, 5, 2);
            lblServingCount.Padding = new Padding(6, 3, 6, 3);
            lblServingCount.BackColor = Color.FromArgb(255, 219, 190);
            lblServingCount.Name = "lblServingCount";

            // lblCleaningCount
            lblCleaningCount.AutoSize = true;
            lblCleaningCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblCleaningCount.Text = "● Chờ dọn: 2";
            lblCleaningCount.Margin = new Padding(0, 2, 5, 2);
            lblCleaningCount.Padding = new Padding(6, 3, 6, 3);
            lblCleaningCount.BackColor = Color.FromArgb(254, 224, 214);
            lblCleaningCount.Name = "lblCleaningCount";

            // lblLockedCount
            lblLockedCount.AutoSize = true;
            lblLockedCount.ForeColor = Color.FromArgb(47, 25, 17);
            lblLockedCount.Text = "● Ngừng dùng: 1";
            lblLockedCount.Margin = new Padding(0, 2, 5, 2);
            lblLockedCount.Padding = new Padding(6, 3, 6, 3);
            lblLockedCount.BackColor = Color.FromArgb(246, 225, 218);
            lblLockedCount.Name = "lblLockedCount";

            // flpActions
            flpActions.AutoSize = true;
            flpActions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpActions.Dock = DockStyle.Fill;
            flpActions.Margin = new Padding(0);
            flpActions.WrapContents = false;
            flpActions.Name = "flpActions";
            flpActions.Controls.Add(btnRefresh);
            flpActions.Controls.Add(btnConfigureTables);

            // btnRefresh
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.White;
            btnRefresh.ForeColor = Color.FromArgb(47, 25, 17);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Text = "↻ Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Margin = new Padding(0, 0, 6, 0);
            btnRefresh.Padding = new Padding(5, 0, 5, 0);
            btnRefresh.MinimumSize = new Size(0, 27);
            btnRefresh.Name = "btnRefresh";

            // btnConfigureTables
            btnConfigureTables.AutoSize = true;
            btnConfigureTables.BackColor = Color.White;
            btnConfigureTables.ForeColor = Color.FromArgb(47, 25, 17);
            btnConfigureTables.FlatStyle = FlatStyle.Flat;
            btnConfigureTables.FlatAppearance.BorderSize = 0;
            btnConfigureTables.Text = "Cài đặt bàn";
            btnConfigureTables.UseVisualStyleBackColor = false;
            btnConfigureTables.Margin = new Padding(0, 0, 6, 0);
            btnConfigureTables.Padding = new Padding(5, 0, 5, 0);
            btnConfigureTables.MinimumSize = new Size(0, 27);
            btnConfigureTables.Name = "btnConfigureTables";

            // flpAreas
            flpAreas.AutoSize = true;
            flpAreas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpAreas.Dock = DockStyle.Fill;
            flpAreas.Margin = new Padding(0, 0, 0, 4);
            flpAreas.Name = "flpAreas";
            flpAreas.Controls.Add(btnFilterAllAreas);
            flpAreas.Controls.Add(btnFilterIndoor);
            flpAreas.Controls.Add(btnFilterGarden);
            flpAreas.Controls.Add(btnFilterAirConditioned);

            // btnFilterAllAreas
            btnFilterAllAreas.AutoSize = true;
            btnFilterAllAreas.BackColor = Color.White;
            btnFilterAllAreas.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterAllAreas.FlatStyle = FlatStyle.Flat;
            btnFilterAllAreas.FlatAppearance.BorderSize = 0;
            btnFilterAllAreas.Text = "Tất cả khu vực (20)";
            btnFilterAllAreas.UseVisualStyleBackColor = false;
            btnFilterAllAreas.Margin = new Padding(0, 0, 6, 0);
            btnFilterAllAreas.Padding = new Padding(5, 0, 5, 0);
            btnFilterAllAreas.MinimumSize = new Size(0, 27);
            btnFilterAllAreas.Name = "btnFilterAllAreas";

            // btnFilterIndoor
            btnFilterIndoor.AutoSize = true;
            btnFilterIndoor.BackColor = Color.FromArgb(253, 229, 220);
            btnFilterIndoor.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterIndoor.FlatStyle = FlatStyle.Flat;
            btnFilterIndoor.FlatAppearance.BorderSize = 0;
            btnFilterIndoor.Text = "Tầng 1 - Trong nhà (8)";
            btnFilterIndoor.UseVisualStyleBackColor = false;
            btnFilterIndoor.Margin = new Padding(0, 0, 6, 0);
            btnFilterIndoor.Padding = new Padding(5, 0, 5, 0);
            btnFilterIndoor.MinimumSize = new Size(0, 27);
            btnFilterIndoor.Name = "btnFilterIndoor";

            // btnFilterGarden
            btnFilterGarden.AutoSize = true;
            btnFilterGarden.BackColor = Color.FromArgb(253, 229, 220);
            btnFilterGarden.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterGarden.FlatStyle = FlatStyle.Flat;
            btnFilterGarden.FlatAppearance.BorderSize = 0;
            btnFilterGarden.Text = "Tầng 1 - Sân vườn (6)";
            btnFilterGarden.UseVisualStyleBackColor = false;
            btnFilterGarden.Margin = new Padding(0, 0, 6, 0);
            btnFilterGarden.Padding = new Padding(5, 0, 5, 0);
            btnFilterGarden.MinimumSize = new Size(0, 27);
            btnFilterGarden.Name = "btnFilterGarden";

            // btnFilterAirConditioned
            btnFilterAirConditioned.AutoSize = true;
            btnFilterAirConditioned.BackColor = Color.FromArgb(253, 229, 220);
            btnFilterAirConditioned.ForeColor = Color.FromArgb(47, 25, 17);
            btnFilterAirConditioned.FlatStyle = FlatStyle.Flat;
            btnFilterAirConditioned.FlatAppearance.BorderSize = 0;
            btnFilterAirConditioned.Text = "Tầng 2 - Máy lạnh (6)";
            btnFilterAirConditioned.UseVisualStyleBackColor = false;
            btnFilterAirConditioned.Margin = new Padding(0, 0, 6, 0);
            btnFilterAirConditioned.Padding = new Padding(5, 0, 5, 0);
            btnFilterAirConditioned.MinimumSize = new Size(0, 27);
            btnFilterAirConditioned.Name = "btnFilterAirConditioned";

            // flpSearch
            flpSearch.AutoSize = true;
            flpSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpSearch.Dock = DockStyle.Fill;
            flpSearch.Margin = new Padding(0);
            flpSearch.Name = "flpSearch";
            flpSearch.Controls.Add(cboTableStatus);
            flpSearch.Controls.Add(txtSearchTable);

            // cboTableStatus
            cboTableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTableStatus.FormattingEnabled = true;
            cboTableStatus.Size = new Size(148, 23);
            cboTableStatus.Margin = new Padding(0, 3, 5, 0);
            cboTableStatus.Name = "cboTableStatus";

            // txtSearchTable
            txtSearchTable.PlaceholderText = "Tìm số bàn…";
            txtSearchTable.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTable.BackColor = Color.White;
            txtSearchTable.ForeColor = Color.FromArgb(47, 25, 17);
            txtSearchTable.Margin = new Padding(4, 3, 6, 0);
            txtSearchTable.Size = new Size(190, 23);
            txtSearchTable.Name = "txtSearchTable";

            // tlpWorkspace
            tlpWorkspace.Dock = DockStyle.Fill;
            tlpWorkspace.Margin = new Padding(0);
            tlpWorkspace.BackColor = Color.FromArgb(253, 246, 243);
            tlpWorkspace.Padding = new Padding(10, 10, 8, 6);
            tlpWorkspace.Name = "tlpWorkspace";
            tlpWorkspace.ColumnCount = 2;
            tlpWorkspace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpWorkspace.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 310F));
            tlpWorkspace.RowCount = 1;
            tlpWorkspace.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpWorkspace.Controls.Add(pnlTableMap, 0, 0);
            tlpWorkspace.Controls.Add(pnlTableDetails, 1, 0);

            // pnlTableMap
            pnlTableMap.Dock = DockStyle.Fill;
            pnlTableMap.Margin = new Padding(0, 0, 6, 0);
            pnlTableMap.Name = "pnlTableMap";
            pnlTableMap.Controls.Add(flpTables);
            pnlTableMap.Controls.Add(tlpAreaSummary);

            // flpTables
            flpTables.AutoSize = false;
            flpTables.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpTables.Dock = DockStyle.Fill;
            flpTables.Margin = new Padding(0);
            flpTables.AutoScroll = true;
            flpTables.BackColor = Color.FromArgb(253, 246, 243);
            flpTables.Padding = new Padding(0, 7, 0, 0);
            flpTables.Name = "flpTables";

            // tlpAreaSummary
            tlpAreaSummary.Dock = DockStyle.Top;
            tlpAreaSummary.Margin = new Padding(0);
            tlpAreaSummary.Height = 55;
            tlpAreaSummary.Name = "tlpAreaSummary";
            tlpAreaSummary.ColumnCount = 3;
            tlpAreaSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpAreaSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpAreaSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpAreaSummary.RowCount = 1;
            tlpAreaSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAreaSummary.Controls.Add(lblIndoorSummary, 0, 0);
            tlpAreaSummary.Controls.Add(lblGardenSummary, 1, 0);
            tlpAreaSummary.Controls.Add(lblAirConditionedSummary, 2, 0);

            // lblIndoorSummary
            lblIndoorSummary.AutoSize = false;
            lblIndoorSummary.ForeColor = Color.FromArgb(47, 25, 17);
            lblIndoorSummary.Text = "TẦNG 1 - TRONG NHÀ";
            lblIndoorSummary.Margin = new Padding(0, 0, 5, 0);
            lblIndoorSummary.Padding = new Padding(8, 0, 4, 0);
            lblIndoorSummary.BackColor = Color.FromArgb(255, 239, 233);
            lblIndoorSummary.Dock = DockStyle.Fill;
            lblIndoorSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIndoorSummary.TextAlign = ContentAlignment.MiddleLeft;
            lblIndoorSummary.Name = "lblIndoorSummary";

            // lblGardenSummary
            lblGardenSummary.AutoSize = false;
            lblGardenSummary.ForeColor = Color.FromArgb(47, 25, 17);
            lblGardenSummary.Text = "TẦNG 1 - SÂN VƯỜN";
            lblGardenSummary.Margin = new Padding(0, 0, 5, 0);
            lblGardenSummary.Padding = new Padding(8, 0, 4, 0);
            lblGardenSummary.BackColor = Color.FromArgb(255, 239, 233);
            lblGardenSummary.Dock = DockStyle.Fill;
            lblGardenSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGardenSummary.TextAlign = ContentAlignment.MiddleLeft;
            lblGardenSummary.Name = "lblGardenSummary";

            // lblAirConditionedSummary
            lblAirConditionedSummary.AutoSize = false;
            lblAirConditionedSummary.ForeColor = Color.FromArgb(47, 25, 17);
            lblAirConditionedSummary.Text = "TẦNG 2 - MÁY LẠNH";
            lblAirConditionedSummary.Margin = new Padding(0, 0, 5, 0);
            lblAirConditionedSummary.Padding = new Padding(8, 0, 4, 0);
            lblAirConditionedSummary.BackColor = Color.FromArgb(255, 239, 233);
            lblAirConditionedSummary.Dock = DockStyle.Fill;
            lblAirConditionedSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAirConditionedSummary.TextAlign = ContentAlignment.MiddleLeft;
            lblAirConditionedSummary.Name = "lblAirConditionedSummary";

            // pnlTableDetails
            pnlTableDetails.Dock = DockStyle.Fill;
            pnlTableDetails.AutoScroll = true;
            pnlTableDetails.BackColor = Color.FromArgb(253, 246, 243);
            pnlTableDetails.Margin = new Padding(3, 0, 0, 0);
            pnlTableDetails.Name = "pnlTableDetails";
            pnlTableDetails.Controls.Add(tlpTableDetails);

            // tlpTableDetails
            tlpTableDetails.Dock = DockStyle.Top;
            tlpTableDetails.Margin = new Padding(0);
            tlpTableDetails.AutoSize = true;
            tlpTableDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpTableDetails.BackColor = Color.White;
            tlpTableDetails.Padding = new Padding(9);
            tlpTableDetails.ColumnCount = 1;
            tlpTableDetails.Name = "tlpTableDetails";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 246, 243);
            Controls.Add(tlpWorkspace);
            Controls.Add(tlpFilters);
            Controls.Add(tlpHeader);
            Name = "ucTableMap";
            Size = new Size(1050, 775);
            pnlTableDetails.ResumeLayout(false);
            tlpAreaSummary.ResumeLayout(false);
            pnlTableMap.ResumeLayout(false);
            tlpWorkspace.ResumeLayout(false);
            flpSearch.ResumeLayout(false);
            flpAreas.ResumeLayout(false);
            flpActions.ResumeLayout(false);
            flpStatuses.ResumeLayout(false);
            tlpStatusBar.ResumeLayout(false);
            tlpFilters.ResumeLayout(false);
            flpHeaderRight.ResumeLayout(false);
            flpHeaderLeft.ResumeLayout(false);
            tlpHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
