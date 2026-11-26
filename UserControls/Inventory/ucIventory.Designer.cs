using DoAnLapTrinhTrucQuan.Helpers;

namespace DoAnLapTrinhTrucQuan.UserControls
{
    partial class ucInventory
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            pnlHeaderButtons = new Panel();
            btnThemNguyenLieu = new RoundedButton();
            btnXuatExcel = new RoundedButton();
            btnNhapKhoTop = new RoundedButton();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlFilterBar = new Panel();
            pnlFilterTrangThai = new RoundedPanel();
            cboTrangThai = new ComboBox();
            lblPrefixTrangThai = new Label();
            pnlFilterNhom = new RoundedPanel();
            cboNhom = new ComboBox();
            lblPrefixNhom = new Label();
            txtSearch = new RoundedTextBox();
            splitMain = new SplitContainer();
            splitTop = new SplitContainer();
            pnlMasterCard = new RoundedPanel();
            dgvNguyenLieu = new DataGridView();
            colMaNL = new DataGridViewTextBoxColumn();
            colTenNL = new DataGridViewTextBoxColumn();
            colDVT = new DataGridViewTextBoxColumn();
            colTonKho = new DataGridViewTextBoxColumn();
            colToiThieu = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlDetailCard = new RoundedPanel();
            flpDetailActions = new FlowLayoutPanel();
            btnNhapKho = new RoundedButton();
            btnXuatKho = new RoundedButton();
            btnNgungSuDung = new RoundedButton();
            tlpDetailFields = new TableLayoutPanel();
            lblFieldMaNL = new Label();
            txtDetailMaNL = new TextBox();
            lblFieldNhom = new Label();
            cboDetailNhom = new ComboBox();
            lblFieldTenNL = new Label();
            txtDetailTenNL = new TextBox();
            lblFieldDVT = new Label();
            txtDetailDVT = new TextBox();
            lblFieldDonGia = new Label();
            txtDetailDonGia = new TextBox();
            lblFieldTonKho = new Label();
            txtDetailTonKho = new TextBox();
            lblFieldMucToiThieu = new Label();
            nudDetailMucToiThieu = new NumericUpDown();
            pnlDetailHeader = new Panel();
            btnLuu = new RoundedButton();
            lblDetailMaNL = new Label();
            lblDetailHeader = new Label();
            pnlHistoryCard = new RoundedPanel();
            dgvLichSuKho = new DataGridView();
            colHistoryThoiGian = new DataGridViewTextBoxColumn();
            colHistoryLoai = new DataGridViewTextBoxColumn();
            colHistorySoLuong = new DataGridViewTextBoxColumn();
            colHistoryTonSau = new DataGridViewTextBoxColumn();
            colHistoryNguoiThucHien = new DataGridViewTextBoxColumn();
            colHistoryGhiChu = new DataGridViewTextBoxColumn();
            lblHistoryTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlHeaderButtons.SuspendLayout();
            pnlFilterBar.SuspendLayout();
            pnlFilterTrangThai.SuspendLayout();
            pnlFilterNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitTop).BeginInit();
            splitTop.Panel1.SuspendLayout();
            splitTop.Panel2.SuspendLayout();
            splitTop.SuspendLayout();
            pnlMasterCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).BeginInit();
            pnlDetailCard.SuspendLayout();
            flpDetailActions.SuspendLayout();
            tlpDetailFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDetailMucToiThieu).BeginInit();
            pnlDetailHeader.SuspendLayout();
            pnlHistoryCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuKho).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlHeaderButtons);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(18, 16);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1244, 68);
            pnlHeader.TabIndex = 0;
            // 
            // pnlHeaderButtons
            // 
            pnlHeaderButtons.Controls.Add(btnThemNguyenLieu);
            pnlHeaderButtons.Controls.Add(btnXuatExcel);
            pnlHeaderButtons.Controls.Add(btnNhapKhoTop);
            pnlHeaderButtons.Dock = DockStyle.Right;
            pnlHeaderButtons.Location = new Point(744, 0);
            pnlHeaderButtons.Name = "pnlHeaderButtons";
            pnlHeaderButtons.Size = new Size(500, 68);
            pnlHeaderButtons.TabIndex = 2;
            // 
            // btnThemNguyenLieu
            // 
            btnThemNguyenLieu.BackColor = Color.FromArgb(106, 80, 63);
            btnThemNguyenLieu.BorderColor = Color.FromArgb(106, 80, 63);
            btnThemNguyenLieu.BorderRadius = 8;
            btnThemNguyenLieu.BorderWidth = 1;
            btnThemNguyenLieu.Cursor = Cursors.Hand;
            btnThemNguyenLieu.CustomIcon = null;
            btnThemNguyenLieu.DownBackColor = Color.FromArgb(85, 55, 34);
            btnThemNguyenLieu.FlatAppearance.BorderSize = 0;
            btnThemNguyenLieu.FlatStyle = FlatStyle.Flat;
            btnThemNguyenLieu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThemNguyenLieu.ForeColor = Color.White;
            btnThemNguyenLieu.HoverBackColor = Color.FromArgb(85, 55, 34);
            btnThemNguyenLieu.HoverColor = Color.FromArgb(85, 55, 34);
            btnThemNguyenLieu.IsOutlined = false;
            btnThemNguyenLieu.Location = new Point(10, 10);
            btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            btnThemNguyenLieu.NormalBackColor = Color.FromArgb(106, 80, 63);
            btnThemNguyenLieu.Size = new Size(165, 46);
            btnThemNguyenLieu.TabIndex = 0;
            btnThemNguyenLieu.Text = "+ Thêm nguyên liệu";
            btnThemNguyenLieu.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.White;
            btnXuatExcel.BorderColor = Color.FromArgb(208, 197, 184);
            btnXuatExcel.BorderRadius = 8;
            btnXuatExcel.BorderWidth = 1;
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.CustomIcon = null;
            btnXuatExcel.DownBackColor = Color.FromArgb(239, 229, 219);
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.FromArgb(111, 78, 55);
            btnXuatExcel.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnXuatExcel.HoverColor = Color.FromArgb(247, 239, 231);
            btnXuatExcel.IsOutlined = true;
            btnXuatExcel.Location = new Point(185, 10);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.NormalBackColor = Color.White;
            btnXuatExcel.Size = new Size(185, 46);
            btnXuatExcel.TabIndex = 1;
            btnXuatExcel.Text = "⭳ Nhập / Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnNhapKhoTop
            // 
            btnNhapKhoTop.BackColor = Color.White;
            btnNhapKhoTop.BorderColor = Color.FromArgb(208, 197, 184);
            btnNhapKhoTop.BorderRadius = 8;
            btnNhapKhoTop.BorderWidth = 1;
            btnNhapKhoTop.Cursor = Cursors.Hand;
            btnNhapKhoTop.CustomIcon = null;
            btnNhapKhoTop.DownBackColor = Color.FromArgb(239, 229, 219);
            btnNhapKhoTop.FlatAppearance.BorderSize = 0;
            btnNhapKhoTop.FlatStyle = FlatStyle.Flat;
            btnNhapKhoTop.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNhapKhoTop.ForeColor = Color.FromArgb(111, 78, 55);
            btnNhapKhoTop.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnNhapKhoTop.HoverColor = Color.FromArgb(247, 239, 231);
            btnNhapKhoTop.IsOutlined = true;
            btnNhapKhoTop.Location = new Point(380, 10);
            btnNhapKhoTop.Name = "btnNhapKhoTop";
            btnNhapKhoTop.NormalBackColor = Color.White;
            btnNhapKhoTop.Size = new Size(115, 46);
            btnNhapKhoTop.TabIndex = 2;
            btnNhapKhoTop.Text = "☷ Nhập kho";
            btnNhapKhoTop.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblSubtitle.Location = new Point(2, 42);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(272, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "28 nguyên liệu · 3 sắp hết · 1 hết hàng";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 30, 20);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý kho";
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.Controls.Add(pnlFilterTrangThai);
            pnlFilterBar.Controls.Add(pnlFilterNhom);
            pnlFilterBar.Controls.Add(txtSearch);
            pnlFilterBar.Dock = DockStyle.Top;
            pnlFilterBar.Location = new Point(18, 84);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(1244, 58);
            pnlFilterBar.TabIndex = 1;
            // 
            // pnlFilterTrangThai
            // 
            pnlFilterTrangThai.BackColor = Color.Transparent;
            pnlFilterTrangThai.BorderColor = Color.FromArgb(232, 223, 213);
            pnlFilterTrangThai.BorderRadius = 8;
            pnlFilterTrangThai.BorderWidth = 1;
            pnlFilterTrangThai.Controls.Add(cboTrangThai);
            pnlFilterTrangThai.Controls.Add(lblPrefixTrangThai);
            pnlFilterTrangThai.FillColor = Color.White;
            pnlFilterTrangThai.Location = new Point(630, 6);
            pnlFilterTrangThai.Name = "pnlFilterTrangThai";
            pnlFilterTrangThai.Padding = new Padding(12);
            pnlFilterTrangThai.Size = new Size(310, 44);
            pnlFilterTrangThai.TabIndex = 2;
            // 
            // cboTrangThai
            // 
            cboTrangThai.BackColor = Color.White;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FlatStyle = FlatStyle.Flat;
            cboTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboTrangThai.ForeColor = Color.FromArgb(44, 30, 20);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(116, 9);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(184, 28);
            cboTrangThai.TabIndex = 1;
            // 
            // lblPrefixTrangThai
            // 
            lblPrefixTrangThai.AutoSize = true;
            lblPrefixTrangThai.BackColor = Color.Transparent;
            lblPrefixTrangThai.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPrefixTrangThai.ForeColor = Color.FromArgb(141, 131, 123);
            lblPrefixTrangThai.Location = new Point(10, 13);
            lblPrefixTrangThai.Name = "lblPrefixTrangThai";
            lblPrefixTrangThai.Size = new Size(106, 20);
            lblPrefixTrangThai.TabIndex = 0;
            lblPrefixTrangThai.Text = "TRẠNG THÁI:";
            // 
            // pnlFilterNhom
            // 
            pnlFilterNhom.BackColor = Color.Transparent;
            pnlFilterNhom.BorderColor = Color.FromArgb(232, 223, 213);
            pnlFilterNhom.BorderRadius = 8;
            pnlFilterNhom.BorderWidth = 1;
            pnlFilterNhom.Controls.Add(cboNhom);
            pnlFilterNhom.Controls.Add(lblPrefixNhom);
            pnlFilterNhom.FillColor = Color.White;
            pnlFilterNhom.Location = new Point(355, 6);
            pnlFilterNhom.Name = "pnlFilterNhom";
            pnlFilterNhom.Padding = new Padding(12);
            pnlFilterNhom.Size = new Size(260, 44);
            pnlFilterNhom.TabIndex = 1;
            // 
            // cboNhom
            // 
            cboNhom.BackColor = Color.White;
            cboNhom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhom.FlatStyle = FlatStyle.Flat;
            cboNhom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboNhom.ForeColor = Color.FromArgb(44, 30, 20);
            cboNhom.FormattingEnabled = true;
            cboNhom.Location = new Point(70, 10);
            cboNhom.Name = "cboNhom";
            cboNhom.Size = new Size(180, 28);
            cboNhom.TabIndex = 1;
            // 
            // lblPrefixNhom
            // 
            lblPrefixNhom.AutoSize = true;
            lblPrefixNhom.BackColor = Color.Transparent;
            lblPrefixNhom.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPrefixNhom.ForeColor = Color.FromArgb(141, 131, 123);
            lblPrefixNhom.Location = new Point(12, 14);
            lblPrefixNhom.Name = "lblPrefixNhom";
            lblPrefixNhom.Size = new Size(61, 20);
            lblPrefixNhom.TabIndex = 0;
            lblPrefixNhom.Text = "NHÓM:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderColor = Color.FromArgb(232, 223, 213);
            txtSearch.BorderRadius = 8;
            txtSearch.FocusBorderColor = Color.FromArgb(111, 78, 55);
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(0, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(12, 10, 12, 10);
            txtSearch.PlaceholderColor = Color.FromArgb(160, 150, 142);
            txtSearch.PlaceholderText = "🔍 Tìm mã hoặc tên nguyên liệu...";
            txtSearch.PrefixIcon = null;
            txtSearch.ReadOnly = false;
            txtSearch.Size = new Size(340, 44);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TextBackgroundColor = Color.White;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(18, 142);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(splitTop);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlHistoryCard);
            splitMain.Size = new Size(1244, 662);
            splitMain.SplitterDistance = 379;
            splitMain.SplitterWidth = 8;
            splitMain.TabIndex = 2;
            // 
            // splitTop
            // 
            splitTop.Dock = DockStyle.Fill;
            splitTop.Location = new Point(0, 0);
            splitTop.Name = "splitTop";
            // 
            // splitTop.Panel1
            // 
            splitTop.Panel1.Controls.Add(pnlMasterCard);
            // 
            // splitTop.Panel2
            // 
            splitTop.Panel2.Controls.Add(pnlDetailCard);
            splitTop.Size = new Size(1244, 379);
            splitTop.SplitterDistance = 770;
            splitTop.SplitterWidth = 10;
            splitTop.TabIndex = 0;
            // 
            // pnlMasterCard
            // 
            pnlMasterCard.BackColor = Color.Transparent;
            pnlMasterCard.BorderColor = Color.FromArgb(232, 223, 213);
            pnlMasterCard.BorderRadius = 12;
            pnlMasterCard.BorderWidth = 1;
            pnlMasterCard.Controls.Add(dgvNguyenLieu);
            pnlMasterCard.Dock = DockStyle.Fill;
            pnlMasterCard.FillColor = Color.White;
            pnlMasterCard.Location = new Point(0, 0);
            pnlMasterCard.Name = "pnlMasterCard";
            pnlMasterCard.Padding = new Padding(10);
            pnlMasterCard.Size = new Size(770, 379);
            pnlMasterCard.TabIndex = 0;
            // 
            // dgvNguyenLieu
            // 
            dgvNguyenLieu.AllowUserToAddRows = false;
            dgvNguyenLieu.AllowUserToDeleteRows = false;
            dgvNguyenLieu.AllowUserToResizeRows = false;
            dgvNguyenLieu.BackgroundColor = Color.White;
            dgvNguyenLieu.BorderStyle = BorderStyle.None;
            dgvNguyenLieu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNguyenLieu.ColumnHeadersHeight = 44;
            dgvNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNguyenLieu.Columns.AddRange(new DataGridViewColumn[] { colMaNL, colTenNL, colDVT, colTonKho, colToiThieu, colTrangThai });
            dgvNguyenLieu.Dock = DockStyle.Fill;
            dgvNguyenLieu.EnableHeadersVisualStyles = false;
            dgvNguyenLieu.Location = new Point(10, 10);
            dgvNguyenLieu.MultiSelect = false;
            dgvNguyenLieu.Name = "dgvNguyenLieu";
            dgvNguyenLieu.ReadOnly = true;
            dgvNguyenLieu.RowHeadersVisible = false;
            dgvNguyenLieu.RowHeadersWidth = 51;
            dgvNguyenLieu.RowTemplate.Height = 46;
            dgvNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNguyenLieu.Size = new Size(750, 359);
            dgvNguyenLieu.TabIndex = 0;
            // 
            // colMaNL
            // 
            colMaNL.HeaderText = "MÃ NL";
            colMaNL.MinimumWidth = 6;
            colMaNL.Name = "colMaNL";
            colMaNL.ReadOnly = true;
            colMaNL.Width = 85;
            // 
            // colTenNL
            // 
            colTenNL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTenNL.HeaderText = "TÊN NGUYÊN LIỆU / NHÓM";
            colTenNL.MinimumWidth = 200;
            colTenNL.Name = "colTenNL";
            colTenNL.ReadOnly = true;
            // 
            // colDVT
            // 
            colDVT.HeaderText = "ĐVT";
            colDVT.MinimumWidth = 6;
            colDVT.Name = "colDVT";
            colDVT.ReadOnly = true;
            colDVT.Width = 90;
            // 
            // colTonKho
            // 
            colTonKho.HeaderText = "TỒN KHO";
            colTonKho.MinimumWidth = 6;
            colTonKho.Name = "colTonKho";
            colTonKho.ReadOnly = true;
            colTonKho.Width = 110;
            // 
            // colToiThieu
            // 
            colToiThieu.HeaderText = "TỐI THIỂU";
            colToiThieu.MinimumWidth = 6;
            colToiThieu.Name = "colToiThieu";
            colToiThieu.ReadOnly = true;
            colToiThieu.Width = 105;
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
            pnlDetailCard.Controls.Add(flpDetailActions);
            pnlDetailCard.Controls.Add(tlpDetailFields);
            pnlDetailCard.Controls.Add(pnlDetailHeader);
            pnlDetailCard.Dock = DockStyle.Fill;
            pnlDetailCard.FillColor = Color.White;
            pnlDetailCard.Location = new Point(0, 0);
            pnlDetailCard.Name = "pnlDetailCard";
            pnlDetailCard.Padding = new Padding(16);
            pnlDetailCard.Size = new Size(464, 379);
            pnlDetailCard.TabIndex = 0;
            // 
            // flpDetailActions
            // 
            flpDetailActions.Controls.Add(btnNhapKho);
            flpDetailActions.Controls.Add(btnXuatKho);
            flpDetailActions.Controls.Add(btnNgungSuDung);
            flpDetailActions.Dock = DockStyle.Bottom;
            flpDetailActions.Location = new Point(16, 315);
            flpDetailActions.Name = "flpDetailActions";
            flpDetailActions.Padding = new Padding(0, 4, 0, 0);
            flpDetailActions.Size = new Size(432, 48);
            flpDetailActions.TabIndex = 2;
            // 
            // btnNhapKho
            // 
            btnNhapKho.BackColor = Color.FromArgb(106, 80, 63);
            btnNhapKho.BorderColor = Color.FromArgb(106, 80, 63);
            btnNhapKho.BorderRadius = 8;
            btnNhapKho.BorderWidth = 1;
            btnNhapKho.Cursor = Cursors.Hand;
            btnNhapKho.CustomIcon = null;
            btnNhapKho.DownBackColor = Color.FromArgb(85, 55, 34);
            btnNhapKho.FlatAppearance.BorderSize = 0;
            btnNhapKho.FlatStyle = FlatStyle.Flat;
            btnNhapKho.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNhapKho.ForeColor = Color.White;
            btnNhapKho.HoverBackColor = Color.FromArgb(85, 55, 34);
            btnNhapKho.HoverColor = Color.FromArgb(85, 55, 34);
            btnNhapKho.IsOutlined = false;
            btnNhapKho.Location = new Point(3, 7);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.NormalBackColor = Color.FromArgb(106, 80, 63);
            btnNhapKho.Size = new Size(105, 38);
            btnNhapKho.TabIndex = 0;
            btnNhapKho.Text = "Nhập kho";
            btnNhapKho.UseVisualStyleBackColor = false;
            // 
            // btnXuatKho
            // 
            btnXuatKho.BackColor = Color.White;
            btnXuatKho.BorderColor = Color.FromArgb(208, 197, 184);
            btnXuatKho.BorderRadius = 8;
            btnXuatKho.BorderWidth = 1;
            btnXuatKho.Cursor = Cursors.Hand;
            btnXuatKho.CustomIcon = null;
            btnXuatKho.DownBackColor = Color.FromArgb(239, 229, 219);
            btnXuatKho.FlatAppearance.BorderSize = 0;
            btnXuatKho.FlatStyle = FlatStyle.Flat;
            btnXuatKho.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXuatKho.ForeColor = Color.FromArgb(111, 78, 55);
            btnXuatKho.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnXuatKho.HoverColor = Color.FromArgb(247, 239, 231);
            btnXuatKho.IsOutlined = true;
            btnXuatKho.Location = new Point(114, 7);
            btnXuatKho.Name = "btnXuatKho";
            btnXuatKho.NormalBackColor = Color.White;
            btnXuatKho.Size = new Size(105, 38);
            btnXuatKho.TabIndex = 1;
            btnXuatKho.Text = "Xuất kho";
            btnXuatKho.UseVisualStyleBackColor = false;
            // 
            // btnNgungSuDung
            // 
            btnNgungSuDung.BackColor = Color.White;
            btnNgungSuDung.BorderColor = Color.FromArgb(208, 197, 184);
            btnNgungSuDung.BorderRadius = 8;
            btnNgungSuDung.BorderWidth = 1;
            btnNgungSuDung.Cursor = Cursors.Hand;
            btnNgungSuDung.CustomIcon = null;
            btnNgungSuDung.DownBackColor = Color.FromArgb(239, 229, 219);
            btnNgungSuDung.FlatAppearance.BorderSize = 0;
            btnNgungSuDung.FlatStyle = FlatStyle.Flat;
            btnNgungSuDung.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNgungSuDung.ForeColor = Color.FromArgb(111, 78, 55);
            btnNgungSuDung.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnNgungSuDung.HoverColor = Color.FromArgb(247, 239, 231);
            btnNgungSuDung.IsOutlined = true;
            btnNgungSuDung.Location = new Point(225, 7);
            btnNgungSuDung.Name = "btnNgungSuDung";
            btnNgungSuDung.NormalBackColor = Color.White;
            btnNgungSuDung.Size = new Size(135, 38);
            btnNgungSuDung.TabIndex = 2;
            btnNgungSuDung.Text = "Ngừng sử dụng";
            btnNgungSuDung.UseVisualStyleBackColor = false;
            // 
            // tlpDetailFields
            // 
            tlpDetailFields.ColumnCount = 2;
            tlpDetailFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDetailFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDetailFields.Controls.Add(lblFieldMaNL, 0, 0);
            tlpDetailFields.Controls.Add(txtDetailMaNL, 0, 1);
            tlpDetailFields.Controls.Add(lblFieldNhom, 1, 0);
            tlpDetailFields.Controls.Add(cboDetailNhom, 1, 1);
            tlpDetailFields.Controls.Add(lblFieldTenNL, 0, 2);
            tlpDetailFields.Controls.Add(txtDetailTenNL, 0, 3);
            tlpDetailFields.Controls.Add(lblFieldDVT, 0, 4);
            tlpDetailFields.Controls.Add(txtDetailDVT, 0, 5);
            tlpDetailFields.Controls.Add(lblFieldDonGia, 1, 4);
            tlpDetailFields.Controls.Add(txtDetailDonGia, 1, 5);
            tlpDetailFields.Controls.Add(lblFieldTonKho, 0, 6);
            tlpDetailFields.Controls.Add(txtDetailTonKho, 0, 7);
            tlpDetailFields.Controls.Add(lblFieldMucToiThieu, 1, 6);
            tlpDetailFields.Controls.Add(nudDetailMucToiThieu, 1, 7);
            tlpDetailFields.Dock = DockStyle.Top;
            tlpDetailFields.Location = new Point(16, 62);
            tlpDetailFields.Name = "tlpDetailFields";
            tlpDetailFields.RowCount = 8;
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpDetailFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpDetailFields.Size = new Size(432, 216);
            tlpDetailFields.TabIndex = 1;
            // 
            // lblFieldMaNL
            // 
            lblFieldMaNL.AutoSize = true;
            lblFieldMaNL.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldMaNL.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldMaNL.Location = new Point(3, 0);
            lblFieldMaNL.Name = "lblFieldMaNL";
            lblFieldMaNL.Size = new Size(58, 20);
            lblFieldMaNL.TabIndex = 0;
            lblFieldMaNL.Text = "MÃ NL";
            // 
            // txtDetailMaNL
            // 
            txtDetailMaNL.BackColor = Color.FromArgb(248, 245, 242);
            txtDetailMaNL.Dock = DockStyle.Fill;
            txtDetailMaNL.Font = new Font("Segoe UI", 9.5F);
            txtDetailMaNL.Location = new Point(3, 23);
            txtDetailMaNL.Name = "txtDetailMaNL";
            txtDetailMaNL.ReadOnly = true;
            txtDetailMaNL.Size = new Size(210, 29);
            txtDetailMaNL.TabIndex = 1;
            txtDetailMaNL.Text = "NL001";
            // 
            // lblFieldNhom
            // 
            lblFieldNhom.AutoSize = true;
            lblFieldNhom.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldNhom.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldNhom.Location = new Point(219, 0);
            lblFieldNhom.Name = "lblFieldNhom";
            lblFieldNhom.Size = new Size(57, 20);
            lblFieldNhom.TabIndex = 2;
            lblFieldNhom.Text = "NHÓM";
            // 
            // cboDetailNhom
            // 
            cboDetailNhom.Dock = DockStyle.Fill;
            cboDetailNhom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDetailNhom.Font = new Font("Segoe UI", 9.5F);
            cboDetailNhom.FormattingEnabled = true;
            cboDetailNhom.Location = new Point(219, 23);
            cboDetailNhom.Name = "cboDetailNhom";
            cboDetailNhom.Size = new Size(210, 29);
            cboDetailNhom.TabIndex = 3;
            // 
            // lblFieldTenNL
            // 
            lblFieldTenNL.AutoSize = true;
            tlpDetailFields.SetColumnSpan(lblFieldTenNL, 2);
            lblFieldTenNL.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldTenNL.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldTenNL.Location = new Point(3, 54);
            lblFieldTenNL.Name = "lblFieldTenNL";
            lblFieldTenNL.Size = new Size(141, 20);
            lblFieldTenNL.TabIndex = 4;
            lblFieldTenNL.Text = "TÊN NGUYÊN LIỆU";
            // 
            // txtDetailTenNL
            // 
            tlpDetailFields.SetColumnSpan(txtDetailTenNL, 2);
            txtDetailTenNL.Dock = DockStyle.Fill;
            txtDetailTenNL.Font = new Font("Segoe UI", 9.5F);
            txtDetailTenNL.Location = new Point(3, 77);
            txtDetailTenNL.Name = "txtDetailTenNL";
            txtDetailTenNL.Size = new Size(426, 29);
            txtDetailTenNL.TabIndex = 5;
            txtDetailTenNL.Text = "Cà phê hạt Cầu Đất Arabica";
            // 
            // lblFieldDVT
            // 
            lblFieldDVT.AutoSize = true;
            lblFieldDVT.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldDVT.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldDVT.Location = new Point(3, 108);
            lblFieldDVT.Name = "lblFieldDVT";
            lblFieldDVT.Size = new Size(104, 20);
            lblFieldDVT.TabIndex = 6;
            lblFieldDVT.Text = "ĐƠN VỊ TÍNH";
            // 
            // txtDetailDVT
            // 
            txtDetailDVT.Dock = DockStyle.Fill;
            txtDetailDVT.Font = new Font("Segoe UI", 9.5F);
            txtDetailDVT.Location = new Point(3, 131);
            txtDetailDVT.Name = "txtDetailDVT";
            txtDetailDVT.Size = new Size(210, 29);
            txtDetailDVT.TabIndex = 7;
            txtDetailDVT.Text = "gram (g)";
            // 
            // lblFieldDonGia
            // 
            lblFieldDonGia.AutoSize = true;
            lblFieldDonGia.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldDonGia.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldDonGia.Location = new Point(219, 108);
            lblFieldDonGia.Name = "lblFieldDonGia";
            lblFieldDonGia.Size = new Size(142, 20);
            lblFieldDonGia.TabIndex = 8;
            lblFieldDonGia.Text = "GIÁ VỐN / ĐƠN VỊ";
            // 
            // txtDetailDonGia
            // 
            txtDetailDonGia.Dock = DockStyle.Fill;
            txtDetailDonGia.Font = new Font("Segoe UI", 9.5F);
            txtDetailDonGia.Location = new Point(219, 131);
            txtDetailDonGia.Name = "txtDetailDonGia";
            txtDetailDonGia.Size = new Size(210, 29);
            txtDetailDonGia.TabIndex = 9;
            txtDetailDonGia.Text = "320 đ";
            // 
            // lblFieldTonKho
            // 
            lblFieldTonKho.AutoSize = true;
            lblFieldTonKho.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldTonKho.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldTonKho.Location = new Point(3, 162);
            lblFieldTonKho.Name = "lblFieldTonKho";
            lblFieldTonKho.Size = new Size(110, 20);
            lblFieldTonKho.TabIndex = 10;
            lblFieldTonKho.Text = "TỒN HIỆN TẠI";
            // 
            // txtDetailTonKho
            // 
            txtDetailTonKho.BackColor = Color.FromArgb(248, 245, 242);
            txtDetailTonKho.Dock = DockStyle.Fill;
            txtDetailTonKho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtDetailTonKho.ForeColor = Color.FromArgb(44, 24, 16);
            txtDetailTonKho.Location = new Point(3, 185);
            txtDetailTonKho.Name = "txtDetailTonKho";
            txtDetailTonKho.ReadOnly = true;
            txtDetailTonKho.Size = new Size(210, 30);
            txtDetailTonKho.TabIndex = 11;
            txtDetailTonKho.Text = "1.200 g";
            // 
            // lblFieldMucToiThieu
            // 
            lblFieldMucToiThieu.AutoSize = true;
            lblFieldMucToiThieu.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFieldMucToiThieu.ForeColor = Color.FromArgb(125, 110, 101);
            lblFieldMucToiThieu.Location = new Point(219, 162);
            lblFieldMucToiThieu.Name = "lblFieldMucToiThieu";
            lblFieldMucToiThieu.Size = new Size(121, 20);
            lblFieldMucToiThieu.TabIndex = 12;
            lblFieldMucToiThieu.Text = "MỨC TỐI THIỂU";
            // 
            // nudDetailMucToiThieu
            // 
            nudDetailMucToiThieu.Dock = DockStyle.Fill;
            nudDetailMucToiThieu.Font = new Font("Segoe UI", 9.5F);
            nudDetailMucToiThieu.Location = new Point(219, 185);
            nudDetailMucToiThieu.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudDetailMucToiThieu.Name = "nudDetailMucToiThieu";
            nudDetailMucToiThieu.Size = new Size(210, 29);
            nudDetailMucToiThieu.TabIndex = 13;
            nudDetailMucToiThieu.ThousandsSeparator = true;
            nudDetailMucToiThieu.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // pnlDetailHeader
            // 
            pnlDetailHeader.Controls.Add(btnLuu);
            pnlDetailHeader.Controls.Add(lblDetailMaNL);
            pnlDetailHeader.Controls.Add(lblDetailHeader);
            pnlDetailHeader.Dock = DockStyle.Top;
            pnlDetailHeader.Location = new Point(16, 16);
            pnlDetailHeader.Name = "pnlDetailHeader";
            pnlDetailHeader.Size = new Size(432, 46);
            pnlDetailHeader.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.BackColor = Color.FromArgb(106, 80, 63);
            btnLuu.BorderColor = Color.FromArgb(106, 80, 63);
            btnLuu.BorderRadius = 6;
            btnLuu.BorderWidth = 1;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.CustomIcon = null;
            btnLuu.DownBackColor = Color.FromArgb(85, 55, 34);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.HoverBackColor = Color.FromArgb(85, 55, 34);
            btnLuu.HoverColor = Color.FromArgb(85, 55, 34);
            btnLuu.IsOutlined = false;
            btnLuu.Location = new Point(355, 6);
            btnLuu.Name = "btnLuu";
            btnLuu.NormalBackColor = Color.FromArgb(106, 80, 63);
            btnLuu.Size = new Size(74, 32);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "💾 Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // lblDetailMaNL
            // 
            lblDetailMaNL.AutoSize = true;
            lblDetailMaNL.Font = new Font("Segoe UI", 9F);
            lblDetailMaNL.ForeColor = Color.FromArgb(125, 110, 101);
            lblDetailMaNL.Location = new Point(2, 24);
            lblDetailMaNL.Name = "lblDetailMaNL";
            lblDetailMaNL.Size = new Size(101, 20);
            lblDetailMaNL.TabIndex = 1;
            lblDetailMaNL.Text = "Mã NL: NL001";
            // 
            // lblDetailHeader
            // 
            lblDetailHeader.AutoSize = true;
            lblDetailHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailHeader.ForeColor = Color.FromArgb(44, 30, 20);
            lblDetailHeader.Location = new Point(0, 0);
            lblDetailHeader.Name = "lblDetailHeader";
            lblDetailHeader.Size = new Size(241, 28);
            lblDetailHeader.TabIndex = 0;
            lblDetailHeader.Text = "≡ Thông tin nguyên liệu";
            // 
            // pnlHistoryCard
            // 
            pnlHistoryCard.BackColor = Color.Transparent;
            pnlHistoryCard.BorderColor = Color.FromArgb(232, 223, 213);
            pnlHistoryCard.BorderRadius = 12;
            pnlHistoryCard.BorderWidth = 1;
            pnlHistoryCard.Controls.Add(dgvLichSuKho);
            pnlHistoryCard.Controls.Add(lblHistoryTitle);
            pnlHistoryCard.Dock = DockStyle.Fill;
            pnlHistoryCard.FillColor = Color.White;
            pnlHistoryCard.Location = new Point(0, 0);
            pnlHistoryCard.Name = "pnlHistoryCard";
            pnlHistoryCard.Padding = new Padding(14);
            pnlHistoryCard.Size = new Size(1244, 275);
            pnlHistoryCard.TabIndex = 0;
            // 
            // dgvLichSuKho
            // 
            dgvLichSuKho.AllowUserToAddRows = false;
            dgvLichSuKho.AllowUserToDeleteRows = false;
            dgvLichSuKho.AllowUserToResizeRows = false;
            dgvLichSuKho.BackgroundColor = Color.White;
            dgvLichSuKho.BorderStyle = BorderStyle.None;
            dgvLichSuKho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLichSuKho.ColumnHeadersHeight = 40;
            dgvLichSuKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLichSuKho.Columns.AddRange(new DataGridViewColumn[] { colHistoryThoiGian, colHistoryLoai, colHistorySoLuong, colHistoryTonSau, colHistoryNguoiThucHien, colHistoryGhiChu });
            dgvLichSuKho.Dock = DockStyle.Fill;
            dgvLichSuKho.EnableHeadersVisualStyles = false;
            dgvLichSuKho.Location = new Point(14, 44);
            dgvLichSuKho.MultiSelect = false;
            dgvLichSuKho.Name = "dgvLichSuKho";
            dgvLichSuKho.ReadOnly = true;
            dgvLichSuKho.RowHeadersVisible = false;
            dgvLichSuKho.RowHeadersWidth = 51;
            dgvLichSuKho.RowTemplate.Height = 38;
            dgvLichSuKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichSuKho.Size = new Size(1216, 217);
            dgvLichSuKho.TabIndex = 1;
            // 
            // colHistoryThoiGian
            // 
            colHistoryThoiGian.HeaderText = "THỜI GIAN";
            colHistoryThoiGian.MinimumWidth = 6;
            colHistoryThoiGian.Name = "colHistoryThoiGian";
            colHistoryThoiGian.ReadOnly = true;
            colHistoryThoiGian.Width = 150;
            // 
            // colHistoryLoai
            // 
            colHistoryLoai.HeaderText = "LOẠI";
            colHistoryLoai.MinimumWidth = 6;
            colHistoryLoai.Name = "colHistoryLoai";
            colHistoryLoai.ReadOnly = true;
            colHistoryLoai.Width = 190;
            // 
            // colHistorySoLuong
            // 
            colHistorySoLuong.HeaderText = "SỐ LƯỢNG";
            colHistorySoLuong.MinimumWidth = 6;
            colHistorySoLuong.Name = "colHistorySoLuong";
            colHistorySoLuong.ReadOnly = true;
            colHistorySoLuong.Width = 130;
            // 
            // colHistoryTonSau
            // 
            colHistoryTonSau.HeaderText = "TỒN SAU";
            colHistoryTonSau.MinimumWidth = 6;
            colHistoryTonSau.Name = "colHistoryTonSau";
            colHistoryTonSau.ReadOnly = true;
            colHistoryTonSau.Width = 130;
            // 
            // colHistoryNguoiThucHien
            // 
            colHistoryNguoiThucHien.HeaderText = "NGƯỜI THỰC HIỆN";
            colHistoryNguoiThucHien.MinimumWidth = 6;
            colHistoryNguoiThucHien.Name = "colHistoryNguoiThucHien";
            colHistoryNguoiThucHien.ReadOnly = true;
            colHistoryNguoiThucHien.Width = 170;
            // 
            // colHistoryGhiChu
            // 
            colHistoryGhiChu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHistoryGhiChu.HeaderText = "GHI CHÚ / CHI TIẾT";
            colHistoryGhiChu.MinimumWidth = 6;
            colHistoryGhiChu.Name = "colHistoryGhiChu";
            colHistoryGhiChu.ReadOnly = true;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(44, 30, 20);
            lblHistoryTitle.Location = new Point(14, 14);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(1216, 30);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "Lịch sử nhập / xuất · NL001";
            // 
            // ucQuanLyKho
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 245, 242);
            Controls.Add(splitMain);
            Controls.Add(pnlFilterBar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "ucQuanLyKho";
            Padding = new Padding(18, 16, 18, 16);
            Size = new Size(1280, 820);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlHeaderButtons.ResumeLayout(false);
            pnlFilterBar.ResumeLayout(false);
            pnlFilterTrangThai.ResumeLayout(false);
            pnlFilterTrangThai.PerformLayout();
            pnlFilterNhom.ResumeLayout(false);
            pnlFilterNhom.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            splitTop.Panel1.ResumeLayout(false);
            splitTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitTop).EndInit();
            splitTop.ResumeLayout(false);
            pnlMasterCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNguyenLieu).EndInit();
            pnlDetailCard.ResumeLayout(false);
            flpDetailActions.ResumeLayout(false);
            tlpDetailFields.ResumeLayout(false);
            tlpDetailFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDetailMucToiThieu).EndInit();
            pnlDetailHeader.ResumeLayout(false);
            pnlDetailHeader.PerformLayout();
            pnlHistoryCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSuKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlHeaderButtons;
        private RoundedButton btnThemNguyenLieu;
        private RoundedButton btnXuatExcel;
        private RoundedButton btnNhapKhoTop;
        private System.Windows.Forms.Panel pnlFilterBar;
        private RoundedTextBox txtSearch;
        private RoundedPanel pnlFilterNhom;
        private System.Windows.Forms.Label lblPrefixNhom;
        private System.Windows.Forms.ComboBox cboNhom;
        private RoundedPanel pnlFilterTrangThai;
        private System.Windows.Forms.Label lblPrefixTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitTop;
        private RoundedPanel pnlMasterCard;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private RoundedPanel pnlDetailCard;
        private System.Windows.Forms.Panel pnlDetailHeader;
        private System.Windows.Forms.Label lblDetailHeader;
        private System.Windows.Forms.Label lblDetailMaNL;
        private RoundedButton btnLuu;
        private System.Windows.Forms.TableLayoutPanel tlpDetailFields;
        private System.Windows.Forms.Label lblFieldMaNL;
        private System.Windows.Forms.TextBox txtDetailMaNL;
        private System.Windows.Forms.Label lblFieldNhom;
        private System.Windows.Forms.ComboBox cboDetailNhom;
        private System.Windows.Forms.Label lblFieldTenNL;
        private System.Windows.Forms.TextBox txtDetailTenNL;
        private System.Windows.Forms.Label lblFieldDVT;
        private System.Windows.Forms.TextBox txtDetailDVT;
        private System.Windows.Forms.Label lblFieldDonGia;
        private System.Windows.Forms.TextBox txtDetailDonGia;
        private System.Windows.Forms.Label lblFieldTonKho;
        private System.Windows.Forms.TextBox txtDetailTonKho;
        private System.Windows.Forms.Label lblFieldMucToiThieu;
        private System.Windows.Forms.NumericUpDown nudDetailMucToiThieu;
        private System.Windows.Forms.FlowLayoutPanel flpDetailActions;
        private RoundedButton btnNhapKho;
        private RoundedButton btnXuatKho;
        private RoundedButton btnNgungSuDung;
        private RoundedPanel pnlHistoryCard;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvLichSuKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistorySoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryTonSau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryNguoiThucHien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistoryGhiChu;
    }
}
