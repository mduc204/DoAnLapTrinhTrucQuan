using System.Globalization;

namespace DoAnLapTrinhTrucQuan.UserControls.Sales
{
    public partial class ucTableMap : UserControl
    {
        private static readonly Color Ink = Color.FromArgb(47, 25, 17);
        private static readonly Color Muted = Color.FromArgb(109, 82, 74);
        private static readonly Color Cream = Color.FromArgb(253, 246, 243);
        private static readonly Color Peach = Color.FromArgb(253, 229, 220);
        private static readonly Color Coffee = Color.FromArgb(44, 22, 15);
        private static readonly Color Orange = Color.FromArgb(255, 141, 39);
        private static readonly CultureInfo CurrencyCulture = CultureInfo.GetCultureInfo("vi-VN");

        private readonly List<DiningTable> _tables = CreateDemoTables();
        private DiningTable? _selectedTable;
        private Area? _selectedArea;

        public ucTableMap()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            cboTableStatus.Items.AddRange(["Tất cả trạng thái", "Trống", "Đang phục vụ", "Chờ dọn", "Tạm khóa"]);
            cboTableStatus.SelectedIndex = 0;
            _selectedTable = _tables[0];

            btnFilterAllAreas.Click += (_, _) => FilterArea(null);
            btnFilterIndoor.Click += (_, _) => FilterArea(Area.Indoor);
            btnFilterGarden.Click += (_, _) => FilterArea(Area.Garden);
            btnFilterAirConditioned.Click += (_, _) => FilterArea(Area.AirConditioned);
            btnRefresh.Click += (_, _) => RenderTables();
            btnConfigureTables.Click += (_, _) => ShowPendingScreen("Quản lý bàn");
            cboTableStatus.SelectedIndexChanged += (_, _) => RenderTables();
            txtSearch.TextChanged += (_, _) => SyncSearchBoxes(txtSearch, txtSearchTable);
            txtSearchTable.TextChanged += (_, _) => SyncSearchBoxes(txtSearchTable, txtSearch);
            tlpFilters.SizeChanged += (_, _) => ResizeFilters();
            flpTables.SizeChanged += (_, _) => ResizeTableCards();

            ResizeFilters();
            RenderTables();
        }

        private void FilterArea(Area? area)
        {
            _selectedArea = area;
            RenderTables();
        }

        private void SyncSearchBoxes(TextBox source, TextBox target)
        {
            if (source.Text != target.Text)
            {
                target.Text = source.Text;
                RenderTables();
            }
        }

        private void RenderTables()
        {
            UpdateSummary();

            var filteredTables = _tables.Where(table =>
                (_selectedArea is null || table.Area == _selectedArea) &&
                (cboTableStatus.SelectedIndex <= 0 || (int)table.State == cboTableStatus.SelectedIndex - 1) &&
                table.Id.Contains(txtSearchTable.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray();

            if (!filteredTables.Contains(_selectedTable))
                _selectedTable = filteredTables.FirstOrDefault();

            flpTables.SuspendLayout();
            ClearControls(flpTables);
            foreach (var table in filteredTables)
                flpTables.Controls.Add(CreateTableCard(table));

            if (filteredTables.Length == 0)
            {
                var lblNoTables = CreateLabel("Không tìm thấy bàn phù hợp.", color: Muted);
                lblNoTables.Name = "lblNoTables";
                lblNoTables.AutoSize = true;
                flpTables.Controls.Add(lblNoTables);
            }

            ResizeTableCards();
            flpTables.ResumeLayout();
            RenderDetails();
        }

        private void UpdateSummary()
        {
            lblEmptyCount.Text = $"● Trống: {_tables.Count(table => table.State == TableState.Empty)}";
            lblServingCount.Text = $"● Đang phục vụ: {_tables.Count(table => table.State == TableState.Serving)}";
            lblCleaningCount.Text = $"● Chờ dọn: {_tables.Count(table => table.State == TableState.Cleaning)}";
            lblLockedCount.Text = $"● Ngừng dùng: {_tables.Count(table => table.State == TableState.Locked)}";

            SetAreaSummary(Area.Indoor, lblIndoorSummary, btnFilterIndoor, "Tầng 1 - Trong nhà");
            SetAreaSummary(Area.Garden, lblGardenSummary, btnFilterGarden, "Tầng 1 - Sân vườn");
            SetAreaSummary(Area.AirConditioned, lblAirConditionedSummary, btnFilterAirConditioned, "Tầng 2 - Máy lạnh");
            btnFilterAllAreas.Text = $"Tất cả khu vực ({_tables.Count})";
            btnFilterAllAreas.BackColor = _selectedArea is null ? Color.White : Peach;
        }

        private void SetAreaSummary(Area area, Label summary, Button filter, string title)
        {
            var areaTables = _tables.Where(table => table.Area == area).ToArray();
            var busy = areaTables.Count(table => table.State == TableState.Serving || table.State == TableState.Cleaning);
            var locked = areaTables.Count(table => table.State == TableState.Locked);
            var lockedText = locked > 0 ? $"  ·  {locked} bảo trì" : "";
            summary.Text = $"{title.ToUpperInvariant()}\n{busy} bàn bận / {areaTables.Length} bàn{lockedText}";
            filter.Text = $"{title} ({areaTables.Length})";
            filter.BackColor = _selectedArea == area ? Color.White : Peach;
        }

        private void ResizeFilters()
        {
            int rowHeight = tlpFilters.ClientSize.Width < 620 ? 55 : 30;
            if (tlpFilters.RowStyles[0].Height == rowHeight)
                return;

            tlpFilters.RowStyles[0].Height = rowHeight;
            tlpFilters.RowStyles[1].Height = rowHeight;
            tlpFilters.Height = rowHeight * 2 + 43;
        }

        private void ResizeTableCards()
        {
            int availableWidth = flpTables.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            int columns = availableWidth >= 606 ? 3 : availableWidth >= 404 ? 2 : 1;
            int cardWidth = Math.Max(160, availableWidth / columns - 6);
            foreach (Control control in flpTables.Controls)
            {
                if (control is Panel)
                    control.Width = cardWidth;
            }
        }

        private Panel CreateTableCard(DiningTable table)
        {
            var card = new Panel
            {
                Name = $"pnlTable_{table.Id}",
                Tag = table,
                Height = 176,
                Margin = new Padding(0, 0, 6, 6)
            };
            StyleTableCard(card, table);

            var layout = new TableLayoutPanel
            {
                Name = $"tlpTable_{table.Id}",
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 4,
                BackColor = Color.White,
                Padding = new Padding(6)
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 21));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            card.Controls.Add(layout);

            var btnSelectTable = CreateButton($"btnTable_{table.Id}", $"{table.Id}  ·  {table.Seats} chỗ", () => SelectTable(table), Color.White, Ink);
            btnSelectTable.Tag = table;
            btnSelectTable.TextAlign = ContentAlignment.MiddleLeft;
            btnSelectTable.Padding = new Padding(0);
            layout.Controls.Add(btnSelectTable, 0, 0);
            var lblState = CreateLabel(StateText(table.State), StateColor(table.State), Ink, true);
            lblState.TextAlign = ContentAlignment.MiddleCenter;
            layout.Controls.Add(lblState, 1, 0);
            AddSpanningControl(layout, CreateLabel(AreaName(table.Area), color: Muted), 1);

            string note = table.Order is { } order
                ? $"Đơn:  #{order.Code}\nGiờ vào:  {order.OpenedAt}\nTạm tính:  {FormatMoney(order.Total)}"
                : table.Note;
            var lblDescription = CreateLabel(note, Cream, table.Order is null ? Muted : Ink);
            lblDescription.TextAlign = table.Order is null ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            lblDescription.Click += (_, _) => SelectTable(table);
            AddSpanningControl(layout, lblDescription, 2);

            switch (table.State)
            {
                case TableState.Serving:
                    string action = table == _selectedTable ? "Thêm món" : "Chi tiết";
                    layout.Controls.Add(CreateButton($"btnOpenTable_{table.Id}", action, () => OpenTable(table), Peach, Ink), 0, 3);
                    layout.Controls.Add(CreateButton($"btnPayTable_{table.Id}", "Thu tiền", () => ShowPendingScreen("Thanh toán"), Coffee, Color.White), 1, 3);
                    break;
                case TableState.Empty:
                    AddSpanningControl(layout, CreateButton($"btnCreateOrder_{table.Id}", "Tạo đơn mới (POS)", () => ShowPendingScreen("Bán hàng (POS)"), Coffee, Color.White), 3);
                    break;
                case TableState.Cleaning:
                    AddSpanningControl(layout, CreateButton($"btnMarkClean_{table.Id}", "✓  Đã dọn xong", () => MarkTableClean(table), Orange, Ink), 3);
                    break;
                case TableState.Locked:
                    var btnLocked = CreateButton($"btnCreateOrder_{table.Id}", "Khóa nhận khách", () => { }, Peach, Muted);
                    btnLocked.Enabled = false;
                    AddSpanningControl(layout, btnLocked, 3);
                    break;
            }

            return card;
        }

        private void OpenTable(DiningTable table)
        {
            if (table == _selectedTable)
                ShowPendingScreen("Bán hàng (POS)");
            else
                SelectTable(table);
        }

        private void SelectTable(DiningTable table)
        {
            if (_selectedTable == table)
                return;

            var previous = _selectedTable;
            _selectedTable = table;

            foreach (Panel card in flpTables.Controls.OfType<Panel>())
            {
                if (card.Tag is not DiningTable item || (item != previous && item != table))
                    continue;

                StyleTableCard(card, item);
                var btnOpenTable = card.Controls.Find($"btnOpenTable_{item.Id}", true).OfType<Button>().FirstOrDefault();
                if (btnOpenTable is not null)
                    btnOpenTable.Text = item == _selectedTable ? "Thêm món" : "Chi tiết";
            }

            RenderDetails();
        }

        private void StyleTableCard(Panel card, DiningTable table)
        {
            bool selected = table == _selectedTable;
            card.Padding = new Padding(selected ? 2 : 0, 4, selected ? 2 : 0, selected ? 2 : 0);
            card.BackColor = selected ? Orange : table.State switch
            {
                TableState.Empty => Color.FromArgb(80, 161, 83),
                TableState.Serving => Orange,
                _ => Color.FromArgb(147, 126, 122)
            };
        }

        private void MarkTableClean(DiningTable table)
        {
            table.State = TableState.Empty;
            table.Note = "Sẵn sàng đón khách";
            _selectedTable = table;
            RenderTables();
        }

        private void RenderDetails()
        {
            tlpTableDetails.SuspendLayout();
            ClearControls(tlpTableDetails);
            tlpTableDetails.RowStyles.Clear();
            tlpTableDetails.RowCount = 0;

            if (_selectedTable is not { } table)
            {
                AddDetailControl(CreateLabel("Chọn một bàn để xem chi tiết.", Cream, Muted), 42);
                tlpTableDetails.ResumeLayout();
                return;
            }

            var heading = CreateDetailRow($"Chi tiết bàn {table.Id}", StateText(table.State), Cream, true);
            heading.ColumnStyles[0].Width = 55;
            heading.ColumnStyles[1].Width = 45;
            heading.GetControlFromPosition(1, 0)!.BackColor = StateColor(table.State);
            AddDetailControl(heading, 34);
            AddDetailControl(CreateLabel($"{AreaName(table.Area)}  ·  {table.Seats} ghế", color: Muted), 28);

            if (table.Order is { } order)
            {
                AddDetailControl(CreateDetailRow("Mã phiếu order", $"#{order.Code}", Cream, true), 26);
                AddDetailControl(CreateDetailRow("Số lượng khách", $"{order.Guests:00} người", Cream), 24);
                AddDetailControl(CreateDetailRow("Giờ vào", order.OpenedAt, Cream), 24);
                AddDetailControl(CreateDetailRow("Nhân viên phụ trách", "Nguyễn Văn Hùng", Cream), 24);
                AddDetailControl(CreateLabel($"DANH SÁCH MÓN ({order.Lines.Sum(line => line.Quantity)} PHẦN)", bold: true), 32);

                foreach (var line in order.Lines)
                    AddDetailControl(CreateDetailRow($"{line.Quantity}x  {line.Name}", FormatMoney(line.Amount), Cream, true), 31);

                AddDetailControl(CreateDetailRow("Tiền hàng", FormatMoney(order.Total), Color.White), 28);
                AddDetailControl(CreateDetailRow("Thuế & phí dịch vụ", "0 đ", Color.White), 24);
                var totals = CreateDetailRow("Tổng thanh toán", FormatMoney(order.Total), Color.White, true);
                totals.GetControlFromPosition(1, 0)!.ForeColor = Color.FromArgb(146, 72, 0);
                AddDetailControl(totals, 37);
                var actions = CreateDetailRow("", "", Color.White);
                ClearControls(actions);
                actions.Controls.Add(CreateButton("btnMergeTables", "Đổi / Gộp bàn", () => ShowPendingScreen("Đổi / Gộp bàn"), Peach, Ink), 0, 0);
                actions.Controls.Add(CreateButton("btnAddOrderItems", "Thêm món (POS)", () => ShowPendingScreen("Bán hàng (POS)"), Peach, Ink), 1, 0);
                AddDetailControl(actions, 32);
                AddDetailControl(CreateButton("btnPayOrder", $"Thanh toán · {FormatMoney(order.Total)}", () => ShowPendingScreen("Thanh toán"), Coffee, Color.White), 40);
            }
            else
            {
                AddDetailControl(CreateLabel(table.Note, Cream, Muted), 60);
                if (table.State == TableState.Empty)
                    AddDetailControl(CreateButton("btnCreateOrder", "Tạo đơn mới (POS)", () => ShowPendingScreen("Bán hàng (POS)"), Coffee, Color.White), 38);
                if (table.State == TableState.Cleaning)
                    AddDetailControl(CreateButton("btnMarkClean", "✓  Đã dọn xong", () => MarkTableClean(table), Orange, Ink), 38);
            }

            tlpTableDetails.ResumeLayout();
        }

        private void AddDetailControl(Control control, int height)
        {
            int row = tlpTableDetails.RowCount++;
            tlpTableDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
            tlpTableDetails.Controls.Add(control, 0, row);
        }

        private static TableLayoutPanel CreateDetailRow(string caption, string value, Color background, bool bold = false)
        {
            var row = new TableLayoutPanel { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 2), ColumnCount = 2, RowCount = 1 };
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41));
            row.Controls.Add(CreateLabel(caption, background, Ink, bold), 0, 0);
            var label = CreateLabel(value, background, Ink, bold);
            label.TextAlign = ContentAlignment.MiddleRight;
            row.Controls.Add(label, 1, 0);
            return row;
        }

        private static void AddSpanningControl(TableLayoutPanel layout, Control control, int row)
        {
            layout.Controls.Add(control, 0, row);
            layout.SetColumnSpan(control, 2);
        }

        private static Label CreateLabel(string text, Color? background = null, Color? color = null, bool bold = false)
        {
            var label = new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0, 1, 0, 1),
                Padding = new Padding(4, 0, 4, 0),
                ForeColor = color ?? Ink,
                BackColor = background ?? Color.Transparent
            };
            if (bold)
            {
                var font = new Font(SystemFonts.MessageBoxFont ?? Control.DefaultFont, FontStyle.Bold);
                label.Font = font;
                label.Disposed += (_, _) => font.Dispose();
            }
            return label;
        }

        private static Button CreateButton(string name, string text, Action click, Color background, Color color)
        {
            var button = new Button
            {
                Name = name,
                Text = text,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                UseVisualStyleBackColor = false,
                BackColor = background,
                ForeColor = color,
                Margin = new Padding(1, 2, 1, 1),
                UseMnemonic = false
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += (_, _) => click();
            return button;
        }

        private static void ClearControls(Control container)
        {
            while (container.Controls.Count > 0)
                container.Controls[0].Dispose();
        }

        private void ShowPendingScreen(string screen)
        {
            MessageBox.Show(this, $"Màn hình {screen} chưa được tích hợp vào bản S01.", "Mộc Café", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string FormatMoney(decimal amount) => amount.ToString("N0", CurrencyCulture) + " đ";

        private static string AreaName(Area area) => area switch
        {
            Area.Indoor => "Tầng 1 (Trong nhà)",
            Area.Garden => "Tầng 1 (Sân vườn)",
            _ => "Tầng 2 (Máy lạnh)"
        };

        private static string StateText(TableState state) => state switch
        {
            TableState.Empty => "● Trống",
            TableState.Serving => "● Phục vụ",
            TableState.Cleaning => "● Chờ dọn",
            _ => "● Tạm khóa"
        };

        private static Color StateColor(TableState state) => state switch
        {
            TableState.Empty => Color.FromArgb(175, 238, 164),
            TableState.Serving => Color.FromArgb(255, 218, 189),
            TableState.Cleaning => Peach,
            _ => Color.FromArgb(244, 231, 226)
        };

        private static List<DiningTable> CreateDemoTables() =>
        [
            new("B03", 4, Area.Indoor, TableState.Serving, "",
                new("DH000125", "08:45", 4, [new("Cà phê phin sữa đá", 2, 35_000), new("Bạc xỉu Mộc", 1, 45_000), new("Trà đào cam sả", 1, 50_000)])),
            new("A01", 2, Area.Indoor, TableState.Empty),
            new("A02", 2, Area.Indoor, TableState.Serving, "", new("DH000122", "08:12", 2, [new("Cà phê sữa phin", 6, 35_000)])),
            new("A03", 4, Area.Indoor, TableState.Cleaning, "Khách vừa thanh toán"),
            new("A04", 6, Area.Indoor, TableState.Empty, "Khu vực cửa kính"),
            new("B01", 4, Area.Garden, TableState.Serving, "", new("DH000123", "08:50", 3, [new("Cà phê sữa phin", 1, 35_000), new("Trà trái cây", 2, 30_000)])),
            new("B02", 4, Area.Garden, TableState.Cleaning, "Chờ nhân viên dọn ly"),
            new("B04", 2, Area.Garden, TableState.Empty, "Bàn dưới bóng cây"),
            new("C01", 8, Area.AirConditioned, TableState.Serving, "", new("DH000120", "07:55", 8, [new("Suất đồ uống", 8, 60_000)])),
            new("C02", 4, Area.AirConditioned, TableState.Locked, "Bảo trì quạt trần"),
            new("A05", 4, Area.Indoor, TableState.Serving, "", new("DH000126", "09:05", 4, [new("Bạc xỉu Mộc", 4, 45_000)])),
            new("A06", 4, Area.Indoor, TableState.Empty),
            new("A07", 2, Area.Indoor, TableState.Empty),
            new("B05", 4, Area.Garden, TableState.Empty),
            new("B06", 6, Area.Garden, TableState.Empty),
            new("B07", 2, Area.Garden, TableState.Empty),
            new("C03", 2, Area.AirConditioned, TableState.Empty),
            new("C04", 4, Area.AirConditioned, TableState.Empty),
            new("C05", 4, Area.AirConditioned, TableState.Empty),
            new("C06", 6, Area.AirConditioned, TableState.Empty)
        ];

        private enum Area { Indoor, Garden, AirConditioned }
        private enum TableState { Empty, Serving, Cleaning, Locked }

        private sealed class DiningTable(
            string id, int seats, Area area, TableState state,
            string note = "Sẵn sàng đón khách", Order? order = null)
        {
            public string Id { get; } = id;
            public int Seats { get; } = seats;
            public Area Area { get; } = area;
            public TableState State { get; set; } = state;
            public string Note { get; set; } = note;
            public Order? Order { get; } = order;
        }

        private sealed record Order(string Code, string OpenedAt, int Guests, OrderLine[] Lines)
        {
            public decimal Total => Lines.Sum(line => line.Amount);
        }

        private sealed record OrderLine(string Name, int Quantity, decimal UnitPrice)
        {
            public decimal Amount => Quantity * UnitPrice;
        }
    }
}
