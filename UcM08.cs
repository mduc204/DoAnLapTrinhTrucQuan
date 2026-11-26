using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace DoAnLapTrinhTrucQuan
{
    public partial class UcM08 : UserControl
    {
        private static readonly Color BrownDark = Color.FromArgb(74, 48, 32);
        private static readonly Color BrownPeak = Color.FromArgb(145, 95, 58);
        private static readonly Color CreamBorder = Color.FromArgb(232, 224, 218);
        private static readonly Color TextDark = Color.FromArgb(45, 30, 20);
        private static readonly Color TextMuted = Color.FromArgb(120, 110, 102);

        private sealed class ReportSnapshot
        {
            public string DateRangeText { get; init; } = "";
            public decimal NetRevenue { get; init; }
            public string RevenueSub { get; init; } = "";
            public string RevenueTrend { get; init; } = "";
            public int TotalOrders { get; init; }
            public decimal AvgOrder { get; init; }
            public decimal Cogs { get; init; }
            public string CogsRate { get; init; } = "";
            public decimal GrossProfit { get; init; }
            public string MarginRate { get; init; } = "";
            public decimal Discount { get; init; }
            public string VoucherNote { get; init; } = "";
            public decimal[] HourlyRevenue { get; init; } = Array.Empty<decimal>();
            public (string Name, decimal Amount, double Pct, int TxCount, Color Color)[] Payments { get; init; } = Array.Empty<(string, decimal, double, int, Color)>();
            public (int Rank, string Name, string Qty, decimal UnitPrice, decimal Total, double SharePct)[] TopItems { get; init; } = Array.Empty<(int, string, string, decimal, decimal, double)>();
            public string Top5ShareText { get; init; } = "";
            public decimal CashOpen { get; init; }
            public decimal CashIn { get; init; }
            public decimal CashOut { get; init; }
        }

        private readonly Dictionary<string, ReportSnapshot> presets = new();
        private readonly Dictionary<string, Button> tabButtons = new();
        private string activeTab = "Hôm nay (23/10)";
        private ReportSnapshot currentData = null!;
        private int hoveredBarIndex = -1;
        private readonly ToolTip chartToolTip = new();

        private readonly string[] hourLabels = { "07h", "08h", "09h", "10h", "11h", "12h", "13h", "14h", "15h", "16h", "17h", "18h", "19h", "20h", "21h" };

        public UcM08()
        {
            InitializeComponent();
            SeedPresets();
            BuildTimeTabs();
            WireEvents();
            ApplyPreset(activeTab);
            LayoutResponsive();
        }

        private void SeedPresets()
        {
            presets["Hôm nay (23/10)"] = new ReportSnapshot
            {
                DateRangeText = "📅  23/10/2024 – 23/10/2024",
                NetRevenue = 8_450_000m,
                RevenueSub = "Tháng 10: 186.42M",
                RevenueTrend = "+14.2%",
                TotalOrders = 68,
                AvgOrder = 124_260m,
                Cogs = 2_535_000m,
                CogsRate = "30.0%",
                GrossProfit = 5_915_000m,
                MarginRate = "70.0% Doanh thu",
                Discount = -245_000m,
                VoucherNote = "-18.300 đ",
                HourlyRevenue = new decimal[] { 310_000, 1_250_000, 1_380_000, 820_000, 360_000, 300_000, 240_000, 920_000, 1_050_000, 520_000, 210_000, 140_000, 440_000, 560_000, 250_000 },
                Payments = new[]
                {
                    ("VietQR Chuyển khoản", 3_800_000m, 45.0, 32, Color.FromArgb(62, 39, 35)),
                    ("Tiền mặt tại két",    3_550_000m, 42.0, 29, Color.FromArgb(145, 95, 58)),
                    ("Quẹt thẻ POS Card",   1_100_000m, 13.0,  7, Color.FromArgb(207, 179, 152))
                },
                TopItems = new[]
                {
                    (1, "Cà phê sữa phin truyền thống", "48 ly",  35_000m, 1_680_000m, 19.9),
                    (2, "Bạc xỉu Mộc cốt dừa",          "34 ly",  39_000m, 1_326_000m, 15.7),
                    (3, "Trà đào cam sả hạt chia",      "28 ly",  42_000m, 1_176_000m, 13.9),
                    (4, "Espresso đúp pha máy",         "22 ly",  35_000m,   770_000m,  9.1),
                    (5, "Bánh sừng bò Croissant bơ tỏi","18 cái", 32_000m,   576_000m,  6.8)
                },
                Top5ShareText = "Chiếm 65.4% tổng doanh số",
                CashOpen = 1_000_000m,
                CashIn = 3_550_000m,
                CashOut = 0m
            };

            presets["Hôm qua"] = new ReportSnapshot
            {
                DateRangeText = "📅  22/10/2024 – 22/10/2024",
                NetRevenue = 7_390_000m,
                RevenueSub = "So với 21/10: 7.12M",
                RevenueTrend = "+3.8%",
                TotalOrders = 61,
                AvgOrder = 121_140m,
                Cogs = 2_217_000m,
                CogsRate = "30.0%",
                GrossProfit = 5_173_000m,
                MarginRate = "70.0% Doanh thu",
                Discount = -180_000m,
                VoucherNote = "-15.000 đ",
                HourlyRevenue = new decimal[] { 260_000, 1_020_000, 1_190_000, 710_000, 320_000, 280_000, 210_000, 810_000, 940_000, 480_000, 190_000, 150_000, 360_000, 450_000, 220_000 },
                Payments = new[]
                {
                    ("VietQR Chuyển khoản", 3_250_000m, 44.0, 28, Color.FromArgb(62, 39, 35)),
                    ("Tiền mặt tại két",    3_180_000m, 43.0, 26, Color.FromArgb(145, 95, 58)),
                    ("Quẹt thẻ POS Card",     960_000m, 13.0,  7, Color.FromArgb(207, 179, 152))
                },
                TopItems = new[]
                {
                    (1, "Cà phê sữa phin truyền thống", "42 ly",  35_000m, 1_470_000m, 19.9),
                    (2, "Bạc xỉu Mộc cốt dừa",          "30 ly",  39_000m, 1_170_000m, 15.8),
                    (3, "Trà đào cam sả hạt chia",      "24 ly",  42_000m, 1_008_000m, 13.6),
                    (4, "Espresso đúp pha máy",         "19 ly",  35_000m,   665_000m,  9.0),
                    (5, "Bánh sừng bò Croissant bơ tỏi","15 cái", 32_000m,   480_000m,  6.5)
                },
                Top5ShareText = "Chiếm 64.8% tổng doanh số",
                CashOpen = 1_000_000m,
                CashIn = 3_180_000m,
                CashOut = 150_000m
            };

            presets["7 ngày qua"] = new ReportSnapshot
            {
                DateRangeText = "📅  17/10/2024 – 23/10/2024",
                NetRevenue = 54_820_000m,
                RevenueSub = "Tuần trước: 49.10M",
                RevenueTrend = "+11.6%",
                TotalOrders = 442,
                AvgOrder = 124_020m,
                Cogs = 16_446_000m,
                CogsRate = "30.0%",
                GrossProfit = 38_374_000m,
                MarginRate = "70.0% Doanh thu",
                Discount = -1_420_000m,
                VoucherNote = "-95.000 đ",
                HourlyRevenue = new decimal[] { 1_850_000, 7_600_000, 8_950_000, 5_100_000, 2_400_000, 2_100_000, 1_750_000, 6_100_000, 6_900_000, 3_450_000, 1_450_000, 1_120_000, 2_900_000, 3_650_000, 1_500_000 },
                Payments = new[]
                {
                    ("VietQR Chuyển khoản", 25_765_000m, 47.0, 210, Color.FromArgb(62, 39, 35)),
                    ("Tiền mặt tại két",    21_928_000m, 40.0, 178, Color.FromArgb(145, 95, 58)),
                    ("Quẹt thẻ POS Card",    7_127_000m, 13.0,  54, Color.FromArgb(207, 179, 152))
                },
                TopItems = new[]
                {
                    (1, "Cà phê sữa phin truyền thống", "310 ly",  35_000m, 10_850_000m, 19.8),
                    (2, "Bạc xỉu Mộc cốt dừa",          "218 ly",  39_000m,  8_502_000m, 15.5),
                    (3, "Trà đào cam sả hạt chia",      "182 ly",  42_000m,  7_644_000m, 13.9),
                    (4, "Espresso đúp pha máy",         "140 ly",  35_000m,  4_900_000m,  8.9),
                    (5, "Bánh sừng bò Croissant bơ tỏi","112 cái", 32_000m,  3_584_000m,  6.5)
                },
                Top5ShareText = "Chiếm 64.6% tổng doanh số",
                CashOpen = 1_000_000m,
                CashIn = 21_928_000m,
                CashOut = 1_200_000m
            };

            presets["Tháng này (10/2024)"] = new ReportSnapshot
            {
                DateRangeText = "📅  01/10/2024 – 23/10/2024",
                NetRevenue = 186_420_000m,
                RevenueSub = "Tháng 09: 163.24M",
                RevenueTrend = "+14.2%",
                TotalOrders = 1_510,
                AvgOrder = 123_450m,
                Cogs = 55_926_000m,
                CogsRate = "30.0%",
                GrossProfit = 130_494_000m,
                MarginRate = "70.0% Doanh thu",
                Discount = -4_850_000m,
                VoucherNote = "-310.000 đ",
                HourlyRevenue = new decimal[] { 6_200_000, 26_100_000, 30_400_000, 17_800_000, 8_200_000, 7_100_000, 5_900_000, 20_500_000, 23_100_000, 11_800_000, 4_900_000, 3_720_000, 9_800_000, 12_100_000, 4_900_000 },
                Payments = new[]
                {
                    ("VietQR Chuyển khoản", 89_482_000m, 48.0, 730, Color.FromArgb(62, 39, 35)),
                    ("Tiền mặt tại két",    70_840_000m, 38.0, 580, Color.FromArgb(145, 95, 58)),
                    ("Quẹt thẻ POS Card",   26_098_000m, 14.0, 200, Color.FromArgb(207, 179, 152))
                },
                TopItems = new[]
                {
                    (1, "Cà phê sữa phin truyền thống", "1.060 ly",  35_000m, 37_100_000m, 19.9),
                    (2, "Bạc xỉu Mộc cốt dừa",          "750 ly",    39_000m, 29_250_000m, 15.7),
                    (3, "Trà đào cam sả hạt chia",      "615 ly",    42_000m, 25_830_000m, 13.9),
                    (4, "Espresso đúp pha máy",         "480 ly",    35_000m, 16_800_000m,  9.0),
                    (5, "Bánh sừng bò Croissant bơ tỏi","385 cái",   32_000m, 12_320_000m,  6.6)
                },
                Top5ShareText = "Chiếm 65.1% tổng doanh số",
                CashOpen = 1_000_000m,
                CashIn = 70_840_000m,
                CashOut = 4_500_000m
            };
        }

        private void BuildTimeTabs()
        {
            pnlTimeTabs.Controls.Clear();
            tabButtons.Clear();
            int x = 0;
            foreach (var name in presets.Keys)
            {
                var btn = new Button
                {
                    Text = name,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Height = 28,
                    Padding = new Padding(10, 0, 10, 0),
                    Location = new Point(x, 2),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderSize = 1;
                string captured = name;
                btn.Click += (_, _) => ApplyPreset(captured);
                pnlTimeTabs.Controls.Add(btn);
                tabButtons[name] = btn;
                x += btn.Width + 6;
            }
        }

        private void RefreshTabStyles()
        {
            foreach (var kv in tabButtons)
            {
                bool active = kv.Key == activeTab;
                kv.Value.BackColor = active ? BrownDark : Color.FromArgb(247, 243, 239);
                kv.Value.ForeColor = active ? Color.White : Color.FromArgb(75, 65, 58);
                kv.Value.FlatAppearance.BorderColor = active ? BrownDark : CreamBorder;
                kv.Value.Font = new Font("Segoe UI", 8.5F, active ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void ApplyPreset(string key)
        {
            if (!presets.TryGetValue(key, out var data)) return;
            activeTab = key;
            currentData = data;
            RefreshTabStyles();

            lblDateRange.Text = data.DateRangeText;

            // KPI 1
            lblKpi1Val.Text = $"{data.NetRevenue:N0} đ";
            lblKpi1Sub.Text = data.RevenueSub;
            lblKpi1Badge.Text = data.RevenueTrend;

            // KPI 2
            lblKpi2Val.Text = $"{data.TotalOrders:N0} hóa đơn";
            lblKpi2Sub.Text = "Trung bình / Đơn";
            lblKpi2Badge.Text = $"{data.AvgOrder:N0} đ";

            // KPI 3
            lblKpi3Val.Text = $"{data.Cogs:N0} đ";
            lblKpi3Sub.Text = "Tỷ lệ giá vốn";
            lblKpi3Badge.Text = data.CogsRate;

            // KPI 4
            lblKpi4Val.Text = $"{data.GrossProfit:N0} đ";
            lblKpi4Sub.Text = "Biên lợi nhuận";
            lblKpi4Badge.Text = data.MarginRate;

            // KPI 5
            lblKpi5Val.Text = $"{data.Discount:N0} đ";
            lblKpi5Sub.Text = "Voucher MOC10";
            lblKpi5Badge.Text = data.VoucherNote;

            // Payment Breakdown List
            BuildPaymentList(data);

            // Top 5 Table
            dgvTop5.Rows.Clear();
            foreach (var item in data.TopItems)
            {
                dgvTop5.Rows.Add(
                    item.Rank.ToString(),
                    item.Name,
                    item.Qty,
                    $"{item.UnitPrice:N0} đ",
                    $"{item.Total:N0} đ",
                    $"{item.SharePct:0.0}%"
                );
            }
            lblTop5Share.Text = data.Top5ShareText;
            decimal top5Sum = data.TopItems.Sum(i => i.Total);
            lblTop5Total.Text = $"Tổng doanh thu Top 5 món: {top5Sum:N0} đ";

            // Cash Drawer
            lblCashOpenVal.Text = $"{data.CashOpen:N0} đ";
            lblCashInVal.Text = $"+ {data.CashIn:N0} đ";
            lblCashOutVal.Text = $"{data.CashOut:N0} đ";
            decimal totalCash = data.CashOpen + data.CashIn - data.CashOut;
            lblCashTotalVal.Text = $"{totalCash:N0} đ";

            pnlHourlyChart.Invalidate();
            pnlDonutChart.Invalidate();
            LayoutResponsive();
        }

        private void BuildPaymentList(ReportSnapshot data)
        {
            pnlPaymentList.Controls.Clear();
            int y = 2;
            foreach (var p in data.Payments)
            {
                var row = new Panel { Location = new Point(0, y), Size = new Size(pnlPaymentList.Width, 32), BackColor = Color.White };
                var dot = new Label
                {
                    Text = "●",
                    ForeColor = p.Color,
                    Font = new Font("Segoe UI", 10F),
                    Location = new Point(0, 5),
                    Size = new Size(18, 22)
                };
                var nameLbl = new Label
                {
                    Text = p.Name,
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = TextDark,
                    Location = new Point(20, 6),
                    AutoSize = true
                };
                var amtLbl = new Label
                {
                    Text = $"{p.Amount:N0} đ",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = TextDark,
                    TextAlign = ContentAlignment.TopRight,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Location = new Point(row.Width - 135, 1),
                    Size = new Size(135, 16)
                };
                var pctLbl = new Label
                {
                    Text = $"{p.Pct:0.0}% · {p.TxCount} GD",
                    Font = new Font("Segoe UI", 7.5F),
                    ForeColor = TextMuted,
                    TextAlign = ContentAlignment.TopRight,
                    Anchor = AnchorStyles.Top | AnchorStyles.Right,
                    Location = new Point(row.Width - 135, 16),
                    Size = new Size(135, 14)
                };
                row.Controls.AddRange(new Control[] { dot, nameLbl, amtLbl, pctLbl });
                pnlPaymentList.Controls.Add(row);
                y += 34;
            }
        }

        private void WireEvents()
        {
            pnlScroll.Resize += (_, _) => LayoutResponsive();
            pnlHourlyChart.Paint += PnlHourlyChart_Paint;
            pnlHourlyChart.MouseMove += PnlHourlyChart_MouseMove;
            pnlHourlyChart.MouseLeave += (_, _) => { hoveredBarIndex = -1; chartToolTip.Hide(pnlHourlyChart); pnlHourlyChart.Invalidate(); };
            pnlDonutChart.Paint += PnlDonutChart_Paint;
            dgvTop5.CellPainting += DgvTop5_CellPainting;

            btnApDung.Click += (_, _) =>
            {
                ApplyPreset(activeTab);
                MessageBox.Show($"Đã áp dụng bộ lọc: {activeTab} | {cboCa.SelectedItem} | {cboThuNgan.SelectedItem}",
                    "Báo cáo thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            btnXuatExcel.Click += (_, _) => MessageBox.Show("Chức năng Xuất Excel sẽ được kết nối ở bước backend.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnXuatPdf.Click += (_, _) => MessageBox.Show("Chức năng Xuất PDF sẽ được kết nối ở bước backend.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnInBaoCao.Click += (_, _) => MessageBox.Show("Đang gửi lệnh in báo cáo ngày tới máy in POS...", "In báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnXacNhanKetCa.Click += (_, _) =>
            {
                var confirm = MessageBox.Show($"Xác nhận kết ca và bàn giao két tiền ({lblCashTotalVal.Text})?",
                    "Xác nhận kết ca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                    MessageBox.Show("Đã xác nhận bàn giao ca thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            lnkViewAllMenu.LinkClicked += (_, _) => MessageBox.Show("Danh sách đầy đủ 34 món thực đơn sẽ hiển thị khi kết nối dữ liệu.", "Thực đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LayoutResponsive()
        {
            int contentWidth = Math.Max(980, pnlScroll.ClientSize.Width - 20);
            pnlContainer.Width = contentWidth;
            int innerW = contentWidth - 40;

            // Header
            pnlHeader.Width = innerW;
            btnInBaoCao.Location = new Point(innerW - btnInBaoCao.Width, 34);
            btnXuatPdf.Location = new Point(innerW - btnXuatPdf.Width, 0);
            btnXuatExcel.Location = new Point(btnXuatPdf.Left - btnXuatExcel.Width - 8, 0);

            // Filter card
            pnlFilterCard.Width = innerW;
            pnlFilterControls.Width = innerW - 24;
            btnApDung.Location = new Point(pnlFilterControls.Width - btnApDung.Width, 1);

            // KPI 5 equal cards
            pnlKpiRow.Width = innerW;
            var kpis = new[] { pnlKpi1, pnlKpi2, pnlKpi3, pnlKpi4, pnlKpi5 };
            int gap = 10;
            int cardW = (innerW - gap * 4) / 5;
            for (int i = 0; i < kpis.Length; i++)
            {
                kpis[i].SetBounds(i * (cardW + gap), 0, cardW, 108);
                var badge = kpis[i].Controls[3];
                badge.Location = new Point(Math.Max(110, cardW - badge.Width - 10), 76);
            }

            // Middle charts row
            pnlChartsRow.Width = innerW;
            int leftW = (int)(innerW * 0.63);
            int rightW = innerW - leftW - 12;
            pnlHourlyCard.SetBounds(0, 0, leftW, 290);
            lblHourlyLegend.Location = new Point(leftW - lblHourlyLegend.Width - 16, 15);
            pnlHourlyChart.SetBounds(14, 44, leftW - 28, 232);

            pnlPaymentCard.SetBounds(leftW + 12, 0, rightW, 290);
            lblPaymentBadge.Location = new Point(rightW - lblPaymentBadge.Width - 16, 13);
            pnlDonutChart.SetBounds(14, 42, rightW - 28, 128);
            pnlPaymentList.SetBounds(14, 174, rightW - 28, 106);
            foreach (Control row in pnlPaymentList.Controls) row.Width = pnlPaymentList.Width;

            // Bottom row
            pnlBottomRow.Width = innerW;
            int botLeftW = (int)(innerW * 0.62);
            int botRightW = innerW - botLeftW - 12;
            pnlTop5Card.SetBounds(0, 0, botLeftW, 286);
            lblTop5Share.Location = new Point(botLeftW - lblTop5Share.Width - 16, 15);
            dgvTop5.SetBounds(14, 42, botLeftW - 28, 202);
            pnlTop5Footer.SetBounds(14, 248, botLeftW - 28, 30);
            lnkViewAllMenu.Location = new Point(pnlTop5Footer.Width - lnkViewAllMenu.Width, 6);

            pnlCashCard.SetBounds(botLeftW + 12, 0, botRightW, 286);
            lblCashStatusBadge.Location = new Point(botRightW - lblCashStatusBadge.Width - 16, 12);
            pnlCashBody.SetBounds(14, 44, botRightW - 28, 180);
            foreach (Control c in pnlCashBody.Controls) c.Width = pnlCashBody.Width;
            pnlCashFooter.SetBounds(14, 228, botRightW - 28, 48);
            btnXacNhanKetCa.Location = new Point(pnlCashFooter.Width - btnXacNhanKetCa.Width - 8, 9);
        }

        // ─── Custom Paint: Hourly Bar Chart ───────────────────────────────────
        private void PnlHourlyChart_Paint(object? sender, PaintEventArgs e)
        {
            if (currentData == null || currentData.HourlyRevenue.Length == 0) return;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int padLeft = 44, padRight = 14, padTop = 24, padBottom = 26;
            int w = pnlHourlyChart.Width - padLeft - padRight;
            int h = pnlHourlyChart.Height - padTop - padBottom;
            if (w <= 20 || h <= 20) return;

            decimal maxVal = Math.Max(1_400_000m, currentData.HourlyRevenue.Max() * 1.12m);
            decimal[] ticks = { 0m, maxVal * 0.25m, maxVal * 0.5m, maxVal * 0.75m, maxVal };

            using var gridPen = new Pen(Color.FromArgb(240, 236, 232), 1);
            using var axisFont = new Font("Segoe UI", 7.5F);
            using var axisBrush = new SolidBrush(TextMuted);
            var rightAlign = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

            foreach (var t in ticks)
            {
                float y = padTop + h - (float)(t / maxVal) * h;
                g.DrawLine(gridPen, padLeft, y, padLeft + w, y);
                string label = t == 0 ? "0" : (t >= 1_000_000m ? $"{t / 1_000_000m:0.#}M" : $"{t / 1000m:0}k");
                g.DrawString(label, axisFont, axisBrush, new RectangleF(0, y - 8, padLeft - 6, 16), rightAlign);
            }

            int n = currentData.HourlyRevenue.Length;
            float slotW = (float)w / n;
            float barW = Math.Max(12f, slotW * 0.58f);
            decimal peakThreshold = currentData.HourlyRevenue.Max() * 0.65m;

            using var peakFont = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            var centerFmt = new StringFormat { Alignment = StringAlignment.Center };

            for (int i = 0; i < n; i++)
            {
                decimal val = currentData.HourlyRevenue[i];
                float barH = (float)(val / maxVal) * h;
                float x = padLeft + i * slotW + (slotW - barW) / 2f;
                float y = padTop + h - barH;

                bool isPeak = val >= peakThreshold;
                Color barColor = i == hoveredBarIndex
                    ? Color.FromArgb(180, 115, 70)
                    : (isPeak ? BrownPeak : BrownDark);

                using var path = RoundedTopRect(new RectangleF(x, y, barW, Math.Max(2f, barH)), 4f);
                using var barBrush = new SolidBrush(barColor);
                g.FillPath(barBrush, path);

                if (isPeak)
                {
                    string valText = val >= 1_000_000m ? $"{val / 1_000_000m:0.##}M" : $"{val / 1000m:0}k";
                    using var lblBrush = new SolidBrush(BrownPeak);
                    g.DrawString(valText, peakFont, lblBrush, x + barW / 2f, y - 16, centerFmt);
                }

                g.DrawString(hourLabels[i], axisFont, isPeak ? new SolidBrush(BrownPeak) : axisBrush,
                    x + barW / 2f, padTop + h + 6, centerFmt);
            }
        }

        private void PnlHourlyChart_MouseMove(object? sender, MouseEventArgs e)
        {
            if (currentData == null) return;
            int padLeft = 44, padRight = 14;
            int w = pnlHourlyChart.Width - padLeft - padRight;
            int n = currentData.HourlyRevenue.Length;
            float slotW = (float)w / n;
            int idx = (int)((e.X - padLeft) / slotW);
            if (idx < 0 || idx >= n || e.X < padLeft) idx = -1;

            if (idx != hoveredBarIndex)
            {
                hoveredBarIndex = idx;
                pnlHourlyChart.Invalidate();
                if (idx >= 0)
                    chartToolTip.Show($"{hourLabels[idx]}: {currentData.HourlyRevenue[idx]:N0} đ", pnlHourlyChart, e.X + 10, e.Y - 22);
                else
                    chartToolTip.Hide(pnlHourlyChart);
            }
        }

        // ─── Custom Paint: Donut Chart ────────────────────────────────────────
        private void PnlDonutChart_Paint(object? sender, PaintEventArgs e)
        {
            if (currentData == null || currentData.Payments.Length == 0) return;
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int size = Math.Min(pnlDonutChart.Width, pnlDonutChart.Height) - 12;
            if (size <= 40) return;
            var rect = new Rectangle((pnlDonutChart.Width - size) / 2, (pnlDonutChart.Height - size) / 2, size, size);

            float startAngle = -90f;
            float thickness = size * 0.22f;

            foreach (var p in currentData.Payments)
            {
                float sweep = (float)(p.Pct / 100.0 * 360.0);
                using var pen = new Pen(p.Color, thickness);
                var arcRect = new RectangleF(rect.X + thickness / 2f, rect.Y + thickness / 2f,
                    rect.Width - thickness, rect.Height - thickness);
                g.DrawArc(pen, arcRect, startAngle, sweep - 1.5f);
                startAngle += sweep;
            }

            var centerFmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            string mainVal = currentData.NetRevenue >= 1_000_000m
                ? $"{currentData.NetRevenue / 1_000_000m:0.##}M"
                : $"{currentData.NetRevenue / 1000m:0}K";
            using var valFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            using var subFont = new Font("Segoe UI", 7F, FontStyle.Bold);
            using var valBrush = new SolidBrush(TextDark);
            using var subBrush = new SolidBrush(TextMuted);

            g.DrawString(mainVal, valFont, valBrush, new RectangleF(rect.X, rect.Y - 8, rect.Width, rect.Height), centerFmt);
            g.DrawString("THỰC THU", subFont, subBrush, new RectangleF(rect.X, rect.Y + 12, rect.Width, rect.Height), centerFmt);
        }

        // ─── Custom Paint: Top 5 Rank & Share Badges ──────────────────────────
        private void DgvTop5_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var colName = dgvTop5.Columns[e.ColumnIndex].Name;

            if (colName == "colHang")
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
                var g = e.Graphics!;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                int rank = e.RowIndex + 1;
                int d = 22;
                var circle = new Rectangle(e.CellBounds.X + (e.CellBounds.Width - d) / 2,
                    e.CellBounds.Y + (e.CellBounds.Height - d) / 2, d, d);
                using var bg = new SolidBrush(rank == 1 ? BrownDark : Color.FromArgb(245, 240, 235));
                using var fg = new SolidBrush(rank == 1 ? Color.White : TextMuted);
                g.FillEllipse(bg, circle);
                var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(rank.ToString(), new Font("Segoe UI", 8.5F, FontStyle.Bold), fg, circle, fmt);
                e.Handled = true;
            }
            else if (colName == "colTyTrong")
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
                var g = e.Graphics!;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                bool isTop = e.RowIndex == 0;
                var pill = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + 7, e.CellBounds.Width - 16, e.CellBounds.Height - 14);
                using var bg = new SolidBrush(isTop ? Color.FromArgb(220, 252, 231) : Color.FromArgb(245, 242, 238));
                using var fg = new SolidBrush(isTop ? Color.FromArgb(21, 128, 61) : TextDark);
                g.FillRectangle(bg, pill);
                var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(e.FormattedValue?.ToString() ?? "", new Font("Segoe UI", 8F, FontStyle.Bold), fg, pill, fmt);
                e.Handled = true;
            }
        }

        private static GraphicsPath RoundedTopRect(RectangleF bounds, float radius)
        {
            var path = new GraphicsPath();
            float d = radius * 2;
            if (bounds.Height < d) d = bounds.Height;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddLine(bounds.Right, bounds.Bottom, bounds.X, bounds.Bottom);
            path.CloseFigure();
            return path;
        }
    }
}
