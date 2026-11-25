using System.Globalization;
using System.IO.Compression;
using System.Xml.Linq;
using DoAnLapTrinhTrucQuan.Models;
using DoAnLapTrinhTrucQuan.Dialogs;

namespace DoAnLapTrinhTrucQuan.UserControls.Sales;

public partial class ucInvoices : UserControl
{
    private IReadOnlyList<Invoice> _invoices = [];
    private Invoice[] _visible = [];
    private static readonly string[] Headers = ["Mã HĐ", "Mã đơn", "Giờ xuất", "Vị trí / Kênh", "Thu ngân", "Phương thức", "Tổng tiền"];

    public ucInvoices()
    {
        InitializeComponent();
        foreach (string header in Headers) dgvInvoices.Columns.Add("col" + dgvInvoices.Columns.Count, header);
        cboService.Items.AddRange(["Mọi hình thức", "Tại quán", "Mang về"]);
        cboMethod.Items.AddRange(["Mọi phương thức", "Tiền mặt", "Chuyển khoản", "Thẻ POS"]);
        cboMethod.SelectedIndex = cboService.SelectedIndex = 0;
        dtpFrom.AccessibleName = "Từ ngày";
        dtpTo.AccessibleName = "Đến ngày";
        dtpFrom.Value = dtpTo.Value = DateTime.Today;
        dtpFrom.ValueChanged += (_, _) => RenderInvoices();
        dtpTo.ValueChanged += (_, _) => RenderInvoices();
        cboMethod.SelectedIndexChanged += (_, _) => RenderInvoices();
        cboService.SelectedIndexChanged += (_, _) => RenderInvoices();
        txtSearch.TextChanged += (_, _) => RenderInvoices();
        btnRefresh.Click += (_, _) => RenderInvoices();
        dgvInvoices.SelectionChanged += (_, _) => RenderPreview();
        btnPrint.Click += (_, _) =>
        {
            if (dgvInvoices.CurrentRow?.Tag is Invoice invoice) dlgReceipt.ShowInvoice(this, invoice);
        };
        btnExportExcel.Click += (_, _) => ExportInvoices();
    }

    internal void LoadInvoices(IReadOnlyList<Invoice> invoices)
    {
        _invoices = invoices;
        RenderInvoices();
    }

    private void RenderInvoices()
    {
        string? selected = (dgvInvoices.CurrentRow?.Tag as Invoice)?.Code;
        string query = txtSearch.Text.Trim();
        _visible = _invoices.Where(i =>
            i.PaidAt.Date >= dtpFrom.Value.Date && i.PaidAt.Date <= dtpTo.Value.Date &&
            (cboMethod.SelectedIndex <= 0 || cboMethod.Text == i.Method) &&
            (cboService.SelectedIndex <= 0 || (i.Table == "Mang về") == (cboService.SelectedIndex == 2)) &&
            $"{i.Code} {i.Order.Code} {i.Table} {i.Cashier}".Contains(query, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(i => i.PaidAt).ToArray();
        dgvInvoices.Rows.Clear();
        foreach (var i in _visible)
        {
            var row = dgvInvoices.Rows[dgvInvoices.Rows.Add(i.Code, i.Order.Code, i.PaidAt.ToString("HH:mm:ss"), i.Table, i.Cashier, i.Method, Invoice.Money(i.Order.Total))];
            row.Tag = i;
            if (i.Code == selected) dgvInvoices.CurrentCell = row.Cells[0];
        }
        lblSummary.Text = dtpFrom.Value.Date > dtpTo.Value.Date ? "Ngày kết thúc phải từ ngày bắt đầu trở đi." :
            $"{_visible.Length} hóa đơn    ·    Doanh thu {Invoice.Money(_visible.Sum(i => i.Order.Total))}";
        btnExportExcel.Enabled = _visible.Length > 0;
        RenderPreview();
    }

    private void RenderPreview()
    {
        var invoice = dgvInvoices.CurrentRow?.Tag as Invoice;
        txtReceipt.Text = invoice == null ? "Chưa có hóa đơn phù hợp." : dlgReceipt.FormatInvoice(invoice);
        lblDetail.Text = invoice == null ? "Phiếu thanh toán" : "Phiếu thanh toán   ·   " + invoice.Code;
        btnPrint.Enabled = invoice != null;
    }

    private void ExportInvoices()
    {
        using var dialog = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx", FileName = $"HoaDon_{DateTime.Today:yyyyMMdd}.xlsx" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            SaveWorkbook(dialog.FileName, _visible);
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MessageBox.Show(this, ex.Message, "Xuất hóa đơn");
        }
    }

    internal static void SaveWorkbook(string path, IEnumerable<Invoice> invoices)
    {
        XNamespace sheet = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
        XNamespace rel = "http://schemas.openxmlformats.org/package/2006/relationships";
        XNamespace doc = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";
        XNamespace types = "http://schemas.openxmlformats.org/package/2006/content-types";
        XElement TextCell(string value) => new(sheet + "c", new XAttribute("t", "inlineStr"), new XElement(sheet + "is", new XElement(sheet + "t", value)));
        var rows = new XElement(sheet + "sheetData", new XElement(sheet + "row", Headers.Select(TextCell)));
        foreach (var invoice in invoices)
            rows.Add(new XElement(sheet + "row", new[] { invoice.Code, invoice.Order.Code, invoice.PaidAt.ToString("dd/MM/yyyy HH:mm:ss"), invoice.Table, invoice.Cashier, invoice.Method }.Select(TextCell),
                new XElement(sheet + "c", new XElement(sheet + "v", invoice.Order.Total.ToString(CultureInfo.InvariantCulture)))));
        using var buffer = new MemoryStream();
        using (var zip = new ZipArchive(buffer, ZipArchiveMode.Create, true))
        {
            void Add(string name, XElement xml)
            {
                using var stream = zip.CreateEntry(name).Open();
                xml.Save(stream);
            }
            XElement Relation(string type, string target) => new(rel + "Relationship", new XAttribute("Id", "rId1"), new XAttribute("Type", doc.NamespaceName + "/" + type), new XAttribute("Target", target));
            Add("[Content_Types].xml", new XElement(types + "Types",
                new XElement(types + "Default", new XAttribute("Extension", "rels"), new XAttribute("ContentType", "application/vnd.openxmlformats-package.relationships+xml")),
                new XElement(types + "Override", new XAttribute("PartName", "/xl/workbook.xml"), new XAttribute("ContentType", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml")),
                new XElement(types + "Override", new XAttribute("PartName", "/xl/worksheets/sheet1.xml"), new XAttribute("ContentType", "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml"))));
            Add("_rels/.rels", new XElement(rel + "Relationships", Relation("officeDocument", "xl/workbook.xml")));
            Add("xl/workbook.xml", new XElement(sheet + "workbook", new XElement(sheet + "sheets", new XElement(sheet + "sheet", new XAttribute("name", "Hóa đơn"), new XAttribute("sheetId", 1), new XAttribute(doc + "id", "rId1")))));
            Add("xl/_rels/workbook.xml.rels", new XElement(rel + "Relationships", Relation("worksheet", "worksheets/sheet1.xml")));
            Add("xl/worksheets/sheet1.xml", new XElement(sheet + "worksheet", new XElement(sheet + "cols", new XElement(sheet + "col", new XAttribute("min", 1), new XAttribute("max", 7), new XAttribute("width", 23), new XAttribute("customWidth", 1))), rows));
        }
        File.WriteAllBytes(path, buffer.ToArray());
    }
}
