namespace DoAnLapTrinhTrucQuan;

partial class UcS05
{
    private void InitializeComponent()
    {
        tlpPage = new TableLayoutPanel();
        tlpHeader = new TableLayoutPanel();
        lblTitle = new Label();
        btnRefresh = new Button();
        btnExportExcel = new Button();
        tlpFilters = new TableLayoutPanel();
        txtSearch = new TextBox();
        cboService = new ComboBox();
        cboMethod = new ComboBox();
        dtpFrom = new DateTimePicker();
        dtpTo = new DateTimePicker();
        lblSummary = new Label();
        tlpBody = new TableLayoutPanel();
        dgvInvoices = new DataGridView();
        tlpDetail = new TableLayoutPanel();
        lblDetail = new Label();
        txtReceipt = new RichTextBox();
        btnPrint = new Button();
        tlpPage.SuspendLayout();
        tlpHeader.SuspendLayout();
        tlpFilters.SuspendLayout();
        tlpBody.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
        tlpDetail.SuspendLayout();
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
        tlpHeader.Controls.Add(btnExportExcel, 2, 0);
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
        lblTitle.Text = "Mộc Café   /   Hóa đơn";
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
        // btnExportExcel
        // 
        btnExportExcel.BackColor = Color.FromArgb(86, 54, 36);
        btnExportExcel.Dock = DockStyle.Fill;
        btnExportExcel.FlatAppearance.BorderSize = 0;
        btnExportExcel.FlatStyle = FlatStyle.Flat;
        btnExportExcel.ForeColor = Color.White;
        btnExportExcel.Location = new Point(818, 3);
        btnExportExcel.Name = "btnExportExcel";
        btnExportExcel.Size = new Size(139, 38);
        btnExportExcel.TabIndex = 2;
        btnExportExcel.Text = "Xuất Excel";
        btnExportExcel.UseVisualStyleBackColor = false;
        // 
        // tlpFilters
        // 
        tlpFilters.ColumnCount = 5;
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
        tlpFilters.Controls.Add(txtSearch, 0, 0);
        tlpFilters.Controls.Add(cboService, 1, 0);
        tlpFilters.Controls.Add(cboMethod, 2, 0);
        tlpFilters.Controls.Add(dtpFrom, 3, 0);
        tlpFilters.Controls.Add(dtpTo, 4, 0);
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
        txtSearch.PlaceholderText = "Tìm hóa đơn, mã đơn, bàn…";
        txtSearch.Size = new Size(272, 23);
        txtSearch.TabIndex = 0;
        // 
        // cboService
        // 
        cboService.Dock = DockStyle.Fill;
        cboService.DropDownStyle = ComboBoxStyle.DropDownList;
        cboService.Location = new Point(281, 3);
        cboService.Name = "cboService";
        cboService.Size = new Size(176, 23);
        cboService.TabIndex = 1;
        // 
        // cboMethod
        // 
        cboMethod.Dock = DockStyle.Fill;
        cboMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMethod.Location = new Point(463, 3);
        cboMethod.Name = "cboMethod";
        cboMethod.Size = new Size(205, 23);
        cboMethod.TabIndex = 2;
        // 
        // dtpFrom
        // 
        dtpFrom.Dock = DockStyle.Fill;
        dtpFrom.Format = DateTimePickerFormat.Short;
        dtpFrom.Location = new Point(674, 3);
        dtpFrom.Name = "dtpFrom";
        dtpFrom.Size = new Size(138, 23);
        dtpFrom.TabIndex = 3;
        // 
        // dtpTo
        // 
        dtpTo.Dock = DockStyle.Fill;
        dtpTo.Format = DateTimePickerFormat.Short;
        dtpTo.Location = new Point(818, 3);
        dtpTo.Name = "dtpTo";
        dtpTo.Size = new Size(139, 23);
        dtpTo.TabIndex = 4;
        // 
        // lblSummary
        // 
        lblSummary.Dock = DockStyle.Fill;
        lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblSummary.Location = new Point(3, 84);
        lblSummary.Name = "lblSummary";
        lblSummary.Size = new Size(954, 44);
        lblSummary.TabIndex = 2;
        lblSummary.Text = "Tổng doanh thu";
        lblSummary.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tlpBody
        // 
        tlpBody.ColumnCount = 2;
        tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
        tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
        tlpBody.Controls.Add(dgvInvoices, 0, 0);
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
        // dgvInvoices
        // 
        dgvInvoices.AllowUserToAddRows = false;
        dgvInvoices.AllowUserToDeleteRows = false;
        dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvInvoices.BackgroundColor = Color.White;
        dgvInvoices.BorderStyle = BorderStyle.None;
        dgvInvoices.Dock = DockStyle.Fill;
        dgvInvoices.Location = new Point(3, 3);
        dgvInvoices.MultiSelect = false;
        dgvInvoices.Name = "dgvInvoices";
        dgvInvoices.ReadOnly = true;
        dgvInvoices.RowHeadersVisible = false;
        dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvInvoices.Size = new Size(608, 566);
        dgvInvoices.TabIndex = 0;
        // 
        // tlpDetail
        // 
        tlpDetail.ColumnCount = 1;
        tlpDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpDetail.Controls.Add(lblDetail, 0, 0);
        tlpDetail.Controls.Add(txtReceipt, 0, 1);
        tlpDetail.Controls.Add(btnPrint, 0, 2);
        tlpDetail.Dock = DockStyle.Fill;
        tlpDetail.Location = new Point(614, 0);
        tlpDetail.Margin = new Padding(0);
        tlpDetail.Name = "tlpDetail";
        tlpDetail.RowCount = 3;
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
        tlpDetail.Size = new Size(346, 572);
        tlpDetail.TabIndex = 1;
        // 
        // lblDetail
        // 
        lblDetail.Dock = DockStyle.Fill;
        lblDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDetail.Location = new Point(3, 0);
        lblDetail.Name = "lblDetail";
        lblDetail.Size = new Size(340, 44);
        lblDetail.TabIndex = 0;
        lblDetail.Text = "Phiếu thanh toán";
        lblDetail.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtReceipt
        // 
        txtReceipt.BackColor = Color.White;
        txtReceipt.BorderStyle = BorderStyle.None;
        txtReceipt.Dock = DockStyle.Fill;
        txtReceipt.Font = new Font("Consolas", 10F);
        txtReceipt.Location = new Point(3, 47);
        txtReceipt.Name = "txtReceipt";
        txtReceipt.ReadOnly = true;
        txtReceipt.Size = new Size(340, 478);
        txtReceipt.TabIndex = 1;
        txtReceipt.Text = "";
        // 
        // btnPrint
        // 
        btnPrint.BackColor = Color.FromArgb(86, 54, 36);
        btnPrint.Dock = DockStyle.Fill;
        btnPrint.FlatAppearance.BorderSize = 0;
        btnPrint.FlatStyle = FlatStyle.Flat;
        btnPrint.ForeColor = Color.White;
        btnPrint.Location = new Point(3, 531);
        btnPrint.Name = "btnPrint";
        btnPrint.Size = new Size(340, 38);
        btnPrint.TabIndex = 2;
        btnPrint.Text = "In lại hóa đơn";
        btnPrint.UseVisualStyleBackColor = false;
        // 
        // UcS05
        // 
        BackColor = Color.FromArgb(252, 246, 242);
        Controls.Add(tlpPage);
        Name = "UcS05";
        Padding = new Padding(10);
        Size = new Size(980, 720);
        tlpPage.ResumeLayout(false);
        tlpHeader.ResumeLayout(false);
        tlpFilters.ResumeLayout(false);
        tlpFilters.PerformLayout();
        tlpBody.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
        tlpDetail.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TableLayoutPanel tlpPage = null!;
    private TableLayoutPanel tlpHeader = null!;
    private Label lblTitle = null!;
    private Button btnRefresh = null!;
    private Button btnExportExcel = null!;
    private TableLayoutPanel tlpFilters = null!;
    private TextBox txtSearch = null!;
    private ComboBox cboService = null!;
    private ComboBox cboMethod = null!;
    private DateTimePicker dtpFrom = null!;
    private DateTimePicker dtpTo = null!;
    private Label lblSummary = null!;
    private TableLayoutPanel tlpBody = null!;
    private DataGridView dgvInvoices = null!;
    private TableLayoutPanel tlpDetail = null!;
    private Label lblDetail = null!;
    private RichTextBox txtReceipt = null!;
    private Button btnPrint = null!;
}
