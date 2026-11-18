namespace DoAnLapTrinhTrucQuan.UserControls
{
    partial class ucQuanLyMon
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
            btnThemMon = new RoundedButton();
            btnXuatExcel = new RoundedButton();
            btnCapNhatGia = new RoundedButton();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlFilterBar = new Panel();
            pnlFilterTrangThai = new RoundedPanel();
            cboLocTrangThai = new ComboBox();
            lblPrefixTrangThai = new Label();
            pnlFilterDanhMuc = new RoundedPanel();
            cboLocDanhMuc = new ComboBox();
            lblPrefixDanhMuc = new Label();
            txtTimKiem = new RoundedTextBox();
            splitMain = new SplitContainer();
            splitMasterDetail = new SplitContainer();
            pnlMasterCard = new RoundedPanel();
            dgvMon = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            colTenMon = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colDinhLuong = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlPagination = new Panel();
            pnlPageButtons = new FlowLayoutPanel();
            btnFirstPage = new Button();
            btnPrevPage = new Button();
            btnPage1 = new Button();
            btnPage2 = new Button();
            btnPage3 = new Button();
            btnNextPage = new Button();
            btnLastPage = new Button();
            lblPagination = new Label();
            pnlDetailCard = new RoundedPanel();
            pnlDetailBody = new Panel();
            pnlFormInputs = new Panel();
            tblInputs = new TableLayoutPanel();
            pnlFieldMa = new Panel();
            txtMaMon = new TextBox();
            lblMaMonTitle = new Label();
            pnlFieldDM = new Panel();
            cboDetailDanhMuc = new ComboBox();
            lblDanhMucTitle = new Label();
            pnlFieldTen = new Panel();
            txtTenMon = new TextBox();
            lblTenMonTitle = new Label();
            pnlFieldGiaBan = new Panel();
            txtGiaBan = new TextBox();
            lblGiaBanTitle = new Label();
            pnlFieldGiaVon = new Panel();
            pnlGiaVonRow = new FlowLayoutPanel();
            lblGiaVonBOM = new Label();
            badgeLai = new StatusBadge();
            lblGiaVonTitle = new Label();
            pnlImageContainer = new Panel();
            lblKichThuocAnh = new Label();
            picMonDetail = new PictureBox();
            pnlMoTaSection = new Panel();
            rtbMoTa = new RichTextBox();
            lblMoTaLabel = new Label();
            pnlDetailFooter = new Panel();
            btnTamNgung = new RoundedButton();
            pnlDetailHeader = new Panel();
            pnlDetailHeaderButtons = new Panel();
            btnLuuMon = new RoundedButton();
            btnInMon = new RoundedButton();
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
            btnThemNguyenLieu = new RoundedButton();
            btnTinhLaiGia = new RoundedButton();
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
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            pnlPagination.SuspendLayout();
            pnlPageButtons.SuspendLayout();
            pnlDetailCard.SuspendLayout();
            pnlDetailBody.SuspendLayout();
            pnlFormInputs.SuspendLayout();
            tblInputs.SuspendLayout();
            pnlFieldMa.SuspendLayout();
            pnlFieldDM.SuspendLayout();
            pnlFieldTen.SuspendLayout();
            pnlFieldGiaBan.SuspendLayout();
            pnlFieldGiaVon.SuspendLayout();
            pnlGiaVonRow.SuspendLayout();
            pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMonDetail).BeginInit();
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
            pnlTopHeaderButtons.Controls.Add(btnThemMon);
            pnlTopHeaderButtons.Controls.Add(btnXuatExcel);
            pnlTopHeaderButtons.Controls.Add(btnCapNhatGia);
            pnlTopHeaderButtons.Dock = DockStyle.Right;
            pnlTopHeaderButtons.Location = new Point(815, 0);
            pnlTopHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            pnlTopHeaderButtons.Name = "pnlTopHeaderButtons";
            pnlTopHeaderButtons.Size = new Size(429, 72);
            pnlTopHeaderButtons.TabIndex = 2;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.Transparent;
            btnThemMon.BorderColor = Color.Transparent;
            btnThemMon.BorderRadius = 8;
            btnThemMon.BorderWidth = 0;
            btnThemMon.CustomIcon = null;
            btnThemMon.DownBackColor = Color.FromArgb(74, 50, 34);
            btnThemMon.FlatStyle = FlatStyle.Flat;
            btnThemMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemMon.ForeColor = Color.White;
            btnThemMon.HoverBackColor = Color.FromArgb(91, 63, 43);
            btnThemMon.IsOutlined = false;
            btnThemMon.Location = new Point(7, 12);
            btnThemMon.Margin = new Padding(3, 4, 3, 4);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.NormalBackColor = Color.FromArgb(111, 78, 55);
            btnThemMon.Size = new Size(135, 48);
            btnThemMon.TabIndex = 0;
            btnThemMon.Text = "+ Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += BtnThemMon_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.Transparent;
            btnXuatExcel.BorderColor = Color.FromArgb(208, 197, 184);
            btnXuatExcel.BorderRadius = 8;
            btnXuatExcel.BorderWidth = 1;
            btnXuatExcel.CustomIcon = null;
            btnXuatExcel.DownBackColor = Color.FromArgb(239, 229, 219);
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.FromArgb(44, 30, 20);
            btnXuatExcel.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnXuatExcel.IsOutlined = true;
            btnXuatExcel.Location = new Point(149, 12);
            btnXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.NormalBackColor = Color.White;
            btnXuatExcel.Size = new Size(126, 48);
            btnXuatExcel.TabIndex = 1;
            btnXuatExcel.Text = "⭳ Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatGia
            // 
            btnCapNhatGia.BackColor = Color.Transparent;
            btnCapNhatGia.BorderColor = Color.FromArgb(208, 197, 184);
            btnCapNhatGia.BorderRadius = 8;
            btnCapNhatGia.BorderWidth = 1;
            btnCapNhatGia.CustomIcon = null;
            btnCapNhatGia.DownBackColor = Color.FromArgb(239, 229, 219);
            btnCapNhatGia.FlatStyle = FlatStyle.Flat;
            btnCapNhatGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapNhatGia.ForeColor = Color.FromArgb(44, 30, 20);
            btnCapNhatGia.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnCapNhatGia.IsOutlined = true;
            btnCapNhatGia.Location = new Point(281, 12);
            btnCapNhatGia.Margin = new Padding(3, 4, 3, 4);
            btnCapNhatGia.Name = "btnCapNhatGia";
            btnCapNhatGia.NormalBackColor = Color.White;
            btnCapNhatGia.Size = new Size(139, 48);
            btnCapNhatGia.TabIndex = 2;
            btnCapNhatGia.Text = "☷ Cập nhật giá";
            btnCapNhatGia.UseVisualStyleBackColor = true;
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
            pnlFilterBar.Controls.Add(txtTimKiem);
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
            pnlFilterTrangThai.Controls.Add(cboLocTrangThai);
            pnlFilterTrangThai.Controls.Add(lblPrefixTrangThai);
            pnlFilterTrangThai.FillColor = Color.White;
            pnlFilterTrangThai.Location = new Point(577, 8);
            pnlFilterTrangThai.Margin = new Padding(3, 4, 3, 4);
            pnlFilterTrangThai.Name = "pnlFilterTrangThai";
            pnlFilterTrangThai.Padding = new Padding(12);
            pnlFilterTrangThai.Size = new Size(314, 48);
            pnlFilterTrangThai.TabIndex = 2;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.BackColor = Color.White;
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.FlatStyle = FlatStyle.Flat;
            cboLocTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboLocTrangThai.ForeColor = Color.FromArgb(44, 30, 20);
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Location = new Point(110, 8);
            cboLocTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(194, 28);
            cboLocTrangThai.TabIndex = 1;
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
            pnlFilterDanhMuc.Controls.Add(cboLocDanhMuc);
            pnlFilterDanhMuc.Controls.Add(lblPrefixDanhMuc);
            pnlFilterDanhMuc.FillColor = Color.White;
            pnlFilterDanhMuc.Location = new Point(297, 8);
            pnlFilterDanhMuc.Margin = new Padding(3, 4, 3, 4);
            pnlFilterDanhMuc.Name = "pnlFilterDanhMuc";
            pnlFilterDanhMuc.Padding = new Padding(12);
            pnlFilterDanhMuc.Size = new Size(269, 48);
            pnlFilterDanhMuc.TabIndex = 1;
            // 
            // cboLocDanhMuc
            // 
            cboLocDanhMuc.BackColor = Color.White;
            cboLocDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocDanhMuc.FlatStyle = FlatStyle.Flat;
            cboLocDanhMuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboLocDanhMuc.ForeColor = Color.FromArgb(44, 30, 20);
            cboLocDanhMuc.FormattingEnabled = true;
            cboLocDanhMuc.Location = new Point(74, 8);
            cboLocDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboLocDanhMuc.Name = "cboLocDanhMuc";
            cboLocDanhMuc.Size = new Size(185, 28);
            cboLocDanhMuc.TabIndex = 1;
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
            // txtTimKiem
            // 
            txtTimKiem.BackColor = Color.Transparent;
            txtTimKiem.BorderColor = Color.FromArgb(232, 223, 213);
            txtTimKiem.BorderRadius = 8;
            txtTimKiem.FocusBorderColor = Color.FromArgb(111, 78, 55);
            txtTimKiem.Location = new Point(0, 8);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderColor = Color.FromArgb(165, 153, 144);
            txtTimKiem.PlaceholderText = "🔍 Tìm theo mã món, tên món...";
            txtTimKiem.PrefixIcon = null;
            txtTimKiem.ReadOnly = false;
            txtTimKiem.Size = new Size(286, 48);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextAlign = HorizontalAlignment.Left;
            txtTimKiem.TextBackgroundColor = Color.White;
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
            splitMain.SplitterDistance = 493;
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
            splitMasterDetail.Size = new Size(1244, 485);
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
            pnlMasterCard.Controls.Add(dgvMon);
            pnlMasterCard.Controls.Add(pnlPagination);
            pnlMasterCard.Dock = DockStyle.Fill;
            pnlMasterCard.FillColor = Color.White;
            pnlMasterCard.Location = new Point(0, 0);
            pnlMasterCard.Margin = new Padding(3, 4, 3, 4);
            pnlMasterCard.Name = "pnlMasterCard";
            pnlMasterCard.Padding = new Padding(9, 11, 9, 11);
            pnlMasterCard.Size = new Size(692, 485);
            pnlMasterCard.TabIndex = 0;
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.BackgroundColor = Color.White;
            dgvMon.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 234, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(44, 30, 20);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMon.ColumnHeadersHeight = 42;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMon.Columns.AddRange(new DataGridViewColumn[] { colMa, colHinhAnh, colTenMon, colGiaBan, colDinhLuong, colTrangThai });
            dgvMon.Dock = DockStyle.Fill;
            dgvMon.Location = new Point(9, 11);
            dgvMon.Margin = new Padding(3, 4, 3, 4);
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dgvMon.RowHeadersVisible = false;
            dgvMon.RowHeadersWidth = 51;
            dgvMon.RowTemplate.Height = 52;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(674, 415);
            dgvMon.TabIndex = 0;
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
            // colDinhLuong
            // 
            colDinhLuong.HeaderText = "ĐL";
            colDinhLuong.MinimumWidth = 6;
            colDinhLuong.Name = "colDinhLuong";
            colDinhLuong.ReadOnly = true;
            colDinhLuong.Resizable = DataGridViewTriState.False;
            colDinhLuong.Width = 55;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 125;
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(pnlPageButtons);
            pnlPagination.Controls.Add(lblPagination);
            pnlPagination.Dock = DockStyle.Bottom;
            pnlPagination.Location = new Point(9, 426);
            pnlPagination.Margin = new Padding(3, 4, 3, 4);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(674, 48);
            pnlPagination.TabIndex = 1;
            // 
            // pnlPageButtons
            // 
            pnlPageButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPageButtons.Controls.Add(btnFirstPage);
            pnlPageButtons.Controls.Add(btnPrevPage);
            pnlPageButtons.Controls.Add(btnPage1);
            pnlPageButtons.Controls.Add(btnPage2);
            pnlPageButtons.Controls.Add(btnPage3);
            pnlPageButtons.Controls.Add(btnNextPage);
            pnlPageButtons.Controls.Add(btnLastPage);
            pnlPageButtons.Location = new Point(400, 5);
            pnlPageButtons.Margin = new Padding(3, 4, 3, 4);
            pnlPageButtons.Name = "pnlPageButtons";
            pnlPageButtons.Size = new Size(270, 37);
            pnlPageButtons.TabIndex = 1;
            // 
            // btnFirstPage
            // 
            btnFirstPage.FlatStyle = FlatStyle.Flat;
            btnFirstPage.Font = new Font("Segoe UI", 7.5F);
            btnFirstPage.ForeColor = Color.FromArgb(126, 110, 101);
            btnFirstPage.Location = new Point(2, 3);
            btnFirstPage.Margin = new Padding(2, 3, 2, 3);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(32, 32);
            btnFirstPage.TabIndex = 0;
            btnFirstPage.Text = "|<";
            btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnPrevPage
            // 
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Font = new Font("Segoe UI", 7.5F);
            btnPrevPage.ForeColor = Color.FromArgb(126, 110, 101);
            btnPrevPage.Location = new Point(38, 3);
            btnPrevPage.Margin = new Padding(2, 3, 2, 3);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(32, 32);
            btnPrevPage.TabIndex = 1;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            btnPage1.BackColor = Color.FromArgb(74, 50, 34);
            btnPage1.FlatStyle = FlatStyle.Flat;
            btnPage1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnPage1.ForeColor = Color.White;
            btnPage1.Location = new Point(74, 3);
            btnPage1.Margin = new Padding(2, 3, 2, 3);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(32, 32);
            btnPage1.TabIndex = 2;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            // 
            // btnPage2
            // 
            btnPage2.FlatStyle = FlatStyle.Flat;
            btnPage2.Font = new Font("Segoe UI", 8F);
            btnPage2.ForeColor = Color.FromArgb(126, 110, 101);
            btnPage2.Location = new Point(110, 3);
            btnPage2.Margin = new Padding(2, 3, 2, 3);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(32, 32);
            btnPage2.TabIndex = 3;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = true;
            // 
            // btnPage3
            // 
            btnPage3.FlatStyle = FlatStyle.Flat;
            btnPage3.Font = new Font("Segoe UI", 8F);
            btnPage3.ForeColor = Color.FromArgb(126, 110, 101);
            btnPage3.Location = new Point(146, 3);
            btnPage3.Margin = new Padding(2, 3, 2, 3);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(32, 32);
            btnPage3.TabIndex = 4;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI", 7.5F);
            btnNextPage.ForeColor = Color.FromArgb(126, 110, 101);
            btnNextPage.Location = new Point(182, 3);
            btnNextPage.Margin = new Padding(2, 3, 2, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(32, 32);
            btnNextPage.TabIndex = 5;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            btnLastPage.FlatStyle = FlatStyle.Flat;
            btnLastPage.Font = new Font("Segoe UI", 7.5F);
            btnLastPage.ForeColor = Color.FromArgb(126, 110, 101);
            btnLastPage.Location = new Point(218, 3);
            btnLastPage.Margin = new Padding(2, 3, 2, 3);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(32, 32);
            btnLastPage.TabIndex = 6;
            btnLastPage.Text = ">|";
            btnLastPage.UseVisualStyleBackColor = true;
            // 
            // lblPagination
            // 
            lblPagination.AutoSize = true;
            lblPagination.Font = new Font("Segoe UI", 8.5F);
            lblPagination.ForeColor = Color.FromArgb(126, 110, 101);
            lblPagination.Location = new Point(5, 13);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(182, 20);
            lblPagination.TabIndex = 0;
            lblPagination.Text = "Trang 1 / 8 (Tổng 48 món)";
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
            pnlDetailCard.Size = new Size(533, 485);
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
            pnlDetailBody.Size = new Size(505, 229);
            pnlDetailBody.TabIndex = 1;
            // 
            // pnlFormInputs
            // 
            pnlFormInputs.Controls.Add(tblInputs);
            pnlFormInputs.Dock = DockStyle.Fill;
            pnlFormInputs.Location = new Point(160, 0);
            pnlFormInputs.Margin = new Padding(3, 4, 3, 4);
            pnlFormInputs.Name = "pnlFormInputs";
            pnlFormInputs.Size = new Size(345, 229);
            pnlFormInputs.TabIndex = 1;
            // 
            // tblInputs
            // 
            tblInputs.ColumnCount = 2;
            tblInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tblInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tblInputs.Controls.Add(pnlFieldMa, 0, 0);
            tblInputs.Controls.Add(pnlFieldDM, 1, 0);
            tblInputs.Controls.Add(pnlFieldTen, 0, 1);
            tblInputs.Controls.Add(pnlFieldGiaBan, 0, 2);
            tblInputs.Controls.Add(pnlFieldGiaVon, 1, 2);
            tblInputs.Dock = DockStyle.Fill;
            tblInputs.Location = new Point(0, 0);
            tblInputs.Margin = new Padding(3, 4, 3, 4);
            tblInputs.Name = "tblInputs";
            tblInputs.RowCount = 3;
            tblInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tblInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tblInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tblInputs.Size = new Size(345, 229);
            tblInputs.TabIndex = 0;
            // 
            // pnlFieldMa
            // 
            pnlFieldMa.Controls.Add(txtMaMon);
            pnlFieldMa.Controls.Add(lblMaMonTitle);
            pnlFieldMa.Dock = DockStyle.Fill;
            pnlFieldMa.Location = new Point(0, 0);
            pnlFieldMa.Margin = new Padding(0, 0, 5, 0);
            pnlFieldMa.Name = "pnlFieldMa";
            pnlFieldMa.Size = new Size(139, 72);
            pnlFieldMa.TabIndex = 0;
            // 
            // txtMaMon
            // 
            txtMaMon.BackColor = Color.FromArgb(250, 246, 240);
            txtMaMon.BorderStyle = BorderStyle.FixedSingle;
            txtMaMon.Dock = DockStyle.Top;
            txtMaMon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtMaMon.ForeColor = Color.FromArgb(44, 30, 20);
            txtMaMon.Location = new Point(0, 24);
            txtMaMon.Margin = new Padding(3, 4, 3, 4);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.ReadOnly = true;
            txtMaMon.Size = new Size(139, 29);
            txtMaMon.TabIndex = 1;
            txtMaMon.Text = "CF02";
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
            pnlFieldDM.Controls.Add(cboDetailDanhMuc);
            pnlFieldDM.Controls.Add(lblDanhMucTitle);
            pnlFieldDM.Dock = DockStyle.Fill;
            pnlFieldDM.Location = new Point(149, 0);
            pnlFieldDM.Margin = new Padding(5, 0, 0, 0);
            pnlFieldDM.Name = "pnlFieldDM";
            pnlFieldDM.Size = new Size(196, 72);
            pnlFieldDM.TabIndex = 1;
            // 
            // cboDetailDanhMuc
            // 
            cboDetailDanhMuc.Dock = DockStyle.Top;
            cboDetailDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDetailDanhMuc.Font = new Font("Segoe UI", 9F);
            cboDetailDanhMuc.FormattingEnabled = true;
            cboDetailDanhMuc.Location = new Point(0, 24);
            cboDetailDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboDetailDanhMuc.Name = "cboDetailDanhMuc";
            cboDetailDanhMuc.Size = new Size(196, 28);
            cboDetailDanhMuc.TabIndex = 1;
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
            tblInputs.SetColumnSpan(pnlFieldTen, 2);
            pnlFieldTen.Controls.Add(txtTenMon);
            pnlFieldTen.Controls.Add(lblTenMonTitle);
            pnlFieldTen.Dock = DockStyle.Fill;
            pnlFieldTen.Location = new Point(3, 76);
            pnlFieldTen.Margin = new Padding(3, 4, 3, 4);
            pnlFieldTen.Name = "pnlFieldTen";
            pnlFieldTen.Size = new Size(339, 64);
            pnlFieldTen.TabIndex = 2;
            // 
            // txtTenMon
            // 
            txtTenMon.BorderStyle = BorderStyle.FixedSingle;
            txtTenMon.Dock = DockStyle.Top;
            txtTenMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTenMon.ForeColor = Color.FromArgb(44, 30, 20);
            txtTenMon.Location = new Point(0, 24);
            txtTenMon.Margin = new Padding(3, 4, 3, 4);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(339, 30);
            txtTenMon.TabIndex = 1;
            txtTenMon.Text = "Cà phê sữa phin truyền thống";
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
            pnlFieldGiaBan.Controls.Add(txtGiaBan);
            pnlFieldGiaBan.Controls.Add(lblGiaBanTitle);
            pnlFieldGiaBan.Dock = DockStyle.Fill;
            pnlFieldGiaBan.Location = new Point(0, 144);
            pnlFieldGiaBan.Margin = new Padding(0, 0, 5, 0);
            pnlFieldGiaBan.Name = "pnlFieldGiaBan";
            pnlFieldGiaBan.Size = new Size(139, 85);
            pnlFieldGiaBan.TabIndex = 3;
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = Color.White;
            txtGiaBan.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBan.Dock = DockStyle.Top;
            txtGiaBan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtGiaBan.ForeColor = Color.FromArgb(111, 78, 55);
            txtGiaBan.Location = new Point(0, 24);
            txtGiaBan.Margin = new Padding(3, 4, 3, 4);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(139, 30);
            txtGiaBan.TabIndex = 1;
            txtGiaBan.Text = "35000";
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
            pnlFieldGiaVon.Size = new Size(196, 85);
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
            pnlImageContainer.Controls.Add(picMonDetail);
            pnlImageContainer.Dock = DockStyle.Left;
            pnlImageContainer.Location = new Point(0, 0);
            pnlImageContainer.Margin = new Padding(3, 4, 3, 4);
            pnlImageContainer.Name = "pnlImageContainer";
            pnlImageContainer.Padding = new Padding(0, 0, 11, 0);
            pnlImageContainer.Size = new Size(160, 229);
            pnlImageContainer.TabIndex = 0;
            // 
            // lblKichThuocAnh
            // 
            lblKichThuocAnh.Cursor = Cursors.Hand;
            lblKichThuocAnh.Dock = DockStyle.Bottom;
            lblKichThuocAnh.Font = new Font("Segoe UI", 7.5F);
            lblKichThuocAnh.ForeColor = Color.FromArgb(126, 110, 101);
            lblKichThuocAnh.Location = new Point(0, 178);
            lblKichThuocAnh.Name = "lblKichThuocAnh";
            lblKichThuocAnh.Size = new Size(149, 51);
            lblKichThuocAnh.TabIndex = 1;
            lblKichThuocAnh.Text = "2048×2048 [PNG, JPG]\r\n(Nhấn để đổi ảnh)";
            lblKichThuocAnh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMonDetail
            // 
            picMonDetail.BackColor = Color.FromArgb(250, 246, 240);
            picMonDetail.Dock = DockStyle.Top;
            picMonDetail.Location = new Point(0, 0);
            picMonDetail.Margin = new Padding(3, 4, 3, 4);
            picMonDetail.Name = "picMonDetail";
            picMonDetail.Size = new Size(149, 173);
            picMonDetail.SizeMode = PictureBoxSizeMode.Zoom;
            picMonDetail.TabIndex = 0;
            picMonDetail.TabStop = false;
            // 
            // pnlMoTaSection
            // 
            pnlMoTaSection.Controls.Add(rtbMoTa);
            pnlMoTaSection.Controls.Add(lblMoTaLabel);
            pnlMoTaSection.Dock = DockStyle.Bottom;
            pnlMoTaSection.Location = new Point(14, 296);
            pnlMoTaSection.Margin = new Padding(3, 4, 3, 4);
            pnlMoTaSection.Name = "pnlMoTaSection";
            pnlMoTaSection.Padding = new Padding(0, 5, 0, 5);
            pnlMoTaSection.Size = new Size(505, 125);
            pnlMoTaSection.TabIndex = 2;
            // 
            // rtbMoTa
            // 
            rtbMoTa.BackColor = Color.FromArgb(250, 248, 245);
            rtbMoTa.BorderStyle = BorderStyle.FixedSingle;
            rtbMoTa.Dock = DockStyle.Fill;
            rtbMoTa.Font = new Font("Segoe UI", 8.5F);
            rtbMoTa.ForeColor = Color.FromArgb(44, 30, 20);
            rtbMoTa.Location = new Point(0, 32);
            rtbMoTa.Margin = new Padding(3, 4, 3, 4);
            rtbMoTa.Name = "rtbMoTa";
            rtbMoTa.Size = new Size(505, 88);
            rtbMoTa.TabIndex = 1;
            rtbMoTa.Text = "Cà phê Robusta Đắk Lắk nguyên chất pha phin thủ công, hòa quyện sữa đặc thơm béo ngậy. Định lượng đá chuẩn 150g.";
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
            pnlDetailFooter.Controls.Add(btnTamNgung);
            pnlDetailFooter.Dock = DockStyle.Bottom;
            pnlDetailFooter.Location = new Point(14, 421);
            pnlDetailFooter.Margin = new Padding(3, 4, 3, 4);
            pnlDetailFooter.Name = "pnlDetailFooter";
            pnlDetailFooter.Padding = new Padding(0, 5, 0, 0);
            pnlDetailFooter.Size = new Size(505, 48);
            pnlDetailFooter.TabIndex = 3;
            // 
            // btnTamNgung
            // 
            btnTamNgung.BackColor = Color.Transparent;
            btnTamNgung.BorderColor = Color.FromArgb(245, 198, 203);
            btnTamNgung.BorderRadius = 6;
            btnTamNgung.BorderWidth = 1;
            btnTamNgung.CustomIcon = null;
            btnTamNgung.Dock = DockStyle.Right;
            btnTamNgung.DownBackColor = Color.FromArgb(245, 183, 183);
            btnTamNgung.FlatStyle = FlatStyle.Flat;
            btnTamNgung.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnTamNgung.ForeColor = Color.FromArgb(192, 57, 43);
            btnTamNgung.HoverBackColor = Color.FromArgb(249, 213, 213);
            btnTamNgung.IsOutlined = false;
            btnTamNgung.Location = new Point(299, 5);
            btnTamNgung.Margin = new Padding(3, 4, 3, 4);
            btnTamNgung.Name = "btnTamNgung";
            btnTamNgung.NormalBackColor = Color.FromArgb(253, 240, 240);
            btnTamNgung.Size = new Size(206, 43);
            btnTamNgung.TabIndex = 0;
            btnTamNgung.Text = "Tạm ngưng bán món này";
            btnTamNgung.UseVisualStyleBackColor = true;
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
            pnlDetailHeaderButtons.Controls.Add(btnLuuMon);
            pnlDetailHeaderButtons.Controls.Add(btnInMon);
            pnlDetailHeaderButtons.Dock = DockStyle.Right;
            pnlDetailHeaderButtons.Location = new Point(345, 0);
            pnlDetailHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            pnlDetailHeaderButtons.Name = "pnlDetailHeaderButtons";
            pnlDetailHeaderButtons.Size = new Size(160, 51);
            pnlDetailHeaderButtons.TabIndex = 2;
            // 
            // btnLuuMon
            // 
            btnLuuMon.BackColor = Color.Transparent;
            btnLuuMon.BorderColor = Color.Transparent;
            btnLuuMon.BorderRadius = 6;
            btnLuuMon.BorderWidth = 0;
            btnLuuMon.CustomIcon = null;
            btnLuuMon.DownBackColor = Color.FromArgb(74, 50, 34);
            btnLuuMon.FlatStyle = FlatStyle.Flat;
            btnLuuMon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuuMon.ForeColor = Color.White;
            btnLuuMon.HoverBackColor = Color.FromArgb(91, 63, 43);
            btnLuuMon.IsOutlined = false;
            btnLuuMon.Location = new Point(2, 4);
            btnLuuMon.Margin = new Padding(3, 4, 3, 4);
            btnLuuMon.Name = "btnLuuMon";
            btnLuuMon.NormalBackColor = Color.FromArgb(111, 78, 55);
            btnLuuMon.Size = new Size(94, 43);
            btnLuuMon.TabIndex = 0;
            btnLuuMon.Text = "💾 Lưu";
            btnLuuMon.UseVisualStyleBackColor = true;
            // 
            // btnInMon
            // 
            btnInMon.BackColor = Color.Transparent;
            btnInMon.BorderColor = Color.FromArgb(208, 197, 184);
            btnInMon.BorderRadius = 6;
            btnInMon.BorderWidth = 1;
            btnInMon.CustomIcon = null;
            btnInMon.DownBackColor = Color.FromArgb(239, 229, 219);
            btnInMon.FlatStyle = FlatStyle.Flat;
            btnInMon.Font = new Font("Segoe UI", 10F);
            btnInMon.ForeColor = Color.FromArgb(44, 30, 20);
            btnInMon.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnInMon.IsOutlined = true;
            btnInMon.Location = new Point(105, 4);
            btnInMon.Margin = new Padding(3, 4, 3, 4);
            btnInMon.Name = "btnInMon";
            btnInMon.NormalBackColor = Color.White;
            btnInMon.Size = new Size(43, 43);
            btnInMon.TabIndex = 1;
            btnInMon.Text = "🖨";
            btnInMon.UseVisualStyleBackColor = true;
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
            pnlBOMCard.Size = new Size(1244, 320);
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
            dgvBOM.Size = new Size(1216, 186);
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
            pnlBOMFooter.Location = new Point(14, 253);
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
            pnlBOMHeaderButtons.Controls.Add(btnThemNguyenLieu);
            pnlBOMHeaderButtons.Controls.Add(btnTinhLaiGia);
            pnlBOMHeaderButtons.Dock = DockStyle.Right;
            pnlBOMHeaderButtons.Location = new Point(896, 0);
            pnlBOMHeaderButtons.Margin = new Padding(3, 4, 3, 4);
            pnlBOMHeaderButtons.Name = "pnlBOMHeaderButtons";
            pnlBOMHeaderButtons.Size = new Size(320, 51);
            pnlBOMHeaderButtons.TabIndex = 1;
            // 
            // btnThemNguyenLieu
            // 
            btnThemNguyenLieu.BackColor = Color.Transparent;
            btnThemNguyenLieu.BorderColor = Color.Transparent;
            btnThemNguyenLieu.BorderRadius = 6;
            btnThemNguyenLieu.BorderWidth = 0;
            btnThemNguyenLieu.CustomIcon = null;
            btnThemNguyenLieu.DownBackColor = Color.FromArgb(74, 50, 34);
            btnThemNguyenLieu.FlatStyle = FlatStyle.Flat;
            btnThemNguyenLieu.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnThemNguyenLieu.ForeColor = Color.White;
            btnThemNguyenLieu.HoverBackColor = Color.FromArgb(91, 63, 43);
            btnThemNguyenLieu.IsOutlined = false;
            btnThemNguyenLieu.Location = new Point(7, 5);
            btnThemNguyenLieu.Margin = new Padding(3, 4, 3, 4);
            btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            btnThemNguyenLieu.NormalBackColor = Color.FromArgb(111, 78, 55);
            btnThemNguyenLieu.Size = new Size(174, 40);
            btnThemNguyenLieu.TabIndex = 0;
            btnThemNguyenLieu.Text = "+ Thêm nguyên liệu";
            btnThemNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btnTinhLaiGia
            // 
            btnTinhLaiGia.BackColor = Color.Transparent;
            btnTinhLaiGia.BorderColor = Color.FromArgb(208, 197, 184);
            btnTinhLaiGia.BorderRadius = 6;
            btnTinhLaiGia.BorderWidth = 1;
            btnTinhLaiGia.CustomIcon = null;
            btnTinhLaiGia.DownBackColor = Color.FromArgb(239, 229, 219);
            btnTinhLaiGia.FlatStyle = FlatStyle.Flat;
            btnTinhLaiGia.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnTinhLaiGia.ForeColor = Color.FromArgb(44, 30, 20);
            btnTinhLaiGia.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnTinhLaiGia.IsOutlined = true;
            btnTinhLaiGia.Location = new Point(187, 5);
            btnTinhLaiGia.Margin = new Padding(3, 4, 3, 4);
            btnTinhLaiGia.Name = "btnTinhLaiGia";
            btnTinhLaiGia.NormalBackColor = Color.White;
            btnTinhLaiGia.Size = new Size(126, 40);
            btnTinhLaiGia.TabIndex = 1;
            btnTinhLaiGia.Text = "☷ Tính lại giá";
            btnTinhLaiGia.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            pnlPagination.ResumeLayout(false);
            pnlPagination.PerformLayout();
            pnlPageButtons.ResumeLayout(false);
            pnlDetailCard.ResumeLayout(false);
            pnlDetailBody.ResumeLayout(false);
            pnlFormInputs.ResumeLayout(false);
            tblInputs.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)picMonDetail).EndInit();
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
        private DoAnLapTrinhTrucQuan.RoundedButton btnThemMon;
        private DoAnLapTrinhTrucQuan.RoundedButton btnXuatExcel;
        private DoAnLapTrinhTrucQuan.RoundedButton btnCapNhatGia;
        private System.Windows.Forms.Panel pnlFilterBar;
        private DoAnLapTrinhTrucQuan.RoundedTextBox txtTimKiem;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlFilterDanhMuc;
        private System.Windows.Forms.Label lblPrefixDanhMuc;
        private System.Windows.Forms.ComboBox cboLocDanhMuc;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlFilterTrangThai;
        private System.Windows.Forms.Label lblPrefixTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitMasterDetail;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlMasterCard;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.FlowLayoutPanel pnlPageButtons;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlDetailCard;
        private System.Windows.Forms.Panel pnlDetailHeader;
        private System.Windows.Forms.Label lblDetailHeader;
        private System.Windows.Forms.Label lblDetailSubHeader;
        private System.Windows.Forms.Panel pnlDetailHeaderButtons;
        private DoAnLapTrinhTrucQuan.RoundedButton btnLuuMon;
        private DoAnLapTrinhTrucQuan.RoundedButton btnInMon;
        private System.Windows.Forms.Panel pnlDetailBody;
        private System.Windows.Forms.Panel pnlImageContainer;
        private System.Windows.Forms.PictureBox picMonDetail;
        private System.Windows.Forms.Label lblKichThuocAnh;
        private System.Windows.Forms.Panel pnlFormInputs;
        private System.Windows.Forms.TableLayoutPanel tblInputs;
        private System.Windows.Forms.Panel pnlFieldMa;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblMaMonTitle;
        private System.Windows.Forms.Panel pnlFieldDM;
        private System.Windows.Forms.Label lblDanhMucTitle;
        private System.Windows.Forms.ComboBox cboDetailDanhMuc;
        private System.Windows.Forms.Panel pnlFieldTen;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblTenMonTitle;
        private System.Windows.Forms.Panel pnlFieldGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblGiaBanTitle;
        private System.Windows.Forms.Panel pnlFieldGiaVon;
        private System.Windows.Forms.Label lblGiaVonTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlGiaVonRow;
        private System.Windows.Forms.Label lblGiaVonBOM;
        private DoAnLapTrinhTrucQuan.StatusBadge badgeLai;
        private System.Windows.Forms.Panel pnlMoTaSection;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.Label lblMoTaLabel;
        private System.Windows.Forms.Panel pnlDetailFooter;
        private DoAnLapTrinhTrucQuan.RoundedButton btnTamNgung;
        private DoAnLapTrinhTrucQuan.RoundedPanel pnlBOMCard;
        private System.Windows.Forms.Panel pnlBOMHeader;
        private System.Windows.Forms.Label lblBOMHeader;
        private System.Windows.Forms.Panel pnlBOMHeaderButtons;
        private DoAnLapTrinhTrucQuan.RoundedButton btnThemNguyenLieu;
        private DoAnLapTrinhTrucQuan.RoundedButton btnTinhLaiGia;
        private System.Windows.Forms.DataGridView dgvBOM;
        private System.Windows.Forms.Panel pnlBOMFooter;
        private System.Windows.Forms.Label lblCOGSLabel;
        private System.Windows.Forms.Label lblCOGSValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewImageColumn colHinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMDinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBOMGiaVon;
        private System.Windows.Forms.DataGridViewButtonColumn colBOMXoa;
    }
}
