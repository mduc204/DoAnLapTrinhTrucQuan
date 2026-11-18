namespace DoAnLapTrinhTrucQuan.UserControls
{
    partial class ucKhuyenMai
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
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyleCell = new System.Windows.Forms.DataGridViewCellStyle();

            // Khởi tạo các thành phần giao diện
            pnlTopArea = new System.Windows.Forms.Panel();
            pnlTitleAndButtons = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            pnlTopActions = new System.Windows.Forms.FlowLayoutPanel();
            btnTaoVoucher = new DoAnLapTrinhTrucQuan.RoundedButton();
            btnXuatExcel = new DoAnLapTrinhTrucQuan.RoundedButton();
            btnLichSu = new DoAnLapTrinhTrucQuan.RoundedButton();
            pnlQuickStats = new System.Windows.Forms.Panel();
            lblQuickStats = new System.Windows.Forms.Label();

            splitMasterDetail = new System.Windows.Forms.SplitContainer();

            // Bảng danh sách & Bộ lọc
            pnlGridCard = new DoAnLapTrinhTrucQuan.RoundedPanel();
            pnlFilterBar = new System.Windows.Forms.Panel();
            txtTimKiem = new DoAnLapTrinhTrucQuan.RoundedTextBox();
            pnlTabButtons = new System.Windows.Forms.FlowLayoutPanel();
            btnTabTatCa = new System.Windows.Forms.Button();
            btnTabDangHieuLuc = new System.Windows.Forms.Button();
            btnTabSapToi = new System.Windows.Forms.Button();
            btnTabHetHan = new System.Windows.Forms.Button();
            pnlFilterScope = new System.Windows.Forms.Panel();
            cboLocPhamVi = new System.Windows.Forms.ComboBox();

            dgvVoucher = new System.Windows.Forms.DataGridView();
            colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMaVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUuDai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLuotDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhamVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colThaoTac = new System.Windows.Forms.DataGridViewTextBoxColumn();

            pnlPagination = new System.Windows.Forms.Panel();
            lblPagination = new System.Windows.Forms.Label();
            pnlPageNav = new System.Windows.Forms.FlowLayoutPanel();
            btnPrevPage = new System.Windows.Forms.Button();
            lblCurrentPage = new System.Windows.Forms.Label();
            btnNextPage = new System.Windows.Forms.Button();

            // Card Chi tiết Voucher
            pnlDetailCard = new DoAnLapTrinhTrucQuan.RoundedPanel();
            pnlDetailHeader = new System.Windows.Forms.Panel();
            lblDetailTitle = new System.Windows.Forms.Label();
            pnlKichHoat = new System.Windows.Forms.FlowLayoutPanel();
            lblKichHoat = new System.Windows.Forms.Label();
            toggleKichHoat = new DoAnLapTrinhTrucQuan.ToggleSwitch();

            pnlFormScroll = new System.Windows.Forms.Panel();
            tblDetailForm = new System.Windows.Forms.TableLayoutPanel();

            // Row 0: Mã & Tên
            pnlFieldMa = new System.Windows.Forms.Panel();
            lblMaTitle = new System.Windows.Forms.Label();
            txtMaVoucher = new System.Windows.Forms.TextBox();
            pnlFieldTen = new System.Windows.Forms.Panel();
            lblTenTitle = new System.Windows.Forms.Label();
            txtTenChuongTrinh = new System.Windows.Forms.TextBox();

            // Row 1: Cơ chế & Đơn tối thiểu/Phạm vi
            pnlFieldCoChe = new System.Windows.Forms.Panel();
            lblCoCheTitle = new System.Windows.Forms.Label();
            pnlRadioGroup = new System.Windows.Forms.FlowLayoutPanel();
            rbPhanTram = new System.Windows.Forms.RadioButton();
            rbTienMat = new System.Windows.Forms.RadioButton();
            pnlCoCheInputs = new System.Windows.Forms.Panel();
            pnlMucGiam = new System.Windows.Forms.Panel();
            lblMucGiam = new System.Windows.Forms.Label();
            numMucGiam = new System.Windows.Forms.NumericUpDown();
            lblMucGiamUnit = new System.Windows.Forms.Label();
            pnlGiamToiDa = new System.Windows.Forms.Panel();
            lblGiamToiDa = new System.Windows.Forms.Label();
            numGiamToiDa = new System.Windows.Forms.NumericUpDown();
            lblGiamToiDaUnit = new System.Windows.Forms.Label();

            pnlFieldDieuKien = new System.Windows.Forms.Panel();
            pnlDonToiThieu = new System.Windows.Forms.Panel();
            lblDonToiThieu = new System.Windows.Forms.Label();
            numDonToiThieu = new System.Windows.Forms.NumericUpDown();
            lblDonToiThieuUnit = new System.Windows.Forms.Label();
            pnlPhamVi = new System.Windows.Forms.Panel();
            lblPhamVi = new System.Windows.Forms.Label();
            cboPhamVi = new System.Windows.Forms.ComboBox();

            // Row 2: Thời gian & Lượt dùng
            pnlFieldThoiGian = new System.Windows.Forms.Panel();
            lblThoiGianTitle = new System.Windows.Forms.Label();
            pnlThoiGianInputs = new System.Windows.Forms.Panel();
            pnlNgayBD = new System.Windows.Forms.Panel();
            lblNgayBD = new System.Windows.Forms.Label();
            dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            pnlNgayKT = new System.Windows.Forms.Panel();
            lblNgayKT = new System.Windows.Forms.Label();
            dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();

            pnlFieldLuotDung = new System.Windows.Forms.Panel();
            pnlLuotDungInputs = new System.Windows.Forms.Panel();
            pnlTongLuot = new System.Windows.Forms.Panel();
            lblTongLuot = new System.Windows.Forms.Label();
            numTongLuot = new System.Windows.Forms.NumericUpDown();
            lblThongKeLuot = new System.Windows.Forms.Label();
            pnlGioiHanHD = new System.Windows.Forms.Panel();
            lblGioiHanHD = new System.Windows.Forms.Label();
            numGioiHanMoiHD = new System.Windows.Forms.NumericUpDown();
            lblGioiHanUnit = new System.Windows.Forms.Label();

            // Row 3: Ghi chú
            pnlFieldGhiChu = new System.Windows.Forms.Panel();
            lblGhiChuTitle = new System.Windows.Forms.Label();
            txtGhiChu = new System.Windows.Forms.TextBox();

            // Footer buttons
            pnlDetailFooter = new System.Windows.Forms.Panel();
            btnTamNgungMa = new DoAnLapTrinhTrucQuan.RoundedButton();
            pnlFooterActions = new System.Windows.Forms.FlowLayoutPanel();
            btnHuy = new DoAnLapTrinhTrucQuan.RoundedButton();
            btnLuu = new DoAnLapTrinhTrucQuan.RoundedButton();

            pnlTopArea.SuspendLayout();
            pnlTitleAndButtons.SuspendLayout();
            pnlTopActions.SuspendLayout();
            pnlQuickStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMasterDetail).BeginInit();
            splitMasterDetail.Panel1.SuspendLayout();
            splitMasterDetail.Panel2.SuspendLayout();
            splitMasterDetail.SuspendLayout();
            pnlGridCard.SuspendLayout();
            pnlFilterBar.SuspendLayout();
            pnlTabButtons.SuspendLayout();
            pnlFilterScope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            pnlPagination.SuspendLayout();
            pnlPageNav.SuspendLayout();
            pnlDetailCard.SuspendLayout();
            pnlDetailHeader.SuspendLayout();
            pnlKichHoat.SuspendLayout();
            pnlFormScroll.SuspendLayout();
            tblDetailForm.SuspendLayout();
            pnlFieldMa.SuspendLayout();
            pnlFieldTen.SuspendLayout();
            pnlFieldCoChe.SuspendLayout();
            pnlRadioGroup.SuspendLayout();
            pnlCoCheInputs.SuspendLayout();
            pnlMucGiam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMucGiam).BeginInit();
            pnlGiamToiDa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamToiDa).BeginInit();
            pnlFieldDieuKien.SuspendLayout();
            pnlDonToiThieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonToiThieu).BeginInit();
            pnlPhamVi.SuspendLayout();
            pnlFieldThoiGian.SuspendLayout();
            pnlThoiGianInputs.SuspendLayout();
            pnlNgayBD.SuspendLayout();
            pnlNgayKT.SuspendLayout();
            pnlFieldLuotDung.SuspendLayout();
            pnlLuotDungInputs.SuspendLayout();
            pnlTongLuot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTongLuot).BeginInit();
            pnlGioiHanHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGioiHanMoiHD).BeginInit();
            pnlFieldGhiChu.SuspendLayout();
            pnlDetailFooter.SuspendLayout();
            pnlFooterActions.SuspendLayout();
            SuspendLayout();

            // =========================================================================
            // 1. pnlTopArea (Header & Quick Stats)
            // =========================================================================
            pnlTopArea.Controls.Add(pnlQuickStats);
            pnlTopArea.Controls.Add(pnlTitleAndButtons);
            pnlTopArea.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopArea.Height = 84;
            pnlTopArea.Padding = new System.Windows.Forms.Padding(16, 10, 16, 4);

            pnlTitleAndButtons.Controls.Add(lblSubtitle);
            pnlTitleAndButtons.Controls.Add(lblTitle);
            pnlTitleAndButtons.Controls.Add(pnlTopActions);
            pnlTitleAndButtons.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitleAndButtons.Height = 44;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Text = "Khuyến mãi & Voucher";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblSubtitle.Location = new System.Drawing.Point(2, 26);
            lblSubtitle.Text = "Quản lý mã giảm giá và thời gian áp dụng.";

            pnlTopActions.Controls.Add(btnTaoVoucher);
            pnlTopActions.Controls.Add(btnXuatExcel);
            pnlTopActions.Controls.Add(btnLichSu);
            pnlTopActions.Dock = System.Windows.Forms.DockStyle.Right;
            pnlTopActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            pnlTopActions.Width = 470;
            pnlTopActions.Height = 40;

            btnTaoVoucher.BorderRadius = 8;
            btnTaoVoucher.NormalBackColor = System.Drawing.Color.FromArgb(111, 78, 55);
            btnTaoVoucher.HoverBackColor = System.Drawing.Color.FromArgb(91, 63, 43);
            btnTaoVoucher.ForeColor = System.Drawing.Color.White;
            btnTaoVoucher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnTaoVoucher.Size = new System.Drawing.Size(155, 36);
            btnTaoVoucher.Text = "＋ Tạo voucher mới";

            btnXuatExcel.BorderRadius = 8;
            btnXuatExcel.IsOutlined = true;
            btnXuatExcel.Size = new System.Drawing.Size(125, 36);
            btnXuatExcel.Text = "📊 Xuất Excel";

            btnLichSu.BorderRadius = 8;
            btnLichSu.IsOutlined = true;
            btnLichSu.Size = new System.Drawing.Size(155, 36);
            btnLichSu.Text = "🕒 Lịch sử áp dụng";

            pnlQuickStats.Controls.Add(lblQuickStats);
            pnlQuickStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlQuickStats.Height = 24;

            lblQuickStats.AutoSize = true;
            lblQuickStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblQuickStats.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblQuickStats.Location = new System.Drawing.Point(2, 4);
            lblQuickStats.Text = "12 voucher • 5 đang hiệu lực • 3 sắp diễn ra • 4 hết hạn / tạm dừng   |   Đã giảm tháng này: 4.820.000 đ - 215 hóa đơn";

            // =========================================================================
            // 2. splitMasterDetail (Master: Danh sách, Detail: Form nhập liệu)
            // =========================================================================
            splitMasterDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            splitMasterDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            splitMasterDetail.SplitterDistance = 330;
            splitMasterDetail.SplitterWidth = 8;
            splitMasterDetail.Padding = new System.Windows.Forms.Padding(16, 4, 16, 12);

            // =========================================================================
            // 3. Panel1: pnlGridCard (Bảng danh sách voucher)
            // =========================================================================
            splitMasterDetail.Panel1.Controls.Add(pnlGridCard);

            pnlGridCard.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            pnlGridCard.BorderRadius = 12;
            pnlGridCard.BorderWidth = 1;
            pnlGridCard.FillColor = System.Drawing.Color.White;
            pnlGridCard.Controls.Add(dgvVoucher);
            pnlGridCard.Controls.Add(pnlPagination);
            pnlGridCard.Controls.Add(pnlFilterBar);
            pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlGridCard.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);

            // 3.1 Thanh tìm kiếm & Tabs lọc
            pnlFilterBar.Controls.Add(txtTimKiem);
            pnlFilterBar.Controls.Add(pnlTabButtons);
            pnlFilterBar.Controls.Add(pnlFilterScope);
            pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFilterBar.Height = 44;

            txtTimKiem.BorderRadius = 8;
            txtTimKiem.PlaceholderText = "🔍 Tìm mã hoặc tên voucher...";
            txtTimKiem.Size = new System.Drawing.Size(260, 36);
            txtTimKiem.Location = new System.Drawing.Point(0, 2);

            pnlTabButtons.Controls.Add(btnTabTatCa);
            pnlTabButtons.Controls.Add(btnTabDangHieuLuc);
            pnlTabButtons.Controls.Add(btnTabSapToi);
            pnlTabButtons.Controls.Add(btnTabHetHan);
            pnlTabButtons.Location = new System.Drawing.Point(270, 2);
            pnlTabButtons.Size = new System.Drawing.Size(460, 38);

            btnTabTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabTatCa.FlatAppearance.BorderSize = 0;
            btnTabTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnTabTatCa.BackColor = System.Drawing.Color.FromArgb(44, 30, 20);
            btnTabTatCa.ForeColor = System.Drawing.Color.White;
            btnTabTatCa.Size = new System.Drawing.Size(95, 34);
            btnTabTatCa.Text = "Tất cả (12)";
            btnTabTatCa.Cursor = System.Windows.Forms.Cursors.Hand;

            btnTabDangHieuLuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabDangHieuLuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            btnTabDangHieuLuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnTabDangHieuLuc.BackColor = System.Drawing.Color.White;
            btnTabDangHieuLuc.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            btnTabDangHieuLuc.Size = new System.Drawing.Size(125, 34);
            btnTabDangHieuLuc.Text = "Đang hiệu lực (5)";
            btnTabDangHieuLuc.Cursor = System.Windows.Forms.Cursors.Hand;

            btnTabSapToi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabSapToi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            btnTabSapToi.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnTabSapToi.BackColor = System.Drawing.Color.White;
            btnTabSapToi.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            btnTabSapToi.Size = new System.Drawing.Size(95, 34);
            btnTabSapToi.Text = "Sắp tới (3)";
            btnTabSapToi.Cursor = System.Windows.Forms.Cursors.Hand;

            btnTabHetHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabHetHan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            btnTabHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnTabHetHan.BackColor = System.Drawing.Color.White;
            btnTabHetHan.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            btnTabHetHan.Size = new System.Drawing.Size(95, 34);
            btnTabHetHan.Text = "Hết hạn (4)";
            btnTabHetHan.Cursor = System.Windows.Forms.Cursors.Hand;

            pnlFilterScope.Controls.Add(cboLocPhamVi);
            pnlFilterScope.Dock = System.Windows.Forms.DockStyle.Right;
            pnlFilterScope.Width = 150;

            cboLocPhamVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLocPhamVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboLocPhamVi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboLocPhamVi.Items.AddRange(new object[] { "Phạm vi: Tất cả", "Phạm vi: Tại quán", "Phạm vi: Mang về" });
            cboLocPhamVi.SelectedIndex = 0;
            cboLocPhamVi.Size = new System.Drawing.Size(150, 28);
            cboLocPhamVi.Location = new System.Drawing.Point(0, 6);

            // 3.2 DataGridView Voucher
            dgvVoucher.AllowUserToAddRows = false;
            dgvVoucher.AllowUserToDeleteRows = false;
            dgvVoucher.AllowUserToResizeRows = false;
            dgvVoucher.BackgroundColor = System.Drawing.Color.White;
            dgvVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvVoucher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dgvVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dgvCellStyleHeader.BackColor = System.Drawing.Color.FromArgb(243, 234, 224);
            dgvCellStyleHeader.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dgvCellStyleHeader.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            dgvCellStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvCellStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvVoucher.ColumnHeadersDefaultCellStyle = dgvCellStyleHeader;
            dgvVoucher.ColumnHeadersHeight = 38;
            dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvCellStyleCell.BackColor = System.Drawing.Color.White;
            dgvCellStyleCell.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvCellStyleCell.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            dgvCellStyleCell.SelectionBackColor = System.Drawing.Color.FromArgb(247, 239, 231);
            dgvCellStyleCell.SelectionForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            dgvVoucher.DefaultCellStyle = dgvCellStyleCell;

            dgvVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVoucher.EnableHeadersVisualStyles = false;
            dgvVoucher.MultiSelect = false;
            dgvVoucher.RowHeadersVisible = false;
            dgvVoucher.RowTemplate.Height = 50;
            dgvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            colSTT.HeaderText = "#";
            colSTT.Name = "colSTT";
            colSTT.ReadOnly = true;
            colSTT.Width = 36;
            colSTT.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            colMaVoucher.HeaderText = "MÃ VOUCHER";
            colMaVoucher.Name = "colMaVoucher";
            colMaVoucher.ReadOnly = true;
            colMaVoucher.Width = 140;

            colTenChuongTrinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colTenChuongTrinh.HeaderText = "TÊN CHƯƠNG TRÌNH";
            colTenChuongTrinh.Name = "colTenChuongTrinh";
            colTenChuongTrinh.ReadOnly = true;
            colTenChuongTrinh.FillWeight = 130F;

            colUuDai.HeaderText = "ƯU ĐÃI / ĐIỀU KIỆN";
            colUuDai.Name = "colUuDai";
            colUuDai.ReadOnly = true;
            colUuDai.Width = 175;

            colLuotDung.HeaderText = "LƯỢT DÙNG";
            colLuotDung.Name = "colLuotDung";
            colLuotDung.ReadOnly = true;
            colLuotDung.Width = 150;

            colPhamVi.HeaderText = "PHẠM VI";
            colPhamVi.Name = "colPhamVi";
            colPhamVi.ReadOnly = true;
            colPhamVi.Width = 95;
            colPhamVi.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 130;
            colTrangThai.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            colThaoTac.HeaderText = "THAO TÁC";
            colThaoTac.Name = "colThaoTac";
            colThaoTac.ReadOnly = true;
            colThaoTac.Width = 85;
            colThaoTac.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            dgvVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colSTT, colMaVoucher, colTenChuongTrinh, colUuDai, colLuotDung, colPhamVi, colTrangThai, colThaoTac
            });

            // 3.3 Thanh phân trang
            pnlPagination.Controls.Add(lblPagination);
            pnlPagination.Controls.Add(pnlPageNav);
            pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlPagination.Height = 36;
            pnlPagination.Padding = new System.Windows.Forms.Padding(4, 6, 4, 0);

            lblPagination.AutoSize = true;
            lblPagination.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPagination.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblPagination.Location = new System.Drawing.Point(4, 10);
            lblPagination.Text = "Hiển thị 6 trên 12 mã voucher";

            pnlPageNav.Controls.Add(btnPrevPage);
            pnlPageNav.Controls.Add(lblCurrentPage);
            pnlPageNav.Controls.Add(btnNextPage);
            pnlPageNav.Dock = System.Windows.Forms.DockStyle.Right;
            pnlPageNav.Width = 120;

            btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            btnPrevPage.Size = new System.Drawing.Size(30, 26);
            btnPrevPage.Text = "〈";
            btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;

            lblCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCurrentPage.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            lblCurrentPage.Size = new System.Drawing.Size(44, 26);
            lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCurrentPage.Text = "1 / 2";

            btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            btnNextPage.Size = new System.Drawing.Size(30, 26);
            btnNextPage.Text = "〉";
            btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;

            // =========================================================================
            // 4. Panel2: pnlDetailCard (Form Chi tiết Voucher M04)
            // =========================================================================
            splitMasterDetail.Panel2.Controls.Add(pnlDetailCard);

            pnlDetailCard.BorderColor = System.Drawing.Color.FromArgb(232, 223, 213);
            pnlDetailCard.BorderRadius = 12;
            pnlDetailCard.BorderWidth = 1;
            pnlDetailCard.FillColor = System.Drawing.Color.White;
            pnlDetailCard.Controls.Add(pnlFormScroll);
            pnlDetailCard.Controls.Add(pnlDetailFooter);
            pnlDetailCard.Controls.Add(pnlDetailHeader);
            pnlDetailCard.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDetailCard.Padding = new System.Windows.Forms.Padding(16, 12, 16, 10);

            // 4.1 Header Form Chi tiết
            pnlDetailHeader.Controls.Add(lblDetailTitle);
            pnlDetailHeader.Controls.Add(pnlKichHoat);
            pnlDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlDetailHeader.Height = 36;

            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            lblDetailTitle.Location = new System.Drawing.Point(0, 4);
            lblDetailTitle.Text = "🏷 Chi tiết Voucher: MOC10";

            pnlKichHoat.Controls.Add(lblKichHoat);
            pnlKichHoat.Controls.Add(toggleKichHoat);
            pnlKichHoat.Dock = System.Windows.Forms.DockStyle.Right;
            pnlKichHoat.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            pnlKichHoat.Width = 160;

            lblKichHoat.AutoSize = true;
            lblKichHoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblKichHoat.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblKichHoat.Margin = new System.Windows.Forms.Padding(0, 5, 8, 0);
            lblKichHoat.Text = "KÍCH HOẠT";

            toggleKichHoat.Checked = true;
            toggleKichHoat.Size = new System.Drawing.Size(46, 24);

            // 4.2 Body Form Chi tiết (TableLayoutPanel có AutoScroll)
            pnlFormScroll.AutoScroll = true;
            pnlFormScroll.Controls.Add(tblDetailForm);
            pnlFormScroll.Dock = System.Windows.Forms.DockStyle.Fill;

            tblDetailForm.ColumnCount = 2;
            tblDetailForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblDetailForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblDetailForm.RowCount = 4;
            tblDetailForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tblDetailForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            tblDetailForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            tblDetailForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tblDetailForm.Dock = System.Windows.Forms.DockStyle.Top;
            tblDetailForm.Height = 312;

            // --- Row 0, Col 0: Mã Voucher ---
            tblDetailForm.Controls.Add(pnlFieldMa, 0, 0);
            pnlFieldMa.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldMa.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            pnlFieldMa.Controls.Add(txtMaVoucher);
            pnlFieldMa.Controls.Add(lblMaTitle);

            lblMaTitle.AutoSize = true;
            lblMaTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblMaTitle.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblMaTitle.Location = new System.Drawing.Point(0, 2);
            lblMaTitle.Text = "MÃ VOUCHER *";

            txtMaVoucher.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            txtMaVoucher.Location = new System.Drawing.Point(0, 22);
            txtMaVoucher.Size = new System.Drawing.Size(320, 29);
            txtMaVoucher.Text = "MOC10";

            // --- Row 0, Col 1: Tên Chương Trình ---
            tblDetailForm.Controls.Add(pnlFieldTen, 1, 0);
            pnlFieldTen.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldTen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            pnlFieldTen.Controls.Add(txtTenChuongTrinh);
            pnlFieldTen.Controls.Add(lblTenTitle);

            lblTenTitle.AutoSize = true;
            lblTenTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTenTitle.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblTenTitle.Location = new System.Drawing.Point(10, 2);
            lblTenTitle.Text = "TÊN CHƯƠNG TRÌNH *";

            txtTenChuongTrinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtTenChuongTrinh.Location = new System.Drawing.Point(10, 22);
            txtTenChuongTrinh.Size = new System.Drawing.Size(420, 29);
            txtTenChuongTrinh.Text = "Ưu đãi giờ vàng Mộc Café - Giảm 10%";

            // --- Row 1, Col 0: Cơ Chế Giảm Giá ---
            tblDetailForm.Controls.Add(pnlFieldCoChe, 0, 1);
            pnlFieldCoChe.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldCoChe.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            pnlFieldCoChe.Controls.Add(pnlCoCheInputs);
            pnlFieldCoChe.Controls.Add(pnlRadioGroup);
            pnlFieldCoChe.Controls.Add(lblCoCheTitle);

            lblCoCheTitle.AutoSize = true;
            lblCoCheTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblCoCheTitle.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblCoCheTitle.Location = new System.Drawing.Point(0, 0);
            lblCoCheTitle.Text = "CƠ CHẾ GIẢM GIÁ";

            pnlRadioGroup.Controls.Add(rbPhanTram);
            pnlRadioGroup.Controls.Add(rbTienMat);
            pnlRadioGroup.Location = new System.Drawing.Point(0, 18);
            pnlRadioGroup.Size = new System.Drawing.Size(380, 24);

            rbPhanTram.AutoSize = true;
            rbPhanTram.Checked = true;
            rbPhanTram.Font = new System.Drawing.Font("Segoe UI", 9F);
            rbPhanTram.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            rbPhanTram.Location = new System.Drawing.Point(0, 0);
            rbPhanTram.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            rbPhanTram.Text = "Theo phần trăm (%)";

            rbTienMat.AutoSize = true;
            rbTienMat.Font = new System.Drawing.Font("Segoe UI", 9F);
            rbTienMat.ForeColor = System.Drawing.Color.FromArgb(44, 30, 20);
            rbTienMat.Location = new System.Drawing.Point(165, 0);
            rbTienMat.Text = "Số tiền cố định (VNĐ)";

            pnlCoCheInputs.Controls.Add(pnlMucGiam);
            pnlCoCheInputs.Controls.Add(pnlGiamToiDa);
            pnlCoCheInputs.Location = new System.Drawing.Point(0, 44);
            pnlCoCheInputs.Size = new System.Drawing.Size(420, 44);

            pnlMucGiam.Controls.Add(lblMucGiam);
            pnlMucGiam.Controls.Add(numMucGiam);
            pnlMucGiam.Controls.Add(lblMucGiamUnit);
            pnlMucGiam.Location = new System.Drawing.Point(0, 0);
            pnlMucGiam.Size = new System.Drawing.Size(180, 44);

            lblMucGiam.AutoSize = true;
            lblMucGiam.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblMucGiam.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblMucGiam.Location = new System.Drawing.Point(0, 0);
            lblMucGiam.Text = "Mức giảm";

            numMucGiam.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            numMucGiam.Location = new System.Drawing.Point(0, 18);
            numMucGiam.Maximum = new decimal(100);
            numMucGiam.Minimum = new decimal(0);
            numMucGiam.Size = new System.Drawing.Size(120, 26);
            numMucGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numMucGiam.Value = new decimal(10);

            lblMucGiamUnit.AutoSize = true;
            lblMucGiamUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblMucGiamUnit.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblMucGiamUnit.Location = new System.Drawing.Point(125, 20);
            lblMucGiamUnit.Text = "%";

            pnlGiamToiDa.Controls.Add(lblGiamToiDa);
            pnlGiamToiDa.Controls.Add(numGiamToiDa);
            pnlGiamToiDa.Controls.Add(lblGiamToiDaUnit);
            pnlGiamToiDa.Location = new System.Drawing.Point(190, 0);
            pnlGiamToiDa.Size = new System.Drawing.Size(220, 44);

            lblGiamToiDa.AutoSize = true;
            lblGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblGiamToiDa.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblGiamToiDa.Location = new System.Drawing.Point(0, 0);
            lblGiamToiDa.Text = "Giảm tối đa (Trần)";

            numGiamToiDa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            numGiamToiDa.Increment = new decimal(5000);
            numGiamToiDa.Location = new System.Drawing.Point(0, 18);
            numGiamToiDa.Maximum = new decimal(1000000);
            numGiamToiDa.Minimum = new decimal(0);
            numGiamToiDa.Size = new System.Drawing.Size(140, 26);
            numGiamToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numGiamToiDa.ThousandsSeparator = true;
            numGiamToiDa.Value = new decimal(30000);

            lblGiamToiDaUnit.AutoSize = true;
            lblGiamToiDaUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblGiamToiDaUnit.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblGiamToiDaUnit.Location = new System.Drawing.Point(145, 20);
            lblGiamToiDaUnit.Text = "đ";

            // --- Row 1, Col 1: Đơn tối thiểu & Phạm vi áp dụng ---
            tblDetailForm.Controls.Add(pnlFieldDieuKien, 1, 1);
            pnlFieldDieuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldDieuKien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            pnlFieldDieuKien.Controls.Add(pnlDonToiThieu);
            pnlFieldDieuKien.Controls.Add(pnlPhamVi);

            pnlDonToiThieu.Controls.Add(lblDonToiThieu);
            pnlDonToiThieu.Controls.Add(numDonToiThieu);
            pnlDonToiThieu.Controls.Add(lblDonToiThieuUnit);
            pnlDonToiThieu.Location = new System.Drawing.Point(10, 14);
            pnlDonToiThieu.Size = new System.Drawing.Size(190, 68);

            lblDonToiThieu.AutoSize = true;
            lblDonToiThieu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblDonToiThieu.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblDonToiThieu.Location = new System.Drawing.Point(0, 0);
            lblDonToiThieu.Text = "ĐƠN TỐI THIỂU ÁP DỤNG *";

            numDonToiThieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            numDonToiThieu.Increment = new decimal(10000);
            numDonToiThieu.Location = new System.Drawing.Point(0, 24);
            numDonToiThieu.Maximum = new decimal(10000000);
            numDonToiThieu.Minimum = new decimal(0);
            numDonToiThieu.Size = new System.Drawing.Size(140, 26);
            numDonToiThieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numDonToiThieu.ThousandsSeparator = true;
            numDonToiThieu.Value = new decimal(100000);

            lblDonToiThieuUnit.AutoSize = true;
            lblDonToiThieuUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblDonToiThieuUnit.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblDonToiThieuUnit.Location = new System.Drawing.Point(145, 26);
            lblDonToiThieuUnit.Text = "đ";

            pnlPhamVi.Controls.Add(lblPhamVi);
            pnlPhamVi.Controls.Add(cboPhamVi);
            pnlPhamVi.Location = new System.Drawing.Point(210, 14);
            pnlPhamVi.Size = new System.Drawing.Size(220, 68);

            lblPhamVi.AutoSize = true;
            lblPhamVi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblPhamVi.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblPhamVi.Location = new System.Drawing.Point(0, 0);
            lblPhamVi.Text = "PHẠM VI ÁP DỤNG";

            cboPhamVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboPhamVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboPhamVi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboPhamVi.Items.AddRange(new object[] {
                "Tất cả hình thức (Tại quán & Mang về)",
                "Tại quán",
                "Mang về"
            });
            cboPhamVi.SelectedIndex = 0;
            cboPhamVi.Location = new System.Drawing.Point(0, 24);
            cboPhamVi.Size = new System.Drawing.Size(220, 28);

            // --- Row 2, Col 0: Thời Gian Hiệu Lực ---
            tblDetailForm.Controls.Add(pnlFieldThoiGian, 0, 2);
            pnlFieldThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldThoiGian.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            pnlFieldThoiGian.Controls.Add(pnlThoiGianInputs);
            pnlFieldThoiGian.Controls.Add(lblThoiGianTitle);

            lblThoiGianTitle.AutoSize = true;
            lblThoiGianTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblThoiGianTitle.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblThoiGianTitle.Location = new System.Drawing.Point(0, 2);
            lblThoiGianTitle.Text = "THỜI GIAN HIỆU LỰC";

            pnlThoiGianInputs.Controls.Add(pnlNgayBD);
            pnlThoiGianInputs.Controls.Add(pnlNgayKT);
            pnlThoiGianInputs.Location = new System.Drawing.Point(0, 20);
            pnlThoiGianInputs.Size = new System.Drawing.Size(420, 52);

            pnlNgayBD.Controls.Add(lblNgayBD);
            pnlNgayBD.Controls.Add(dtpNgayBatDau);
            pnlNgayBD.Location = new System.Drawing.Point(0, 0);
            pnlNgayBD.Size = new System.Drawing.Size(185, 50);

            lblNgayBD.AutoSize = true;
            lblNgayBD.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNgayBD.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblNgayBD.Location = new System.Drawing.Point(0, 0);
            lblNgayBD.Text = "Bắt đầu từ";

            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpNgayBatDau.Location = new System.Drawing.Point(0, 18);
            dtpNgayBatDau.Size = new System.Drawing.Size(175, 27);

            pnlNgayKT.Controls.Add(lblNgayKT);
            pnlNgayKT.Controls.Add(dtpNgayKetThuc);
            pnlNgayKT.Location = new System.Drawing.Point(190, 0);
            pnlNgayKT.Size = new System.Drawing.Size(185, 50);

            lblNgayKT.AutoSize = true;
            lblNgayKT.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNgayKT.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblNgayKT.Location = new System.Drawing.Point(0, 0);
            lblNgayKT.Text = "Kết thúc lúc";

            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpNgayKetThuc.Location = new System.Drawing.Point(0, 18);
            dtpNgayKetThuc.Size = new System.Drawing.Size(175, 27);

            // --- Row 2, Col 1: Lượt Phát Hành & Giới Hạn Hóa Đơn ---
            tblDetailForm.Controls.Add(pnlFieldLuotDung, 1, 2);
            pnlFieldLuotDung.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldLuotDung.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            pnlFieldLuotDung.Controls.Add(pnlLuotDungInputs);

            pnlLuotDungInputs.Controls.Add(pnlTongLuot);
            pnlLuotDungInputs.Controls.Add(pnlGioiHanHD);
            pnlLuotDungInputs.Location = new System.Drawing.Point(10, 2);
            pnlLuotDungInputs.Size = new System.Drawing.Size(420, 68);

            pnlTongLuot.Controls.Add(lblTongLuot);
            pnlTongLuot.Controls.Add(numTongLuot);
            pnlTongLuot.Controls.Add(lblThongKeLuot);
            pnlTongLuot.Location = new System.Drawing.Point(0, 0);
            pnlTongLuot.Size = new System.Drawing.Size(190, 68);

            lblTongLuot.AutoSize = true;
            lblTongLuot.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTongLuot.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblTongLuot.Location = new System.Drawing.Point(0, 0);
            lblTongLuot.Text = "TỔNG SỐ LƯỢT PHÁT HÀNH";

            numTongLuot.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            numTongLuot.Location = new System.Drawing.Point(0, 18);
            numTongLuot.Maximum = new decimal(100000);
            numTongLuot.Minimum = new decimal(0);
            numTongLuot.Size = new System.Drawing.Size(150, 26);
            numTongLuot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numTongLuot.ThousandsSeparator = true;
            numTongLuot.Value = new decimal(200);

            lblThongKeLuot.AutoSize = true;
            lblThongKeLuot.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblThongKeLuot.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblThongKeLuot.Location = new System.Drawing.Point(0, 46);
            lblThongKeLuot.Text = "Đã dùng: 68       Còn lại: 132";

            pnlGioiHanHD.Controls.Add(lblGioiHanHD);
            pnlGioiHanHD.Controls.Add(numGioiHanMoiHD);
            pnlGioiHanHD.Controls.Add(lblGioiHanUnit);
            pnlGioiHanHD.Location = new System.Drawing.Point(200, 0);
            pnlGioiHanHD.Size = new System.Drawing.Size(210, 68);

            lblGioiHanHD.AutoSize = true;
            lblGioiHanHD.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblGioiHanHD.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblGioiHanHD.Location = new System.Drawing.Point(0, 0);
            lblGioiHanHD.Text = "GIỚI HẠN MỖI HÓA ĐƠN";

            numGioiHanMoiHD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            numGioiHanMoiHD.Location = new System.Drawing.Point(0, 18);
            numGioiHanMoiHD.Maximum = new decimal(100);
            numGioiHanMoiHD.Minimum = new decimal(1);
            numGioiHanMoiHD.Size = new System.Drawing.Size(80, 26);
            numGioiHanMoiHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numGioiHanMoiHD.Value = new decimal(1);

            lblGioiHanUnit.AutoSize = true;
            lblGioiHanUnit.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblGioiHanUnit.ForeColor = System.Drawing.Color.FromArgb(126, 110, 101);
            lblGioiHanUnit.Location = new System.Drawing.Point(86, 22);
            lblGioiHanUnit.Text = "1 lượt / hóa đơn";

            // --- Row 3: Ghi Chú / Điều Kiện Áp Dụng (Chiếm 2 cột) ---
            tblDetailForm.SetColumnSpan(pnlFieldGhiChu, 2);
            tblDetailForm.Controls.Add(pnlFieldGhiChu, 0, 3);
            pnlFieldGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFieldGhiChu.Controls.Add(txtGhiChu);
            pnlFieldGhiChu.Controls.Add(lblGhiChuTitle);

            lblGhiChuTitle.AutoSize = true;
            lblGhiChuTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblGhiChuTitle.ForeColor = System.Drawing.Color.FromArgb(93, 74, 61);
            lblGhiChuTitle.Location = new System.Drawing.Point(0, 2);
            lblGhiChuTitle.Text = "Ghi chú / Điều kiện áp dụng";

            txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtGhiChu.Location = new System.Drawing.Point(0, 22);
            txtGhiChu.Multiline = true;
            txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtGhiChu.Size = new System.Drawing.Size(860, 48);
            txtGhiChu.Text = "Áp dụng cho mọi hóa đơn ăn uống đạt từ 100.000đ. Không áp dụng đồng thời với các combo giảm giá khác.";

            // 4.3 Footer Buttons
            pnlDetailFooter.Controls.Add(btnTamNgungMa);
            pnlDetailFooter.Controls.Add(pnlFooterActions);
            pnlDetailFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlDetailFooter.Height = 44;
            pnlDetailFooter.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);

            btnTamNgungMa.BorderRadius = 8;
            btnTamNgungMa.IsOutlined = true;
            btnTamNgungMa.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            btnTamNgungMa.Location = new System.Drawing.Point(0, 6);
            btnTamNgungMa.Size = new System.Drawing.Size(160, 36);
            btnTamNgungMa.Text = "🚫 Tạm ngưng mã này";

            pnlFooterActions.Controls.Add(btnHuy);
            pnlFooterActions.Controls.Add(btnLuu);
            pnlFooterActions.Dock = System.Windows.Forms.DockStyle.Right;
            pnlFooterActions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            pnlFooterActions.Width = 250;
            pnlFooterActions.Height = 40;

            btnHuy.BorderRadius = 8;
            btnHuy.IsOutlined = true;
            btnHuy.Size = new System.Drawing.Size(95, 36);
            btnHuy.Text = "Hủy bỏ";

            btnLuu.BorderRadius = 8;
            btnLuu.NormalBackColor = System.Drawing.Color.FromArgb(111, 78, 55);
            btnLuu.HoverBackColor = System.Drawing.Color.FromArgb(91, 63, 43);
            btnLuu.ForeColor = System.Drawing.Color.White;
            btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnLuu.Size = new System.Drawing.Size(140, 36);
            btnLuu.Text = "💾 Lưu thay đổi";

            // =========================================================================
            // ucKhuyenMai
            // =========================================================================
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 246, 240);
            Controls.Add(splitMasterDetail);
            Controls.Add(pnlTopArea);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            Name = "ucKhuyenMai";
            Size = new System.Drawing.Size(1050, 750);

            pnlTopArea.ResumeLayout(false);
            pnlTitleAndButtons.ResumeLayout(false);
            pnlTitleAndButtons.PerformLayout();
            pnlTopActions.ResumeLayout(false);
            pnlQuickStats.ResumeLayout(false);
            pnlQuickStats.PerformLayout();
            splitMasterDetail.Panel1.ResumeLayout(false);
            splitMasterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMasterDetail).EndInit();
            splitMasterDetail.ResumeLayout(false);
            pnlGridCard.ResumeLayout(false);
            pnlFilterBar.ResumeLayout(false);
            pnlTabButtons.ResumeLayout(false);
            pnlFilterScope.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            pnlPagination.ResumeLayout(false);
            pnlPagination.PerformLayout();
            pnlPageNav.ResumeLayout(false);
            pnlDetailCard.ResumeLayout(false);
            pnlDetailHeader.ResumeLayout(false);
            pnlDetailHeader.PerformLayout();
            pnlKichHoat.ResumeLayout(false);
            pnlKichHoat.PerformLayout();
            pnlFormScroll.ResumeLayout(false);
            tblDetailForm.ResumeLayout(false);
            pnlFieldMa.ResumeLayout(false);
            pnlFieldMa.PerformLayout();
            pnlFieldTen.ResumeLayout(false);
            pnlFieldTen.PerformLayout();
            pnlFieldCoChe.ResumeLayout(false);
            pnlFieldCoChe.PerformLayout();
            pnlRadioGroup.ResumeLayout(false);
            pnlRadioGroup.PerformLayout();
            pnlCoCheInputs.ResumeLayout(false);
            pnlMucGiam.ResumeLayout(false);
            pnlMucGiam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMucGiam).EndInit();
            pnlGiamToiDa.ResumeLayout(false);
            pnlGiamToiDa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamToiDa).EndInit();
            pnlFieldDieuKien.ResumeLayout(false);
            pnlDonToiThieu.ResumeLayout(false);
            pnlDonToiThieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonToiThieu).EndInit();
            pnlPhamVi.ResumeLayout(false);
            pnlPhamVi.PerformLayout();
            pnlFieldThoiGian.ResumeLayout(false);
            pnlFieldThoiGian.PerformLayout();
            pnlThoiGianInputs.ResumeLayout(false);
            pnlNgayBD.ResumeLayout(false);
            pnlNgayBD.PerformLayout();
            pnlNgayKT.ResumeLayout(false);
            pnlNgayKT.PerformLayout();
            pnlFieldLuotDung.ResumeLayout(false);
            pnlLuotDungInputs.ResumeLayout(false);
            pnlTongLuot.ResumeLayout(false);
            pnlTongLuot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTongLuot).EndInit();
            pnlGioiHanHD.ResumeLayout(false);
            pnlGioiHanHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGioiHanMoiHD).EndInit();
            pnlFieldGhiChu.ResumeLayout(false);
            pnlFieldGhiChu.PerformLayout();
            pnlDetailFooter.ResumeLayout(false);
            pnlFooterActions.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        // Khai báo các Controls
        private System.Windows.Forms.Panel pnlTopArea;
        private System.Windows.Forms.Panel pnlTitleAndButtons;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel pnlTopActions;
        private DoAnLapTrinhTrucQuan.RoundedButton btnTaoVoucher;
        private DoAnLapTrinhTrucQuan.RoundedButton btnXuatExcel;
        private DoAnLapTrinhTrucQuan.RoundedButton btnLichSu;
        private System.Windows.Forms.Panel pnlQuickStats;
        private System.Windows.Forms.Label lblQuickStats;

        private System.Windows.Forms.SplitContainer splitMasterDetail;

        private DoAnLapTrinhTrucQuan.RoundedPanel pnlGridCard;
        private System.Windows.Forms.Panel pnlFilterBar;
        private DoAnLapTrinhTrucQuan.RoundedTextBox txtTimKiem;
        private System.Windows.Forms.FlowLayoutPanel pnlTabButtons;
        private System.Windows.Forms.Button btnTabTatCa;
        private System.Windows.Forms.Button btnTabDangHieuLuc;
        private System.Windows.Forms.Button btnTabSapToi;
        private System.Windows.Forms.Button btnTabHetHan;
        private System.Windows.Forms.Panel pnlFilterScope;
        private System.Windows.Forms.ComboBox cboLocPhamVi;

        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUuDai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuotDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhamVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThaoTac;

        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblPagination;
        private System.Windows.Forms.FlowLayoutPanel pnlPageNav;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Button btnNextPage;

        private DoAnLapTrinhTrucQuan.RoundedPanel pnlDetailCard;
        private System.Windows.Forms.Panel pnlDetailHeader;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlKichHoat;
        private System.Windows.Forms.Label lblKichHoat;
        private DoAnLapTrinhTrucQuan.ToggleSwitch toggleKichHoat;

        private System.Windows.Forms.Panel pnlFormScroll;
        private System.Windows.Forms.TableLayoutPanel tblDetailForm;

        private System.Windows.Forms.Panel pnlFieldMa;
        private System.Windows.Forms.Label lblMaTitle;
        private System.Windows.Forms.TextBox txtMaVoucher;

        private System.Windows.Forms.Panel pnlFieldTen;
        private System.Windows.Forms.Label lblTenTitle;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;

        private System.Windows.Forms.Panel pnlFieldCoChe;
        private System.Windows.Forms.Label lblCoCheTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlRadioGroup;
        private System.Windows.Forms.RadioButton rbPhanTram;
        private System.Windows.Forms.RadioButton rbTienMat;
        private System.Windows.Forms.Panel pnlCoCheInputs;
        private System.Windows.Forms.Panel pnlMucGiam;
        private System.Windows.Forms.Label lblMucGiam;
        private System.Windows.Forms.NumericUpDown numMucGiam;
        private System.Windows.Forms.Label lblMucGiamUnit;
        private System.Windows.Forms.Panel pnlGiamToiDa;
        private System.Windows.Forms.Label lblGiamToiDa;
        private System.Windows.Forms.NumericUpDown numGiamToiDa;
        private System.Windows.Forms.Label lblGiamToiDaUnit;

        private System.Windows.Forms.Panel pnlFieldDieuKien;
        private System.Windows.Forms.Panel pnlDonToiThieu;
        private System.Windows.Forms.Label lblDonToiThieu;
        private System.Windows.Forms.NumericUpDown numDonToiThieu;
        private System.Windows.Forms.Label lblDonToiThieuUnit;
        private System.Windows.Forms.Panel pnlPhamVi;
        private System.Windows.Forms.Label lblPhamVi;
        private System.Windows.Forms.ComboBox cboPhamVi;

        private System.Windows.Forms.Panel pnlFieldThoiGian;
        private System.Windows.Forms.Label lblThoiGianTitle;
        private System.Windows.Forms.Panel pnlThoiGianInputs;
        private System.Windows.Forms.Panel pnlNgayBD;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Panel pnlNgayKT;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;

        private System.Windows.Forms.Panel pnlFieldLuotDung;
        private System.Windows.Forms.Panel pnlLuotDungInputs;
        private System.Windows.Forms.Panel pnlTongLuot;
        private System.Windows.Forms.Label lblTongLuot;
        private System.Windows.Forms.NumericUpDown numTongLuot;
        private System.Windows.Forms.Label lblThongKeLuot;
        private System.Windows.Forms.Panel pnlGioiHanHD;
        private System.Windows.Forms.Label lblGioiHanHD;
        private System.Windows.Forms.NumericUpDown numGioiHanMoiHD;
        private System.Windows.Forms.Label lblGioiHanUnit;

        private System.Windows.Forms.Panel pnlFieldGhiChu;
        private System.Windows.Forms.Label lblGhiChuTitle;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Panel pnlDetailFooter;
        private DoAnLapTrinhTrucQuan.RoundedButton btnTamNgungMa;
        private System.Windows.Forms.FlowLayoutPanel pnlFooterActions;
        private DoAnLapTrinhTrucQuan.RoundedButton btnHuy;
        private DoAnLapTrinhTrucQuan.RoundedButton btnLuu;
    }
}
