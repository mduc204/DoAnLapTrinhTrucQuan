using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Dialogs;

internal sealed class dlgReceipt : Form
{
    private dlgReceipt(string receipt, string title)
    {
        Text = title;
        StartPosition = FormStartPosition.CenterParent;
        ClientSize = new Size(470, 530);
        var txtReceipt = new RichTextBox { Name = "txtReceipt", Dock = DockStyle.Fill, Text = receipt, ReadOnly = true, BackColor = Color.White };
        var btnPrint = new Button { Name = "btnPrint", Text = "In phiếu…", Dock = DockStyle.Bottom, Height = 40 };
        btnPrint.Click += (_, _) => PrintReceipt(receipt);
        Controls.Add(txtReceipt);
        Controls.Add(btnPrint);
    }

    internal static void ShowReceipt(IWin32Window owner, string table, Order order, string? method, decimal received = 0)
    {
        ShowText(owner, FormatReceipt(table, order, method, received), method is null ? "Phiếu tạm tính" : "Phiếu thanh toán");
    }

    internal static void ShowInvoice(IWin32Window owner, Invoice invoice) =>
        ShowText(owner, FormatInvoice(invoice), "Phiếu thanh toán");

    internal static string FormatInvoice(Invoice invoice) =>
        FormatReceipt(invoice.Table, invoice.Order, invoice.Method, invoice.Received, invoice);

    internal static void ShowText(IWin32Window owner, string receipt, string title)
    {
        using var dialog = new dlgReceipt(receipt, title);
        dialog.ShowDialog(owner);
    }

    private static string FormatReceipt(string table, Order order, string? method, decimal received, Invoice? invoice = null)
    {
        static string Money(decimal value) => value.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        string title = method is null ? "Phiếu tạm tính" : "Phiếu thanh toán";
        var text = new StringBuilder().AppendLine("MỘC CAFÉ").AppendLine(title.ToUpperInvariant())
            .AppendLine($"{order.Code}   ·   {table}").AppendLine();
        if (invoice is not null)
            text.AppendLine($"Số hóa đơn: {invoice.Code}").AppendLine($"Ngày giờ: {invoice.PaidAt:dd/MM/yyyy HH:mm:ss}")
                .AppendLine($"Thu ngân: {invoice.Cashier}").AppendLine();
        foreach (var line in order.Lines)
            text.AppendLine(line.Name).AppendLine($"  {line.Quantity} × {Money(line.UnitPrice)}     {Money(line.Amount)}");
        text.AppendLine().AppendLine($"Tiền hàng: {Money(order.Subtotal)}");
        if (order.Discount > 0) text.AppendLine($"{order.Voucher}: −{Money(order.Discount)}");
        text.AppendLine($"Tổng cộng: {Money(order.Total)}");
        if (method is not null)
            text.AppendLine($"{method}: {Money(received)}").AppendLine($"Tiền trả lại: {Money(received - order.Total)}");
        return text.ToString();
    }

    private void PrintReceipt(string receipt)
    {
        using var document = new PrintDocument { DocumentName = Text };
        using var dialog = new PrintDialog { Document = document, UseEXDialog = true };
        using var font = new Font("Segoe UI", 10);
        int offset = 0;
        document.PrintPage += (sender, e) =>
        {
            var graphics = e.Graphics!;
            string remaining = receipt[offset..];
            graphics.MeasureString(remaining, font, e.MarginBounds.Size, StringFormat.GenericDefault, out int count, out _);
            if (count == 0) { e.Cancel = true; return; }
            graphics.DrawString(remaining[..count], font, Brushes.Black, e.MarginBounds);
            offset += count;
            e.HasMorePages = offset < receipt.Length;
        };
        try
        {
            if (dialog.ShowDialog(this) == DialogResult.OK) document.Print();
        }
        catch (System.ComponentModel.Win32Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Máy in");
        }
        catch (InvalidPrinterException ex)
        {
            MessageBox.Show(this, ex.Message, "Máy in");
        }
    }
}
