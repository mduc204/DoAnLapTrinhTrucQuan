namespace DoAnLapTrinhTrucQuan.UserControls
{
    partial class ucProduct
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            pnlTopHeaderButtons = new Panel();
            btnAddProduct = new RoundedButton();
            btnExportExcel = new RoundedButton();
            btnUpdatePrice = new RoundedButton();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlFilterBar = new Panel();
            pnlFilterTrangThai = new RoundedPanel();
            cboFilterStatus = new ComboBox();
            lblPrefixTrangThai = new Label();
            pnlFilterDanhMuc = new RoundedPanel();
            cboFilterCategory = new ComboBox();
            lblPrefixDanhMuc = new Label();
            txtSearch = new RoundedTextBox();
            splitMain = new SplitContainer();
            splitMasterDetail = new SplitContainer();
            pnlMasterCard = new RoundedPanel();
            dgvProduct = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlDetailCard = new RoundedPanel();
            pnlDetailBody = new Panel();
            pnlFormInputs = new Panel();
            tlpInputs = new TableLayoutPanel();
            pnlFieldMa = new Panel();
            txtProductId = new TextBox();
            lblMaMonTitle = new Label();
            pnlFieldDM = new Panel();
            cboCategory = new ComboBox();
            lblDanhMucTitle = new Label();
            pnlFieldTen = new Panel();
            txtName = new TextBox();
            lblTenMonTitle = new Label();
            pnlFieldGiaBan = new Panel();
            txtPrice = new TextBox();
            lblGiaBanTitle = new Label();
            pnlFieldGiaVon = new Panel();
            pnlGiaVonRow = new FlowLayoutPanel();
            lblGiaVonBOM = new Label();
            badgeLai = new StatusBadge();
            lblGiaVonTitle = new Label();
            pnlImageContainer = new Panel();
            lblKichThuocAnh = new Label();
            picProductDetail = new PictureBox();
            pnlMoTaSection = new Panel();
            rtbDescription = new RichTextBox();
            lblMoTaLabel = new Label();
            pnlDetailFooter = new Panel();
            btnToggleStatus = new RoundedButton();
            pnlDetailHeader = new Panel();
            pnlDetailHeaderButtons = new Panel();
            btnSave = new RoundedButton();
            btnPrint = new RoundedButton();
            lblDetailSubHeader = new Label();
            lblDetailHeader = new Label();
            pnlBOMCard = new RoundedPanel();
            dgvBOM = new DataGridView();
            colBOMTenNL = new DataGridViewTextBoxColumn();
            colBOMDinhLuong = new DataGridViewTextBoxColumn();
            colBOMDVT = new DataGridViewTextBoxColumn();
            colBOMGiaVon = new DataGridViewTextBoxColumn();
            colBOMXoa = new DataGridViewButtonColumn();
            pnlBOMFooter = new Panel();
            lblCOGSValue = new Label();
            lblCOGSLabel = new Label();
            pnlBOMHeader = new Panel();
            pnlBOMHeaderButtons = new Panel();
            btnAddIngredient = new RoundedButton();
            btnRecalculate = new RoundedButton();
            lblBOMHeader = new Label();
            pnlTopHeader.SuspendLayout();
            pnlTopHeaderButtons.SuspendLayout();
            pnlFilterBar.SuspendLayout();
            pnlFilterTrangThai.SuspendLayout();
            pnlFilterDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMasterDetail).BeginInit();
            splitMasterDetail.Panel1.SuspendLayout();
            splitMasterDetail.Panel2.SuspendLayout();
            splitMasterDetail.SuspendLayout();
            pnlMasterCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            pnlDetailCard.SuspendLayout();
            pnlDetailBody.SuspendLayout();
            pnlFormInputs.SuspendLayout();
            tlpInputs.SuspendLayout();
            pnlFieldMa.SuspendLayout();
            pnlFieldDM.SuspendLayout();
            pnlFieldTen.SuspendLayout();
            pnlFieldGiaBan.SuspendLayout();
            pnlFieldGiaVon.SuspendLayout();
            pnlGiaVonRow.SuspendLayout();
            pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductDetail).BeginInit();
            pnlMoTaSection.SuspendLayout();
            pnlDetailFooter.SuspendLayout();
            pnlDetailHeader.SuspendLayout();
            pnlDetailHeaderButtons.SuspendLayout();
            pnlBOMCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBOM).BeginInit();
            pnlBOMFooter.SuspendLayout();
            pnlBOMHeader.SuspendLayout();
            pnlBOMHeaderButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.Controls.Add(pnlTopHeaderButtons);
            pnlTopHeader.Controls.Add(lblSubtitle);
            pnlTopHeader.Controls.Add(lblTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(18, 16);
            pnlTopHeader.Margin = new Padding(3, 4, 3, 4);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Size = new Size(1244, 72);
            pnlTopHeader.TabIndex = 0;
            // 
            // pnlTopHeaderButtons
            // 
            pnlTopHeaderButtons.Controls.Add(btnAddProduct);
            pnlTopHeaderButtons.Controls.Add(btnExportExcel);
            pnlTopHeaderButtons.Controls.Add(btnUpdatePrice);
            pnlTopHeaderButtons.Dock = DockStyle.Right;
            pnlTopHeaderButtons.Location = new Point(815, 0);
            pnlTopHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            pnlTopHeaderButtons.Name = "pnlTopHeaderButtons";
            pnlTopHeaderButtons.Size = new Size(429, 72);
            pnlTopHeaderButtons.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Transparent;
            btnAddProduct.BorderColor = Color.Transparent;
            btnAddProduct.BorderRadius = 8;
            btnAddProduct.BorderWidth = 0;
            btnAddProduct.CustomIcon = null;
            btnAddProduct.DownBackColor = Color.FromArgb(74, 50, 34);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.HoverBackColor = Color.FromArgb(91, 63, 43);
            btnAddProduct.IsOutlined = false;
            btnAddProduct.Location = new Point(7, 12);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.NormalBackColor = Color.FromArgb(111, 78, 55);
            btnAddProduct.Size = new Size(135, 48);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "+ Thêm món";
            btnAddProduct.UseVisualStyleBackColor = true;
            
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Transparent;
            btnExportExcel.BorderColor = Color.FromArgb(208, 197, 184);
            btnExportExcel.BorderRadius = 8;
            btnExportExcel.BorderWidth = 1;
            btnExportExcel.CustomIcon = null;
            btnExportExcel.DownBackColor = Color.FromArgb(239, 229, 219);
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.FromArgb(44, 30, 20);
            btnExportExcel.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnExportExcel.IsOutlined = true;
            btnExportExcel.Location = new Point(149, 12);
            btnExportExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.NormalBackColor = Color.White;
            btnExportExcel.Size = new Size(126, 48);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "⭳ Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.BackColor = Color.Transparent;
            btnUpdatePrice.BorderColor = Color.FromArgb(208, 197, 184);
            btnUpdatePrice.BorderRadius = 8;
            btnUpdatePrice.BorderWidth = 1;
            btnUpdatePrice.CustomIcon = null;
            btnUpdatePrice.DownBackColor = Color.FromArgb(239, 229, 219);
            btnUpdatePrice.FlatStyle = FlatStyle.Flat;
            btnUpdatePrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdatePrice.ForeColor = Color.FromArgb(44, 30, 20);
            btnUpdatePrice.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnUpdatePrice.IsOutlined = true;
            btnUpdatePrice.Location = new Point(281, 12);
            btnUpdatePrice.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.NormalBackColor = Color.White;
            btnUpdatePrice.Size = new Size(139, 48);
            btnUpdatePrice.TabIndex = 2;
            btnUpdatePrice.Text = "☷ Cập nhật giá";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblSubtitle.Location = new Point(2, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(367, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "48 món • 44 đang bán • 4 tạm ngưng • 6 danh mục";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 30, 20);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(179, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý món";
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.Controls.Add(pnlFilterTrangThai);
            pnlFilterBar.Controls.Add(pnlFilterDanhMuc);
            pnlFilterBar.Controls.Add(txtSearch);
            pnlFilterBar.Dock = DockStyle.Top;
            pnlFilterBar.Location = new Point(18, 88);
            pnlFilterBar.Margin = new Padding(3, 4, 3, 4);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(1244, 64);
            pnlFilterBar.TabIndex = 1;
            // 
            // pnlFilterTrangThai
            // 
            pnlFilterTrangThai.BackColor = Color.Transparent;
            pnlFilterTrangThai.BorderColor = Color.FromArgb(232, 223, 213);
            pnlFilterTrangThai.BorderRadius = 8;
            pnlFilterTrangThai.BorderWidth = 1;
            pnlFilterTrangThai.Controls.Add(cboFilterStatus);
            pnlFilterTrangThai.Controls.Add(lblPrefixTrangThai);
            pnlFilterTrangThai.FillColor = Color.White;
            pnlFilterTrangThai.Location = new Point(577, 8);
            pnlFilterTrangThai.Margin = new Padding(3, 4, 3, 4);
            pnlFilterTrangThai.Name = "pnlFilterTrangThai";
            pnlFilterTrangThai.Padding = new Padding(12);
            pnlFilterTrangThai.Size = new Size(314, 48);
            pnlFilterTrangThai.TabIndex = 2;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.BackColor = Color.White;
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FlatStyle = FlatStyle.Flat;
            cboFilterStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboFilterStatus.ForeColor = Color.FromArgb(44, 30, 20);
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(110, 8);
            cboFilterStatus.Margin = new Padding(3, 4, 3, 4);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(194, 28);
            cboFilterStatus.TabIndex = 1;
            // 
            // lblPrefixTrangThai
            // 
            lblPrefixTrangThai.AutoSize = true;
            lblPrefixTrangThai.BackColor = Color.Transparent;
            lblPrefixTrangThai.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPrefixTrangThai.ForeColor = Color.FromArgb(141, 131, 123);
            lblPrefixTrangThai.Location = new Point(11, 13);
            lblPrefixTrangThai.Name = "lblPrefixTrangThai";
            lblPrefixTrangThai.Size = new Size(106, 20);
            lblPrefixTrangThai.TabIndex = 0;
            lblPrefixTrangThai.Text = "TRẠNG THÁI:";
            // 
            // pnlFilterDanhMuc
            // 
            pnlFilterDanhMuc.BackColor = Color.Transparent;
            pnlFilterDanhMuc.BorderColor = Color.FromArgb(232, 223, 213);
            pnlFilterDanhMuc.BorderRadius = 8;
            pnlFilterDanhMuc.BorderWidth = 1;
            pnlFilterDanhMuc.Controls.Add(cboFilterCategory);
            pnlFilterDanhMuc.Controls.Add(lblPrefixDanhMuc);
            pnlFilterDanhMuc.FillColor = Color.White;
            pnlFilterDanhMuc.Location = new Point(297, 8);
            pnlFilterDanhMuc.Margin = new Padding(3, 4, 3, 4);
            pnlFilterDanhMuc.Name = "pnlFilterDanhMuc";
            pnlFilterDanhMuc.Padding = new Padding(12);
            pnlFilterDanhMuc.Size = new Size(269, 48);
            pnlFilterDanhMuc.TabIndex = 1;
            // 
            // cboFilterCategory
            // 
            cboFilterCategory.BackColor = Color.White;
            cboFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterCategory.FlatStyle = FlatStyle.Flat;
            cboFilterCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboFilterCategory.ForeColor = Color.FromArgb(44, 30, 20);
            cboFilterCategory.FormattingEnabled = true;
            cboFilterCategory.Location = new Point(74, 8);
            cboFilterCategory.Margin = new Padding(3, 4, 3, 4);
            cboFilterCategory.Name = "cboFilterCategory";
            cboFilterCategory.Size = new Size(185, 28);
            cboFilterCategory.TabIndex = 1;
            // 
            // lblPrefixDanhMuc
            // 
            lblPrefixDanhMuc.AutoSize = true;
            lblPrefixDanhMuc.BackColor = Color.Transparent;
            lblPrefixDanhMuc.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPrefixDanhMuc.ForeColor = Color.FromArgb(141, 131, 123);
            lblPrefixDanhMuc.Location = new Point(11, 13);
            lblPrefixDanhMuc.Name = "lblPrefixDanhMuc";
            lblPrefixDanhMuc.Size = new Size(61, 20);
            lblPrefixDanhMuc.TabIndex = 0;
            lblPrefixDanhMuc.Text = "NHÓM:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderColor = Color.FromArgb(232, 223, 213);
            txtSearch.BorderRadius = 8;
            txtSearch.FocusBorderColor = Color.FromArgb(111, 78, 55);
            txtSearch.Location = new Point(0, 8);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderColor = Color.FromArgb(165, 153, 144);
            txtSearch.PlaceholderText = "🔍 Tìm theo mã món, tên món...";
            txtSearch.PrefixIcon = null;
            txtSearch.ReadOnly = false;
            txtSearch.Size = new Size(286, 48);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextBackgroundColor = Color.White;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(18, 152);
            splitMain.Margin = new Padding(3, 4, 3, 4);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(splitMasterDetail);
            splitMain.Panel1.Padding = new Padding(0, 0, 0, 8);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlBOMCard);
            splitMain.Panel2.Padding = new Padding(0, 5, 0, 0);
            splitMain.Size = new Size(1244, 829);
            splitMain.SplitterDistance = 469;
            splitMain.SplitterWidth = 11;
            splitMain.TabIndex = 2;
            // 
            // splitMasterDetail
            // 
            splitMasterDetail.Dock = DockStyle.Fill;
            splitMasterDetail.Location = new Point(0, 0);
            splitMasterDetail.Margin = new Padding(3, 4, 3, 4);
            splitMasterDetail.Name = "splitMasterDetail";
            // 
            // splitMasterDetail.Panel1
            // 
            splitMasterDetail.Panel1.Controls.Add(pnlMasterCard);
            splitMasterDetail.Panel1.Padding = new Padding(0, 0, 5, 0);
            // 
            // splitMasterDetail.Panel2
            // 
            splitMasterDetail.Panel2.Controls.Add(pnlDetailCard);
            splitMasterDetail.Panel2.Padding = new Padding(5, 0, 0, 0);
            splitMasterDetail.Size = new Size(1244, 461);
            splitMasterDetail.SplitterDistance = 697;
            splitMasterDetail.SplitterWidth = 9;
            splitMasterDetail.TabIndex = 0;
            // 
            // pnlMasterCard
            // 
            pnlMasterCard.BackColor = Color.Transparent;
            pnlMasterCard.BorderColor = Color.FromArgb(232, 223, 213);
            pnlMasterCard.BorderRadius = 12;
            pnlMasterCard.BorderWidth = 1;
            pnlMasterCard.Controls.Add(dgvProduct);
            pnlMasterCard.Dock = DockStyle.Fill;
            pnlMasterCard.FillColor = Color.White;
            pnlMasterCard.Location = new Point(0, 0);
            pnlMasterCard.Margin = new Padding(3, 4, 3, 4);
            pnlMasterCard.Name = "pnlMasterCard";
            pnlMasterCard.Padding = new Padding(9, 11, 9, 11);
            pnlMasterCard.Size = new Size(692, 461);
            pnlMasterCard.TabIndex = 0;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 234, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(44, 30, 20);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 42;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { colMa, colHinhAnh, colTenMon, colGiaBan, colTrangThai });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(9, 11);
            dgvProduct.Margin = new Padding(3, 4, 3, 4);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 52;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(674, 439);
            dgvProduct.TabIndex = 0;
            // 
            // colMa
            // 
            colMa.HeaderText = "MÃ";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            colMa.ReadOnly = true;
            colMa.Resizable = DataGridViewTriState.False;
            colMa.Width = 65;
            // 
            // colHinhAnh
            // 
            colHinhAnh.HeaderText = "ẢNH";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.ReadOnly = true;
            colHinhAnh.Resizable = DataGridViewTriState.False;
            colHinhAnh.Width = 54;
            // 
            // colTenMon
            // 
            colTenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenMon.HeaderText = "TÊN MÓN / DANH MỤC";
            colTenMon.MinimumWidth = 200;
            colTenMon.Name = "colTenMon";
            colTenMon.ReadOnly = true;
            // 
            // colGiaBan
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colGiaBan.DefaultCellStyle = dataGridViewCellStyle2;
            colGiaBan.HeaderText = "GIÁ BÁN";
            colGiaBan.MinimumWidth = 6;
            colGiaBan.Name = "colGiaBan";
            colGiaBan.ReadOnly = true;
            colGiaBan.Width = 95;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 125;
            // 
            // pnlDetailCard
            // 
            pnlDetailCard.BackColor = Color.Transparent;
            pnlDetailCard.BorderColor = Color.FromArgb(232, 223, 213);
            pnlDetailCard.BorderRadius = 12;
            pnlDetailCard.BorderWidth = 1;
            pnlDetailCard.Controls.Add(pnlDetailBody);
            pnlDetailCard.Controls.Add(pnlMoTaSection);
            pnlDetailCard.Controls.Add(pnlDetailFooter);
            pnlDetailCard.Controls.Add(pnlDetailHeader);
            pnlDetailCard.Dock = DockStyle.Fill;
            pnlDetailCard.FillColor = Color.White;
            pnlDetailCard.Location = new Point(5, 0);
            pnlDetailCard.Margin = new Padding(3, 4, 3, 4);
            pnlDetailCard.Name = "pnlDetailCard";
            pnlDetailCard.Padding = new Padding(14, 16, 14, 16);
            pnlDetailCard.Size = new Size(533, 461);
            pnlDetailCard.TabIndex = 0;
            // 
            // pnlDetailBody
            // 
            pnlDetailBody.Controls.Add(pnlFormInputs);
            pnlDetailBody.Controls.Add(pnlImageContainer);
            pnlDetailBody.Dock = DockStyle.Fill;
            pnlDetailBody.Location = new Point(14, 67);
            pnlDetailBody.Margin = new Padding(3, 4, 3, 4);
            pnlDetailBody.Name = "pnlDetailBody";
            pnlDetailBody.Size = new Size(505, 205);
            pnlDetailBody.TabIndex = 1;
            // 
            // pnlFormInputs
            // 
            pnlFormInputs.Controls.Add(tlpInputs);
            pnlFormInputs.Dock = DockStyle.Fill;
            pnlFormInputs.Location = new Point(160, 0);
            pnlFormInputs.Margin = new Padding(3, 4, 3, 4);
            pnlFormInputs.Name = "pnlFormInputs";
            pnlFormInputs.Size = new Size(345, 205);
            pnlFormInputs.TabIndex = 1;
            // 
            // tlpInputs
            // 
            tlpInputs.ColumnCount = 2;
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpInputs.Controls.Add(pnlFieldMa, 0, 0);
            tlpInputs.Controls.Add(pnlFieldDM, 1, 0);
            tlpInputs.Controls.Add(pnlFieldTen, 0, 1);
            tlpInputs.Controls.Add(pnlFieldGiaBan, 0, 2);
            tlpInputs.Controls.Add(pnlFieldGiaVon, 1, 2);
            tlpInputs.Dock = DockStyle.Fill;
            tlpInputs.Location = new Point(0, 0);
            tlpInputs.Margin = new Padding(3, 4, 3, 4);
            tlpInputs.Name = "tlpInputs";
            tlpInputs.RowCount = 3;
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tlpInputs.Size = new Size(345, 205);
            tlpInputs.TabIndex = 0;
            // 
            // pnlFieldMa
            // 
            pnlFieldMa.Controls.Add(txtProductId);
            pnlFieldMa.Controls.Add(lblMaMonTitle);
            pnlFieldMa.Dock = DockStyle.Fill;
            pnlFieldMa.Location = new Point(0, 0);
            pnlFieldMa.Margin = new Padding(0, 0, 5, 0);
            pnlFieldMa.Name = "pnlFieldMa";
            pnlFieldMa.Size = new Size(139, 72);
            pnlFieldMa.TabIndex = 0;
            // 
            // txtProductId
            // 
            txtProductId.BackColor = Color.FromArgb(250, 246, 240);
            txtProductId.BorderStyle = BorderStyle.FixedSingle;
            txtProductId.Dock = DockStyle.Top;
            txtProductId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtProductId.ForeColor = Color.FromArgb(44, 30, 20);
            txtProductId.Location = new Point(0, 24);
            txtProductId.Margin = new Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(139, 29);
            txtProductId.TabIndex = 1;
            txtProductId.Text = "CF02";
            // 
            // lblMaMonTitle
            // 
            lblMaMonTitle.Dock = DockStyle.Top;
            lblMaMonTitle.Font = new Font("Segoe UI", 8F);
            lblMaMonTitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblMaMonTitle.Location = new Point(0, 0);
            lblMaMonTitle.Name = "lblMaMonTitle";
            lblMaMonTitle.Size = new Size(139, 24);
            lblMaMonTitle.TabIndex = 0;
            lblMaMonTitle.Text = "Mã món (*)";
            // 
            // pnlFieldDM
            // 
            pnlFieldDM.Controls.Add(cboCategory);
            pnlFieldDM.Controls.Add(lblDanhMucTitle);
            pnlFieldDM.Dock = DockStyle.Fill;
            pnlFieldDM.Location = new Point(149, 0);
            pnlFieldDM.Margin = new Padding(5, 0, 0, 0);
            pnlFieldDM.Name = "pnlFieldDM";
            pnlFieldDM.Size = new Size(196, 72);
            pnlFieldDM.TabIndex = 1;
            // 
            // cboCategory
            // 
            cboCategory.Dock = DockStyle.Top;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 9F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(0, 24);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(196, 28);
            cboCategory.TabIndex = 1;
            // 
            // lblDanhMucTitle
            // 
            lblDanhMucTitle.Dock = DockStyle.Top;
            lblDanhMucTitle.Font = new Font("Segoe UI", 8F);
            lblDanhMucTitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblDanhMucTitle.Location = new Point(0, 0);
            lblDanhMucTitle.Name = "lblDanhMucTitle";
            lblDanhMucTitle.Size = new Size(196, 24);
            lblDanhMucTitle.TabIndex = 0;
            lblDanhMucTitle.Text = "Danh mục món";
            // 
            // pnlFieldTen
            // 
            tlpInputs.SetColumnSpan(pnlFieldTen, 2);
            pnlFieldTen.Controls.Add(txtName);
            pnlFieldTen.Controls.Add(lblTenMonTitle);
            pnlFieldTen.Dock = DockStyle.Fill;
            pnlFieldTen.Location = new Point(3, 76);
            pnlFieldTen.Margin = new Padding(3, 4, 3, 4);
            pnlFieldTen.Name = "pnlFieldTen";
            pnlFieldTen.Size = new Size(339, 64);
            pnlFieldTen.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Dock = DockStyle.Top;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtName.ForeColor = Color.FromArgb(44, 30, 20);
            txtName.Location = new Point(0, 24);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 30);
            txtName.TabIndex = 1;
            txtName.Text = "Cà phê sữa phin truyền thống";
            // 
            // lblTenMonTitle
            // 
            lblTenMonTitle.Dock = DockStyle.Top;
            lblTenMonTitle.Font = new Font("Segoe UI", 8F);
            lblTenMonTitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblTenMonTitle.Location = new Point(0, 0);
            lblTenMonTitle.Name = "lblTenMonTitle";
            lblTenMonTitle.Size = new Size(339, 24);
            lblTenMonTitle.TabIndex = 0;
            lblTenMonTitle.Text = "Tên món (*)";
            // 
            // pnlFieldGiaBan
            // 
            pnlFieldGiaBan.Controls.Add(txtPrice);
            pnlFieldGiaBan.Controls.Add(lblGiaBanTitle);
            pnlFieldGiaBan.Dock = DockStyle.Fill;
            pnlFieldGiaBan.Location = new Point(0, 144);
            pnlFieldGiaBan.Margin = new Padding(0, 0, 5, 0);
            pnlFieldGiaBan.Name = "pnlFieldGiaBan";
            pnlFieldGiaBan.Size = new Size(139, 72);
            pnlFieldGiaBan.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Dock = DockStyle.Top;
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPrice.ForeColor = Color.FromArgb(111, 78, 55);
            txtPrice.Location = new Point(0, 24);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(139, 30);
            txtPrice.TabIndex = 1;
            txtPrice.Text = "35000";
            // 
            // lblGiaBanTitle
            // 
            lblGiaBanTitle.Dock = DockStyle.Top;
            lblGiaBanTitle.Font = new Font("Segoe UI", 8F);
            lblGiaBanTitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblGiaBanTitle.Location = new Point(0, 0);
            lblGiaBanTitle.Name = "lblGiaBanTitle";
            lblGiaBanTitle.Size = new Size(139, 24);
            lblGiaBanTitle.TabIndex = 0;
            lblGiaBanTitle.Text = "Giá bán niêm yết (VND)";
            // 
            // pnlFieldGiaVon
            // 
            pnlFieldGiaVon.Controls.Add(pnlGiaVonRow);
            pnlFieldGiaVon.Controls.Add(lblGiaVonTitle);
            pnlFieldGiaVon.Dock = DockStyle.Fill;
            pnlFieldGiaVon.Location = new Point(149, 144);
            pnlFieldGiaVon.Margin = new Padding(5, 0, 0, 0);
            pnlFieldGiaVon.Name = "pnlFieldGiaVon";
            pnlFieldGiaVon.Size = new Size(196, 72);
            pnlFieldGiaVon.TabIndex = 4;
            // 
            // pnlGiaVonRow
            // 
            pnlGiaVonRow.Controls.Add(lblGiaVonBOM);
            pnlGiaVonRow.Controls.Add(badgeLai);
            pnlGiaVonRow.Dock = DockStyle.Top;
            pnlGiaVonRow.Location = new Point(0, 24);
            pnlGiaVonRow.Margin = new Padding(3, 4, 3, 4);
            pnlGiaVonRow.Name = "pnlGiaVonRow";
            pnlGiaVonRow.Size = new Size(196, 40);
            pnlGiaVonRow.TabIndex = 1;
            // 
            // lblGiaVonBOM
            // 
            lblGiaVonBOM.AutoSize = true;
            lblGiaVonBOM.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblGiaVonBOM.ForeColor = Color.FromArgb(44, 30, 20);
            lblGiaVonBOM.Location = new Point(0, 3);
            lblGiaVonBOM.Margin = new Padding(0, 3, 7, 0);
            lblGiaVonBOM.Name = "lblGiaVonBOM";
            lblGiaVonBOM.Size = new Size(83, 25);
            lblGiaVonBOM.TabIndex = 0;
            lblGiaVonBOM.Text = "11.200 đ";
            // 
            // badgeLai
            // 
            badgeLai.BackColor = Color.Transparent;
            badgeLai.BadgeColor = Color.FromArgb(226, 248, 232);
            badgeLai.BadgeTextColor = Color.FromArgb(27, 124, 63);
            badgeLai.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            badgeLai.Location = new Point(93, 3);
            badgeLai.Margin = new Padding(3, 3, 0, 0);
            badgeLai.Name = "badgeLai";
            badgeLai.ShowDot = false;
            badgeLai.Size = new Size(78, 29);
            badgeLai.Style = BadgeStyle.Success;
            badgeLai.TabIndex = 1;
            badgeLai.Text = "Lãi: 68%";
            // 
            // lblGiaVonTitle
            // 
            lblGiaVonTitle.Dock = DockStyle.Top;
            lblGiaVonTitle.Font = new Font("Segoe UI", 8F);
            lblGiaVonTitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblGiaVonTitle.Location = new Point(0, 0);
            lblGiaVonTitle.Name = "lblGiaVonTitle";
            lblGiaVonTitle.Size = new Size(196, 24);
            lblGiaVonTitle.TabIndex = 0;
            lblGiaVonTitle.Text = "Giá vốn BOM (Tự tính)";
            // 
            // pnlImageContainer
            // 
            pnlImageContainer.Controls.Add(lblKichThuocAnh);
            pnlImageContainer.Controls.Add(picProductDetail);
            pnlImageContainer.Dock = DockStyle.Left;
            pnlImageContainer.Location = new Point(0, 0);
            pnlImageContainer.Margin = new Padding(3, 4, 3, 4);
            pnlImageContainer.Name = "pnlImageContainer";
            pnlImageContainer.Padding = new Padding(0, 0, 11, 0);
            pnlImageContainer.Size = new Size(160, 205);
            pnlImageContainer.TabIndex = 0;
            // 
            // lblKichThuocAnh
            // 
            lblKichThuocAnh.Cursor = Cursors.Hand;
            lblKichThuocAnh.Dock = DockStyle.Bottom;
            lblKichThuocAnh.Font = new Font("Segoe UI", 7.5F);
            lblKichThuocAnh.ForeColor = Color.FromArgb(126, 110, 101);
            lblKichThuocAnh.Location = new Point(0, 154);
            lblKichThuocAnh.Name = "lblKichThuocAnh";
            lblKichThuocAnh.Size = new Size(149, 51);
            lblKichThuocAnh.TabIndex = 1;
            lblKichThuocAnh.Text = "2048×2048 [PNG, JPG]\r\n(Nhấn để đổi ảnh)";
            lblKichThuocAnh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picProductDetail
            // 
            picProductDetail.BackColor = Color.FromArgb(250, 246, 240);
            picProductDetail.Dock = DockStyle.Top;
            picProductDetail.Location = new Point(0, 0);
            picProductDetail.Margin = new Padding(3, 4, 3, 4);
            picProductDetail.Name = "picProductDetail";
            picProductDetail.Size = new Size(149, 173);
            picProductDetail.SizeMode = PictureBoxSizeMode.Zoom;
            picProductDetail.TabIndex = 0;
            picProductDetail.TabStop = false;
            // 
            // pnlMoTaSection
            // 
            pnlMoTaSection.Controls.Add(rtbDescription);
            pnlMoTaSection.Controls.Add(lblMoTaLabel);
            pnlMoTaSection.Dock = DockStyle.Bottom;
            pnlMoTaSection.Location = new Point(14, 272);
            pnlMoTaSection.Margin = new Padding(3, 4, 3, 4);
            pnlMoTaSection.Name = "pnlMoTaSection";
            pnlMoTaSection.Padding = new Padding(0, 5, 0, 5);
            pnlMoTaSection.Size = new Size(505, 125);
            pnlMoTaSection.TabIndex = 2;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(250, 248, 245);
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Dock = DockStyle.Fill;
            rtbDescription.Font = new Font("Segoe UI", 8.5F);
            rtbDescription.ForeColor = Color.FromArgb(44, 30, 20);
            rtbDescription.Location = new Point(0, 32);
            rtbDescription.Margin = new Padding(3, 4, 3, 4);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(505, 88);
            rtbDescription.TabIndex = 1;
            rtbDescription.Text = "Cà phê Robusta Đắk Lắk nguyên chất pha phin thủ công, hòa quyện sữa đặc thơm béo ngậy. Định lượng đá chuẩn 150g.";
            // 
            // lblMoTaLabel
            // 
            lblMoTaLabel.Dock = DockStyle.Top;
            lblMoTaLabel.Font = new Font("Segoe UI", 8.5F);
            lblMoTaLabel.ForeColor = Color.FromArgb(126, 110, 101);
            lblMoTaLabel.Location = new Point(0, 5);
            lblMoTaLabel.Name = "lblMoTaLabel";
            lblMoTaLabel.Size = new Size(505, 27);
            lblMoTaLabel.TabIndex = 0;
            lblMoTaLabel.Text = "Mô tả hương vị & Ghi chú Barista";
            lblMoTaLabel.UseMnemonic = false;
            // 
            // pnlDetailFooter
            // 
            pnlDetailFooter.Controls.Add(btnToggleStatus);
            pnlDetailFooter.Dock = DockStyle.Bottom;
            pnlDetailFooter.Location = new Point(14, 397);
            pnlDetailFooter.Margin = new Padding(3, 4, 3, 4);
            pnlDetailFooter.Name = "pnlDetailFooter";
            pnlDetailFooter.Padding = new Padding(0, 5, 0, 0);
            pnlDetailFooter.Size = new Size(505, 48);
            pnlDetailFooter.TabIndex = 3;
            // 
            // btnToggleStatus
            // 
            btnToggleStatus.BackColor = Color.Transparent;
            btnToggleStatus.BorderColor = Color.FromArgb(245, 198, 203);
            btnToggleStatus.BorderRadius = 6;
            btnToggleStatus.BorderWidth = 1;
            btnToggleStatus.CustomIcon = null;
            btnToggleStatus.Dock = DockStyle.Right;
            btnToggleStatus.DownBackColor = Color.FromArgb(245, 183, 183);
            btnToggleStatus.FlatStyle = FlatStyle.Flat;
            btnToggleStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnToggleStatus.ForeColor = Color.FromArgb(192, 57, 43);
            btnToggleStatus.HoverBackColor = Color.FromArgb(249, 213, 213);
            btnToggleStatus.IsOutlined = false;
            btnToggleStatus.Location = new Point(299, 5);
            btnToggleStatus.Margin = new Padding(3, 4, 3, 4);
            btnToggleStatus.Name = "btnToggleStatus";
            btnToggleStatus.NormalBackColor = Color.FromArgb(253, 240, 240);
            btnToggleStatus.Size = new Size(206, 43);
            btnToggleStatus.TabIndex = 0;
            btnToggleStatus.Text = "Tạm ngưng bán món này";
            btnToggleStatus.UseVisualStyleBackColor = true;
            // 
            // pnlDetailHeader
            // 
            pnlDetailHeader.Controls.Add(pnlDetailHeaderButtons);
            pnlDetailHeader.Controls.Add(lblDetailSubHeader);
            pnlDetailHeader.Controls.Add(lblDetailHeader);
            pnlDetailHeader.Dock = DockStyle.Top;
            pnlDetailHeader.Location = new Point(14, 16);
            pnlDetailHeader.Margin = new Padding(3, 4, 3, 4);
            pnlDetailHeader.Name = "pnlDetailHeader";
            pnlDetailHeader.Size = new Size(505, 51);
            pnlDetailHeader.TabIndex = 0;
            // 
            // pnlDetailHeaderButtons
            // 
            pnlDetailHeaderButtons.Controls.Add(btnSave);
            pnlDetailHeaderButtons.Controls.Add(btnPrint);
            pnlDetailHeaderButtons.Dock = DockStyle.Right;
            pnlDetailHeaderButtons.Location = new Point(345, 0);
            pnlDetailHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            pnlDetailHeaderButtons.Name = "pnlDetailHeaderButtons";
            pnlDetailHeaderButtons.Size = new Size(160, 51);
            pnlDetailHeaderButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BorderColor = Color.Transparent;
            btnSave.BorderRadius = 6;
            btnSave.BorderWidth = 0;
            btnSave.CustomIcon = null;
            btnSave.DownBackColor = Color.FromArgb(74, 50, 34);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.HoverBackColor = Color.FromArgb(91, 63, 43);
            btnSave.IsOutlined = false;
            btnSave.Location = new Point(2, 4);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.NormalBackColor = Color.FromArgb(111, 78, 55);
            btnSave.Size = new Size(94, 43);
            btnSave.TabIndex = 0;
            btnSave.Text = "💾 Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Transparent;
            btnPrint.BorderColor = Color.FromArgb(208, 197, 184);
            btnPrint.BorderRadius = 6;
            btnPrint.BorderWidth = 1;
            btnPrint.CustomIcon = null;
            btnPrint.DownBackColor = Color.FromArgb(239, 229, 219);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10F);
            btnPrint.ForeColor = Color.FromArgb(44, 30, 20);
            btnPrint.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnPrint.IsOutlined = true;
            btnPrint.Location = new Point(105, 4);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.NormalBackColor = Color.White;
            btnPrint.Size = new Size(43, 43);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "🖨";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblDetailSubHeader
            // 
            lblDetailSubHeader.AutoSize = true;
            lblDetailSubHeader.Font = new Font("Segoe UI", 8.5F);
            lblDetailSubHeader.ForeColor = Color.FromArgb(126, 110, 101);
            lblDetailSubHeader.Location = new Point(3, 18);
            lblDetailSubHeader.Name = "lblDetailSubHeader";
            lblDetailSubHeader.Size = new Size(103, 20);
            lblDetailSubHeader.TabIndex = 1;
            lblDetailSubHeader.Text = "Mã món: CF02";
            // 
            // lblDetailHeader
            // 
            lblDetailHeader.AutoSize = true;
            lblDetailHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailHeader.ForeColor = Color.FromArgb(44, 25, 20);
            lblDetailHeader.Location = new Point(0, -5);
            lblDetailHeader.Name = "lblDetailHeader";
            lblDetailHeader.Size = new Size(158, 23);
            lblDetailHeader.TabIndex = 0;
            lblDetailHeader.Text = "📝 Thông tin món";
            // 
            // pnlBOMCard
            // 
            pnlBOMCard.BackColor = Color.Transparent;
            pnlBOMCard.BorderColor = Color.FromArgb(232, 223, 213);
            pnlBOMCard.BorderRadius = 12;
            pnlBOMCard.BorderWidth = 1;
            pnlBOMCard.Controls.Add(dgvBOM);
            pnlBOMCard.Controls.Add(pnlBOMFooter);
            pnlBOMCard.Controls.Add(pnlBOMHeader);
            pnlBOMCard.Dock = DockStyle.Fill;
            pnlBOMCard.FillColor = Color.White;
            pnlBOMCard.Location = new Point(0, 5);
            pnlBOMCard.Margin = new Padding(3, 4, 3, 4);
            pnlBOMCard.Name = "pnlBOMCard";
            pnlBOMCard.Padding = new Padding(14, 16, 14, 16);
            pnlBOMCard.Size = new Size(1244, 344);
            pnlBOMCard.TabIndex = 0;
            // 
            // dgvBOM
            // 
            dgvBOM.AllowUserToAddRows = false;
            dgvBOM.AllowUserToDeleteRows = false;
            dgvBOM.BackgroundColor = Color.White;
            dgvBOM.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(243, 234, 224);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 30, 20);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBOM.ColumnHeadersHeight = 44;
            dgvBOM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBOM.Columns.AddRange(new DataGridViewColumn[] { colBOMTenNL, colBOMDinhLuong, colBOMDVT, colBOMGiaVon, colBOMXoa });
            dgvBOM.Dock = DockStyle.Fill;
            dgvBOM.Location = new Point(14, 67);
            dgvBOM.Margin = new Padding(3, 4, 3, 4);
            dgvBOM.Name = "dgvBOM";
            dgvBOM.RowHeadersVisible = false;
            dgvBOM.RowHeadersWidth = 51;
            dgvBOM.RowTemplate.Height = 46;
            dgvBOM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBOM.Size = new Size(1216, 210);
            dgvBOM.TabIndex = 1;
            // 
            // colBOMTenNL
            // 
            colBOMTenNL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBOMTenNL.HeaderText = "NGUYÊN LIỆU PHA CHẾ";
            colBOMTenNL.MinimumWidth = 220;
            colBOMTenNL.Name = "colBOMTenNL";
            colBOMTenNL.ReadOnly = true;
            // 
            // colBOMDinhLuong
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colBOMDinhLuong.DefaultCellStyle = dataGridViewCellStyle4;
            colBOMDinhLuong.HeaderText = "ĐỊNH LƯỢNG";
            colBOMDinhLuong.MinimumWidth = 6;
            colBOMDinhLuong.Name = "colBOMDinhLuong";
            colBOMDinhLuong.Resizable = DataGridViewTriState.False;
            colBOMDinhLuong.Width = 140;
            // 
            // colBOMDVT
            // 
            colBOMDVT.HeaderText = "ĐVT";
            colBOMDVT.MinimumWidth = 6;
            colBOMDVT.Name = "colBOMDVT";
            colBOMDVT.ReadOnly = true;
            colBOMDVT.Resizable = DataGridViewTriState.False;
            colBOMDVT.Width = 130;
            // 
            // colBOMGiaVon
            // 
            colBOMGiaVon.HeaderText = "GIÁ VỐN";
            colBOMGiaVon.MinimumWidth = 6;
            colBOMGiaVon.Name = "colBOMGiaVon";
            colBOMGiaVon.ReadOnly = true;
            colBOMGiaVon.Resizable = DataGridViewTriState.False;
            colBOMGiaVon.Width = 140;
            // 
            // colBOMXoa
            // 
            colBOMXoa.FlatStyle = FlatStyle.Flat;
            colBOMXoa.HeaderText = "XÓA";
            colBOMXoa.MinimumWidth = 6;
            colBOMXoa.Name = "colBOMXoa";
            colBOMXoa.Resizable = DataGridViewTriState.False;
            colBOMXoa.Text = "🗑";
            colBOMXoa.UseColumnTextForButtonValue = true;
            colBOMXoa.Width = 70;
            // 
            // pnlBOMFooter
            // 
            pnlBOMFooter.Controls.Add(lblCOGSValue);
            pnlBOMFooter.Controls.Add(lblCOGSLabel);
            pnlBOMFooter.Dock = DockStyle.Bottom;
            pnlBOMFooter.Location = new Point(14, 277);
            pnlBOMFooter.Margin = new Padding(3, 4, 3, 4);
            pnlBOMFooter.Name = "pnlBOMFooter";
            pnlBOMFooter.Size = new Size(1216, 51);
            pnlBOMFooter.TabIndex = 2;
            // 
            // lblCOGSValue
            // 
            lblCOGSValue.Dock = DockStyle.Right;
            lblCOGSValue.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblCOGSValue.ForeColor = Color.FromArgb(192, 106, 43);
            lblCOGSValue.Location = new Point(873, 0);
            lblCOGSValue.Name = "lblCOGSValue";
            lblCOGSValue.Size = new Size(343, 51);
            lblCOGSValue.TabIndex = 1;
            lblCOGSValue.Text = "11.200 đ / suất";
            lblCOGSValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCOGSLabel
            // 
            lblCOGSLabel.Dock = DockStyle.Left;
            lblCOGSLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCOGSLabel.ForeColor = Color.FromArgb(44, 30, 20);
            lblCOGSLabel.Location = new Point(0, 0);
            lblCOGSLabel.Name = "lblCOGSLabel";
            lblCOGSLabel.Size = new Size(480, 51);
            lblCOGSLabel.TabIndex = 0;
            lblCOGSLabel.Text = "TỔNG GIÁ VỐN NGUYÊN VẬT LIỆU TRỰC TIẾP (COGS):";
            lblCOGSLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBOMHeader
            // 
            pnlBOMHeader.Controls.Add(pnlBOMHeaderButtons);
            pnlBOMHeader.Controls.Add(lblBOMHeader);
            pnlBOMHeader.Dock = DockStyle.Top;
            pnlBOMHeader.Location = new Point(14, 16);
            pnlBOMHeader.Margin = new Padding(3, 4, 3, 4);
            pnlBOMHeader.Name = "pnlBOMHeader";
            pnlBOMHeader.Size = new Size(1216, 51);
            pnlBOMHeader.TabIndex = 0;
            // 
            // pnlBOMHeaderButtons
            // 
            pnlBOMHeaderButtons.Controls.Add(btnAddIngredient);
            pnlBOMHeaderButtons.Controls.Add(btnRecalculate);
            pnlBOMHeaderButtons.Dock = DockStyle.Right;
            pnlBOMHeaderButtons.Location = new Point(896, 0);
            pnlBOMHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            pnlBOMHeaderButtons.Name = "pnlBOMHeaderButtons";
            pnlBOMHeaderButtons.Size = new Size(320, 51);
            pnlBOMHeaderButtons.TabIndex = 1;
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.BackColor = Color.Transparent;
            btnAddIngredient.BorderColor = Color.Transparent;
            btnAddIngredient.BorderRadius = 6;
            btnAddIngredient.BorderWidth = 0;
            btnAddIngredient.CustomIcon = null;
            btnAddIngredient.DownBackColor = Color.FromArgb(74, 50, 34);
            btnAddIngredient.FlatStyle = FlatStyle.Flat;
            btnAddIngredient.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAddIngredient.ForeColor = Color.White;
            btnAddIngredient.HoverBackColor = Color.FromArgb(91, 63, 43);
            btnAddIngredient.IsOutlined = false;
            btnAddIngredient.Location = new Point(7, 5);
            btnAddIngredient.Margin = new Padding(3, 4, 3, 4);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.NormalBackColor = Color.FromArgb(111, 78, 55);
            btnAddIngredient.Size = new Size(174, 40);
            btnAddIngredient.TabIndex = 0;
            btnAddIngredient.Text = "+ Thêm nguyên liệu";
            btnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // btnRecalculate
            // 
            btnRecalculate.BackColor = Color.Transparent;
            btnRecalculate.BorderColor = Color.FromArgb(208, 197, 184);
            btnRecalculate.BorderRadius = 6;
            btnRecalculate.BorderWidth = 1;
            btnRecalculate.CustomIcon = null;
            btnRecalculate.DownBackColor = Color.FromArgb(239, 229, 219);
            btnRecalculate.FlatStyle = FlatStyle.Flat;
            btnRecalculate.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRecalculate.ForeColor = Color.FromArgb(44, 30, 20);
            btnRecalculate.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnRecalculate.IsOutlined = true;
            btnRecalculate.Location = new Point(187, 5);
            btnRecalculate.Margin = new Padding(3, 4, 3, 4);
            btnRecalculate.Name = "btnRecalculate";
            btnRecalculate.NormalBackColor = Color.White;
            btnRecalculate.Size = new Size(126, 40);
            btnRecalculate.TabIndex = 1;
            btnRecalculate.Text = "☷ Tính lại giá";
            btnRecalculate.UseVisualStyleBackColor = true;
            // 
            // lblBOMHeader
            // 
            lblBOMHeader.AutoSize = true;
            lblBOMHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBOMHeader.ForeColor = Color.FromArgb(44, 30, 20);
            lblBOMHeader.Location = new Point(0, 11);
            lblBOMHeader.Name = "lblBOMHeader";
            lblBOMHeader.Size = new Size(262, 25);
            lblBOMHeader.TabIndex = 0;
            lblBOMHeader.Text = "⚗ Định lượng pha chế - 1 ly";
            // 
            // ucQuanLyMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 240);
            Controls.Add(splitMain);
            Controls.Add(pnlFilterBar);
            Controls.Add(pnlTopHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucQuanLyMon";
            Padding = new Padding(18, 16, 18, 16);
            Size = new Size(1280, 997);
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlTopHeaderButtons.ResumeLayout(false);
            pnlFilterBar.ResumeLayout(false);
            pnlFilterTrangThai.ResumeLayout(false);
            pnlFilterTrangThai.PerformLayout();
            pnlFilterDanhMuc.ResumeLayout(false);
            pnlFilterDanhMuc.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            splitMasterDetail.Panel1.ResumeLayout(false);
            splitMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMasterDetail).EndInit();
            splitMasterDetail.ResumeLayout(false);
            pnlMasterCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            pnlDetailCard.ResumeLayout(false);
            pnlDetailBody.ResumeLayout(false);
            pnlFormInputs.ResumeLayout(false);
            tlpInputs.ResumeLayout(false);
            pnlFieldMa.ResumeLayout(false);
            pnlFieldMa.PerformLayout();
            pnlFieldDM.ResumeLayout(false);
            pnlFieldTen.ResumeLayout(false);
            pnlFieldTen.PerformLayout();
            pnlFieldGiaBan.ResumeLayout(false);
            pnlFieldGiaBan.PerformLayout();
            pnlFieldGiaVon.ResumeLayout(false);
            pnlGiaVonRow.ResumeLayout(false);
            pnlGiaVonRow.PerformLayout();
            pnlImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductDetail).EndInit();
            pnlMoTaSection.ResumeLayout(false);
            pnlDetailFooter.ResumeLayout(false);
            pnlDetailHeader.ResumeLayout(false);
            pnlDetailHeader.PerformLayout();
            pnlDetailHeaderButtons.ResumeLayout(false);
            pnlBOMCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBOM).EndInit();
            pnlBOMFooter.ResumeLayout(false);
            pnlBOMHeader.ResumeLayout(false);
            pnlBOMHeader.PerformLayout();
            pnlBOMHeaderButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlTopHeaderButtons;
        private DoAnLapTrinhTrucQuan.RoundedButton btnAddProduct;
        private DoAnLapTrinhTrucQuan.RoundedButton btnExportExcel;
        private DoAnLapTrinhTrucQuan.RoundedButton btnUpdatePrice;
        private System.Windows.Forms.Panel pnlFilterBar;
        private DoAnLapTrinhTrucQuan.RoundedTextBox txtSearch;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlFilterDanhMuc;
        private System.Windows.Forms.Label lblPrefixDanhMuc;
        private System.Windows.Forms.ComboBox cboFilterCategory;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlFilterTrangThai;
        private System.Windows.Forms.Label lblPrefixTrangThai;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitMasterDetail;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlMasterCard;
        private System.Windows.Forms.DataGridView dgvProduct;
                private DoAnLapTrinhTrucQuan.RoundedPanel pnlDetailCard;
        private System.Windows.Forms.Panel pnlDetailHeader;
        private System.Windows.Forms.Label lblDetailHeader;
        private System.Windows.Forms.Label lblDetailSubHeader;
        private System.Windows.Forms.Panel pnlDetailHeaderButtons;
        private DoAnLapTrinhTrucQuan.RoundedButton btnSave;
        private DoAnLapTrinhTrucQuan.RoundedButton btnPrint;
        private System.Windows.Forms.Panel pnlDetailBody;
        private System.Windows.Forms.Panel pnlImageContainer;
        private System.Windows.Forms.PictureBox picProductDetail;
        private System.Windows.Forms.Label lblKichThuocAnh;
        private System.Windows.Forms.Panel pnlFormInputs;
        private System.Windows.Forms.TableLayoutPanel tlpInputs;
        private System.Windows.Forms.Panel pnlFieldMa;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblMaMonTitle;
        private System.Windows.Forms.Panel pnlFieldDM;
        private System.Windows.Forms.Label lblDanhMucTitle;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Panel pnlFieldTen;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTenMonTitle;
        private System.Windows.Forms.Panel pnlFieldGiaBan;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblGiaBanTitle;
        private System.Windows.Forms.Panel pnlFieldGiaVon;
        private System.Windows.Forms.Label lblGiaVonTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlGiaVonRow;
        private System.Windows.Forms.Label lblGiaVonBOM;
        private DoAnLapTrinhTrucQuan.StatusBadge badgeLai;
        private System.Windows.Forms.Panel pnlMoTaSection;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblMoTaLabel;
        private System.Windows.Forms.Panel pnlDetailFooter;
        private DoAnLapTrinhTrucQuan.RoundedButton btnToggleStatus;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlBOMCard;
        private System.Windows.Forms.Panel pnlBOMHeader;
        private System.Windows.Forms.Label lblBOMHeader;
        private System.Windows.Forms.Panel pnlBOMHeaderButtons;
        private DoAnLapTrinhTrucQuan.RoundedButton btnAddIngredient;
        private DoAnLapTrinhTrucQuan.RoundedButton btnRecalculate;
        private System.Windows.Forms.DataGridView dgvBOM;
        private System.Windows.Forms.Panel pnlBOMFooter;
        private System.Windows.Forms.Label lblCOGSLabel;
        private System.Windows.Forms.Label lblCOGSValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewImageColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
                private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMDinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMGiaVon;
        private System.Windows.Forms.DataGridViewButtonColumn colBOMXoa;
    }
}
