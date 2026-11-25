namespace DoAnLapTrinhTrucQuan
{
    partial class UcS02
    {
        private TableLayoutPanel tlpOrderActions = null!;
        private Button btnDiscardChanges = null!;
        private Button btnPrintEstimate = null!;
        private void InitializeComponent()
        {
            tlpPos = new TableLayoutPanel();
            lblHeading = new Label();
            tlpContext = new TableLayoutPanel();
            cboService = new ComboBox();
            lblOrderInfo = new Label();
            btnReturn = new Button();
            tlpSale = new TableLayoutPanel();
            tlpCategories = new TableLayoutPanel();
            lblCategories = new Label();
            lstCategories = new ListBox();
            tlpCatalog = new TableLayoutPanel();
            txtSearchProduct = new TextBox();
            cboStock = new ComboBox();
            flpProducts = new FlowLayoutPanel();
            tlpCart = new TableLayoutPanel();
            tlpOrderActions = new TableLayoutPanel();
            btnDiscardChanges = new Button();
            btnPrintEstimate = new Button();
            lblCart = new Label();
            dgvCart = new DataGridView();
            tlpQuantity = new TableLayoutPanel();
            btnDecrease = new Button();
            btnIncrease = new Button();
            btnRemoveItem = new Button();
            tlpVoucher = new TableLayoutPanel();
            txtVoucher = new TextBox();
            btnApplyVoucher = new Button();
            lblTotal = new Label();
            btnSaveOrder = new Button();
            btnPayOrder = new Button();
            tlpPos.SuspendLayout();
            tlpContext.SuspendLayout();
            tlpSale.SuspendLayout();
            tlpCategories.SuspendLayout();
            tlpCatalog.SuspendLayout();
            tlpCart.SuspendLayout();
            tlpOrderActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            tlpQuantity.SuspendLayout();
            tlpVoucher.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPos
            // 
            tlpPos.ColumnCount = 1;
            tlpPos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPos.Controls.Add(lblHeading, 0, 0);
            tlpPos.Controls.Add(tlpContext, 0, 1);
            tlpPos.Controls.Add(tlpSale, 0, 2);
            tlpPos.Dock = DockStyle.Fill;
            tlpPos.Location = new Point(10, 10);
            tlpPos.Margin = new Padding(0);
            tlpPos.Name = "tlpPos";
            tlpPos.RowCount = 3;
            tlpPos.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpPos.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpPos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPos.Size = new Size(975, 670);
            tlpPos.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoEllipsis = true;
            lblHeading.Dock = DockStyle.Fill;
            lblHeading.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHeading.Location = new Point(3, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(969, 42);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Mộc Café   /   Bán hàng POS";
            lblHeading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpContext
            // 
            tlpContext.ColumnCount = 3;
            tlpContext.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 185F));
            tlpContext.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContext.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tlpContext.Controls.Add(cboService, 0, 0);
            tlpContext.Controls.Add(lblOrderInfo, 1, 0);
            tlpContext.Controls.Add(btnReturn, 2, 0);
            tlpContext.Dock = DockStyle.Fill;
            tlpContext.Location = new Point(0, 42);
            tlpContext.Margin = new Padding(0);
            tlpContext.Name = "tlpContext";
            tlpContext.RowCount = 1;
            tlpContext.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContext.Size = new Size(975, 44);
            tlpContext.TabIndex = 1;
            // 
            // cboService
            // 
            cboService.Dock = DockStyle.Fill;
            cboService.DropDownStyle = ComboBoxStyle.DropDownList;
            cboService.Location = new Point(3, 3);
            cboService.Name = "cboService";
            cboService.Size = new Size(179, 23);
            cboService.TabIndex = 0;
            // 
            // lblOrderInfo
            // 
            lblOrderInfo.AutoEllipsis = true;
            lblOrderInfo.Dock = DockStyle.Fill;
            lblOrderInfo.Font = new Font("Segoe UI", 9F);
            lblOrderInfo.Location = new Point(188, 0);
            lblOrderInfo.Name = "lblOrderInfo";
            lblOrderInfo.Size = new Size(624, 44);
            lblOrderInfo.TabIndex = 1;
            lblOrderInfo.Text = "Đơn hàng";
            lblOrderInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 234, 223);
            btnReturn.Dock = DockStyle.Fill;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = Color.FromArgb(63, 38, 29);
            btnReturn.Location = new Point(818, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(154, 38);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "←  Sơ đồ bàn";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // tlpSale
            // 
            tlpSale.ColumnCount = 3;
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSale.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 315F));
            tlpSale.Controls.Add(tlpCategories, 0, 0);
            tlpSale.Controls.Add(tlpCatalog, 1, 0);
            tlpSale.Controls.Add(tlpCart, 2, 0);
            tlpSale.Dock = DockStyle.Fill;
            tlpSale.Location = new Point(0, 86);
            tlpSale.Margin = new Padding(0);
            tlpSale.Name = "tlpSale";
            tlpSale.RowCount = 1;
            tlpSale.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSale.Size = new Size(975, 584);
            tlpSale.TabIndex = 2;
            // 
            // tlpCategories
            // 
            tlpCategories.ColumnCount = 1;
            tlpCategories.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCategories.Controls.Add(lblCategories, 0, 0);
            tlpCategories.Controls.Add(lstCategories, 0, 1);
            tlpCategories.Dock = DockStyle.Fill;
            tlpCategories.Location = new Point(0, 0);
            tlpCategories.Margin = new Padding(0);
            tlpCategories.Name = "tlpCategories";
            tlpCategories.RowCount = 2;
            tlpCategories.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpCategories.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCategories.Size = new Size(132, 584);
            tlpCategories.TabIndex = 0;
            // 
            // lblCategories
            // 
            lblCategories.AutoEllipsis = true;
            lblCategories.Dock = DockStyle.Fill;
            lblCategories.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCategories.Location = new Point(3, 0);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(126, 42);
            lblCategories.TabIndex = 0;
            lblCategories.Text = "Danh mục";
            lblCategories.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstCategories
            // 
            lstCategories.BorderStyle = BorderStyle.None;
            lstCategories.Dock = DockStyle.Fill;
            lstCategories.DrawMode = DrawMode.OwnerDrawFixed;
            lstCategories.IntegralHeight = false;
            lstCategories.ItemHeight = 40;
            lstCategories.Location = new Point(3, 45);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(126, 536);
            lstCategories.TabIndex = 1;
            // 
            // tlpCatalog
            // 
            tlpCatalog.ColumnCount = 1;
            tlpCatalog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCatalog.Controls.Add(txtSearchProduct, 0, 0);
            tlpCatalog.Controls.Add(cboStock, 0, 1);
            tlpCatalog.Controls.Add(flpProducts, 0, 2);
            tlpCatalog.Dock = DockStyle.Fill;
            tlpCatalog.Location = new Point(132, 0);
            tlpCatalog.Margin = new Padding(0);
            tlpCatalog.Name = "tlpCatalog";
            tlpCatalog.RowCount = 3;
            tlpCatalog.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCatalog.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpCatalog.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCatalog.Size = new Size(528, 584);
            tlpCatalog.TabIndex = 1;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Dock = DockStyle.Fill;
            txtSearchProduct.Location = new Point(3, 3);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Tìm tên món, mã món…";
            txtSearchProduct.Size = new Size(522, 23);
            txtSearchProduct.TabIndex = 0;
            // 
            // cboStock
            // 
            cboStock.Dock = DockStyle.Fill;
            cboStock.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStock.Location = new Point(3, 37);
            cboStock.Name = "cboStock";
            cboStock.Size = new Size(522, 23);
            cboStock.TabIndex = 1;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Dock = DockStyle.Fill;
            flpProducts.Location = new Point(3, 69);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(522, 512);
            flpProducts.TabIndex = 2;
            // 
            // tlpCart
            // 
            tlpCart.ColumnCount = 1;
            tlpCart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCart.Controls.Add(tlpOrderActions, 0, 7);
            tlpCart.Controls.Add(lblCart, 0, 0);
            tlpCart.Controls.Add(dgvCart, 0, 1);
            tlpCart.Controls.Add(tlpQuantity, 0, 2);
            tlpCart.Controls.Add(tlpVoucher, 0, 3);
            tlpCart.Controls.Add(lblTotal, 0, 4);
            tlpCart.Controls.Add(btnSaveOrder, 0, 5);
            tlpCart.Controls.Add(btnPayOrder, 0, 6);
            tlpCart.Dock = DockStyle.Fill;
            tlpCart.Location = new Point(660, 0);
            tlpCart.Margin = new Padding(0);
            tlpCart.Name = "tlpCart";
            tlpCart.RowCount = 8;
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpCart.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCart.Size = new Size(315, 584);
            tlpCart.TabIndex = 2;
            // 
            // tlpOrderActions
            // 
            tlpOrderActions.ColumnCount = 2;
            tlpOrderActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOrderActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpOrderActions.Controls.Add(btnDiscardChanges, 0, 0);
            tlpOrderActions.Controls.Add(btnPrintEstimate, 1, 0);
            tlpOrderActions.Dock = DockStyle.Fill;
            tlpOrderActions.Location = new Point(0, 550);
            tlpOrderActions.Margin = new Padding(0);
            tlpOrderActions.Name = "tlpOrderActions";
            tlpOrderActions.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpOrderActions.Size = new Size(315, 34);
            tlpOrderActions.TabIndex = 0;
            // 
            // btnDiscardChanges
            // 
            btnDiscardChanges.Dock = DockStyle.Fill;
            btnDiscardChanges.Location = new Point(3, 3);
            btnDiscardChanges.Name = "btnDiscardChanges";
            btnDiscardChanges.Size = new Size(151, 28);
            btnDiscardChanges.TabIndex = 0;
            btnDiscardChanges.Text = "Hủy thao tác";
            // 
            // btnPrintEstimate
            // 
            btnPrintEstimate.Dock = DockStyle.Fill;
            btnPrintEstimate.Location = new Point(160, 3);
            btnPrintEstimate.Name = "btnPrintEstimate";
            btnPrintEstimate.Size = new Size(152, 28);
            btnPrintEstimate.TabIndex = 1;
            btnPrintEstimate.Text = "In tạm tính";
            // 
            // lblCart
            // 
            lblCart.AutoEllipsis = true;
            lblCart.Dock = DockStyle.Fill;
            lblCart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCart.Location = new Point(3, 0);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(309, 40);
            lblCart.TabIndex = 1;
            lblCart.Text = "Đơn hiện tại";
            lblCart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(3, 43);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(309, 284);
            dgvCart.TabIndex = 2;
            // 
            // tlpQuantity
            // 
            tlpQuantity.ColumnCount = 3;
            tlpQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpQuantity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpQuantity.Controls.Add(btnDecrease, 0, 0);
            tlpQuantity.Controls.Add(btnIncrease, 1, 0);
            tlpQuantity.Controls.Add(btnRemoveItem, 2, 0);
            tlpQuantity.Dock = DockStyle.Fill;
            tlpQuantity.Location = new Point(0, 330);
            tlpQuantity.Margin = new Padding(0);
            tlpQuantity.Name = "tlpQuantity";
            tlpQuantity.RowCount = 1;
            tlpQuantity.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpQuantity.Size = new Size(315, 36);
            tlpQuantity.TabIndex = 3;
            // 
            // btnDecrease
            // 
            btnDecrease.BackColor = Color.FromArgb(255, 234, 223);
            btnDecrease.Dock = DockStyle.Fill;
            btnDecrease.FlatAppearance.BorderSize = 0;
            btnDecrease.FlatStyle = FlatStyle.Flat;
            btnDecrease.ForeColor = Color.FromArgb(63, 38, 29);
            btnDecrease.Location = new Point(3, 3);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(97, 30);
            btnDecrease.TabIndex = 0;
            btnDecrease.Text = "−";
            btnDecrease.UseVisualStyleBackColor = false;
            // 
            // btnIncrease
            // 
            btnIncrease.BackColor = Color.FromArgb(255, 234, 223);
            btnIncrease.Dock = DockStyle.Fill;
            btnIncrease.FlatAppearance.BorderSize = 0;
            btnIncrease.FlatStyle = FlatStyle.Flat;
            btnIncrease.ForeColor = Color.FromArgb(63, 38, 29);
            btnIncrease.Location = new Point(106, 3);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(97, 30);
            btnIncrease.TabIndex = 1;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(255, 234, 223);
            btnRemoveItem.Dock = DockStyle.Fill;
            btnRemoveItem.FlatAppearance.BorderSize = 0;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.ForeColor = Color.FromArgb(63, 38, 29);
            btnRemoveItem.Location = new Point(209, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(103, 30);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "Xóa món";
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // tlpVoucher
            // 
            tlpVoucher.ColumnCount = 2;
            tlpVoucher.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpVoucher.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tlpVoucher.Controls.Add(txtVoucher, 0, 0);
            tlpVoucher.Controls.Add(btnApplyVoucher, 1, 0);
            tlpVoucher.Dock = DockStyle.Fill;
            tlpVoucher.Location = new Point(0, 366);
            tlpVoucher.Margin = new Padding(0);
            tlpVoucher.Name = "tlpVoucher";
            tlpVoucher.RowCount = 1;
            tlpVoucher.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVoucher.Size = new Size(315, 38);
            tlpVoucher.TabIndex = 4;
            // 
            // txtVoucher
            // 
            txtVoucher.Dock = DockStyle.Fill;
            txtVoucher.Location = new Point(3, 3);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.PlaceholderText = "Mã voucher";
            txtVoucher.Size = new Size(225, 23);
            txtVoucher.TabIndex = 0;
            // 
            // btnApplyVoucher
            // 
            btnApplyVoucher.BackColor = Color.FromArgb(255, 234, 223);
            btnApplyVoucher.Dock = DockStyle.Fill;
            btnApplyVoucher.FlatAppearance.BorderSize = 0;
            btnApplyVoucher.FlatStyle = FlatStyle.Flat;
            btnApplyVoucher.ForeColor = Color.FromArgb(63, 38, 29);
            btnApplyVoucher.Location = new Point(234, 3);
            btnApplyVoucher.Name = "btnApplyVoucher";
            btnApplyVoucher.Size = new Size(78, 32);
            btnApplyVoucher.TabIndex = 1;
            btnApplyVoucher.Text = "Áp dụng";
            btnApplyVoucher.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoEllipsis = true;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(3, 404);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(309, 62);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Tổng thanh toán";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.FromArgb(53, 30, 22);
            btnSaveOrder.Dock = DockStyle.Fill;
            btnSaveOrder.FlatAppearance.BorderSize = 0;
            btnSaveOrder.FlatStyle = FlatStyle.Flat;
            btnSaveOrder.ForeColor = Color.White;
            btnSaveOrder.Location = new Point(3, 469);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(309, 36);
            btnSaveOrder.TabIndex = 6;
            btnSaveOrder.Text = "Lưu món & báo pha chế";
            btnSaveOrder.UseVisualStyleBackColor = false;
            // 
            // btnPayOrder
            // 
            btnPayOrder.BackColor = Color.FromArgb(53, 30, 22);
            btnPayOrder.Dock = DockStyle.Fill;
            btnPayOrder.FlatAppearance.BorderSize = 0;
            btnPayOrder.FlatStyle = FlatStyle.Flat;
            btnPayOrder.ForeColor = Color.White;
            btnPayOrder.Location = new Point(3, 511);
            btnPayOrder.Name = "btnPayOrder";
            btnPayOrder.Size = new Size(309, 36);
            btnPayOrder.TabIndex = 7;
            btnPayOrder.Text = "Thanh toán";
            btnPayOrder.UseVisualStyleBackColor = false;
            btnPayOrder.Click += btnPayOrder_Click;
            // 
            // UcS02
            // 
            BackColor = Color.FromArgb(252, 246, 242);
            Controls.Add(tlpPos);
            ForeColor = Color.FromArgb(55, 34, 25);
            Name = "UcS02";
            Padding = new Padding(10);
            Size = new Size(995, 690);
            tlpPos.ResumeLayout(false);
            tlpContext.ResumeLayout(false);
            tlpSale.ResumeLayout(false);
            tlpCategories.ResumeLayout(false);
            tlpCatalog.ResumeLayout(false);
            tlpCatalog.PerformLayout();
            tlpCart.ResumeLayout(false);
            tlpOrderActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            tlpQuantity.ResumeLayout(false);
            tlpVoucher.ResumeLayout(false);
            tlpVoucher.PerformLayout();
            ResumeLayout(false);
        }
        private TableLayoutPanel tlpPos = null!;
        private Label lblHeading = null!;
        private TableLayoutPanel tlpContext = null!;
        private ComboBox cboService = null!;
        private Label lblOrderInfo = null!;
        private Button btnReturn = null!;
        private TableLayoutPanel tlpSale = null!;
        private TableLayoutPanel tlpCategories = null!;
        private Label lblCategories = null!;
        private ListBox lstCategories = null!;
        private TableLayoutPanel tlpCatalog = null!;
        private TextBox txtSearchProduct = null!;
        private ComboBox cboStock = null!;
        private FlowLayoutPanel flpProducts = null!;
        private TableLayoutPanel tlpCart = null!;
        private Label lblCart = null!;
        private DataGridView dgvCart = null!;
        private TableLayoutPanel tlpQuantity = null!;
        private Button btnDecrease = null!;
        private Button btnIncrease = null!;
        private Button btnRemoveItem = null!;
        private TableLayoutPanel tlpVoucher = null!;
        private TextBox txtVoucher = null!;
        private Button btnApplyVoucher = null!;
        private Label lblTotal = null!;
        private Button btnSaveOrder = null!;
        private Button btnPayOrder = null!;
    }
}
