using DoAnLapTrinhTrucQuan.Helpers;

namespace DoAnLapTrinhTrucQuan.Forms
{
    partial class dlgAddIngredient
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            pnlContentArea = new Panel();
            pnlTabExcel = new Panel();
            tlpExcelCards = new TableLayoutPanel();
            pnlCardNhap = new RoundedPanel();
            lblNoteNhap = new Label();
            flpNhapButtons = new FlowLayoutPanel();
            btnTaiTepMau = new RoundedButton();
            btnXemTruoc = new RoundedButton();
            btnNhapNguyenLieu = new RoundedButton();
            pnlDashedBox = new Panel();
            btnChonTepExcel = new RoundedButton();
            lblDropSub = new Label();
            lblDropTitle = new Label();
            pnlHeaderCardNhap = new Panel();
            lblBadgeXlsxNhap = new Label();
            lblSubtitleNhap = new Label();
            lblTitleNhap = new Label();
            pnlCardXuat = new RoundedPanel();
            lblNoteXuat = new Label();
            flpXuatButtons = new FlowLayoutPanel();
            btnXuatExcel = new RoundedButton();
            btnXemDuLieuXuat = new RoundedButton();
            pnlXuatInfoBox = new RoundedPanel();
            lblAllIngSub = new Label();
            lblAllIngTitle = new Label();
            pnlHeaderCardXuat = new Panel();
            lblBadgeXlsxXuat = new Label();
            lblSubtitleXuat = new Label();
            lblTitleXuat = new Label();
            pnlTabManual = new Panel();
            pnlButtons = new Panel();
            btnSave = new RoundedButton();
            btnCancel = new RoundedButton();
            pnlDivider2 = new Panel();
            tlpFields = new TableLayoutPanel();
            lblMaNL = new Label();
            txtMaNL = new TextBox();
            lblNhom = new Label();
            cboNhom = new ComboBox();
            lblTenNL = new Label();
            txtTenNL = new TextBox();
            lblDVT = new Label();
            cboDVT = new ComboBox();
            lblDonGiaNhap = new Label();
            nudDonGiaNhap = new NumericUpDown();
            lblTonBanDau = new Label();
            nudTonBanDau = new NumericUpDown();
            lblMinStock = new Label();
            nudMinStock = new NumericUpDown();
            lblViTriKho = new Label();
            txtViTriKho = new TextBox();
            pnlTabSelector = new RoundedPanel();
            btnTabExcel = new RoundedButton();
            btnTabManual = new RoundedButton();
            lblSubTitle = new Label();
            lblTitle = new Label();
            pnlCard.SuspendLayout();
            pnlContentArea.SuspendLayout();
            pnlTabExcel.SuspendLayout();
            tlpExcelCards.SuspendLayout();
            pnlCardNhap.SuspendLayout();
            flpNhapButtons.SuspendLayout();
            pnlDashedBox.SuspendLayout();
            pnlHeaderCardNhap.SuspendLayout();
            pnlCardXuat.SuspendLayout();
            flpXuatButtons.SuspendLayout();
            pnlXuatInfoBox.SuspendLayout();
            pnlHeaderCardXuat.SuspendLayout();
            pnlTabManual.SuspendLayout();
            pnlButtons.SuspendLayout();
            tlpFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDonGiaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTonBanDau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStock).BeginInit();
            pnlTabSelector.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(pnlContentArea);
            pnlCard.Controls.Add(pnlTabSelector);
            pnlCard.Controls.Add(lblSubTitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(27, 24, 27, 21);
            pnlCard.Size = new Size(846, 760);
            pnlCard.TabIndex = 0;
            // 
            // pnlContentArea
            // 
            pnlContentArea.Controls.Add(pnlTabExcel);
            pnlContentArea.Controls.Add(pnlTabManual);
            pnlContentArea.Dock = DockStyle.Fill;
            pnlContentArea.Location = new Point(27, 146);
            pnlContentArea.Margin = new Padding(3, 4, 3, 4);
            pnlContentArea.Name = "pnlContentArea";
            pnlContentArea.Size = new Size(792, 593);
            pnlContentArea.TabIndex = 3;
            // 
            // pnlTabExcel
            // 
            pnlTabExcel.Controls.Add(tlpExcelCards);
            pnlTabExcel.Dock = DockStyle.Fill;
            pnlTabExcel.Location = new Point(0, 0);
            pnlTabExcel.Margin = new Padding(3, 4, 3, 4);
            pnlTabExcel.Name = "pnlTabExcel";
            pnlTabExcel.Padding = new Padding(0, 8, 0, 0);
            pnlTabExcel.Size = new Size(792, 593);
            pnlTabExcel.TabIndex = 1;
            pnlTabExcel.Visible = false;
            // 
            // tlpExcelCards
            // 
            tlpExcelCards.ColumnCount = 2;
            tlpExcelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpExcelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpExcelCards.Controls.Add(pnlCardNhap, 0, 0);
            tlpExcelCards.Controls.Add(pnlCardXuat, 1, 0);
            tlpExcelCards.Dock = DockStyle.Fill;
            tlpExcelCards.Location = new Point(0, 8);
            tlpExcelCards.Margin = new Padding(3, 4, 3, 4);
            tlpExcelCards.Name = "tlpExcelCards";
            tlpExcelCards.RowCount = 1;
            tlpExcelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpExcelCards.Size = new Size(792, 585);
            tlpExcelCards.TabIndex = 0;
            // 
            // pnlCardNhap
            // 
            pnlCardNhap.BackColor = Color.Transparent;
            pnlCardNhap.BorderColor = Color.FromArgb(232, 223, 213);
            pnlCardNhap.BorderRadius = 10;
            pnlCardNhap.BorderWidth = 1;
            pnlCardNhap.Controls.Add(lblNoteNhap);
            pnlCardNhap.Controls.Add(flpNhapButtons);
            pnlCardNhap.Controls.Add(pnlDashedBox);
            pnlCardNhap.Controls.Add(pnlHeaderCardNhap);
            pnlCardNhap.Dock = DockStyle.Fill;
            pnlCardNhap.FillColor = Color.White;
            pnlCardNhap.Location = new Point(0, 0);
            pnlCardNhap.Margin = new Padding(0, 0, 9, 0);
            pnlCardNhap.Name = "pnlCardNhap";
            pnlCardNhap.Padding = new Padding(18, 19, 18, 19);
            pnlCardNhap.Size = new Size(387, 585);
            pnlCardNhap.TabIndex = 0;
            // 
            // lblNoteNhap
            // 
            lblNoteNhap.AutoSize = true;
            lblNoteNhap.Font = new Font("Segoe UI", 8.5F);
            lblNoteNhap.ForeColor = Color.FromArgb(141, 131, 123);
            lblNoteNhap.Location = new Point(18, 347);
            lblNoteNhap.Name = "lblNoteNhap";
            lblNoteNhap.Size = new Size(185, 20);
            lblNoteNhap.TabIndex = 3;
            lblNoteNhap.Text = "Chọn tệp để bắt đầu nhập.";
            // 
            // flpNhapButtons
            // 
            flpNhapButtons.Controls.Add(btnTaiTepMau);
            flpNhapButtons.Controls.Add(btnXemTruoc);
            flpNhapButtons.Controls.Add(btnNhapNguyenLieu);
            flpNhapButtons.Location = new Point(18, 272);
            flpNhapButtons.Margin = new Padding(3, 4, 3, 4);
            flpNhapButtons.Name = "flpNhapButtons";
            flpNhapButtons.Size = new Size(350, 59);
            flpNhapButtons.TabIndex = 2;
            // 
            // btnTaiTepMau
            // 
            btnTaiTepMau.BackColor = Color.FromArgb(248, 243, 238);
            btnTaiTepMau.BorderColor = Color.FromArgb(220, 206, 194);
            btnTaiTepMau.BorderRadius = 6;
            btnTaiTepMau.BorderWidth = 1;
            btnTaiTepMau.Cursor = Cursors.Hand;
            btnTaiTepMau.CustomIcon = null;
            btnTaiTepMau.DownBackColor = Color.FromArgb(238, 228, 218);
            btnTaiTepMau.FlatAppearance.BorderSize = 0;
            btnTaiTepMau.FlatStyle = FlatStyle.Flat;
            btnTaiTepMau.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnTaiTepMau.ForeColor = Color.FromArgb(91, 63, 43);
            btnTaiTepMau.HoverBackColor = Color.FromArgb(242, 234, 226);
            btnTaiTepMau.HoverColor = Color.FromArgb(242, 234, 226);
            btnTaiTepMau.IsOutlined = false;
            btnTaiTepMau.Location = new Point(0, 5);
            btnTaiTepMau.Margin = new Padding(0, 5, 7, 0);
            btnTaiTepMau.Name = "btnTaiTepMau";
            btnTaiTepMau.NormalBackColor = Color.FromArgb(248, 243, 238);
            btnTaiTepMau.Size = new Size(109, 45);
            btnTaiTepMau.TabIndex = 0;
            btnTaiTepMau.Text = "Tải tệp mẫu";
            btnTaiTepMau.UseVisualStyleBackColor = false;
            // 
            // btnXemTruoc
            // 
            btnXemTruoc.BackColor = Color.White;
            btnXemTruoc.BorderColor = Color.FromArgb(208, 197, 184);
            btnXemTruoc.BorderRadius = 6;
            btnXemTruoc.BorderWidth = 1;
            btnXemTruoc.Cursor = Cursors.Hand;
            btnXemTruoc.CustomIcon = null;
            btnXemTruoc.DownBackColor = Color.FromArgb(239, 229, 219);
            btnXemTruoc.FlatAppearance.BorderSize = 0;
            btnXemTruoc.FlatStyle = FlatStyle.Flat;
            btnXemTruoc.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnXemTruoc.ForeColor = Color.FromArgb(111, 78, 55);
            btnXemTruoc.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnXemTruoc.HoverColor = Color.FromArgb(247, 239, 231);
            btnXemTruoc.IsOutlined = true;
            btnXemTruoc.Location = new Point(116, 5);
            btnXemTruoc.Margin = new Padding(0, 5, 7, 0);
            btnXemTruoc.Name = "btnXemTruoc";
            btnXemTruoc.NormalBackColor = Color.White;
            btnXemTruoc.Size = new Size(98, 45);
            btnXemTruoc.TabIndex = 1;
            btnXemTruoc.Text = "Xem trước";
            btnXemTruoc.UseVisualStyleBackColor = false;
            // 
            // btnNhapNguyenLieu
            // 
            btnNhapNguyenLieu.BackColor = Color.FromArgb(200, 185, 172);
            btnNhapNguyenLieu.BorderColor = Color.FromArgb(200, 185, 172);
            btnNhapNguyenLieu.BorderRadius = 6;
            btnNhapNguyenLieu.BorderWidth = 1;
            btnNhapNguyenLieu.Cursor = Cursors.Hand;
            btnNhapNguyenLieu.CustomIcon = null;
            btnNhapNguyenLieu.DownBackColor = Color.FromArgb(85, 55, 34);
            btnNhapNguyenLieu.FlatAppearance.BorderSize = 0;
            btnNhapNguyenLieu.FlatStyle = FlatStyle.Flat;
            btnNhapNguyenLieu.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnNhapNguyenLieu.ForeColor = Color.White;
            btnNhapNguyenLieu.HoverBackColor = Color.FromArgb(106, 80, 63);
            btnNhapNguyenLieu.HoverColor = Color.FromArgb(106, 80, 63);
            btnNhapNguyenLieu.IsOutlined = false;
            btnNhapNguyenLieu.Location = new Point(221, 5);
            btnNhapNguyenLieu.Margin = new Padding(0, 5, 0, 0);
            btnNhapNguyenLieu.Name = "btnNhapNguyenLieu";
            btnNhapNguyenLieu.NormalBackColor = Color.FromArgb(200, 185, 172);
            btnNhapNguyenLieu.Size = new Size(121, 45);
            btnNhapNguyenLieu.TabIndex = 2;
            btnNhapNguyenLieu.Text = "Nhập tệp";
            btnNhapNguyenLieu.UseVisualStyleBackColor = false;
            // 
            // pnlDashedBox
            // 
            pnlDashedBox.Controls.Add(btnChonTepExcel);
            pnlDashedBox.Controls.Add(lblDropSub);
            pnlDashedBox.Controls.Add(lblDropTitle);
            pnlDashedBox.Location = new Point(18, 96);
            pnlDashedBox.Margin = new Padding(3, 4, 3, 4);
            pnlDashedBox.Name = "pnlDashedBox";
            pnlDashedBox.Size = new Size(350, 155);
            pnlDashedBox.TabIndex = 1;
            // 
            // btnChonTepExcel
            // 
            btnChonTepExcel.BackColor = Color.FromArgb(140, 74, 39);
            btnChonTepExcel.BorderColor = Color.FromArgb(140, 74, 39);
            btnChonTepExcel.BorderRadius = 6;
            btnChonTepExcel.BorderWidth = 1;
            btnChonTepExcel.Cursor = Cursors.Hand;
            btnChonTepExcel.CustomIcon = null;
            btnChonTepExcel.DownBackColor = Color.FromArgb(115, 55, 25);
            btnChonTepExcel.FlatAppearance.BorderSize = 0;
            btnChonTepExcel.FlatStyle = FlatStyle.Flat;
            btnChonTepExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChonTepExcel.ForeColor = Color.White;
            btnChonTepExcel.HoverBackColor = Color.FromArgb(125, 65, 30);
            btnChonTepExcel.HoverColor = Color.FromArgb(125, 65, 30);
            btnChonTepExcel.IsOutlined = false;
            btnChonTepExcel.Location = new Point(103, 96);
            btnChonTepExcel.Margin = new Padding(3, 4, 3, 4);
            btnChonTepExcel.Name = "btnChonTepExcel";
            btnChonTepExcel.NormalBackColor = Color.FromArgb(140, 74, 39);
            btnChonTepExcel.Size = new Size(144, 43);
            btnChonTepExcel.TabIndex = 2;
            btnChonTepExcel.Text = "Chọn tệp Excel";
            btnChonTepExcel.UseVisualStyleBackColor = false;
            // 
            // lblDropSub
            // 
            lblDropSub.Font = new Font("Segoe UI", 8.5F);
            lblDropSub.ForeColor = Color.FromArgb(141, 131, 123);
            lblDropSub.Location = new Point(7, 56);
            lblDropSub.Name = "lblDropSub";
            lblDropSub.Size = new Size(336, 24);
            lblDropSub.TabIndex = 1;
            lblDropSub.Text = "Định dạng hỗ trợ: .xlsx";
            lblDropSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDropTitle
            // 
            lblDropTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDropTitle.ForeColor = Color.FromArgb(70, 50, 40);
            lblDropTitle.Location = new Point(7, 21);
            lblDropTitle.Name = "lblDropTitle";
            lblDropTitle.Size = new Size(336, 27);
            lblDropTitle.TabIndex = 0;
            lblDropTitle.Text = "Chưa chọn tệp";
            lblDropTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeaderCardNhap
            // 
            pnlHeaderCardNhap.Controls.Add(lblBadgeXlsxNhap);
            pnlHeaderCardNhap.Controls.Add(lblSubtitleNhap);
            pnlHeaderCardNhap.Controls.Add(lblTitleNhap);
            pnlHeaderCardNhap.Dock = DockStyle.Top;
            pnlHeaderCardNhap.Location = new Point(18, 19);
            pnlHeaderCardNhap.Margin = new Padding(3, 4, 3, 4);
            pnlHeaderCardNhap.Name = "pnlHeaderCardNhap";
            pnlHeaderCardNhap.Size = new Size(351, 69);
            pnlHeaderCardNhap.TabIndex = 0;
            // 
            // lblBadgeXlsxNhap
            // 
            lblBadgeXlsxNhap.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBadgeXlsxNhap.BackColor = Color.FromArgb(254, 243, 235);
            lblBadgeXlsxNhap.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBadgeXlsxNhap.ForeColor = Color.FromArgb(192, 106, 43);
            lblBadgeXlsxNhap.Location = new Point(294, 0);
            lblBadgeXlsxNhap.Name = "lblBadgeXlsxNhap";
            lblBadgeXlsxNhap.Size = new Size(57, 27);
            lblBadgeXlsxNhap.TabIndex = 2;
            lblBadgeXlsxNhap.Text = ".XLSX";
            lblBadgeXlsxNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitleNhap
            // 
            lblSubtitleNhap.AutoSize = true;
            lblSubtitleNhap.Font = new Font("Segoe UI", 8.5F);
            lblSubtitleNhap.ForeColor = Color.FromArgb(126, 110, 101);
            lblSubtitleNhap.Location = new Point(0, 35);
            lblSubtitleNhap.Name = "lblSubtitleNhap";
            lblSubtitleNhap.Size = new Size(258, 20);
            lblSubtitleNhap.TabIndex = 1;
            lblSubtitleNhap.Text = "Dùng tệp mẫu để chuẩn bị danh sách.";
            // 
            // lblTitleNhap
            // 
            lblTitleNhap.AutoSize = true;
            lblTitleNhap.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTitleNhap.ForeColor = Color.FromArgb(44, 30, 20);
            lblTitleNhap.Location = new Point(0, 0);
            lblTitleNhap.Name = "lblTitleNhap";
            lblTitleNhap.Size = new Size(180, 28);
            lblTitleNhap.TabIndex = 0;
            lblTitleNhap.Text = "Nhập nguyên liệu";
            // 
            // pnlCardXuat
            // 
            pnlCardXuat.BackColor = Color.Transparent;
            pnlCardXuat.BorderColor = Color.FromArgb(232, 223, 213);
            pnlCardXuat.BorderRadius = 10;
            pnlCardXuat.BorderWidth = 1;
            pnlCardXuat.Controls.Add(lblNoteXuat);
            pnlCardXuat.Controls.Add(flpXuatButtons);
            pnlCardXuat.Controls.Add(pnlXuatInfoBox);
            pnlCardXuat.Controls.Add(pnlHeaderCardXuat);
            pnlCardXuat.Dock = DockStyle.Fill;
            pnlCardXuat.FillColor = Color.White;
            pnlCardXuat.Location = new Point(405, 0);
            pnlCardXuat.Margin = new Padding(9, 0, 0, 0);
            pnlCardXuat.Name = "pnlCardXuat";
            pnlCardXuat.Padding = new Padding(18, 19, 18, 19);
            pnlCardXuat.Size = new Size(387, 585);
            pnlCardXuat.TabIndex = 1;
            // 
            // lblNoteXuat
            // 
            lblNoteXuat.AutoSize = true;
            lblNoteXuat.Font = new Font("Segoe UI", 8.5F);
            lblNoteXuat.ForeColor = Color.FromArgb(141, 131, 123);
            lblNoteXuat.Location = new Point(18, 347);
            lblNoteXuat.Name = "lblNoteXuat";
            lblNoteXuat.Size = new Size(321, 20);
            lblNoteXuat.TabIndex = 3;
            lblNoteXuat.Text = "Bao gồm mã, tên, nhóm, đơn vị tính và tồn kho.";
            // 
            // flpXuatButtons
            // 
            flpXuatButtons.Controls.Add(btnXuatExcel);
            flpXuatButtons.Controls.Add(btnXemDuLieuXuat);
            flpXuatButtons.Location = new Point(18, 272);
            flpXuatButtons.Margin = new Padding(3, 4, 3, 4);
            flpXuatButtons.Name = "flpXuatButtons";
            flpXuatButtons.Size = new Size(359, 59);
            flpXuatButtons.TabIndex = 2;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(22, 101, 52);
            btnXuatExcel.BorderColor = Color.FromArgb(22, 101, 52);
            btnXuatExcel.BorderRadius = 6;
            btnXuatExcel.BorderWidth = 1;
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.CustomIcon = null;
            btnXuatExcel.DownBackColor = Color.FromArgb(16, 75, 38);
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.HoverBackColor = Color.FromArgb(20, 88, 45);
            btnXuatExcel.HoverColor = Color.FromArgb(20, 88, 45);
            btnXuatExcel.IsOutlined = false;
            btnXuatExcel.Location = new Point(0, 5);
            btnXuatExcel.Margin = new Padding(0, 5, 9, 0);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.NormalBackColor = Color.FromArgb(22, 101, 52);
            btnXuatExcel.Size = new Size(114, 45);
            btnXuatExcel.TabIndex = 0;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnXemDuLieuXuat
            // 
            btnXemDuLieuXuat.BackColor = Color.White;
            btnXemDuLieuXuat.BorderColor = Color.FromArgb(208, 197, 184);
            btnXemDuLieuXuat.BorderRadius = 6;
            btnXemDuLieuXuat.BorderWidth = 1;
            btnXemDuLieuXuat.Cursor = Cursors.Hand;
            btnXemDuLieuXuat.CustomIcon = null;
            btnXemDuLieuXuat.DownBackColor = Color.FromArgb(239, 229, 219);
            btnXemDuLieuXuat.FlatAppearance.BorderSize = 0;
            btnXemDuLieuXuat.FlatStyle = FlatStyle.Flat;
            btnXemDuLieuXuat.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnXemDuLieuXuat.ForeColor = Color.FromArgb(111, 78, 55);
            btnXemDuLieuXuat.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnXemDuLieuXuat.HoverColor = Color.FromArgb(247, 239, 231);
            btnXemDuLieuXuat.IsOutlined = true;
            btnXemDuLieuXuat.Location = new Point(123, 5);
            btnXemDuLieuXuat.Margin = new Padding(0, 5, 0, 0);
            btnXemDuLieuXuat.Name = "btnXemDuLieuXuat";
            btnXemDuLieuXuat.NormalBackColor = Color.White;
            btnXemDuLieuXuat.Size = new Size(143, 45);
            btnXemDuLieuXuat.TabIndex = 1;
            btnXemDuLieuXuat.Text = "Xem dữ liệu xuất";
            btnXemDuLieuXuat.UseVisualStyleBackColor = false;
            // 
            // pnlXuatInfoBox
            // 
            pnlXuatInfoBox.BackColor = Color.Transparent;
            pnlXuatInfoBox.BorderColor = Color.FromArgb(198, 238, 212);
            pnlXuatInfoBox.BorderRadius = 8;
            pnlXuatInfoBox.BorderWidth = 1;
            pnlXuatInfoBox.Controls.Add(lblAllIngSub);
            pnlXuatInfoBox.Controls.Add(lblAllIngTitle);
            pnlXuatInfoBox.FillColor = Color.FromArgb(240, 253, 244);
            pnlXuatInfoBox.Location = new Point(18, 96);
            pnlXuatInfoBox.Margin = new Padding(3, 4, 3, 4);
            pnlXuatInfoBox.Name = "pnlXuatInfoBox";
            pnlXuatInfoBox.Padding = new Padding(18, 27, 18, 21);
            pnlXuatInfoBox.Size = new Size(359, 155);
            pnlXuatInfoBox.TabIndex = 1;
            // 
            // lblAllIngSub
            // 
            lblAllIngSub.AutoSize = true;
            lblAllIngSub.Font = new Font("Segoe UI", 8.5F);
            lblAllIngSub.ForeColor = Color.FromArgb(21, 128, 61);
            lblAllIngSub.Location = new Point(16, 61);
            lblAllIngSub.Name = "lblAllIngSub";
            lblAllIngSub.Size = new Size(267, 20);
            lblAllIngSub.TabIndex = 1;
            lblAllIngSub.Text = "28 nguyên liệu - Định dạng Excel (.xlsx)";
            // 
            // lblAllIngTitle
            // 
            lblAllIngTitle.AutoSize = true;
            lblAllIngTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAllIngTitle.ForeColor = Color.FromArgb(20, 83, 45);
            lblAllIngTitle.Location = new Point(16, 27);
            lblAllIngTitle.Name = "lblAllIngTitle";
            lblAllIngTitle.Size = new Size(169, 25);
            lblAllIngTitle.TabIndex = 0;
            lblAllIngTitle.Text = "Tất cả nguyên liệu";
            // 
            // pnlHeaderCardXuat
            // 
            pnlHeaderCardXuat.Controls.Add(lblBadgeXlsxXuat);
            pnlHeaderCardXuat.Controls.Add(lblSubtitleXuat);
            pnlHeaderCardXuat.Controls.Add(lblTitleXuat);
            pnlHeaderCardXuat.Dock = DockStyle.Top;
            pnlHeaderCardXuat.Location = new Point(18, 19);
            pnlHeaderCardXuat.Margin = new Padding(3, 4, 3, 4);
            pnlHeaderCardXuat.Name = "pnlHeaderCardXuat";
            pnlHeaderCardXuat.Size = new Size(351, 69);
            pnlHeaderCardXuat.TabIndex = 0;
            // 
            // lblBadgeXlsxXuat
            // 
            lblBadgeXlsxXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBadgeXlsxXuat.BackColor = Color.FromArgb(226, 248, 232);
            lblBadgeXlsxXuat.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblBadgeXlsxXuat.ForeColor = Color.FromArgb(27, 124, 63);
            lblBadgeXlsxXuat.Location = new Point(294, 0);
            lblBadgeXlsxXuat.Name = "lblBadgeXlsxXuat";
            lblBadgeXlsxXuat.Size = new Size(57, 27);
            lblBadgeXlsxXuat.TabIndex = 2;
            lblBadgeXlsxXuat.Text = ".XLSX";
            lblBadgeXlsxXuat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitleXuat
            // 
            lblSubtitleXuat.AutoSize = true;
            lblSubtitleXuat.Font = new Font("Segoe UI", 8.5F);
            lblSubtitleXuat.ForeColor = Color.FromArgb(126, 110, 101);
            lblSubtitleXuat.Location = new Point(0, 35);
            lblSubtitleXuat.Name = "lblSubtitleXuat";
            lblSubtitleXuat.Size = new Size(289, 20);
            lblSubtitleXuat.TabIndex = 1;
            lblSubtitleXuat.Text = "Tải danh sách nguyên liệu và số lượng tồn.";
            // 
            // lblTitleXuat
            // 
            lblTitleXuat.AutoSize = true;
            lblTitleXuat.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTitleXuat.ForeColor = Color.FromArgb(44, 30, 20);
            lblTitleXuat.Location = new Point(0, 0);
            lblTitleXuat.Name = "lblTitleXuat";
            lblTitleXuat.Size = new Size(173, 28);
            lblTitleXuat.TabIndex = 0;
            lblTitleXuat.Text = "Xuất nguyên liệu";
            // 
            // pnlTabManual
            // 
            pnlTabManual.Controls.Add(pnlButtons);
            pnlTabManual.Controls.Add(pnlDivider2);
            pnlTabManual.Controls.Add(tlpFields);
            pnlTabManual.Dock = DockStyle.Fill;
            pnlTabManual.Location = new Point(0, 0);
            pnlTabManual.Margin = new Padding(3, 4, 3, 4);
            pnlTabManual.Name = "pnlTabManual";
            pnlTabManual.Padding = new Padding(0, 13, 0, 0);
            pnlTabManual.Size = new Size(792, 593);
            pnlTabManual.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 531);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(792, 61);
            pnlButtons.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(85, 55, 34);
            btnSave.BorderColor = Color.FromArgb(85, 55, 34);
            btnSave.BorderRadius = 8;
            btnSave.BorderWidth = 0;
            btnSave.Cursor = Cursors.Hand;
            btnSave.CustomIcon = null;
            btnSave.DownBackColor = Color.FromArgb(65, 40, 24);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.HoverBackColor = Color.FromArgb(106, 70, 45);
            btnSave.HoverColor = Color.FromArgb(106, 70, 45);
            btnSave.IsOutlined = false;
            btnSave.Location = new Point(609, 8);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.NormalBackColor = Color.FromArgb(85, 55, 34);
            btnSave.Size = new Size(183, 51);
            btnSave.TabIndex = 1;
            btnSave.Text = "💾 Lưu nguyên liệu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.BorderColor = Color.FromArgb(208, 197, 184);
            btnCancel.BorderRadius = 8;
            btnCancel.BorderWidth = 1;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CustomIcon = null;
            btnCancel.DownBackColor = Color.FromArgb(239, 229, 219);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(111, 78, 55);
            btnCancel.HoverBackColor = Color.FromArgb(247, 239, 231);
            btnCancel.HoverColor = Color.FromArgb(247, 239, 231);
            btnCancel.IsOutlined = true;
            btnCancel.Location = new Point(481, 8);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.NormalBackColor = Color.White;
            btnCancel.Size = new Size(117, 51);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlDivider2
            // 
            pnlDivider2.BackColor = Color.FromArgb(232, 223, 213);
            pnlDivider2.Dock = DockStyle.Bottom;
            pnlDivider2.Location = new Point(0, 592);
            pnlDivider2.Margin = new Padding(3, 4, 3, 4);
            pnlDivider2.Name = "pnlDivider2";
            pnlDivider2.Size = new Size(792, 1);
            pnlDivider2.TabIndex = 4;
            // 
            // tlpFields
            // 
            tlpFields.ColumnCount = 2;
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFields.Controls.Add(lblMaNL, 0, 0);
            tlpFields.Controls.Add(txtMaNL, 0, 1);
            tlpFields.Controls.Add(lblNhom, 1, 0);
            tlpFields.Controls.Add(cboNhom, 1, 1);
            tlpFields.Controls.Add(lblTenNL, 0, 2);
            tlpFields.Controls.Add(txtTenNL, 0, 3);
            tlpFields.Controls.Add(lblDVT, 0, 4);
            tlpFields.Controls.Add(cboDVT, 0, 5);
            tlpFields.Controls.Add(lblDonGiaNhap, 1, 4);
            tlpFields.Controls.Add(nudDonGiaNhap, 1, 5);
            tlpFields.Controls.Add(lblTonBanDau, 0, 6);
            tlpFields.Controls.Add(nudTonBanDau, 0, 7);
            tlpFields.Controls.Add(lblMinStock, 1, 6);
            tlpFields.Controls.Add(nudMinStock, 1, 7);
            tlpFields.Controls.Add(lblViTriKho, 0, 8);
            tlpFields.Controls.Add(txtViTriKho, 0, 9);
            tlpFields.Dock = DockStyle.Top;
            tlpFields.Location = new Point(0, 13);
            tlpFields.Margin = new Padding(3, 4, 3, 4);
            tlpFields.Name = "tlpFields";
            tlpFields.RowCount = 10;
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpFields.Size = new Size(792, 413);
            tlpFields.TabIndex = 3;
            // 
            // lblMaNL
            // 
            lblMaNL.AutoSize = true;
            lblMaNL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaNL.ForeColor = Color.FromArgb(70, 50, 40);
            lblMaNL.Location = new Point(3, 0);
            lblMaNL.Name = "lblMaNL";
            lblMaNL.Size = new Size(127, 20);
            lblMaNL.TabIndex = 0;
            lblMaNL.Text = "Mã nguyên liệu *";
            // 
            // txtMaNL
            // 
            txtMaNL.Dock = DockStyle.Fill;
            txtMaNL.Font = new Font("Segoe UI", 10F);
            txtMaNL.Location = new Point(3, 36);
            txtMaNL.Margin = new Padding(3, 4, 16, 4);
            txtMaNL.Name = "txtMaNL";
            txtMaNL.Size = new Size(377, 30);
            txtMaNL.TabIndex = 1;
            // 
            // lblNhom
            // 
            lblNhom.AutoSize = true;
            lblNhom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNhom.ForeColor = Color.FromArgb(70, 50, 40);
            lblNhom.Location = new Point(399, 0);
            lblNhom.Name = "lblNhom";
            lblNhom.Size = new Size(149, 20);
            lblNhom.TabIndex = 2;
            lblNhom.Text = "Nhóm nguyên liệu *";
            // 
            // cboNhom
            // 
            cboNhom.Dock = DockStyle.Fill;
            cboNhom.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhom.Font = new Font("Segoe UI", 10F);
            cboNhom.FormattingEnabled = true;
            cboNhom.Location = new Point(399, 36);
            cboNhom.Margin = new Padding(3, 4, 3, 4);
            cboNhom.Name = "cboNhom";
            cboNhom.Size = new Size(390, 31);
            cboNhom.TabIndex = 3;
            // 
            // lblTenNL
            // 
            lblTenNL.AutoSize = true;
            tlpFields.SetColumnSpan(lblTenNL, 2);
            lblTenNL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenNL.ForeColor = Color.FromArgb(70, 50, 40);
            lblTenNL.Location = new Point(3, 83);
            lblTenNL.Name = "lblTenNL";
            lblTenNL.Size = new Size(130, 20);
            lblTenNL.TabIndex = 4;
            lblTenNL.Text = "Tên nguyên liệu *";
            // 
            // txtTenNL
            // 
            tlpFields.SetColumnSpan(txtTenNL, 2);
            txtTenNL.Dock = DockStyle.Fill;
            txtTenNL.Font = new Font("Segoe UI", 10F);
            txtTenNL.Location = new Point(3, 119);
            txtTenNL.Margin = new Padding(3, 4, 3, 4);
            txtTenNL.Name = "txtTenNL";
            txtTenNL.PlaceholderText = "Ví dụ: Hạt Cà Phê Typica Đà Lạt Hảo Hạng";
            txtTenNL.Size = new Size(786, 30);
            txtTenNL.TabIndex = 5;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDVT.ForeColor = Color.FromArgb(70, 50, 40);
            lblDVT.Location = new Point(3, 166);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(97, 20);
            lblDVT.TabIndex = 6;
            lblDVT.Text = "Đơn vị tính *";
            // 
            // cboDVT
            // 
            cboDVT.Dock = DockStyle.Fill;
            cboDVT.Font = new Font("Segoe UI", 10F);
            cboDVT.FormattingEnabled = true;
            cboDVT.Items.AddRange(new object[] { "gram (g)", "mililit (ml)", "lon", "hộp", "kg", "lát", "miếng", "chai", "cái (set)" });
            cboDVT.Location = new Point(3, 202);
            cboDVT.Margin = new Padding(3, 4, 16, 4);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(377, 31);
            cboDVT.TabIndex = 7;
            cboDVT.Text = "gram (g)";
            // 
            // lblDonGiaNhap
            // 
            lblDonGiaNhap.AutoSize = true;
            lblDonGiaNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDonGiaNhap.ForeColor = Color.FromArgb(70, 50, 40);
            lblDonGiaNhap.Location = new Point(399, 166);
            lblDonGiaNhap.Name = "lblDonGiaNhap";
            lblDonGiaNhap.Size = new Size(169, 20);
            lblDonGiaNhap.TabIndex = 8;
            lblDonGiaNhap.Text = "Giá vốn / đơn vị (VNĐ)";
            // 
            // nudDonGiaNhap
            // 
            nudDonGiaNhap.Dock = DockStyle.Fill;
            nudDonGiaNhap.Font = new Font("Segoe UI", 10F);
            nudDonGiaNhap.Location = new Point(399, 202);
            nudDonGiaNhap.Margin = new Padding(3, 4, 3, 4);
            nudDonGiaNhap.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudDonGiaNhap.Name = "nudDonGiaNhap";
            nudDonGiaNhap.Size = new Size(390, 30);
            nudDonGiaNhap.TabIndex = 9;
            nudDonGiaNhap.ThousandsSeparator = true;
            // 
            // lblTonBanDau
            // 
            lblTonBanDau.AutoSize = true;
            lblTonBanDau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTonBanDau.ForeColor = Color.FromArgb(70, 50, 40);
            lblTonBanDau.Location = new Point(3, 249);
            lblTonBanDau.Name = "lblTonBanDau";
            lblTonBanDau.Size = new Size(127, 20);
            lblTonBanDau.TabIndex = 10;
            lblTonBanDau.Text = "Tồn kho khởi tạo";
            // 
            // nudTonBanDau
            // 
            nudTonBanDau.Dock = DockStyle.Fill;
            nudTonBanDau.Font = new Font("Segoe UI", 10F);
            nudTonBanDau.Location = new Point(3, 285);
            nudTonBanDau.Margin = new Padding(3, 4, 16, 4);
            nudTonBanDau.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudTonBanDau.Name = "nudTonBanDau";
            nudTonBanDau.Size = new Size(377, 30);
            nudTonBanDau.TabIndex = 11;
            nudTonBanDau.ThousandsSeparator = true;
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMinStock.ForeColor = Color.FromArgb(70, 50, 40);
            lblMinStock.Location = new Point(399, 249);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(172, 20);
            lblMinStock.TabIndex = 12;
            lblMinStock.Text = "Mức tồn tối thiểu (ĐM)";
            // 
            // nudMinStock
            // 
            nudMinStock.Dock = DockStyle.Fill;
            nudMinStock.Font = new Font("Segoe UI", 10F);
            nudMinStock.Location = new Point(399, 285);
            nudMinStock.Margin = new Padding(3, 4, 3, 4);
            nudMinStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMinStock.Name = "nudMinStock";
            nudMinStock.Size = new Size(390, 30);
            nudMinStock.TabIndex = 13;
            nudMinStock.ThousandsSeparator = true;
            // 
            // lblViTriKho
            // 
            lblViTriKho.AutoSize = true;
            tlpFields.SetColumnSpan(lblViTriKho, 2);
            lblViTriKho.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblViTriKho.ForeColor = Color.FromArgb(70, 50, 40);
            lblViTriKho.Location = new Point(3, 332);
            lblViTriKho.Name = "lblViTriKho";
            lblViTriKho.Size = new Size(112, 20);
            lblViTriKho.TabIndex = 14;
            lblViTriKho.Text = "Vị trí bảo quản";
            // 
            // txtViTriKho
            // 
            tlpFields.SetColumnSpan(txtViTriKho, 2);
            txtViTriKho.Dock = DockStyle.Fill;
            txtViTriKho.Font = new Font("Segoe UI", 10F);
            txtViTriKho.Location = new Point(3, 368);
            txtViTriKho.Margin = new Padding(3, 4, 3, 4);
            txtViTriKho.Name = "txtViTriKho";
            txtViTriKho.Size = new Size(786, 30);
            txtViTriKho.TabIndex = 15;
            txtViTriKho.Text = "Kho mát quầy Bar";
            // 
            // pnlTabSelector
            // 
            pnlTabSelector.BackColor = Color.Transparent;
            pnlTabSelector.BorderColor = Color.FromArgb(229, 221, 211);
            pnlTabSelector.BorderRadius = 8;
            pnlTabSelector.BorderWidth = 1;
            pnlTabSelector.Controls.Add(btnTabExcel);
            pnlTabSelector.Controls.Add(btnTabManual);
            pnlTabSelector.Dock = DockStyle.Top;
            pnlTabSelector.FillColor = Color.FromArgb(243, 236, 228);
            pnlTabSelector.Location = new Point(27, 87);
            pnlTabSelector.Margin = new Padding(3, 4, 3, 4);
            pnlTabSelector.Name = "pnlTabSelector";
            pnlTabSelector.Padding = new Padding(3, 4, 3, 4);
            pnlTabSelector.Size = new Size(792, 59);
            pnlTabSelector.TabIndex = 2;
            // 
            // btnTabExcel
            // 
            btnTabExcel.BackColor = Color.FromArgb(243, 236, 228);
            btnTabExcel.BorderColor = Color.Transparent;
            btnTabExcel.BorderRadius = 6;
            btnTabExcel.BorderWidth = 0;
            btnTabExcel.Cursor = Cursors.Hand;
            btnTabExcel.CustomIcon = null;
            btnTabExcel.DownBackColor = Color.FromArgb(232, 223, 212);
            btnTabExcel.FlatAppearance.BorderSize = 0;
            btnTabExcel.FlatStyle = FlatStyle.Flat;
            btnTabExcel.Font = new Font("Segoe UI", 9.5F);
            btnTabExcel.ForeColor = Color.FromArgb(126, 110, 101);
            btnTabExcel.HoverBackColor = Color.FromArgb(238, 230, 220);
            btnTabExcel.HoverColor = Color.FromArgb(238, 230, 220);
            btnTabExcel.IsOutlined = false;
            btnTabExcel.Location = new Point(398, 4);
            btnTabExcel.Margin = new Padding(3, 4, 3, 4);
            btnTabExcel.Name = "btnTabExcel";
            btnTabExcel.NormalBackColor = Color.FromArgb(243, 236, 228);
            btnTabExcel.Size = new Size(390, 51);
            btnTabExcel.TabIndex = 1;
            btnTabExcel.Text = "⭳ Nhập / Xuất Excel (.XLSX)";
            btnTabExcel.UseVisualStyleBackColor = false;
            // 
            // btnTabManual
            // 
            btnTabManual.BackColor = Color.White;
            btnTabManual.BorderColor = Color.FromArgb(220, 210, 200);
            btnTabManual.BorderRadius = 6;
            btnTabManual.BorderWidth = 1;
            btnTabManual.Cursor = Cursors.Hand;
            btnTabManual.CustomIcon = null;
            btnTabManual.DownBackColor = Color.FromArgb(250, 246, 240);
            btnTabManual.FlatAppearance.BorderSize = 0;
            btnTabManual.FlatStyle = FlatStyle.Flat;
            btnTabManual.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTabManual.ForeColor = Color.FromArgb(85, 55, 34);
            btnTabManual.HoverBackColor = Color.White;
            btnTabManual.HoverColor = Color.White;
            btnTabManual.IsOutlined = false;
            btnTabManual.Location = new Point(3, 4);
            btnTabManual.Margin = new Padding(3, 4, 3, 4);
            btnTabManual.Name = "btnTabManual";
            btnTabManual.NormalBackColor = Color.White;
            btnTabManual.Size = new Size(390, 51);
            btnTabManual.TabIndex = 0;
            btnTabManual.Text = "✏ Thêm thủ công";
            btnTabManual.UseVisualStyleBackColor = false;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Dock = DockStyle.Top;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.FromArgb(126, 110, 101);
            lblSubTitle.Location = new Point(27, 56);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Padding = new Padding(0, 0, 0, 11);
            lblSubTitle.Size = new Size(516, 31);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Nhập thông tin nguyên vật liệu để thêm vào danh mục quản lý kho Mộc Café";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 30, 20);
            lblTitle.Location = new Point(27, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "⊕ Thêm nguyên liệu mới";
            // 
            // FormThemNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 245, 242);
            ClientSize = new Size(846, 760);
            Controls.Add(pnlCard);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemNguyenLieu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý & Thêm nguyên liệu";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlContentArea.ResumeLayout(false);
            pnlTabExcel.ResumeLayout(false);
            tlpExcelCards.ResumeLayout(false);
            pnlCardNhap.ResumeLayout(false);
            pnlCardNhap.PerformLayout();
            flpNhapButtons.ResumeLayout(false);
            pnlDashedBox.ResumeLayout(false);
            pnlHeaderCardNhap.ResumeLayout(false);
            pnlHeaderCardNhap.PerformLayout();
            pnlCardXuat.ResumeLayout(false);
            pnlCardXuat.PerformLayout();
            flpXuatButtons.ResumeLayout(false);
            pnlXuatInfoBox.ResumeLayout(false);
            pnlXuatInfoBox.PerformLayout();
            pnlHeaderCardXuat.ResumeLayout(false);
            pnlHeaderCardXuat.PerformLayout();
            pnlTabManual.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            tlpFields.ResumeLayout(false);
            tlpFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDonGiaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTonBanDau).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStock).EndInit();
            pnlTabSelector.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private RoundedPanel pnlTabSelector;
        private RoundedButton btnTabManual;
        private RoundedButton btnTabExcel;
        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.Panel pnlTabManual;
        private System.Windows.Forms.Panel pnlTabExcel;
        private System.Windows.Forms.TableLayoutPanel tlpFields;
        private System.Windows.Forms.Label lblMaNL;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.Label lblTenNL;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.NumericUpDown nudDonGiaNhap;
        private System.Windows.Forms.Label lblTonBanDau;
        private System.Windows.Forms.NumericUpDown nudTonBanDau;
        private System.Windows.Forms.Label lblMinStock;
        private System.Windows.Forms.NumericUpDown nudMinStock;
        private System.Windows.Forms.Label lblViTriKho;
        private System.Windows.Forms.TextBox txtViTriKho;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Panel pnlButtons;
        private RoundedButton btnSave;
        private RoundedButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tlpExcelCards;
        private RoundedPanel pnlCardNhap;
        private System.Windows.Forms.Panel pnlHeaderCardNhap;
        private System.Windows.Forms.Label lblTitleNhap;
        private System.Windows.Forms.Label lblSubtitleNhap;
        private System.Windows.Forms.Label lblBadgeXlsxNhap;
        private System.Windows.Forms.Panel pnlDashedBox;
        private System.Windows.Forms.Label lblDropTitle;
        private System.Windows.Forms.Label lblDropSub;
        private RoundedButton btnChonTepExcel;
        private System.Windows.Forms.FlowLayoutPanel flpNhapButtons;
        private RoundedButton btnTaiTepMau;
        private RoundedButton btnXemTruoc;
        private RoundedButton btnNhapNguyenLieu;
        private System.Windows.Forms.Label lblNoteNhap;
        private RoundedPanel pnlCardXuat;
        private System.Windows.Forms.Panel pnlHeaderCardXuat;
        private System.Windows.Forms.Label lblTitleXuat;
        private System.Windows.Forms.Label lblSubtitleXuat;
        private System.Windows.Forms.Label lblBadgeXlsxXuat;
        private RoundedPanel pnlXuatInfoBox;
        private System.Windows.Forms.Label lblAllIngTitle;
        private System.Windows.Forms.Label lblAllIngSub;
        private System.Windows.Forms.FlowLayoutPanel flpXuatButtons;
        private RoundedButton btnXuatExcel;
        private RoundedButton btnXemDuLieuXuat;
        private System.Windows.Forms.Label lblNoteXuat;
    }
}
