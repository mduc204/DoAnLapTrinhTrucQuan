namespace DoAnLapTrinhTrucQuan;

partial class UcS03
{
    private void InitializeComponent()
    {
        tlpPage = new TableLayoutPanel();
        tlpHeader = new TableLayoutPanel();
        lblTitle = new Label();
        btnRefresh = new Button();
        btnCreateOrder = new Button();
        tlpFilters = new TableLayoutPanel();
        txtSearch = new TextBox();
        cboService = new ComboBox();
        cboPayment = new ComboBox();
        cboKitchen = new ComboBox();
        lblSummary = new Label();
        tlpBody = new TableLayoutPanel();
        dgvOrders = new DataGridView();
        tlpDetail = new TableLayoutPanel();
        lblDetail = new Label();
        dgvItems = new DataGridView();
        btnAdvance = new Button();
        btnPrintKitchen = new Button();
        btnAddItems = new Button();
        btnCancel = new Button();
        tlpPage.SuspendLayout();
        tlpHeader.SuspendLayout();
        tlpFilters.SuspendLayout();
        tlpBody.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
        tlpDetail.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
        SuspendLayout();
        // 
        // tlpPage
        // 
        tlpPage.ColumnCount = 1;
        tlpPage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpPage.Controls.Add(tlpHeader, 0, 0);
        tlpPage.Controls.Add(tlpFilters, 0, 1);
        tlpPage.Controls.Add(lblSummary, 0, 2);
        tlpPage.Controls.Add(tlpBody, 0, 3);
        tlpPage.Dock = DockStyle.Fill;
        tlpPage.Location = new Point(10, 10);
        tlpPage.Margin = new Padding(0);
        tlpPage.Name = "tlpPage";
        tlpPage.RowCount = 4;
        tlpPage.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        tlpPage.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpPage.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        tlpPage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpPage.Size = new Size(960, 700);
        tlpPage.TabIndex = 0;
        // 
        // tlpHeader
        // 
        tlpHeader.ColumnCount = 3;
        tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tlpHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
        tlpHeader.Controls.Add(lblTitle, 0, 0);
        tlpHeader.Controls.Add(btnRefresh, 1, 0);
        tlpHeader.Controls.Add(btnCreateOrder, 2, 0);
        tlpHeader.Dock = DockStyle.Fill;
        tlpHeader.Location = new Point(0, 0);
        tlpHeader.Margin = new Padding(0);
        tlpHeader.Name = "tlpHeader";
        tlpHeader.RowCount = 1;
        tlpHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpHeader.Size = new Size(960, 44);
        tlpHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblTitle.Location = new Point(3, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(689, 44);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Mộc Café   /   Quản lý đơn hàng";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.FromArgb(86, 54, 36);
        btnRefresh.Dock = DockStyle.Fill;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.ForeColor = Color.White;
        btnRefresh.Location = new Point(698, 3);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(114, 38);
        btnRefresh.TabIndex = 1;
        btnRefresh.Text = "Làm mới";
        btnRefresh.UseVisualStyleBackColor = false;
        // 
        // btnCreateOrder
        // 
        btnCreateOrder.BackColor = Color.FromArgb(86, 54, 36);
        btnCreateOrder.Dock = DockStyle.Fill;
        btnCreateOrder.FlatAppearance.BorderSize = 0;
        btnCreateOrder.FlatStyle = FlatStyle.Flat;
        btnCreateOrder.ForeColor = Color.White;
        btnCreateOrder.Location = new Point(818, 3);
        btnCreateOrder.Name = "btnCreateOrder";
        btnCreateOrder.Size = new Size(139, 38);
        btnCreateOrder.TabIndex = 2;
        btnCreateOrder.Text = "Tạo đơn tại quầy";
        btnCreateOrder.UseVisualStyleBackColor = false;
        // 
        // tlpFilters
        // 
        tlpFilters.ColumnCount = 4;
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        tlpFilters.Controls.Add(txtSearch, 0, 0);
        tlpFilters.Controls.Add(cboService, 1, 0);
        tlpFilters.Controls.Add(cboPayment, 2, 0);
        tlpFilters.Controls.Add(cboKitchen, 3, 0);
        tlpFilters.Dock = DockStyle.Fill;
        tlpFilters.Location = new Point(0, 44);
        tlpFilters.Margin = new Padding(0);
        tlpFilters.Name = "tlpFilters";
        tlpFilters.RowCount = 1;
        tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpFilters.Size = new Size(960, 40);
        tlpFilters.TabIndex = 1;
        // 
        // txtSearch
        // 
        txtSearch.Dock = DockStyle.Fill;
        txtSearch.Location = new Point(3, 3);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Tìm mã đơn, bàn…";
        txtSearch.Size = new Size(320, 23);
        txtSearch.TabIndex = 0;
        // 
        // cboService
        // 
        cboService.Dock = DockStyle.Fill;
        cboService.DropDownStyle = ComboBoxStyle.DropDownList;
        cboService.Location = new Point(329, 3);
        cboService.Name = "cboService";
        cboService.Size = new Size(205, 23);
        cboService.TabIndex = 1;
        // 
        // cboPayment
        // 
        cboPayment.Dock = DockStyle.Fill;
        cboPayment.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPayment.Location = new Point(540, 3);
        cboPayment.Name = "cboPayment";
        cboPayment.Size = new Size(205, 23);
        cboPayment.TabIndex = 2;
        // 
        // cboKitchen
        // 
        cboKitchen.Dock = DockStyle.Fill;
        cboKitchen.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKitchen.Location = new Point(751, 3);
        cboKitchen.Name = "cboKitchen";
        cboKitchen.Size = new Size(206, 23);
        cboKitchen.TabIndex = 3;
        // 
        // lblSummary
        // 
        lblSummary.Dock = DockStyle.Fill;
        lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblSummary.Location = new Point(3, 84);
        lblSummary.Name = "lblSummary";
        lblSummary.Size = new Size(954, 44);
        lblSummary.TabIndex = 2;
        lblSummary.Text = "Đơn đang xử lý";
        lblSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tlpBody
        // 
        tlpBody.ColumnCount = 2;
        tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
        tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
        tlpBody.Controls.Add(dgvOrders, 0, 0);
        tlpBody.Controls.Add(tlpDetail, 1, 0);
        tlpBody.Dock = DockStyle.Fill;
        tlpBody.Location = new Point(0, 128);
        tlpBody.Margin = new Padding(0);
        tlpBody.Name = "tlpBody";
        tlpBody.RowCount = 1;
        tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBody.Size = new Size(960, 572);
        tlpBody.TabIndex = 3;
        // 
        // dgvOrders
        // 
        dgvOrders.AllowUserToAddRows = false;
        dgvOrders.AllowUserToDeleteRows = false;
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvOrders.BackgroundColor = Color.White;
        dgvOrders.BorderStyle = BorderStyle.None;
        dgvOrders.Dock = DockStyle.Fill;
        dgvOrders.Location = new Point(3, 3);
        dgvOrders.MultiSelect = false;
        dgvOrders.Name = "dgvOrders";
        dgvOrders.ReadOnly = true;
        dgvOrders.RowHeadersVisible = false;
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvOrders.Size = new Size(608, 566);
        dgvOrders.TabIndex = 0;
        // 
        // tlpDetail
        // 
        tlpDetail.ColumnCount = 1;
        tlpDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpDetail.Controls.Add(lblDetail, 0, 0);
        tlpDetail.Controls.Add(dgvItems, 0, 1);
        tlpDetail.Controls.Add(btnAdvance, 0, 2);
        tlpDetail.Controls.Add(btnPrintKitchen, 0, 3);
        tlpDetail.Controls.Add(btnAddItems, 0, 4);
        tlpDetail.Controls.Add(btnCancel, 0, 5);
        tlpDetail.Dock = DockStyle.Fill;
        tlpDetail.Location = new Point(614, 0);
        tlpDetail.Margin = new Padding(0);
        tlpDetail.Name = "tlpDetail";
        tlpDetail.RowCount = 6;
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tlpDetail.Size = new Size(346, 572);
        tlpDetail.TabIndex = 1;
        // 
        // lblDetail
        // 
        lblDetail.Dock = DockStyle.Fill;
        lblDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDetail.Location = new Point(3, 0);
        lblDetail.Name = "lblDetail";
        lblDetail.Size = new Size(340, 46);
        lblDetail.TabIndex = 0;
        lblDetail.Text = "Chi tiết đơn";
        lblDetail.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dgvItems
        // 
        dgvItems.AllowUserToAddRows = false;
        dgvItems.AllowUserToDeleteRows = false;
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvItems.BackgroundColor = Color.White;
        dgvItems.BorderStyle = BorderStyle.None;
        dgvItems.Dock = DockStyle.Fill;
        dgvItems.Location = new Point(3, 49);
        dgvItems.MultiSelect = false;
        dgvItems.Name = "dgvItems";
        dgvItems.ReadOnly = true;
        dgvItems.RowHeadersVisible = false;
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvItems.Size = new Size(340, 360);
        dgvItems.TabIndex = 1;
        // 
        // btnAdvance
        // 
        btnAdvance.BackColor = Color.FromArgb(86, 54, 36);
        btnAdvance.Dock = DockStyle.Fill;
        btnAdvance.FlatAppearance.BorderSize = 0;
        btnAdvance.FlatStyle = FlatStyle.Flat;
        btnAdvance.ForeColor = Color.White;
        btnAdvance.Location = new Point(3, 415);
        btnAdvance.Name = "btnAdvance";
        btnAdvance.Size = new Size(340, 34);
        btnAdvance.TabIndex = 2;
        btnAdvance.Text = "Bắt đầu chuẩn bị";
        btnAdvance.UseVisualStyleBackColor = false;
        // 
        // btnPrintKitchen
        // 
        btnPrintKitchen.BackColor = Color.FromArgb(86, 54, 36);
        btnPrintKitchen.Dock = DockStyle.Fill;
        btnPrintKitchen.FlatAppearance.BorderSize = 0;
        btnPrintKitchen.FlatStyle = FlatStyle.Flat;
        btnPrintKitchen.ForeColor = Color.White;
        btnPrintKitchen.Location = new Point(3, 455);
        btnPrintKitchen.Name = "btnPrintKitchen";
        btnPrintKitchen.Size = new Size(340, 34);
        btnPrintKitchen.TabIndex = 3;
        btnPrintKitchen.Text = "In danh sách bếp";
        btnPrintKitchen.UseVisualStyleBackColor = false;
        // 
        // btnAddItems
        // 
        btnAddItems.BackColor = Color.FromArgb(86, 54, 36);
        btnAddItems.Dock = DockStyle.Fill;
        btnAddItems.FlatAppearance.BorderSize = 0;
        btnAddItems.FlatStyle = FlatStyle.Flat;
        btnAddItems.ForeColor = Color.White;
        btnAddItems.Location = new Point(3, 495);
        btnAddItems.Name = "btnAddItems";
        btnAddItems.Size = new Size(340, 34);
        btnAddItems.TabIndex = 4;
        btnAddItems.Text = "Gọi thêm món";
        btnAddItems.UseVisualStyleBackColor = false;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.FromArgb(86, 54, 36);
        btnCancel.Dock = DockStyle.Fill;
        btnCancel.FlatAppearance.BorderSize = 0;
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.ForeColor = Color.White;
        btnCancel.Location = new Point(3, 535);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(340, 34);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Hủy đơn";
        btnCancel.UseVisualStyleBackColor = false;
        // 
        // UcS03
        // 
        BackColor = Color.FromArgb(252, 246, 242);
        Controls.Add(tlpPage);
        Name = "UcS03";
        Padding = new Padding(10);
        Size = new Size(980, 720);
        tlpPage.ResumeLayout(false);
        tlpHeader.ResumeLayout(false);
        tlpFilters.ResumeLayout(false);
        tlpFilters.PerformLayout();
        tlpBody.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
        tlpDetail.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
        ResumeLayout(false);
    }

    private TableLayoutPanel tlpPage = null!;
    private TableLayoutPanel tlpHeader = null!;
    private Label lblTitle = null!;
    private Button btnRefresh = null!;
    private Button btnCreateOrder = null!;
    private TableLayoutPanel tlpFilters = null!;
    private TextBox txtSearch = null!;
    private ComboBox cboService = null!;
    private ComboBox cboPayment = null!;
    private ComboBox cboKitchen = null!;
    private Label lblSummary = null!;
    private TableLayoutPanel tlpBody = null!;
    private DataGridView dgvOrders = null!;
    private TableLayoutPanel tlpDetail = null!;
    private Label lblDetail = null!;
    private DataGridView dgvItems = null!;
    private Button btnAdvance = null!;
    private Button btnPrintKitchen = null!;
    private Button btnAddItems = null!;
    private Button btnCancel = null!;
}
