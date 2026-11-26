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
            var cream = Color.FromArgb(250, 247, 243);
            var brown = Color.FromArgb(86, 57, 39);
            var borderGray = Color.FromArgb(232, 224, 218);

            pnlScroll = new Panel();
            pnlContainer = new Panel();

            // Header
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnXuatExcel = new Button();
            btnXuatPdf = new Button();
            btnInBaoCao = new Button();

            // Filter Bar
            pnlFilterCard = new Panel();
            pnlTimeTabs = new Panel();
            pnlFilterControls = new Panel();
            lblDateRange = new Label();
            lblCaLabel = new Label();
            cboCa = new ComboBox();
            lblThuNganLabel = new Label();
            cboThuNgan = new ComboBox();
            btnApDung = new Button();

            // KPI Row
            pnlKpiRow = new Panel();
            pnlKpi1 = new Panel(); lblKpi1Title = new Label(); lblKpi1Val = new Label(); lblKpi1Sub = new Label(); lblKpi1Badge = new Label();
            pnlKpi2 = new Panel(); lblKpi2Title = new Label(); lblKpi2Val = new Label(); lblKpi2Sub = new Label(); lblKpi2Badge = new Label();
            pnlKpi3 = new Panel(); lblKpi3Title = new Label(); lblKpi3Val = new Label(); lblKpi3Sub = new Label(); lblKpi3Badge = new Label();
            pnlKpi4 = new Panel(); lblKpi4Title = new Label(); lblKpi4Val = new Label(); lblKpi4Sub = new Label(); lblKpi4Badge = new Label();
            pnlKpi5 = new Panel(); lblKpi5Title = new Label(); lblKpi5Val = new Label(); lblKpi5Sub = new Label(); lblKpi5Badge = new Label();

            // Middle Row (Charts)
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

            // Bottom Row (Top 5 + Cash Drawer)
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
            lblCashOpenVal = new Label();
            lblCashInVal = new Label();
            lblCashOutVal = new Label();
            pnlCashTotalBar = new Panel();
            lblCashTotalVal = new Label();
            pnlCashDiffBar = new Panel();
            lblCashDiffVal = new Label();
            pnlCashFooter = new Panel();
            lblCashierAvatar = new Label();
            lblCashierName = new Label();
            lblCashierRole = new Label();
            btnXacNhanKetCa = new Button();

            SuspendLayout();

            // Root UserControl
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = cream;
            Dock = DockStyle.Fill;
            Font = new Font("Segoe UI", 9F);
            Name = "UcM08";
            Size = new Size(1240, 920);

            // Scroll wrapper
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.AutoScroll = true;
            pnlScroll.BackColor = cream;
            Controls.Add(pnlScroll);

            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Size = new Size(1200, 910);
            pnlContainer.BackColor = cream;
            pnlContainer.Padding = new Padding(20, 14, 20, 20);
            pnlScroll.Controls.Add(pnlContainer);

            // ════════════════════════════════════════════════════════════════
            // 1. Header Row
            // ════════════════════════════════════════════════════════════════
            pnlHeader.Location = new Point(20, 14);
            pnlHeader.Size = new Size(1160, 66);
            pnlHeader.BackColor = cream;
            pnlContainer.Controls.Add(pnlHeader);

            lblTitle.Text = "Báo cáo thống kê";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(52, 34, 23);
            lblTitle.Location = new Point(0, 10);
            lblTitle.AutoSize = true;
            pnlHeader.Controls.Add(lblTitle);

            btnXuatExcel = MakeActionBtn("Xuất Excel", Color.White, Color.FromArgb(22, 101, 52), borderGray);
            btnXuatPdf = MakeActionBtn("Xuất PDF", Color.White, Color.FromArgb(185, 28, 28), borderGray);
            btnInBaoCao = MakeActionBtn("In báo cáo ngày", Color.FromArgb(74, 48, 32), Color.White, Color.FromArgb(74, 48, 32));
            btnXuatExcel.Size = new Size(112, 30);
            btnXuatPdf.Size = new Size(104, 30);
            btnInBaoCao.Size = new Size(134, 32);
            pnlHeader.Controls.Add(btnXuatExcel);
            pnlHeader.Controls.Add(btnXuatPdf);
            pnlHeader.Controls.Add(btnInBaoCao);

            // ════════════════════════════════════════════════════════════════
            // 2. Filter Bar Card
            // ════════════════════════════════════════════════════════════════
            pnlFilterCard.Location = new Point(20, 82);
            pnlFilterCard.Size = new Size(1160, 88);
            pnlFilterCard.BackColor = Color.White;
            pnlFilterCard.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Controls.Add(pnlFilterCard);

            pnlTimeTabs.Location = new Point(12, 8);
            pnlTimeTabs.Size = new Size(760, 32);
            pnlTimeTabs.BackColor = Color.Transparent;
            pnlFilterCard.Controls.Add(pnlTimeTabs);

            pnlFilterControls.Location = new Point(12, 46);
            pnlFilterControls.Size = new Size(1134, 34);
            pnlFilterControls.BackColor = Color.Transparent;
            pnlFilterCard.Controls.Add(pnlFilterControls);

            lblDateRange.Text = "📅  23/10/2024 – 23/10/2024";
            lblDateRange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateRange.ForeColor = Color.FromArgb(55, 55, 55);
            lblDateRange.Location = new Point(0, 6);
            lblDateRange.AutoSize = true;
            pnlFilterControls.Controls.Add(lblDateRange);

            lblCaLabel.Text = "CA:";
            lblCaLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCaLabel.ForeColor = Color.Gray;
            lblCaLabel.Location = new Point(220, 7);
            lblCaLabel.AutoSize = true;
            pnlFilterControls.Controls.Add(lblCaLabel);

            cboCa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCa.Font = new Font("Segoe UI", 9F);
            cboCa.Items.AddRange(new object[] { "Cả ngày", "Ca sáng (06:30 - 14:30)", "Ca chiều (14:30 - 22:00)" });
            cboCa.SelectedIndex = 0;
            cboCa.Location = new Point(250, 3);
            cboCa.Size = new Size(175, 25);
            pnlFilterControls.Controls.Add(cboCa);

            lblThuNganLabel.Text = "THU NGÂN:";
            lblThuNganLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblThuNganLabel.ForeColor = Color.Gray;
            lblThuNganLabel.Location = new Point(445, 7);
            lblThuNganLabel.AutoSize = true;
            pnlFilterControls.Controls.Add(lblThuNganLabel);

            cboThuNgan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuNgan.Font = new Font("Segoe UI", 9F);
            cboThuNgan.Items.AddRange(new object[] { "Tất cả nhân viên", "Nguyễn Văn Hưng", "Lê Mỹ Hạnh", "Trần Đình Nam" });
            cboThuNgan.SelectedIndex = 0;
            cboThuNgan.Location = new Point(522, 3);
            cboThuNgan.Size = new Size(185, 25);
            pnlFilterControls.Controls.Add(cboThuNgan);

            btnApDung = MakeActionBtn("↻ Áp dụng", brown, Color.White, brown);
            btnApDung.Size = new Size(105, 28);
            btnApDung.Location = new Point(1020, 1);
            pnlFilterControls.Controls.Add(btnApDung);

            // ════════════════════════════════════════════════════════════════
            // 3. KPI Summary Cards Row
            // ════════════════════════════════════════════════════════════════
            pnlKpiRow.Location = new Point(20, 182);
            pnlKpiRow.Size = new Size(1160, 112);
            pnlKpiRow.BackColor = Color.Transparent;
            pnlContainer.Controls.Add(pnlKpiRow);

            SetupKpiCard(pnlKpi1, lblKpi1Title, lblKpi1Val, lblKpi1Sub, lblKpi1Badge, "DOANH THU THUẦN", Color.FromArgb(45, 30, 20), Color.FromArgb(220, 252, 231), Color.FromArgb(22, 163, 74));
            SetupKpiCard(pnlKpi2, lblKpi2Title, lblKpi2Val, lblKpi2Sub, lblKpi2Badge, "TỔNG ĐƠN HÀNG POS", Color.FromArgb(45, 30, 20), Color.Transparent, Color.FromArgb(55, 55, 55));
            SetupKpiCard(pnlKpi3, lblKpi3Title, lblKpi3Val, lblKpi3Sub, lblKpi3Badge, "GIÁ VỐN (COGS)", Color.FromArgb(45, 30, 20), Color.FromArgb(220, 252, 231), Color.FromArgb(22, 163, 74));
            SetupKpiCard(pnlKpi4, lblKpi4Title, lblKpi4Val, lblKpi4Sub, lblKpi4Badge, "LỢI NHUẬN GỘP", Color.FromArgb(45, 30, 20), Color.Transparent, Color.FromArgb(22, 163, 74));
            SetupKpiCard(pnlKpi5, lblKpi5Title, lblKpi5Val, lblKpi5Sub, lblKpi5Badge, "GIẢM GIÁ & KHUYẾN MÃI", Color.FromArgb(220, 38, 38), Color.Transparent, Color.FromArgb(220, 38, 38));

            pnlKpiRow.Controls.AddRange(new Control[] { pnlKpi1, pnlKpi2, pnlKpi3, pnlKpi4, pnlKpi5 });

            // ════════════════════════════════════════════════════════════════
            // 4. Middle Charts Row
            // ════════════════════════════════════════════════════════════════
            pnlChartsRow.Location = new Point(20, 306);
            pnlChartsRow.Size = new Size(1160, 290);
            pnlChartsRow.BackColor = Color.Transparent;
            pnlContainer.Controls.Add(pnlChartsRow);

            // Left: Hourly Revenue
            pnlHourlyCard.BackColor = Color.White;
            pnlHourlyCard.BorderStyle = BorderStyle.FixedSingle;
            pnlChartsRow.Controls.Add(pnlHourlyCard);

            lblHourlyTitle.Text = "📊  Doanh thu theo giờ";
            lblHourlyTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHourlyTitle.ForeColor = Color.FromArgb(45, 30, 20);
            lblHourlyTitle.Location = new Point(14, 12);
            lblHourlyTitle.AutoSize = true;
            pnlHourlyCard.Controls.Add(lblHourlyTitle);

            lblHourlyLegend.Text = "● Giờ thường    ● Giờ cao điểm";
            lblHourlyLegend.Font = new Font("Segoe UI", 8.5F);
            lblHourlyLegend.ForeColor = Color.FromArgb(100, 90, 80);
            lblHourlyLegend.AutoSize = true;
            pnlHourlyCard.Controls.Add(lblHourlyLegend);

            pnlHourlyChart.Location = new Point(14, 44);
            pnlHourlyChart.Size = new Size(700, 232);
            pnlHourlyChart.BackColor = Color.White;
            pnlHourlyCard.Controls.Add(pnlHourlyChart);

            // Right: Payment Breakdown
            pnlPaymentCard.BackColor = Color.White;
            pnlPaymentCard.BorderStyle = BorderStyle.FixedSingle;
            pnlChartsRow.Controls.Add(pnlPaymentCard);

            lblPaymentTitle.Text = "◔  Cơ cấu thanh toán";
            lblPaymentTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPaymentTitle.ForeColor = Color.FromArgb(45, 30, 20);
            lblPaymentTitle.Location = new Point(14, 12);
            lblPaymentTitle.AutoSize = true;
            pnlPaymentCard.Controls.Add(lblPaymentTitle);

            lblPaymentBadge.Text = "100% Thu";
            lblPaymentBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPaymentBadge.ForeColor = Color.FromArgb(100, 80, 65);
            lblPaymentBadge.BackColor = Color.FromArgb(245, 240, 235);
            lblPaymentBadge.Padding = new Padding(6, 2, 6, 2);
            lblPaymentBadge.AutoSize = true;
            pnlPaymentCard.Controls.Add(lblPaymentBadge);

            pnlDonutChart.Location = new Point(14, 42);
            pnlDonutChart.Size = new Size(370, 128);
            pnlDonutChart.BackColor = Color.White;
            pnlPaymentCard.Controls.Add(pnlDonutChart);

            pnlPaymentList.Location = new Point(14, 174);
            pnlPaymentList.Size = new Size(370, 106);
            pnlPaymentList.BackColor = Color.White;
            pnlPaymentCard.Controls.Add(pnlPaymentList);

            // ════════════════════════════════════════════════════════════════
            // 5. Bottom Row (Top 5 + Cash Drawer)
            // ════════════════════════════════════════════════════════════════
            pnlBottomRow.Location = new Point(20, 608);
            pnlBottomRow.Size = new Size(1160, 286);
            pnlBottomRow.BackColor = Color.Transparent;
            pnlContainer.Controls.Add(pnlBottomRow);

            // Left: Top 5 Best Sellers
            pnlTop5Card.BackColor = Color.White;
            pnlTop5Card.BorderStyle = BorderStyle.FixedSingle;
            pnlBottomRow.Controls.Add(pnlTop5Card);

            lblTop5Title.Text = "☆  Top 5 món bán chạy";
            lblTop5Title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTop5Title.ForeColor = Color.FromArgb(45, 30, 20);
            lblTop5Title.Location = new Point(14, 12);
            lblTop5Title.AutoSize = true;
            pnlTop5Card.Controls.Add(lblTop5Title);

            lblTop5Share.Text = "Chiếm 65.4% tổng doanh số";
            lblTop5Share.Font = new Font("Segoe UI", 8.5F);
            lblTop5Share.ForeColor = Color.Gray;
            lblTop5Share.AutoSize = true;
            pnlTop5Card.Controls.Add(lblTop5Share);

            dgvTop5.Location = new Point(14, 42);
            dgvTop5.Size = new Size(690, 202);
            dgvTop5.BackgroundColor = Color.White;
            dgvTop5.BorderStyle = BorderStyle.None;
            dgvTop5.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTop5.GridColor = Color.FromArgb(242, 238, 234);
            dgvTop5.RowHeadersVisible = false;
            dgvTop5.AllowUserToAddRows = false;
            dgvTop5.AllowUserToDeleteRows = false;
            dgvTop5.AllowUserToResizeRows = false;
            dgvTop5.ReadOnly = true;
            dgvTop5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop5.MultiSelect = false;
            dgvTop5.EnableHeadersVisualStyles = false;
            dgvTop5.ColumnHeadersHeight = 30;
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTop5.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 247, 243);
            dgvTop5.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(120, 105, 95);
            dgvTop5.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dgvTop5.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 250, 244);
            dgvTop5.DefaultCellStyle.SelectionForeColor = Color.FromArgb(45, 30, 20);
            dgvTop5.RowTemplate.Height = 34;

            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHang", HeaderText = "HẠNG", Width = 50, SortMode = DataGridViewColumnSortMode.NotSortable });
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTenMon", HeaderText = "MÃ MÓN & TÊN SẢN PHẨM", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, SortMode = DataGridViewColumnSortMode.NotSortable });
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSoLuong", HeaderText = "SỐ LƯỢNG BÁN", Width = 96, SortMode = DataGridViewColumnSortMode.NotSortable, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDonGia", HeaderText = "ĐƠN GIÁ TB", Width = 86, SortMode = DataGridViewColumnSortMode.NotSortable, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { Name = "colThanhTien", HeaderText = "TỔNG THÀNH TIỀN", Width = 115, SortMode = DataGridViewColumnSortMode.NotSortable, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font("Segoe UI", 9F, FontStyle.Bold) } });
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTyTrong", HeaderText = "TỶ TRỌNG", Width = 75, SortMode = DataGridViewColumnSortMode.NotSortable, DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter } });
            pnlTop5Card.Controls.Add(dgvTop5);

            pnlTop5Footer.Location = new Point(14, 248);
            pnlTop5Footer.Size = new Size(690, 30);
            pnlTop5Footer.BackColor = Color.White;
            pnlTop5Card.Controls.Add(pnlTop5Footer);

            lblTop5Total.Text = "Tổng doanh thu Top 5 món: 5.528.000 đ";
            lblTop5Total.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTop5Total.ForeColor = Color.FromArgb(65, 50, 40);
            lblTop5Total.Location = new Point(0, 6);
            lblTop5Total.AutoSize = true;
            pnlTop5Footer.Controls.Add(lblTop5Total);

            lnkViewAllMenu.Text = "Xem toàn bộ 34 món thực đơn >";
            lnkViewAllMenu.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lnkViewAllMenu.LinkColor = Color.FromArgb(145, 95, 60);
            lnkViewAllMenu.ActiveLinkColor = brown;
            lnkViewAllMenu.AutoSize = true;
            lnkViewAllMenu.LinkBehavior = LinkBehavior.HoverUnderline;
            pnlTop5Footer.Controls.Add(lnkViewAllMenu);

            // Right: Cash Drawer & Handover
            pnlCashCard.BackColor = Color.White;
            pnlCashCard.BorderStyle = BorderStyle.FixedSingle;
            pnlBottomRow.Controls.Add(pnlCashCard);

            lblCashTitle.Text = "🗄  Két tiền & bàn giao ca";
            lblCashTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCashTitle.ForeColor = Color.FromArgb(45, 30, 20);
            lblCashTitle.Location = new Point(14, 12);
            lblCashTitle.AutoSize = true;
            pnlCashCard.Controls.Add(lblCashTitle);

            lblCashStatusBadge.Text = "● Khớp 100%";
            lblCashStatusBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCashStatusBadge.BackColor = Color.FromArgb(220, 252, 231);
            lblCashStatusBadge.ForeColor = Color.FromArgb(22, 163, 74);
            lblCashStatusBadge.Padding = new Padding(8, 3, 8, 3);
            lblCashStatusBadge.AutoSize = true;
            pnlCashCard.Controls.Add(lblCashStatusBadge);

            pnlCashBody.Location = new Point(14, 44);
            pnlCashBody.Size = new Size(370, 180);
            pnlCashBody.BackColor = Color.White;
            pnlCashCard.Controls.Add(pnlCashBody);

            BuildCashRows();

            pnlCashFooter.Location = new Point(14, 228);
            pnlCashFooter.Size = new Size(370, 48);
            pnlCashFooter.BackColor = Color.FromArgb(250, 247, 243);
            pnlCashCard.Controls.Add(pnlCashFooter);

            lblCashierAvatar.Text = "NVH";
            lblCashierAvatar.Size = new Size(34, 34);
            lblCashierAvatar.Location = new Point(8, 7);
            lblCashierAvatar.BackColor = brown;
            lblCashierAvatar.ForeColor = Color.White;
            lblCashierAvatar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCashierAvatar.TextAlign = ContentAlignment.MiddleCenter;
            pnlCashFooter.Controls.Add(lblCashierAvatar);

            lblCashierName.Text = "Nguyễn Văn Hưng";
            lblCashierName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCashierName.ForeColor = Color.FromArgb(45, 30, 20);
            lblCashierName.Location = new Point(50, 6);
            lblCashierName.AutoSize = true;
            pnlCashFooter.Controls.Add(lblCashierName);

            lblCashierRole.Text = "Quản lý ca · MC-004";
            lblCashierRole.Font = new Font("Segoe UI", 8F);
            lblCashierRole.ForeColor = Color.Gray;
            lblCashierRole.Location = new Point(50, 24);
            lblCashierRole.AutoSize = true;
            pnlCashFooter.Controls.Add(lblCashierRole);

            btnXacNhanKetCa = MakeActionBtn("Xác nhận kết ca", Color.White, brown, borderGray);
            btnXacNhanKetCa.Size = new Size(124, 30);
            btnXacNhanKetCa.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            pnlCashFooter.Controls.Add(btnXacNhanKetCa);

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
    }
}
