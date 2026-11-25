using DoAnLapTrinhTrucQuan.Dialogs;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.UserControls.Sales;

public partial class ucOrders : UserControl
{
    private static readonly string[] Stages = ["Đã nhận", "Đang chuẩn bị", "Sẵn sàng", "Đã phục vụ"];
    private sealed record KitchenBatch(string Name, decimal Price, int Quantity, int Stage);
    private readonly Dictionary<string, List<KitchenBatch>> _batches = [];
    private SalesRecord[] _records = [];
    private bool _loading;
    internal event Action<DiningTable?>? SaleRequested;
    internal event Action<SalesRecord>? CancelRequested;

    public ucOrders()
    {
        InitializeComponent();
        foreach (var column in new[] { "Mã đơn", "Giờ vào", "Bàn / Kênh", "Tổng tiền", "Bếp / Bar", "Thanh toán" })
            dgvOrders.Columns.Add("col" + dgvOrders.Columns.Count, column);
        dgvItems.Columns.Add("colItem", "Tên món");
        dgvItems.Columns.Add("colQuantity", "SL");
        dgvItems.Columns.Add("colStage", "Tiến độ");
        dgvItems.Columns[1].FillWeight = 36;
        foreach (var grid in new[] { dgvOrders, dgvItems })
            foreach (DataGridViewColumn column in grid.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
        cboService.Items.AddRange(["Mọi hình thức", "Tại quán", "Mang về"]);
        cboPayment.Items.AddRange(["Mọi thanh toán", "Chưa thu", "Đã thanh toán", "Đã hủy"]);
        cboKitchen.Items.AddRange(["Mọi tiến độ", ..Stages]);
        foreach (var filter in new[] { cboService, cboPayment, cboKitchen })
        {
            filter.SelectedIndex = 0;
            filter.SelectedIndexChanged += (_, _) => RenderOrders();
        }
        txtSearch.TextChanged += (_, _) => RenderOrders();
        dgvOrders.SelectionChanged += (_, _) => { if (!_loading) RenderDetails(); };
        dgvItems.SelectionChanged += (_, _) => UpdateAction();
        btnRefresh.Click += (_, _) => RenderOrders();
        btnCreateOrder.Click += (_, _) => SaleRequested?.Invoke(null);
        btnAddItems.Click += (_, _) => { if (Selected?.ActiveTable is { } table) SaleRequested?.Invoke(table); };
        btnCancel.Click += (_, _) =>
        {
            if (Selected is { ActiveTable: not null } record &&
                MessageBox.Show(this, $"Hủy đơn {record.Order.Code}?", "Mộc Café", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CancelRequested?.Invoke(record);
        };
        btnAdvance.Click += (_, _) => AdvanceItem();
        btnPrintKitchen.Click += (_, _) =>
        {
            if (Selected is not { } record) return;
            var lines = _batches[record.Order.Code].Select(b => $"{b.Quantity} × {b.Name}    {Stages[b.Stage]}");
            dlgReceipt.ShowText(this, $"PHIẾU BẾP   {record.Order.Code}\n{record.Table}\n\n" + string.Join("\n", lines), "Danh sách bếp");
        };
    }

    private SalesRecord? Selected => dgvOrders.CurrentRow?.Tag as SalesRecord;

    internal void LoadOrders(IEnumerable<SalesRecord> records)
    {
        _records = records.OrderByDescending(record => record.Order.Code).ToArray();
        foreach (var record in _records)
        {
            if (!_batches.TryGetValue(record.Order.Code, out var batches))
                _batches[record.Order.Code] = batches = [];
            foreach (var line in record.Order.Lines)
            {
                int added = line.Quantity - batches.Where(b => b.Name == line.Name && b.Price == line.UnitPrice).Sum(b => b.Quantity);
                if (added > 0) batches.Add(new KitchenBatch(line.Name, line.UnitPrice, added, 0));
            }
        }
        RenderOrders();
    }

    private void RenderOrders()
    {
        string? selected = Selected?.Order.Code;
        _loading = true;
        dgvOrders.Rows.Clear();
        var visible = _records.Where(r =>
            (cboService.SelectedIndex <= 0 || (r.Table == "Mang về") == (cboService.SelectedIndex == 2)) &&
            (cboPayment.SelectedIndex <= 0 || r.PaymentStatus == cboPayment.Text) &&
            (cboKitchen.SelectedIndex <= 0 || !r.Cancelled && _batches[r.Order.Code].Any(b => b.Stage == cboKitchen.SelectedIndex - 1)) &&
            (r.Order.Code + " " + r.Table).Contains(txtSearch.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToArray();
        foreach (var r in visible)
        {
            var batches = _batches[r.Order.Code];
            string stage = r.Cancelled || batches.Count == 0 ? "—" : Stages[batches.Min(b => b.Stage)];
            var row = dgvOrders.Rows[dgvOrders.Rows.Add(r.Order.Code, r.Order.OpenedAt, r.Table, Invoice.Money(r.Order.Total), stage, r.PaymentStatus)];
            row.Tag = r;
            if (r.Order.Code == selected) dgvOrders.CurrentCell = row.Cells[0];
        }
        lblSummary.Text = $"{visible.Length} đơn    ·    Chưa thu {Invoice.Money(visible.Where(r => r.ActiveTable != null).Sum(r => r.Order.Total))}    ·    Chờ ra món {visible.Where(r => !r.Cancelled).Sum(r => _batches[r.Order.Code].Where(b => b.Stage == 2).Sum(b => b.Quantity))} phần";
        _loading = false;
        RenderDetails();
    }

    private void RenderDetails()
    {
        var record = Selected;
        dgvItems.Rows.Clear();
        lblDetail.Text = record == null ? "Không có đơn phù hợp" : $"{record.Order.Code}   ·   {record.Table}";
        btnAddItems.Enabled = btnCancel.Enabled = record?.ActiveTable != null;
        btnPrintKitchen.Enabled = record is { Cancelled: false };
        if (record != null)
            foreach (var batch in _batches[record.Order.Code])
                dgvItems.Rows[dgvItems.Rows.Add(batch.Name, batch.Quantity, record.Cancelled ? "Đã hủy" : Stages[batch.Stage])].Tag = batch;
        UpdateAction();
    }

    private void UpdateAction()
    {
        int stage = (dgvItems.CurrentRow?.Tag as KitchenBatch)?.Stage ?? 3;
        btnAdvance.Text = stage switch { 0 => "Bắt đầu chuẩn bị", 1 => "Sẵn sàng phục vụ", 2 => "Xác nhận đã phục vụ", _ => "Đã phục vụ" };
        btnAdvance.Enabled = Selected is { Cancelled: false } && stage < 3;
    }

    private void AdvanceItem()
    {
        if (Selected is not { Cancelled: false } record || dgvItems.CurrentRow?.Tag is not KitchenBatch batch || batch.Stage >= 3) return;
        var batches = _batches[record.Order.Code];
        int index = batches.IndexOf(batch);
        batches[index] = batch with { Stage = batch.Stage + 1 };
        RenderOrders();
        if (Selected?.Order.Code == record.Order.Code) dgvItems.CurrentCell = dgvItems.Rows[index].Cells[0];
    }
}
