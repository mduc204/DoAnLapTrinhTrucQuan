using System.Globalization;

using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan;

public partial class UcS02 : UserControl
{
    private sealed record Product(string Code, string Name, string Category, decimal Price, string Icon, bool Available = true);
    private static readonly Product[] Products =
    [
        new("CF01", "Cà phê đen phin", "Cà phê truyền thống", 29000, "☕"),
        new("CF02", "Cà phê sữa phin", "Cà phê truyền thống", 35000, "☕"),
        new("CF03", "Bạc xỉu Mộc đặc biệt", "Cà phê pha máy", 39000, "🥛"),
        new("CF04", "Cà phê trứng Hà Nội", "Cà phê truyền thống", 45000, "☕"),
        new("TE01", "Trà đào cam sả", "Trà trái cây", 42000, "🍑"),
        new("TE02", "Trà sen vàng", "Trà trái cây", 45000, "🍵"),
        new("CF05", "Espresso đúp", "Cà phê pha máy", 35000, "☕"),
        new("BK01", "Croissant bơ tỏi", "Bánh & ăn nhẹ", 32000, "🥐"),
        new("BK02", "Bánh phô mai", "Bánh & ăn nhẹ", 42000, "🍰", false),
        new("IC01", "Matcha đá xay", "Thức uống đá xay", 49000, "🍵")
    ];

    private readonly DiningTable _takeaway = new("Mang về", 0, Area.Indoor, TableState.Empty);
    private readonly Dictionary<DiningTable, Order> _drafts = [];
    private readonly List<Invoice> _payments = [];
    private readonly List<SalesRecord> _cancelled = [];
    internal IReadOnlyList<Invoice> Invoices => _payments;

    internal IEnumerable<SalesRecord> GetOrders(IEnumerable<DiningTable> tables)
    {
        foreach (var table in tables.Append(_takeaway))
            if (table.Order is { } order)
                yield return new SalesRecord(order, TableName(table), table, "Chưa thu");
        foreach (var invoice in _payments)
            yield return new SalesRecord(invoice.Order, invoice.Table, null, "Đã thanh toán");
        foreach (var record in _cancelled)
            yield return record;
    }

    internal void CancelOrder(SalesRecord record)
    {
        var table = record.ActiveTable;
        if (table is null || table.Order?.Code != record.Order.Code) return;
        _cancelled.Add(record with { ActiveTable = null, PaymentStatus = "Đã hủy", Cancelled = true });
        _drafts.Remove(table);
        table.Order = null;
        table.State = table == _takeaway ? TableState.Empty : TableState.Cleaning;
        table.Note = "Đơn đã hủy";
    }
    private DiningTable? _table;
    private int _nextNumber = 127;
    private bool _loading;
    internal event Action? ReturnRequested;
    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    internal string Cashier { get; set; } = "";

    public UcS02()
    {
        InitializeComponent();
        lstCategories.DrawItem += DrawCategory;
        lstCategories.Items.Add("Tất cả món");
        foreach (string category in Products.Select(product => product.Category).Distinct())
            lstCategories.Items.Add(category);
        lstCategories.SelectedIndex = 0;
        cboStock.Items.AddRange(["Tất cả trạng thái", "Còn bán", "Hết món"]);
        cboStock.SelectedIndex = 0;
        dgvCart.Columns.Add("colProduct", "Món / Pha chế");
        dgvCart.Columns.Add("colQuantity", "SL");
        dgvCart.Columns.Add("colAmount", "Thành tiền");
        dgvCart.Columns[0].FillWeight = 165;
        dgvCart.Columns[1].FillWeight = 38;
        dgvCart.RowTemplate.Height = 50;
        dgvCart.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        cboService.Format += (_, args) => { if (args.ListItem is DiningTable t) args.Value = TableName(t); };
        cboService.FormattingEnabled = true;
        cboService.SelectedIndexChanged += (_, _) =>
        {
            if (!_loading && cboService.SelectedItem is DiningTable t) LoadOrder(t);
        };
        lstCategories.SelectedIndexChanged += (_, _) => RenderProducts();
        cboStock.SelectedIndexChanged += (_, _) => RenderProducts();
        txtSearchProduct.TextChanged += (_, _) => RenderProducts();
        btnIncrease.Click += (_, _) => ChangeQuantity(1);
        btnDecrease.Click += (_, _) => ChangeQuantity(-1);
        btnRemoveItem.Click += (_, _) => ChangeQuantity(int.MinValue);
        btnApplyVoucher.Click += (_, _) => ApplyVoucher();
        btnSaveOrder.Click += (_, _) => SaveOrder();
        btnPayOrder.Click += (_, _) => PayOrder();
        btnDiscardChanges.Click += (_, _) =>
        {
            if (_table is null) return;
            var draft = _drafts[_table];
            _drafts[_table] = _table.Order ?? (draft with { Lines = [], Voucher = "" });
            RenderCart();
        };
        btnPrintEstimate.Click += (_, _) =>
        {
            if (_table is not null) DlgSalesReceipt.ShowReceipt(this, TableName(_table), _drafts[_table], null);
        };
        btnReturn.Click += (_, _) => ReturnRequested?.Invoke();
        RenderProducts();
    }

    private string TableName(DiningTable table) => table == _takeaway ? "Mang về" : $"Tại quán · Bàn {table.Id}";
    private static string Money(decimal value) => value.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";

    internal void OpenSale(IReadOnlyList<DiningTable> tables, DiningTable? requested)
    {
        var choices = tables.Where(t => t.State is TableState.Serving or TableState.Empty).Append(_takeaway).ToArray();
        _loading = true;
        cboService.Items.Clear();
        cboService.Items.AddRange(choices);
        var selected = requested ?? _table;
        if (selected is null || !choices.Contains(selected)) selected = choices[0];
        cboService.SelectedItem = selected;
        _loading = false;
        LoadOrder(selected);
    }

    private void LoadOrder(DiningTable table)
    {
        _table = table;
        if (!_drafts.ContainsKey(table))
            _drafts[table] = table.Order ?? new Order($"DH{_nextNumber++:000000}", DateTime.Now.ToString("HH:mm"), table == _takeaway ? 0 : 1, []);
        RenderCart();
    }

    private void DrawCategory(object? sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;
        bool selected = (e.State & DrawItemState.Selected) != 0;
        using var background = new SolidBrush(selected ? Color.FromArgb(60, 34, 25) : Color.Linen);
        e.Graphics.FillRectangle(background, e.Bounds);
        TextRenderer.DrawText(e.Graphics, lstCategories.Items[e.Index]?.ToString(), e.Font, Rectangle.Inflate(e.Bounds, -6, -2),
            selected ? Color.White : Color.SaddleBrown, TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter);
        e.DrawFocusRectangle();
    }

    private void RenderProducts()
    {
        flpProducts.SuspendLayout();
        while (flpProducts.Controls.Count > 0) flpProducts.Controls[0].Dispose();
        string query = txtSearchProduct.Text.Trim();
        foreach (var product in Products)
        {
            if (lstCategories.SelectedIndex > 0 && product.Category != lstCategories.Text) continue;
            if (cboStock.SelectedIndex == 1 && !product.Available || cboStock.SelectedIndex == 2 && product.Available) continue;
            if (!(product.Name + " " + product.Code).Contains(query, StringComparison.CurrentCultureIgnoreCase)) continue;

            var card = new Panel { Name = "pnlProduct_" + product.Code, Size = new Size(142, 143), BackColor = Color.White, Padding = new Padding(5) };
            var add = new Button
            {
                Name = "btnAddProduct_" + product.Code,
                Tag = product,
                Text = $"{Money(product.Price)}     ＋",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.SeaShell,
                Dock = DockStyle.Bottom,
                Height = 29,
                Enabled = product.Available
            };
            add.FlatAppearance.BorderSize = 0;
            var title = new Label { Text = product.Name, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var picture = new Label
            {
                Text = product.Icon,
                Font = new Font("Segoe UI Emoji", 23),
                BackColor = Color.FromArgb(247, 226, 203),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };
            var iconFont = picture.Font;
            picture.Disposed += (_, _) => iconFont.Dispose();
            var badge = new Label
            {
                Text = $"{product.Code}    ·    {(product.Available ? "Còn bán" : "Hết món")}",
                Height = 20,
                Dock = DockStyle.Top,
                ForeColor = product.Available ? Color.DarkGreen : Color.Firebrick
            };
            add.Click += (_, _) => AddProduct(product);
            card.Controls.AddRange([title, add, picture, badge]);
            flpProducts.Controls.Add(card);
        }
        if (flpProducts.Controls.Count == 0)
            flpProducts.Controls.Add(new Label { AutoSize = true, Text = "Không tìm thấy món phù hợp." });
        flpProducts.ResumeLayout();
    }

    private void AddProduct(Product product)
    {
        if (_table is null) return;
        var order = _drafts[_table];
        var lines = order.Lines.ToList();
        int index = lines.FindIndex(l => l.Name == product.Name && l.UnitPrice == product.Price);
        if (index < 0) lines.Add(new OrderLine(product.Name, 1, product.Price));
        else lines[index] = lines[index] with { Quantity = lines[index].Quantity + 1 };
        _drafts[_table] = order with { Lines = lines.ToArray() };
        RenderCart(index < 0 ? lines.Count - 1 : index);
    }

    private int SentQuantity(OrderLine line) => _table?.Order?.Lines
        .Where(l => l.Name == line.Name && l.UnitPrice == line.UnitPrice).Sum(l => l.Quantity) ?? 0;

    private void ChangeQuantity(int delta)
    {
        if (_table is null || dgvCart.CurrentRow is null) return;
        var order = _drafts[_table];
        int index = dgvCart.CurrentRow.Index;
        var lines = order.Lines.ToList();
        var line = lines[index];
        int quantity = Math.Max(SentQuantity(line), line.Quantity + delta);
        if (quantity == 0) lines.RemoveAt(index);
        else lines[index] = line with { Quantity = quantity };
        _drafts[_table] = order with { Lines = lines.ToArray() };
        RenderCart(index);
    }

    private void ApplyVoucher()
    {
        if (_table is null) return;
        string code = txtVoucher.Text.Trim().ToUpperInvariant();
        if (code != "" && code != "MOC10")
        {
            MessageBox.Show(this, "Mã chưa hợp lệ. MOC10 giảm 10%, tối đa 30.000 đ.");
            return;
        }
        _drafts[_table] = _drafts[_table] with { Voucher = code };
        RenderCart();
    }

    private void RenderCart(int selection = 0)
    {
        if (_table is null) return;
        var order = _drafts[_table];
        lblCart.Text = TableName(_table);
        lblOrderInfo.Text = $"{order.Code}     ·     Giờ vào {order.OpenedAt}";
        dgvCart.Rows.Clear();
        foreach (var line in order.Lines)
        {
            int sent = SentQuantity(line);
            string state = sent == 0 ? "Mới thêm" : sent == line.Quantity ? "Đã gửi bếp" : $"{sent} đã gửi · {line.Quantity - sent} mới";
            dgvCart.Rows.Add(line.Name + "\n" + state, line.Quantity, Money(line.Amount));
        }
        if (dgvCart.Rows.Count > 0)
            dgvCart.CurrentCell = dgvCart.Rows[Math.Min(selection, dgvCart.Rows.Count - 1)].Cells[0];
        txtVoucher.Text = order.Voucher;
        lblTotal.Text = $"Tạm tính {Money(order.Subtotal)}   ·   Giảm {Money(order.Discount)}\nTổng thanh toán    {Money(order.Total)}";
        btnPrintEstimate.Enabled = btnSaveOrder.Enabled = btnPayOrder.Enabled = order.Lines.Length > 0;
    }

    private void SaveOrder()
    {
        if (_table is null || _drafts[_table].Lines.Length == 0) return;
        _table.Order = _drafts[_table];
        _table.State = TableState.Serving;
        RenderCart();
    }

    internal void PayOrder()
    {
        if (_table is null || _drafts[_table].Lines.Length == 0) return;
        var order = _drafts[_table];
        using var payment = new DlgS04(TableName(_table), order);
        if (payment.ShowDialog(this) != DialogResult.OK) return;
        string tableName = TableName(_table);
        var invoice = new Invoice($"HD{_payments.Count + 1:000000}", order, tableName, payment.PaymentMethod, payment.Received, DateTime.Now, Cashier);
        _payments.Add(invoice);
        _drafts.Remove(_table);
        _table.Order = null;
        _table.State = _table == _takeaway ? TableState.Empty : TableState.Cleaning;
        _table.Note = "Khách vừa thanh toán";
        _table = null;
        if (payment.PrintReceipt)
            DlgSalesReceipt.ShowInvoice(this, invoice);
        ReturnRequested?.Invoke();
    }

    private void btnPayOrder_Click(object sender, EventArgs e)
    {

    }
}
