namespace DoAnLapTrinhTrucQuan
{
    partial class DlgS04
    {
        private FlowLayoutPanel flpOptions = null!;
        private CheckBox chkPrintReceipt = null!;
        private void InitializeComponent()
        {
            tlpPayment = new TableLayoutPanel();
            lblHeading = new Label();
            tlpBody = new TableLayoutPanel();
            tlpBill = new TableLayoutPanel();
            lblTable = new Label();
            lblOrder = new Label();
            dgvBill = new DataGridView();
            lblDue = new Label();
            tlpTender = new TableLayoutPanel();
            tlpMethods = new TableLayoutPanel();
            btnCash = new Button();
            btnTransfer = new Button();
            btnCard = new Button();
            lblTender = new Label();
            txtTender = new TextBox();
            tlpAmounts = new TableLayoutPanel();
            btnExact = new Button();
            btnTwoHundred = new Button();
            btnThreeHundred = new Button();
            btnFiveHundred = new Button();
            tlpKeypad = new TableLayoutPanel();
            btnEnter7 = new Button();
            btnEnter8 = new Button();
            btnEnter9 = new Button();
            btnEnter4 = new Button();
            btnEnter5 = new Button();
            btnEnter6 = new Button();
            btnEnter1 = new Button();
            btnEnter2 = new Button();
            btnEnter3 = new Button();
            btnEnter000 = new Button();
            btnEnter0 = new Button();
            btnBackspace = new Button();
            lblChange = new Label();
            flpOptions = new FlowLayoutPanel();
            chkPrintReceipt = new CheckBox();
            chkReceived = new CheckBox();
            tlpConfirm = new TableLayoutPanel();
            btnCancel = new Button();
            btnConfirm = new Button();
            tlpPayment.SuspendLayout();
            tlpBody.SuspendLayout();
            tlpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            tlpTender.SuspendLayout();
            tlpMethods.SuspendLayout();
            tlpAmounts.SuspendLayout();
            tlpKeypad.SuspendLayout();
            flpOptions.SuspendLayout();
            tlpConfirm.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPayment
            // 
            tlpPayment.ColumnCount = 1;
            tlpPayment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPayment.Controls.Add(lblHeading, 0, 0);
            tlpPayment.Controls.Add(tlpBody, 0, 1);
            tlpPayment.Dock = DockStyle.Fill;
            tlpPayment.Location = new Point(12, 12);
            tlpPayment.Margin = new Padding(0);
            tlpPayment.Name = "tlpPayment";
            tlpPayment.RowCount = 2;
            tlpPayment.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpPayment.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPayment.Size = new Size(906, 546);
            tlpPayment.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoEllipsis = true;
            lblHeading.Dock = DockStyle.Fill;
            lblHeading.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHeading.Location = new Point(3, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(900, 44);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Mộc Café   /   Thanh toán";
            lblHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpBody
            // 
            tlpBody.ColumnCount = 2;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpBody.Controls.Add(tlpBill, 0, 0);
            tlpBody.Controls.Add(tlpTender, 1, 0);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(0, 44);
            tlpBody.Margin = new Padding(0);
            tlpBody.Name = "tlpBody";
            tlpBody.RowCount = 1;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBody.Size = new Size(906, 502);
            tlpBody.TabIndex = 1;
            // 
            // tlpBill
            // 
            tlpBill.ColumnCount = 1;
            tlpBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBill.Controls.Add(lblTable, 0, 0);
            tlpBill.Controls.Add(lblOrder, 0, 1);
            tlpBill.Controls.Add(dgvBill, 0, 2);
            tlpBill.Controls.Add(lblDue, 0, 3);
            tlpBill.Dock = DockStyle.Fill;
            tlpBill.Location = new Point(0, 0);
            tlpBill.Margin = new Padding(0);
            tlpBill.Name = "tlpBill";
            tlpBill.RowCount = 4;
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tlpBill.Size = new Size(380, 502);
            tlpBill.TabIndex = 0;
            // 
            // lblTable
            // 
            lblTable.AutoEllipsis = true;
            lblTable.Dock = DockStyle.Fill;
            lblTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTable.Location = new Point(3, 0);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(374, 44);
            lblTable.TabIndex = 0;
            lblTable.Text = "Chi tiết đơn";
            lblTable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrder
            // 
            lblOrder.AutoEllipsis = true;
            lblOrder.Dock = DockStyle.Fill;
            lblOrder.Font = new Font("Segoe UI", 9F);
            lblOrder.Location = new Point(3, 44);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(374, 34);
            lblOrder.TabIndex = 1;
            lblOrder.Text = "Mã đơn";
            lblOrder.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AllowUserToResizeRows = false;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = Color.White;
            dgvBill.BorderStyle = BorderStyle.None;
            dgvBill.Dock = DockStyle.Fill;
            dgvBill.Location = new Point(3, 81);
            dgvBill.MultiSelect = false;
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dgvBill.RowHeadersVisible = false;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(374, 350);
            dgvBill.TabIndex = 2;
            // 
            // lblDue
            // 
            lblDue.AutoEllipsis = true;
            lblDue.Dock = DockStyle.Fill;
            lblDue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDue.Location = new Point(3, 434);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(374, 68);
            lblDue.TabIndex = 3;
            lblDue.Text = "Khách phải trả";
            lblDue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpTender
            // 
            tlpTender.ColumnCount = 1;
            tlpTender.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTender.Controls.Add(tlpMethods, 0, 0);
            tlpTender.Controls.Add(lblTender, 0, 1);
            tlpTender.Controls.Add(txtTender, 0, 2);
            tlpTender.Controls.Add(tlpAmounts, 0, 3);
            tlpTender.Controls.Add(tlpKeypad, 0, 4);
            tlpTender.Controls.Add(lblChange, 0, 5);
            tlpTender.Controls.Add(flpOptions, 0, 6);
            tlpTender.Controls.Add(tlpConfirm, 0, 7);
            tlpTender.Dock = DockStyle.Fill;
            tlpTender.Location = new Point(380, 0);
            tlpTender.Margin = new Padding(0);
            tlpTender.Name = "tlpTender";
            tlpTender.RowCount = 8;
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpTender.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpTender.Size = new Size(526, 502);
            tlpTender.TabIndex = 1;
            // 
            // tlpMethods
            // 
            tlpMethods.ColumnCount = 3;
            tlpMethods.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpMethods.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpMethods.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpMethods.Controls.Add(btnCash, 0, 0);
            tlpMethods.Controls.Add(btnTransfer, 1, 0);
            tlpMethods.Controls.Add(btnCard, 2, 0);
            tlpMethods.Dock = DockStyle.Fill;
            tlpMethods.Location = new Point(0, 0);
            tlpMethods.Margin = new Padding(0);
            tlpMethods.Name = "tlpMethods";
            tlpMethods.RowCount = 1;
            tlpMethods.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMethods.Size = new Size(526, 44);
            tlpMethods.TabIndex = 0;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.FromArgb(255, 234, 223);
            btnCash.Dock = DockStyle.Fill;
            btnCash.FlatAppearance.BorderSize = 0;
            btnCash.FlatStyle = FlatStyle.Flat;
            btnCash.ForeColor = Color.FromArgb(63, 38, 29);
            btnCash.Location = new Point(3, 3);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(172, 38);
            btnCash.TabIndex = 0;
            btnCash.Text = "Tiền mặt";
            btnCash.UseVisualStyleBackColor = false;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.FromArgb(255, 234, 223);
            btnTransfer.Dock = DockStyle.Fill;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.ForeColor = Color.FromArgb(63, 38, 29);
            btnTransfer.Location = new Point(181, 3);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(167, 38);
            btnTransfer.TabIndex = 1;
            btnTransfer.Text = "Chuyển khoản";
            btnTransfer.UseVisualStyleBackColor = false;
            // 
            // btnCard
            // 
            btnCard.BackColor = Color.FromArgb(255, 234, 223);
            btnCard.Dock = DockStyle.Fill;
            btnCard.FlatAppearance.BorderSize = 0;
            btnCard.FlatStyle = FlatStyle.Flat;
            btnCard.ForeColor = Color.FromArgb(63, 38, 29);
            btnCard.Location = new Point(354, 3);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(169, 38);
            btnCard.TabIndex = 2;
            btnCard.Text = "Thẻ POS";
            btnCard.UseVisualStyleBackColor = false;
            // 
            // lblTender
            // 
            lblTender.AutoEllipsis = true;
            lblTender.Dock = DockStyle.Fill;
            lblTender.Font = new Font("Segoe UI", 9F);
            lblTender.Location = new Point(3, 44);
            lblTender.Name = "lblTender";
            lblTender.Size = new Size(520, 32);
            lblTender.TabIndex = 1;
            lblTender.Text = "Tiền khách đưa";
            lblTender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTender
            // 
            txtTender.Dock = DockStyle.Fill;
            txtTender.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txtTender.Location = new Point(3, 79);
            txtTender.MaxLength = 12;
            txtTender.Name = "txtTender";
            txtTender.Size = new Size(520, 34);
            txtTender.TabIndex = 2;
            txtTender.TextAlign = HorizontalAlignment.Right;
            // 
            // tlpAmounts
            // 
            tlpAmounts.ColumnCount = 4;
            tlpAmounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAmounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAmounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAmounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAmounts.Controls.Add(btnExact, 0, 0);
            tlpAmounts.Controls.Add(btnTwoHundred, 1, 0);
            tlpAmounts.Controls.Add(btnThreeHundred, 2, 0);
            tlpAmounts.Controls.Add(btnFiveHundred, 3, 0);
            tlpAmounts.Dock = DockStyle.Fill;
            tlpAmounts.Location = new Point(0, 118);
            tlpAmounts.Margin = new Padding(0);
            tlpAmounts.Name = "tlpAmounts";
            tlpAmounts.RowCount = 1;
            tlpAmounts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAmounts.Size = new Size(526, 42);
            tlpAmounts.TabIndex = 3;
            // 
            // btnExact
            // 
            btnExact.BackColor = Color.FromArgb(255, 234, 223);
            btnExact.Dock = DockStyle.Fill;
            btnExact.FlatAppearance.BorderSize = 0;
            btnExact.FlatStyle = FlatStyle.Flat;
            btnExact.ForeColor = Color.FromArgb(63, 38, 29);
            btnExact.Location = new Point(3, 3);
            btnExact.Name = "btnExact";
            btnExact.Size = new Size(125, 36);
            btnExact.TabIndex = 0;
            btnExact.Text = "Đưa đúng";
            btnExact.UseVisualStyleBackColor = false;
            // 
            // btnTwoHundred
            // 
            btnTwoHundred.BackColor = Color.FromArgb(255, 234, 223);
            btnTwoHundred.Dock = DockStyle.Fill;
            btnTwoHundred.FlatAppearance.BorderSize = 0;
            btnTwoHundred.FlatStyle = FlatStyle.Flat;
            btnTwoHundred.ForeColor = Color.FromArgb(63, 38, 29);
            btnTwoHundred.Location = new Point(134, 3);
            btnTwoHundred.Name = "btnTwoHundred";
            btnTwoHundred.Size = new Size(125, 36);
            btnTwoHundred.TabIndex = 1;
            btnTwoHundred.Text = "200.000";
            btnTwoHundred.UseVisualStyleBackColor = false;
            // 
            // btnThreeHundred
            // 
            btnThreeHundred.BackColor = Color.FromArgb(255, 234, 223);
            btnThreeHundred.Dock = DockStyle.Fill;
            btnThreeHundred.FlatAppearance.BorderSize = 0;
            btnThreeHundred.FlatStyle = FlatStyle.Flat;
            btnThreeHundred.ForeColor = Color.FromArgb(63, 38, 29);
            btnThreeHundred.Location = new Point(265, 3);
            btnThreeHundred.Name = "btnThreeHundred";
            btnThreeHundred.Size = new Size(125, 36);
            btnThreeHundred.TabIndex = 2;
            btnThreeHundred.Text = "300.000";
            btnThreeHundred.UseVisualStyleBackColor = false;
            // 
            // btnFiveHundred
            // 
            btnFiveHundred.BackColor = Color.FromArgb(255, 234, 223);
            btnFiveHundred.Dock = DockStyle.Fill;
            btnFiveHundred.FlatAppearance.BorderSize = 0;
            btnFiveHundred.FlatStyle = FlatStyle.Flat;
            btnFiveHundred.ForeColor = Color.FromArgb(63, 38, 29);
            btnFiveHundred.Location = new Point(396, 3);
            btnFiveHundred.Name = "btnFiveHundred";
            btnFiveHundred.Size = new Size(127, 36);
            btnFiveHundred.TabIndex = 3;
            btnFiveHundred.Text = "500.000";
            btnFiveHundred.UseVisualStyleBackColor = false;
            // 
            // tlpKeypad
            // 
            tlpKeypad.ColumnCount = 3;
            tlpKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpKeypad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpKeypad.Controls.Add(btnEnter7, 0, 0);
            tlpKeypad.Controls.Add(btnEnter8, 1, 0);
            tlpKeypad.Controls.Add(btnEnter9, 2, 0);
            tlpKeypad.Controls.Add(btnEnter4, 0, 1);
            tlpKeypad.Controls.Add(btnEnter5, 1, 1);
            tlpKeypad.Controls.Add(btnEnter6, 2, 1);
            tlpKeypad.Controls.Add(btnEnter1, 0, 2);
            tlpKeypad.Controls.Add(btnEnter2, 1, 2);
            tlpKeypad.Controls.Add(btnEnter3, 2, 2);
            tlpKeypad.Controls.Add(btnEnter000, 0, 3);
            tlpKeypad.Controls.Add(btnEnter0, 1, 3);
            tlpKeypad.Controls.Add(btnBackspace, 2, 3);
            tlpKeypad.Dock = DockStyle.Fill;
            tlpKeypad.Location = new Point(0, 160);
            tlpKeypad.Margin = new Padding(0);
            tlpKeypad.Name = "tlpKeypad";
            tlpKeypad.RowCount = 4;
            tlpKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpKeypad.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpKeypad.Size = new Size(526, 206);
            tlpKeypad.TabIndex = 4;
            // 
            // btnEnter7
            // 
            btnEnter7.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter7.Dock = DockStyle.Fill;
            btnEnter7.FlatAppearance.BorderSize = 0;
            btnEnter7.FlatStyle = FlatStyle.Flat;
            btnEnter7.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter7.Location = new Point(3, 3);
            btnEnter7.Name = "btnEnter7";
            btnEnter7.Size = new Size(167, 45);
            btnEnter7.TabIndex = 0;
            btnEnter7.Text = "7";
            btnEnter7.UseVisualStyleBackColor = false;
            // 
            // btnEnter8
            // 
            btnEnter8.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter8.Dock = DockStyle.Fill;
            btnEnter8.FlatAppearance.BorderSize = 0;
            btnEnter8.FlatStyle = FlatStyle.Flat;
            btnEnter8.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter8.Location = new Point(176, 3);
            btnEnter8.Name = "btnEnter8";
            btnEnter8.Size = new Size(172, 45);
            btnEnter8.TabIndex = 1;
            btnEnter8.Text = "8";
            btnEnter8.UseVisualStyleBackColor = false;
            // 
            // btnEnter9
            // 
            btnEnter9.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter9.Dock = DockStyle.Fill;
            btnEnter9.FlatAppearance.BorderSize = 0;
            btnEnter9.FlatStyle = FlatStyle.Flat;
            btnEnter9.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter9.Location = new Point(354, 3);
            btnEnter9.Name = "btnEnter9";
            btnEnter9.Size = new Size(169, 45);
            btnEnter9.TabIndex = 2;
            btnEnter9.Text = "9";
            btnEnter9.UseVisualStyleBackColor = false;
            // 
            // btnEnter4
            // 
            btnEnter4.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter4.Dock = DockStyle.Fill;
            btnEnter4.FlatAppearance.BorderSize = 0;
            btnEnter4.FlatStyle = FlatStyle.Flat;
            btnEnter4.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter4.Location = new Point(3, 54);
            btnEnter4.Name = "btnEnter4";
            btnEnter4.Size = new Size(167, 45);
            btnEnter4.TabIndex = 3;
            btnEnter4.Text = "4";
            btnEnter4.UseVisualStyleBackColor = false;
            // 
            // btnEnter5
            // 
            btnEnter5.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter5.Dock = DockStyle.Fill;
            btnEnter5.FlatAppearance.BorderSize = 0;
            btnEnter5.FlatStyle = FlatStyle.Flat;
            btnEnter5.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter5.Location = new Point(176, 54);
            btnEnter5.Name = "btnEnter5";
            btnEnter5.Size = new Size(172, 45);
            btnEnter5.TabIndex = 4;
            btnEnter5.Text = "5";
            btnEnter5.UseVisualStyleBackColor = false;
            // 
            // btnEnter6
            // 
            btnEnter6.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter6.Dock = DockStyle.Fill;
            btnEnter6.FlatAppearance.BorderSize = 0;
            btnEnter6.FlatStyle = FlatStyle.Flat;
            btnEnter6.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter6.Location = new Point(354, 54);
            btnEnter6.Name = "btnEnter6";
            btnEnter6.Size = new Size(169, 45);
            btnEnter6.TabIndex = 5;
            btnEnter6.Text = "6";
            btnEnter6.UseVisualStyleBackColor = false;
            // 
            // btnEnter1
            // 
            btnEnter1.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter1.Dock = DockStyle.Fill;
            btnEnter1.FlatAppearance.BorderSize = 0;
            btnEnter1.FlatStyle = FlatStyle.Flat;
            btnEnter1.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter1.Location = new Point(3, 105);
            btnEnter1.Name = "btnEnter1";
            btnEnter1.Size = new Size(167, 45);
            btnEnter1.TabIndex = 6;
            btnEnter1.Text = "1";
            btnEnter1.UseVisualStyleBackColor = false;
            // 
            // btnEnter2
            // 
            btnEnter2.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter2.Dock = DockStyle.Fill;
            btnEnter2.FlatAppearance.BorderSize = 0;
            btnEnter2.FlatStyle = FlatStyle.Flat;
            btnEnter2.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter2.Location = new Point(176, 105);
            btnEnter2.Name = "btnEnter2";
            btnEnter2.Size = new Size(172, 45);
            btnEnter2.TabIndex = 7;
            btnEnter2.Text = "2";
            btnEnter2.UseVisualStyleBackColor = false;
            // 
            // btnEnter3
            // 
            btnEnter3.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter3.Dock = DockStyle.Fill;
            btnEnter3.FlatAppearance.BorderSize = 0;
            btnEnter3.FlatStyle = FlatStyle.Flat;
            btnEnter3.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter3.Location = new Point(354, 105);
            btnEnter3.Name = "btnEnter3";
            btnEnter3.Size = new Size(169, 45);
            btnEnter3.TabIndex = 8;
            btnEnter3.Text = "3";
            btnEnter3.UseVisualStyleBackColor = false;
            // 
            // btnEnter000
            // 
            btnEnter000.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter000.Dock = DockStyle.Fill;
            btnEnter000.FlatAppearance.BorderSize = 0;
            btnEnter000.FlatStyle = FlatStyle.Flat;
            btnEnter000.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter000.Location = new Point(3, 156);
            btnEnter000.Name = "btnEnter000";
            btnEnter000.Size = new Size(167, 47);
            btnEnter000.TabIndex = 9;
            btnEnter000.Text = "000";
            btnEnter000.UseVisualStyleBackColor = false;
            // 
            // btnEnter0
            // 
            btnEnter0.BackColor = Color.FromArgb(255, 234, 223);
            btnEnter0.Dock = DockStyle.Fill;
            btnEnter0.FlatAppearance.BorderSize = 0;
            btnEnter0.FlatStyle = FlatStyle.Flat;
            btnEnter0.ForeColor = Color.FromArgb(63, 38, 29);
            btnEnter0.Location = new Point(176, 156);
            btnEnter0.Name = "btnEnter0";
            btnEnter0.Size = new Size(172, 47);
            btnEnter0.TabIndex = 10;
            btnEnter0.Text = "0";
            btnEnter0.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.FromArgb(255, 234, 223);
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.FlatAppearance.BorderSize = 0;
            btnBackspace.FlatStyle = FlatStyle.Flat;
            btnBackspace.ForeColor = Color.FromArgb(63, 38, 29);
            btnBackspace.Location = new Point(354, 156);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(169, 47);
            btnBackspace.TabIndex = 11;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            // 
            // lblChange
            // 
            lblChange.AutoEllipsis = true;
            lblChange.Dock = DockStyle.Fill;
            lblChange.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblChange.Location = new Point(3, 366);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(520, 52);
            lblChange.TabIndex = 5;
            lblChange.Text = "Tiền thừa trả khách";
            lblChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpOptions
            // 
            flpOptions.Controls.Add(chkPrintReceipt);
            flpOptions.Controls.Add(chkReceived);
            flpOptions.Dock = DockStyle.Fill;
            flpOptions.Location = new Point(3, 421);
            flpOptions.Name = "flpOptions";
            flpOptions.Size = new Size(520, 28);
            flpOptions.TabIndex = 6;
            // 
            // chkPrintReceipt
            // 
            chkPrintReceipt.AutoSize = true;
            chkPrintReceipt.Location = new Point(3, 3);
            chkPrintReceipt.Name = "chkPrintReceipt";
            chkPrintReceipt.Size = new Size(83, 19);
            chkPrintReceipt.TabIndex = 0;
            chkPrintReceipt.Text = "In hóa đơn";
            // 
            // chkReceived
            // 
            chkReceived.AutoSize = true;
            chkReceived.Dock = DockStyle.Fill;
            chkReceived.Location = new Point(92, 3);
            chkReceived.Name = "chkReceived";
            chkReceived.Size = new Size(202, 19);
            chkReceived.TabIndex = 1;
            chkReceived.Text = "Đã kiểm tra giao dịch thành công";
            // 
            // tlpConfirm
            // 
            tlpConfirm.ColumnCount = 2;
            tlpConfirm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tlpConfirm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            tlpConfirm.Controls.Add(btnCancel, 0, 0);
            tlpConfirm.Controls.Add(btnConfirm, 1, 0);
            tlpConfirm.Dock = DockStyle.Fill;
            tlpConfirm.Location = new Point(0, 452);
            tlpConfirm.Margin = new Padding(0);
            tlpConfirm.Name = "tlpConfirm";
            tlpConfirm.RowCount = 1;
            tlpConfirm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpConfirm.Size = new Size(526, 50);
            tlpConfirm.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 234, 223);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(63, 38, 29);
            btnCancel.Location = new Point(3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(162, 44);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Quay lại";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(53, 30, 22);
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(171, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(352, 44);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Xác nhận thanh toán";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // DlgS04
            // 
            BackColor = Color.FromArgb(252, 246, 242);
            CancelButton = btnCancel;
            ClientSize = new Size(930, 570);
            Controls.Add(tlpPayment);
            ForeColor = Color.FromArgb(55, 34, 25);
            MinimumSize = new Size(730, 490);
            Name = "DlgS04";
            Padding = new Padding(12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mộc Café · Thanh toán";
            tlpPayment.ResumeLayout(false);
            tlpBody.ResumeLayout(false);
            tlpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            tlpTender.ResumeLayout(false);
            tlpTender.PerformLayout();
            tlpMethods.ResumeLayout(false);
            tlpAmounts.ResumeLayout(false);
            tlpKeypad.ResumeLayout(false);
            flpOptions.ResumeLayout(false);
            flpOptions.PerformLayout();
            tlpConfirm.ResumeLayout(false);
            ResumeLayout(false);
        }
        private TableLayoutPanel tlpPayment = null!;
        private Label lblHeading = null!;
        private TableLayoutPanel tlpBody = null!;
        private TableLayoutPanel tlpBill = null!;
        private Label lblTable = null!;
        private Label lblOrder = null!;
        private DataGridView dgvBill = null!;
        private Label lblDue = null!;
        private TableLayoutPanel tlpTender = null!;
        private TableLayoutPanel tlpMethods = null!;
        private Button btnCash = null!;
        private Button btnTransfer = null!;
        private Button btnCard = null!;
        private Label lblTender = null!;
        private TextBox txtTender = null!;
        private TableLayoutPanel tlpAmounts = null!;
        private Button btnExact = null!;
        private Button btnTwoHundred = null!;
        private Button btnThreeHundred = null!;
        private Button btnFiveHundred = null!;
        private TableLayoutPanel tlpKeypad = null!;
        private Button btnEnter7 = null!;
        private Button btnEnter8 = null!;
        private Button btnEnter9 = null!;
        private Button btnEnter4 = null!;
        private Button btnEnter5 = null!;
        private Button btnEnter6 = null!;
        private Button btnEnter1 = null!;
        private Button btnEnter2 = null!;
        private Button btnEnter3 = null!;
        private Button btnEnter000 = null!;
        private Button btnEnter0 = null!;
        private Button btnBackspace = null!;
        private Label lblChange = null!;
        private CheckBox chkReceived = null!;
        private TableLayoutPanel tlpConfirm = null!;
        private Button btnCancel = null!;
        private Button btnConfirm = null!;
    }
}
