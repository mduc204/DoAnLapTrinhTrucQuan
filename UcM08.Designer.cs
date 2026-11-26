namespace DoAnLapTrinhTrucQuan
{
    partial class UcM08
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlScroll = new Panel();
            pnlContainer = new Panel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnXuatExcel = new Button();
            btnXuatPdf = new Button();
            btnInBaoCao = new Button();
            pnlFilterCard = new Panel();
            pnlTimeTabs = new Panel();
            pnlFilterControls = new Panel();
            lblDateRange = new Label();
            lblCaLabel = new Label();
            cboCa = new ComboBox();
            lblThuNganLabel = new Label();
            cboThuNgan = new ComboBox();
            btnApDung = new Button();
            pnlKpiRow = new Panel();
            pnlKpi1 = new Panel();
            pnlKpi2 = new Panel();
            pnlKpi3 = new Panel();
            pnlKpi4 = new Panel();
            pnlKpi5 = new Panel();
            pnlChartsRow = new Panel();
            pnlHourlyCard = new Panel();
            lblHourlyTitle = new Label();
            lblHourlyLegend = new Label();
            pnlHourlyChart = new DoubleBufferedPanel();
            pnlPaymentCard = new Panel();
            lblPaymentTitle = new Label();
            lblPaymentBadge = new Label();
            pnlDonutChart = new DoubleBufferedPanel();
            pnlPaymentList = new Panel();
            pnlBottomRow = new Panel();
            pnlTop5Card = new Panel();
            lblTop5Title = new Label();
            lblTop5Share = new Label();
            dgvTop5 = new DataGridView();
            pnlTop5Footer = new Panel();
            lblTop5Total = new Label();
            lnkViewAllMenu = new LinkLabel();
            pnlCashCard = new Panel();
            lblCashTitle = new Label();
            lblCashStatusBadge = new Label();
            pnlCashBody = new Panel();
            pnlCashFooter = new Panel();
            lblCashierAvatar = new Label();
            lblCashierName = new Label();
            lblCashierRole = new Label();
            btnXacNhanKetCa = new Button();
            lblKpi1Title = new Label();
            lblKpi1Val = new Label();
            lblKpi1Sub = new Label();
            lblKpi1Badge = new Label();
            lblKpi2Title = new Label();
            lblKpi2Val = new Label();
            lblKpi2Sub = new Label();
            lblKpi2Badge = new Label();
            lblKpi3Title = new Label();
            lblKpi3Val = new Label();
            lblKpi3Sub = new Label();
            lblKpi3Badge = new Label();
            lblKpi4Title = new Label();
            lblKpi4Val = new Label();
            lblKpi4Sub = new Label();
            lblKpi4Badge = new Label();
            lblKpi5Title = new Label();
            lblKpi5Val = new Label();
            lblKpi5Sub = new Label();
            lblKpi5Badge = new Label();
            lblCashOpenVal = new Label();
            lblCashInVal = new Label();
            lblCashOutVal = new Label();
            pnlCashTotalBar = new Panel();
            lblCashTotalVal = new Label();
            pnlCashDiffBar = new Panel();
            lblCashDiffVal = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            pnlScroll.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlFilterCard.SuspendLayout();
            pnlFilterControls.SuspendLayout();
            pnlKpiRow.SuspendLayout();
            pnlChartsRow.SuspendLayout();
            pnlHourlyCard.SuspendLayout();
            pnlPaymentCard.SuspendLayout();
            pnlBottomRow.SuspendLayout();
            pnlTop5Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            pnlTop5Footer.SuspendLayout();
            pnlCashCard.SuspendLayout();
            pnlCashFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.BackColor = Color.FromArgb(250, 247, 243);
            pnlScroll.Controls.Add(pnlContainer);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(0, 0);
            pnlScroll.Margin = new Padding(6, 6, 6, 6);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Size = new Size(2087, 1330);
            pnlScroll.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(250, 247, 243);
            pnlContainer.Controls.Add(pnlHeader);
            pnlContainer.Controls.Add(pnlFilterCard);
            pnlContainer.Controls.Add(pnlKpiRow);
            pnlContainer.Controls.Add(pnlChartsRow);
            pnlContainer.Controls.Add(pnlBottomRow);
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(6, 6, 6, 6);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(37, 30, 37, 43);
            pnlContainer.Size = new Size(2229, 1941);
            pnlContainer.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(250, 247, 243);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnXuatExcel);
            pnlHeader.Controls.Add(btnXuatPdf);
            pnlHeader.Controls.Add(btnInBaoCao);
            pnlHeader.Location = new Point(37, 30);
            pnlHeader.Margin = new Padding(6, 6, 6, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(2154, 141);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(52, 34, 23);
            lblTitle.Location = new Point(0, 21);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(419, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Báo cáo thống kê";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(0, 0);
            btnXuatExcel.Margin = new Padding(6, 6, 6, 6);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(208, 64);
            btnXuatExcel.TabIndex = 1;
            // 
            // btnXuatPdf
            // 
            btnXuatPdf.Location = new Point(0, 0);
            btnXuatPdf.Margin = new Padding(6, 6, 6, 6);
            btnXuatPdf.Name = "btnXuatPdf";
            btnXuatPdf.Size = new Size(193, 64);
            btnXuatPdf.TabIndex = 2;
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.Location = new Point(0, 0);
            btnInBaoCao.Margin = new Padding(6, 6, 6, 6);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(249, 68);
            btnInBaoCao.TabIndex = 3;
            // 
            // pnlFilterCard
            // 
            pnlFilterCard.BackColor = Color.White;
            pnlFilterCard.BorderStyle = BorderStyle.FixedSingle;
            pnlFilterCard.Controls.Add(pnlTimeTabs);
            pnlFilterCard.Controls.Add(pnlFilterControls);
            pnlFilterCard.Location = new Point(37, 175);
            pnlFilterCard.Margin = new Padding(6, 6, 6, 6);
            pnlFilterCard.Name = "pnlFilterCard";
            pnlFilterCard.Size = new Size(2153, 185);
            pnlFilterCard.TabIndex = 1;
            // 
            // pnlTimeTabs
            // 
            pnlTimeTabs.BackColor = Color.Transparent;
            pnlTimeTabs.Location = new Point(22, 17);
            pnlTimeTabs.Margin = new Padding(6, 6, 6, 6);
            pnlTimeTabs.Name = "pnlTimeTabs";
            pnlTimeTabs.Size = new Size(1411, 68);
            pnlTimeTabs.TabIndex = 0;
            // 
            // pnlFilterControls
            // 
            pnlFilterControls.BackColor = Color.Transparent;
            pnlFilterControls.Controls.Add(lblDateRange);
            pnlFilterControls.Controls.Add(lblCaLabel);
            pnlFilterControls.Controls.Add(cboCa);
            pnlFilterControls.Controls.Add(lblThuNganLabel);
            pnlFilterControls.Controls.Add(cboThuNgan);
            pnlFilterControls.Controls.Add(btnApDung);
            pnlFilterControls.Location = new Point(22, 98);
            pnlFilterControls.Margin = new Padding(6, 6, 6, 6);
            pnlFilterControls.Name = "pnlFilterControls";
            pnlFilterControls.Size = new Size(2106, 73);
            pnlFilterControls.TabIndex = 1;
            // 
            // lblDateRange
            // 
            lblDateRange.AutoSize = true;
            lblDateRange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateRange.ForeColor = Color.FromArgb(55, 55, 55);
            lblDateRange.Location = new Point(0, 13);
            lblDateRange.Margin = new Padding(6, 0, 6, 0);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new Size(356, 32);
            lblDateRange.TabIndex = 0;
            lblDateRange.Text = "📅  23/10/2024 – 23/10/2024";
            // 
            // lblCaLabel
            // 
            lblCaLabel.AutoSize = true;
            lblCaLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCaLabel.ForeColor = Color.Gray;
            lblCaLabel.Location = new Point(409, 15);
            lblCaLabel.Margin = new Padding(6, 0, 6, 0);
            lblCaLabel.Name = "lblCaLabel";
            lblCaLabel.Size = new Size(50, 31);
            lblCaLabel.TabIndex = 1;
            lblCaLabel.Text = "CA:";
            // 
            // cboCa
            // 
            cboCa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCa.Font = new Font("Segoe UI", 9F);
            cboCa.Items.AddRange(new object[] { "Cả ngày", "Ca sáng (06:30 - 14:30)", "Ca chiều (14:30 - 22:00)" });
            cboCa.Location = new Point(464, 6);
            cboCa.Margin = new Padding(6, 6, 6, 6);
            cboCa.Name = "cboCa";
            cboCa.Size = new Size(322, 40);
            cboCa.TabIndex = 2;
            // 
            // lblThuNganLabel
            // 
            lblThuNganLabel.AutoSize = true;
            lblThuNganLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblThuNganLabel.ForeColor = Color.Gray;
            lblThuNganLabel.Location = new Point(826, 15);
            lblThuNganLabel.Margin = new Padding(6, 0, 6, 0);
            lblThuNganLabel.Name = "lblThuNganLabel";
            lblThuNganLabel.Size = new Size(142, 31);
            lblThuNganLabel.TabIndex = 3;
            lblThuNganLabel.Text = "THU NGÂN:";
            // 
            // cboThuNgan
            // 
            cboThuNgan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuNgan.Font = new Font("Segoe UI", 9F);
            cboThuNgan.Items.AddRange(new object[] { "Tất cả nhân viên", "Nguyễn Văn Hưng", "Lê Mỹ Hạnh", "Trần Đình Nam" });
            cboThuNgan.Location = new Point(969, 6);
            cboThuNgan.Margin = new Padding(6, 6, 6, 6);
            cboThuNgan.Name = "cboThuNgan";
            cboThuNgan.Size = new Size(340, 40);
            cboThuNgan.TabIndex = 4;
            // 
            // btnApDung
            // 
            btnApDung.Location = new Point(1894, 2);
            btnApDung.Margin = new Padding(6, 6, 6, 6);
            btnApDung.Name = "btnApDung";
            btnApDung.Size = new Size(195, 60);
            btnApDung.TabIndex = 5;
            // 
            // pnlKpiRow
            // 
            pnlKpiRow.BackColor = Color.Transparent;
            pnlKpiRow.Controls.Add(pnlKpi1);
            pnlKpiRow.Controls.Add(pnlKpi2);
            pnlKpiRow.Controls.Add(pnlKpi3);
            pnlKpiRow.Controls.Add(pnlKpi4);
            pnlKpiRow.Controls.Add(pnlKpi5);
            pnlKpiRow.Location = new Point(37, 388);
            pnlKpiRow.Margin = new Padding(6, 6, 6, 6);
            pnlKpiRow.Name = "pnlKpiRow";
            pnlKpiRow.Size = new Size(2154, 239);
            pnlKpiRow.TabIndex = 2;
            // 
            // pnlKpi1
            // 
            pnlKpi1.Location = new Point(0, 0);
            pnlKpi1.Margin = new Padding(6, 6, 6, 6);
            pnlKpi1.Name = "pnlKpi1";
            pnlKpi1.Size = new Size(371, 213);
            pnlKpi1.TabIndex = 0;
            // 
            // pnlKpi2
            // 
            pnlKpi2.Location = new Point(0, 0);
            pnlKpi2.Margin = new Padding(6, 6, 6, 6);
            pnlKpi2.Name = "pnlKpi2";
            pnlKpi2.Size = new Size(371, 213);
            pnlKpi2.TabIndex = 1;
            // 
            // pnlKpi3
            // 
            pnlKpi3.Location = new Point(0, 0);
            pnlKpi3.Margin = new Padding(6, 6, 6, 6);
            pnlKpi3.Name = "pnlKpi3";
            pnlKpi3.Size = new Size(371, 213);
            pnlKpi3.TabIndex = 2;
            // 
            // pnlKpi4
            // 
            pnlKpi4.Location = new Point(0, 0);
            pnlKpi4.Margin = new Padding(6, 6, 6, 6);
            pnlKpi4.Name = "pnlKpi4";
            pnlKpi4.Size = new Size(371, 213);
            pnlKpi4.TabIndex = 3;
            // 
            // pnlKpi5
            // 
            pnlKpi5.Location = new Point(0, 0);
            pnlKpi5.Margin = new Padding(6, 6, 6, 6);
            pnlKpi5.Name = "pnlKpi5";
            pnlKpi5.Size = new Size(371, 213);
            pnlKpi5.TabIndex = 4;
            // 
            // pnlChartsRow
            // 
            pnlChartsRow.BackColor = Color.Transparent;
            pnlChartsRow.Controls.Add(pnlHourlyCard);
            pnlChartsRow.Controls.Add(pnlPaymentCard);
            pnlChartsRow.Location = new Point(37, 653);
            pnlChartsRow.Margin = new Padding(6, 6, 6, 6);
            pnlChartsRow.Name = "pnlChartsRow";
            pnlChartsRow.Size = new Size(2154, 619);
            pnlChartsRow.TabIndex = 3;
            // 
            // pnlHourlyCard
            // 
            pnlHourlyCard.BackColor = Color.White;
            pnlHourlyCard.BorderStyle = BorderStyle.FixedSingle;
            pnlHourlyCard.Controls.Add(lblHourlyTitle);
            pnlHourlyCard.Controls.Add(lblHourlyLegend);
            pnlHourlyCard.Controls.Add(pnlHourlyChart);
            pnlHourlyCard.Location = new Point(0, 0);
            pnlHourlyCard.Margin = new Padding(6, 6, 6, 6);
            pnlHourlyCard.Name = "pnlHourlyCard";
            pnlHourlyCard.Size = new Size(370, 211);
            pnlHourlyCard.TabIndex = 0;
            // 
            // lblHourlyTitle
            // 
            lblHourlyTitle.AutoSize = true;
            lblHourlyTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHourlyTitle.ForeColor = Color.FromArgb(45, 30, 20);
            lblHourlyTitle.Location = new Point(26, 26);
            lblHourlyTitle.Margin = new Padding(6, 0, 6, 0);
            lblHourlyTitle.Name = "lblHourlyTitle";
            lblHourlyTitle.Size = new Size(351, 41);
            lblHourlyTitle.TabIndex = 0;
            lblHourlyTitle.Text = "📊  Doanh thu theo giờ";
            // 
            // lblHourlyLegend
            // 
            lblHourlyLegend.AutoSize = true;
            lblHourlyLegend.Font = new Font("Segoe UI", 8.5F);
            lblHourlyLegend.ForeColor = Color.FromArgb(100, 90, 80);
            lblHourlyLegend.Location = new Point(0, 0);
            lblHourlyLegend.Margin = new Padding(6, 0, 6, 0);
            lblHourlyLegend.Name = "lblHourlyLegend";
            lblHourlyLegend.Size = new Size(332, 31);
            lblHourlyLegend.TabIndex = 1;
            lblHourlyLegend.Text = "● Giờ thường    ● Giờ cao điểm";
            // 
            // pnlPaymentCard
            // 
            pnlPaymentCard.BackColor = Color.White;
            pnlPaymentCard.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentCard.Controls.Add(lblPaymentTitle);
            pnlPaymentCard.Controls.Add(lblPaymentBadge);
            pnlPaymentCard.Controls.Add(pnlDonutChart);
            pnlPaymentCard.Controls.Add(pnlPaymentList);
            pnlPaymentCard.Location = new Point(0, 0);
            pnlPaymentCard.Margin = new Padding(6, 6, 6, 6);
            pnlPaymentCard.Name = "pnlPaymentCard";
            pnlPaymentCard.Size = new Size(370, 211);
            pnlPaymentCard.TabIndex = 1;
            // 
            // lblPaymentTitle
            // 
            lblPaymentTitle.AutoSize = true;
            lblPaymentTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPaymentTitle.ForeColor = Color.FromArgb(45, 30, 20);
            lblPaymentTitle.Location = new Point(26, 26);
            lblPaymentTitle.Margin = new Padding(6, 0, 6, 0);
            lblPaymentTitle.Name = "lblPaymentTitle";
            lblPaymentTitle.Size = new Size(317, 41);
            lblPaymentTitle.TabIndex = 0;
            lblPaymentTitle.Text = "◔  Cơ cấu thanh toán";
            // 
            // lblPaymentBadge
            // 
            lblPaymentBadge.AutoSize = true;
            lblPaymentBadge.BackColor = Color.FromArgb(245, 240, 235);
            lblPaymentBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPaymentBadge.ForeColor = Color.FromArgb(100, 80, 65);
            lblPaymentBadge.Location = new Point(0, 0);
            lblPaymentBadge.Margin = new Padding(6, 0, 6, 0);
            lblPaymentBadge.Name = "lblPaymentBadge";
            lblPaymentBadge.Padding = new Padding(11, 4, 11, 4);
            lblPaymentBadge.Size = new Size(138, 38);
            lblPaymentBadge.TabIndex = 1;
            lblPaymentBadge.Text = "100% Thu";
            // 
            // pnlPaymentList
            // 
            pnlPaymentList.BackColor = Color.White;
            pnlPaymentList.Location = new Point(26, 371);
            pnlPaymentList.Margin = new Padding(6, 6, 6, 6);
            pnlPaymentList.Name = "pnlPaymentList";
            pnlPaymentList.Size = new Size(687, 226);
            pnlPaymentList.TabIndex = 2;
            // 
            // pnlBottomRow
            // 
            pnlBottomRow.BackColor = Color.Transparent;
            pnlBottomRow.Controls.Add(pnlTop5Card);
            pnlBottomRow.Controls.Add(pnlCashCard);
            pnlBottomRow.Location = new Point(37, 1297);
            pnlBottomRow.Margin = new Padding(6, 6, 6, 6);
            pnlBottomRow.Name = "pnlBottomRow";
            pnlBottomRow.Size = new Size(2154, 610);
            pnlBottomRow.TabIndex = 4;
            // 
            // pnlTop5Card
            // 
            pnlTop5Card.BackColor = Color.White;
            pnlTop5Card.BorderStyle = BorderStyle.FixedSingle;
            pnlTop5Card.Controls.Add(lblTop5Title);
            pnlTop5Card.Controls.Add(lblTop5Share);
            pnlTop5Card.Controls.Add(dgvTop5);
            pnlTop5Card.Controls.Add(pnlTop5Footer);
            pnlTop5Card.Location = new Point(0, 0);
            pnlTop5Card.Margin = new Padding(6, 6, 6, 6);
            pnlTop5Card.Name = "pnlTop5Card";
            pnlTop5Card.Size = new Size(370, 211);
            pnlTop5Card.TabIndex = 0;
            // 
            // lblTop5Title
            // 
            lblTop5Title.AutoSize = true;
            lblTop5Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTop5Title.ForeColor = Color.FromArgb(45, 30, 20);
            lblTop5Title.Location = new Point(26, 26);
            lblTop5Title.Margin = new Padding(6, 0, 6, 0);
            lblTop5Title.Name = "lblTop5Title";
            lblTop5Title.Size = new Size(341, 41);
            lblTop5Title.TabIndex = 0;
            lblTop5Title.Text = "☆  Top 5 món bán chạy";
            // 
            // lblTop5Share
            // 
            lblTop5Share.AutoSize = true;
            lblTop5Share.Font = new Font("Segoe UI", 8.5F);
            lblTop5Share.ForeColor = Color.Gray;
            lblTop5Share.Location = new Point(0, 0);
            lblTop5Share.Margin = new Padding(6, 0, 6, 0);
            lblTop5Share.Name = "lblTop5Share";
            lblTop5Share.Size = new Size(299, 31);
            lblTop5Share.TabIndex = 1;
            lblTop5Share.Text = "Chiếm 65.4% tổng doanh số";
            // 
            // dgvTop5
            // 
            dgvTop5.AllowUserToAddRows = false;
            dgvTop5.AllowUserToDeleteRows = false;
            dgvTop5.AllowUserToResizeRows = false;
            dgvTop5.BackgroundColor = Color.White;
            dgvTop5.BorderStyle = BorderStyle.None;
            dgvTop5.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(250, 247, 243);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(120, 105, 95);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTop5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTop5.ColumnHeadersHeight = 30;
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTop5.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 250, 244);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(45, 30, 20);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTop5.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTop5.EnableHeadersVisualStyles = false;
            dgvTop5.GridColor = Color.FromArgb(242, 238, 234);
            dgvTop5.Location = new Point(26, 90);
            dgvTop5.Margin = new Padding(6, 6, 6, 6);
            dgvTop5.MultiSelect = false;
            dgvTop5.Name = "dgvTop5";
            dgvTop5.ReadOnly = true;
            dgvTop5.RowHeadersVisible = false;
            dgvTop5.RowHeadersWidth = 82;
            dgvTop5.RowTemplate.Height = 34;
            dgvTop5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop5.Size = new Size(1281, 431);
            dgvTop5.TabIndex = 2;
            // 
            // pnlTop5Footer
            // 
            pnlTop5Footer.BackColor = Color.White;
            pnlTop5Footer.Controls.Add(lblTop5Total);
            pnlTop5Footer.Controls.Add(lnkViewAllMenu);
            pnlTop5Footer.Location = new Point(26, 529);
            pnlTop5Footer.Margin = new Padding(6, 6, 6, 6);
            pnlTop5Footer.Name = "pnlTop5Footer";
            pnlTop5Footer.Size = new Size(1281, 64);
            pnlTop5Footer.TabIndex = 3;
            // 
            // lblTop5Total
            // 
            lblTop5Total.AutoSize = true;
            lblTop5Total.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTop5Total.ForeColor = Color.FromArgb(65, 50, 40);
            lblTop5Total.Location = new Point(0, 13);
            lblTop5Total.Margin = new Padding(6, 0, 6, 0);
            lblTop5Total.Name = "lblTop5Total";
            lblTop5Total.Size = new Size(441, 31);
            lblTop5Total.TabIndex = 0;
            lblTop5Total.Text = "Tổng doanh thu Top 5 món: 5.528.000 đ";
            // 
            // lnkViewAllMenu
            // 
            lnkViewAllMenu.ActiveLinkColor = Color.FromArgb(86, 57, 39);
            lnkViewAllMenu.AutoSize = true;
            lnkViewAllMenu.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lnkViewAllMenu.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkViewAllMenu.LinkColor = Color.FromArgb(145, 95, 60);
            lnkViewAllMenu.Location = new Point(0, 0);
            lnkViewAllMenu.Margin = new Padding(6, 0, 6, 0);
            lnkViewAllMenu.Name = "lnkViewAllMenu";
            lnkViewAllMenu.Size = new Size(364, 31);
            lnkViewAllMenu.TabIndex = 1;
            lnkViewAllMenu.TabStop = true;
            lnkViewAllMenu.Text = "Xem toàn bộ 34 món thực đơn >";
            // 
            // pnlCashCard
            // 
            pnlCashCard.BackColor = Color.White;
            pnlCashCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCashCard.Controls.Add(lblCashTitle);
            pnlCashCard.Controls.Add(lblCashStatusBadge);
            pnlCashCard.Controls.Add(pnlCashBody);
            pnlCashCard.Controls.Add(pnlCashFooter);
            pnlCashCard.Location = new Point(0, 0);
            pnlCashCard.Margin = new Padding(6, 6, 6, 6);
            pnlCashCard.Name = "pnlCashCard";
            pnlCashCard.Size = new Size(370, 211);
            pnlCashCard.TabIndex = 1;
            // 
            // lblCashTitle
            // 
            lblCashTitle.AutoSize = true;
            lblCashTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCashTitle.ForeColor = Color.FromArgb(45, 30, 20);
            lblCashTitle.Location = new Point(26, 26);
            lblCashTitle.Margin = new Padding(6, 0, 6, 0);
            lblCashTitle.Name = "lblCashTitle";
            lblCashTitle.Size = new Size(363, 41);
            lblCashTitle.TabIndex = 0;
            lblCashTitle.Text = "🗄  Két tiền & bàn giao ca";
            // 
            // lblCashStatusBadge
            // 
            lblCashStatusBadge.AutoSize = true;
            lblCashStatusBadge.BackColor = Color.FromArgb(220, 252, 231);
            lblCashStatusBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCashStatusBadge.ForeColor = Color.FromArgb(22, 163, 74);
            lblCashStatusBadge.Location = new Point(0, 0);
            lblCashStatusBadge.Margin = new Padding(6, 0, 6, 0);
            lblCashStatusBadge.Name = "lblCashStatusBadge";
            lblCashStatusBadge.Padding = new Padding(15, 6, 15, 6);
            lblCashStatusBadge.Size = new Size(181, 42);
            lblCashStatusBadge.TabIndex = 1;
            lblCashStatusBadge.Text = "● Khớp 100%";
            // 
            // pnlCashBody
            // 
            pnlCashBody.BackColor = Color.White;
            pnlCashBody.Location = new Point(26, 94);
            pnlCashBody.Margin = new Padding(6, 6, 6, 6);
            pnlCashBody.Name = "pnlCashBody";
            pnlCashBody.Size = new Size(687, 384);
            pnlCashBody.TabIndex = 2;
            // 
            // pnlCashFooter
            // 
            pnlCashFooter.BackColor = Color.FromArgb(250, 247, 243);
            pnlCashFooter.Controls.Add(lblCashierAvatar);
            pnlCashFooter.Controls.Add(lblCashierName);
            pnlCashFooter.Controls.Add(lblCashierRole);
            pnlCashFooter.Controls.Add(btnXacNhanKetCa);
            pnlCashFooter.Location = new Point(26, 486);
            pnlCashFooter.Margin = new Padding(6, 6, 6, 6);
            pnlCashFooter.Name = "pnlCashFooter";
            pnlCashFooter.Size = new Size(687, 102);
            pnlCashFooter.TabIndex = 3;
            // 
            // lblCashierAvatar
            // 
            lblCashierAvatar.BackColor = Color.FromArgb(86, 57, 39);
            lblCashierAvatar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCashierAvatar.ForeColor = Color.White;
            lblCashierAvatar.Location = new Point(15, 15);
            lblCashierAvatar.Margin = new Padding(6, 0, 6, 0);
            lblCashierAvatar.Name = "lblCashierAvatar";
            lblCashierAvatar.Size = new Size(63, 73);
            lblCashierAvatar.TabIndex = 0;
            lblCashierAvatar.Text = "NVH";
            lblCashierAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCashierName
            // 
            lblCashierName.AutoSize = true;
            lblCashierName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCashierName.ForeColor = Color.FromArgb(45, 30, 20);
            lblCashierName.Location = new Point(93, 13);
            lblCashierName.Margin = new Padding(6, 0, 6, 0);
            lblCashierName.Name = "lblCashierName";
            lblCashierName.Size = new Size(225, 32);
            lblCashierName.TabIndex = 1;
            lblCashierName.Text = "Nguyễn Văn Hưng";
            // 
            // lblCashierRole
            // 
            lblCashierRole.AutoSize = true;
            lblCashierRole.Font = new Font("Segoe UI", 8F);
            lblCashierRole.ForeColor = Color.Gray;
            lblCashierRole.Location = new Point(93, 51);
            lblCashierRole.Margin = new Padding(6, 0, 6, 0);
            lblCashierRole.Name = "lblCashierRole";
            lblCashierRole.Size = new Size(210, 30);
            lblCashierRole.TabIndex = 2;
            lblCashierRole.Text = "Quản lý ca · MC-004";
            // 
            // btnXacNhanKetCa
            // 
            btnXacNhanKetCa.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnXacNhanKetCa.Location = new Point(0, 0);
            btnXacNhanKetCa.Margin = new Padding(6, 6, 6, 6);
            btnXacNhanKetCa.Name = "btnXacNhanKetCa";
            btnXacNhanKetCa.Size = new Size(230, 64);
            btnXacNhanKetCa.TabIndex = 3;
            // 
            // lblKpi1Title
            // 
            lblKpi1Title.Location = new Point(0, 0);
            lblKpi1Title.Name = "lblKpi1Title";
            lblKpi1Title.Size = new Size(100, 23);
            lblKpi1Title.TabIndex = 0;
            // 
            // lblKpi1Val
            // 
            lblKpi1Val.Location = new Point(0, 0);
            lblKpi1Val.Name = "lblKpi1Val";
            lblKpi1Val.Size = new Size(100, 23);
            lblKpi1Val.TabIndex = 0;
            // 
            // lblKpi1Sub
            // 
            lblKpi1Sub.Location = new Point(0, 0);
            lblKpi1Sub.Name = "lblKpi1Sub";
            lblKpi1Sub.Size = new Size(100, 23);
            lblKpi1Sub.TabIndex = 0;
            // 
            // lblKpi1Badge
            // 
            lblKpi1Badge.Location = new Point(0, 0);
            lblKpi1Badge.Name = "lblKpi1Badge";
            lblKpi1Badge.Size = new Size(100, 23);
            lblKpi1Badge.TabIndex = 0;
            // 
            // lblKpi2Title
            // 
            lblKpi2Title.Location = new Point(0, 0);
            lblKpi2Title.Name = "lblKpi2Title";
            lblKpi2Title.Size = new Size(100, 23);
            lblKpi2Title.TabIndex = 0;
            // 
            // lblKpi2Val
            // 
            lblKpi2Val.Location = new Point(0, 0);
            lblKpi2Val.Name = "lblKpi2Val";
            lblKpi2Val.Size = new Size(100, 23);
            lblKpi2Val.TabIndex = 0;
            // 
            // lblKpi2Sub
            // 
            lblKpi2Sub.Location = new Point(0, 0);
            lblKpi2Sub.Name = "lblKpi2Sub";
            lblKpi2Sub.Size = new Size(100, 23);
            lblKpi2Sub.TabIndex = 0;
            // 
            // lblKpi2Badge
            // 
            lblKpi2Badge.Location = new Point(0, 0);
            lblKpi2Badge.Name = "lblKpi2Badge";
            lblKpi2Badge.Size = new Size(100, 23);
            lblKpi2Badge.TabIndex = 0;
            // 
            // lblKpi3Title
            // 
            lblKpi3Title.Location = new Point(0, 0);
            lblKpi3Title.Name = "lblKpi3Title";
            lblKpi3Title.Size = new Size(100, 23);
            lblKpi3Title.TabIndex = 0;
            // 
            // lblKpi3Val
            // 
            lblKpi3Val.Location = new Point(0, 0);
            lblKpi3Val.Name = "lblKpi3Val";
            lblKpi3Val.Size = new Size(100, 23);
            lblKpi3Val.TabIndex = 0;
            // 
            // lblKpi3Sub
            // 
            lblKpi3Sub.Location = new Point(0, 0);
            lblKpi3Sub.Name = "lblKpi3Sub";
            lblKpi3Sub.Size = new Size(100, 23);
            lblKpi3Sub.TabIndex = 0;
            // 
            // lblKpi3Badge
            // 
            lblKpi3Badge.Location = new Point(0, 0);
            lblKpi3Badge.Name = "lblKpi3Badge";
            lblKpi3Badge.Size = new Size(100, 23);
            lblKpi3Badge.TabIndex = 0;
            // 
            // lblKpi4Title
            // 
            lblKpi4Title.Location = new Point(0, 0);
            lblKpi4Title.Name = "lblKpi4Title";
            lblKpi4Title.Size = new Size(100, 23);
            lblKpi4Title.TabIndex = 0;
            // 
            // lblKpi4Val
            // 
            lblKpi4Val.Location = new Point(0, 0);
            lblKpi4Val.Name = "lblKpi4Val";
            lblKpi4Val.Size = new Size(100, 23);
            lblKpi4Val.TabIndex = 0;
            // 
            // lblKpi4Sub
            // 
            lblKpi4Sub.Location = new Point(0, 0);
            lblKpi4Sub.Name = "lblKpi4Sub";
            lblKpi4Sub.Size = new Size(100, 23);
            lblKpi4Sub.TabIndex = 0;
            // 
            // lblKpi4Badge
            // 
            lblKpi4Badge.Location = new Point(0, 0);
            lblKpi4Badge.Name = "lblKpi4Badge";
            lblKpi4Badge.Size = new Size(100, 23);
            lblKpi4Badge.TabIndex = 0;
            // 
            // lblKpi5Title
            // 
            lblKpi5Title.Location = new Point(0, 0);
            lblKpi5Title.Name = "lblKpi5Title";
            lblKpi5Title.Size = new Size(100, 23);
            lblKpi5Title.TabIndex = 0;
            // 
            // lblKpi5Val
            // 
            lblKpi5Val.Location = new Point(0, 0);
            lblKpi5Val.Name = "lblKpi5Val";
            lblKpi5Val.Size = new Size(100, 23);
            lblKpi5Val.TabIndex = 0;
            // 
            // lblKpi5Sub
            // 
            lblKpi5Sub.Location = new Point(0, 0);
            lblKpi5Sub.Name = "lblKpi5Sub";
            lblKpi5Sub.Size = new Size(100, 23);
            lblKpi5Sub.TabIndex = 0;
            // 
            // lblKpi5Badge
            // 
            lblKpi5Badge.Location = new Point(0, 0);
            lblKpi5Badge.Name = "lblKpi5Badge";
            lblKpi5Badge.Size = new Size(100, 23);
            lblKpi5Badge.TabIndex = 0;
            // 
            // lblCashOpenVal
            // 
            lblCashOpenVal.Location = new Point(0, 0);
            lblCashOpenVal.Name = "lblCashOpenVal";
            lblCashOpenVal.Size = new Size(100, 23);
            lblCashOpenVal.TabIndex = 0;
            // 
            // lblCashInVal
            // 
            lblCashInVal.Location = new Point(0, 0);
            lblCashInVal.Name = "lblCashInVal";
            lblCashInVal.Size = new Size(100, 23);
            lblCashInVal.TabIndex = 0;
            // 
            // lblCashOutVal
            // 
            lblCashOutVal.Location = new Point(0, 0);
            lblCashOutVal.Name = "lblCashOutVal";
            lblCashOutVal.Size = new Size(100, 23);
            lblCashOutVal.TabIndex = 0;
            // 
            // pnlCashTotalBar
            // 
            pnlCashTotalBar.Location = new Point(0, 0);
            pnlCashTotalBar.Name = "pnlCashTotalBar";
            pnlCashTotalBar.Size = new Size(200, 100);
            pnlCashTotalBar.TabIndex = 0;
            // 
            // lblCashTotalVal
            // 
            lblCashTotalVal.Location = new Point(0, 0);
            lblCashTotalVal.Name = "lblCashTotalVal";
            lblCashTotalVal.Size = new Size(100, 23);
            lblCashTotalVal.TabIndex = 0;
            // 
            // pnlCashDiffBar
            // 
            pnlCashDiffBar.Location = new Point(0, 0);
            pnlCashDiffBar.Name = "pnlCashDiffBar";
            pnlCashDiffBar.Size = new Size(200, 100);
            pnlCashDiffBar.TabIndex = 0;
            // 
            // lblCashDiffVal
            // 
            lblCashDiffVal.Location = new Point(0, 0);
            lblCashDiffVal.Name = "lblCashDiffVal";
            lblCashDiffVal.Size = new Size(100, 23);
            lblCashDiffVal.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // UcM08
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 243);
            Controls.Add(pnlScroll);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(6, 6, 6, 6);
            Name = "UcM08";
            Size = new Size(2087, 1330);
            pnlScroll.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilterCard.ResumeLayout(false);
            pnlFilterControls.ResumeLayout(false);
            pnlFilterControls.PerformLayout();
            pnlKpiRow.ResumeLayout(false);
            pnlChartsRow.ResumeLayout(false);
            pnlHourlyCard.ResumeLayout(false);
            pnlHourlyCard.PerformLayout();
            pnlPaymentCard.ResumeLayout(false);
            pnlPaymentCard.PerformLayout();
            pnlBottomRow.ResumeLayout(false);
            pnlTop5Card.ResumeLayout(false);
            pnlTop5Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            pnlTop5Footer.ResumeLayout(false);
            pnlTop5Footer.PerformLayout();
            pnlCashCard.ResumeLayout(false);
            pnlCashCard.PerformLayout();
            pnlCashFooter.ResumeLayout(false);
            pnlCashFooter.PerformLayout();
            ResumeLayout(false);
        }

        private void BuildCashRows()
        {
            var r1 = MakeCashRow("💵  Tiền mặt đầu ca", out lblCashOpenVal, 0);
            var r2 = MakeCashRow("⊕  Tiền mặt thu trong ngày", out lblCashInVal, 30);
            var r3 = MakeCashRow("⊖  Chi quỹ tại két", out lblCashOutVal, 60);
            pnlCashBody.Controls.AddRange(new Control[] { r1, r2, r3 });

            pnlCashTotalBar.Location = new Point(0, 96);
            pnlCashTotalBar.Size = new Size(370, 36);
            pnlCashTotalBar.BackColor = Color.FromArgb(74, 48, 32);
            pnlCashBody.Controls.Add(pnlCashTotalBar);

            var lblTotalTitle = new Label
            {
                Text = "TỔNG TIỀN TRONG KÉT",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(245, 235, 225),
                Location = new Point(10, 9),
                AutoSize = true
            };
            lblCashTotalVal.Text = "4.550.000 đ";
            lblCashTotalVal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCashTotalVal.ForeColor = Color.White;
            lblCashTotalVal.TextAlign = ContentAlignment.MiddleRight;
            lblCashTotalVal.Dock = DockStyle.Right;
            lblCashTotalVal.Width = 150;
            lblCashTotalVal.Padding = new Padding(0, 0, 10, 0);
            pnlCashTotalBar.Controls.Add(lblTotalTitle);
            pnlCashTotalBar.Controls.Add(lblCashTotalVal);

            pnlCashDiffBar.Location = new Point(0, 138);
            pnlCashDiffBar.Size = new Size(370, 30);
            pnlCashDiffBar.BackColor = Color.FromArgb(220, 252, 231);
            pnlCashBody.Controls.Add(pnlCashDiffBar);

            var lblDiffTitle = new Label
            {
                Text = "✓ Chênh lệch / Lệch quỹ kiểm kê:",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.FromArgb(21, 128, 61),
                Location = new Point(8, 7),
                AutoSize = true
            };
            lblCashDiffVal.Text = "0 đ (Chính xác)";
            lblCashDiffVal.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCashDiffVal.ForeColor = Color.FromArgb(21, 128, 61);
            lblCashDiffVal.TextAlign = ContentAlignment.MiddleRight;
            lblCashDiffVal.Dock = DockStyle.Right;
            lblCashDiffVal.Width = 140;
            lblCashDiffVal.Padding = new Padding(0, 0, 8, 0);
            pnlCashDiffBar.Controls.Add(lblDiffTitle);
            pnlCashDiffBar.Controls.Add(lblCashDiffVal);
        }

        private Panel MakeCashRow(string title, out Label valLabel, int y)
        {
            var row = new Panel { Location = new Point(0, y), Size = new Size(370, 28), BackColor = Color.White };
            var lbl = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(75, 65, 58),
                Location = new Point(2, 5),
                AutoSize = true
            };
            valLabel = new Label
            {
                Text = "0 đ",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 30, 20),
                Dock = DockStyle.Right,
                Width = 140,
                TextAlign = ContentAlignment.MiddleRight
            };
            row.Controls.Add(lbl);
            row.Controls.Add(valLabel);
            return row;
        }

        private static Button MakeActionBtn(string text, Color bg, Color fg, Color border)
        {
            var b = new Button
            {
                Text = text,
                BackColor = bg,
                ForeColor = fg,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 1;
            b.FlatAppearance.BorderColor = border;
            return b;
        }

        private static void SetupKpiCard(Panel card, Label title, Label val, Label sub, Label badge,
            string titleText, Color valColor, Color badgeBg, Color badgeFg)
        {
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Padding = new Padding(12, 10, 12, 10);

            title.Text = titleText;
            title.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(120, 110, 102);
            title.Location = new Point(12, 10);
            title.AutoSize = true;

            val.Text = "0 đ";
            val.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            val.ForeColor = valColor;
            val.Location = new Point(10, 34);
            val.AutoSize = true;

            sub.Text = "";
            sub.Font = new Font("Segoe UI", 8F);
            sub.ForeColor = Color.FromArgb(120, 110, 102);
            sub.Location = new Point(12, 78);
            sub.AutoSize = true;

            badge.Text = "";
            badge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            badge.BackColor = badgeBg;
            badge.ForeColor = badgeFg;
            badge.Padding = new Padding(5, 2, 5, 2);
            badge.Location = new Point(135, 76);
            badge.AutoSize = true;

            card.Controls.AddRange(new Control[] { title, val, sub, badge });
        }

        // Helper panel with DoubleBuffered enabled for smooth custom GDI+ chart painting
        private sealed class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }
        }

        // Control fields
        private Panel pnlScroll = null!;
        private Panel pnlContainer = null!;
        private Panel pnlHeader = null!;
        private Label lblTitle = null!;
        private Button btnXuatExcel = null!;
        private Button btnXuatPdf = null!;
        private Button btnInBaoCao = null!;

        private Panel pnlFilterCard = null!;
        private Panel pnlTimeTabs = null!;
        private Panel pnlFilterControls = null!;
        private Label lblDateRange = null!;
        private Label lblCaLabel = null!;
        private ComboBox cboCa = null!;
        private Label lblThuNganLabel = null!;
        private ComboBox cboThuNgan = null!;
        private Button btnApDung = null!;

        private Panel pnlKpiRow = null!;
        private Panel pnlKpi1 = null!, pnlKpi2 = null!, pnlKpi3 = null!, pnlKpi4 = null!, pnlKpi5 = null!;
        private Label lblKpi1Title = null!, lblKpi1Val = null!, lblKpi1Sub = null!, lblKpi1Badge = null!;
        private Label lblKpi2Title = null!, lblKpi2Val = null!, lblKpi2Sub = null!, lblKpi2Badge = null!;
        private Label lblKpi3Title = null!, lblKpi3Val = null!, lblKpi3Sub = null!, lblKpi3Badge = null!;
        private Label lblKpi4Title = null!, lblKpi4Val = null!, lblKpi4Sub = null!, lblKpi4Badge = null!;
        private Label lblKpi5Title = null!, lblKpi5Val = null!, lblKpi5Sub = null!, lblKpi5Badge = null!;

        private Panel pnlChartsRow = null!;
        private Panel pnlHourlyCard = null!;
        private Label lblHourlyTitle = null!;
        private Label lblHourlyLegend = null!;
        private DoubleBufferedPanel pnlHourlyChart = null!;

        private Panel pnlPaymentCard = null!;
        private Label lblPaymentTitle = null!;
        private Label lblPaymentBadge = null!;
        private DoubleBufferedPanel pnlDonutChart = null!;
        private Panel pnlPaymentList = null!;

        private Panel pnlBottomRow = null!;
        private Panel pnlTop5Card = null!;
        private Label lblTop5Title = null!;
        private Label lblTop5Share = null!;
        private DataGridView dgvTop5 = null!;
        private Panel pnlTop5Footer = null!;
        private Label lblTop5Total = null!;
        private LinkLabel lnkViewAllMenu = null!;

        private Panel pnlCashCard = null!;
        private Label lblCashTitle = null!;
        private Label lblCashStatusBadge = null!;
        private Panel pnlCashBody = null!;
        private Label lblCashOpenVal = null!, lblCashInVal = null!, lblCashOutVal = null!;
        private Panel pnlCashTotalBar = null!;
        private Label lblCashTotalVal = null!;
        private Panel pnlCashDiffBar = null!;
        private Label lblCashDiffVal = null!;
        private Panel pnlCashFooter = null!;
        private Label lblCashierAvatar = null!, lblCashierName = null!, lblCashierRole = null!;
        private Button btnXacNhanKetCa = null!;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
