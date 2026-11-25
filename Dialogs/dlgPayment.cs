using System.Globalization;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Dialogs;

public partial class dlgPayment : Form
{
    private decimal _due;
    private Button _method;

    public dlgPayment()
    {
        InitializeComponent();
        _method = btnCash;
        dgvBill.Columns.Add("colProduct", "Tên món");
        dgvBill.Columns.Add("colQuantity", "SL");
        dgvBill.Columns.Add("colPrice", "Đơn giá");
        dgvBill.Columns.Add("colAmount", "Thành tiền");
        dgvBill.Columns[0].FillWeight = 170;
        dgvBill.Columns[1].FillWeight = 42;
        foreach (Button method in tlpMethods.Controls)
            method.Click += (_, _) => SelectMethod(method);
        foreach (Button key in tlpKeypad.Controls)
            key.Click += (_, _) => EnterAmount(key);
        btnExact.Click += (_, _) => SetAmount(_due);
        btnTwoHundred.Click += (_, _) => SetAmount(200000);
        btnThreeHundred.Click += (_, _) => SetAmount(300000);
        btnFiveHundred.Click += (_, _) => SetAmount(500000);
        txtTender.TextChanged += (_, _) => UpdateChange();
        chkReceived.CheckedChanged += (_, _) => UpdateChange();
        btnConfirm.Click += (_, _) => { if (btnConfirm.Enabled) DialogResult = DialogResult.OK; };
    }

    internal dlgPayment(string tableName, Order order) : this()
    {
        _due = order.Total;
        lblTable.Text = tableName;
        lblOrder.Text = $"{order.Code}    ·    Giờ vào {order.OpenedAt}";
        foreach (var line in order.Lines)
            dgvBill.Rows.Add(line.Name, line.Quantity, Money(line.UnitPrice), Money(line.Amount));
        lblDue.Text = $"Tiền hàng   {Money(order.Subtotal)}    ·    Giảm   {Money(order.Discount)}\nKhách phải trả     {Money(_due)}";
        SelectMethod(btnCash);
    }

    internal bool PrintReceipt => chkPrintReceipt.Checked;
    internal string PaymentMethod => _method.Text;
    internal decimal Received => _method == btnCash ? ReadAmount() : _due;
    private static string Money(decimal value) => value.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
    private void SetAmount(decimal amount) => txtTender.Text = amount.ToString("0", CultureInfo.InvariantCulture);

    private decimal ReadAmount() =>
        decimal.TryParse(txtTender.Text, NumberStyles.None, CultureInfo.InvariantCulture, out decimal value) ? value : -1;

    private void SelectMethod(Button method)
    {
        _method = method;
        bool cash = method == btnCash;
        foreach (Button button in tlpMethods.Controls)
            button.BackColor = button == method ? Color.BurlyWood : Color.WhiteSmoke;
        txtTender.Enabled = tlpAmounts.Enabled = tlpKeypad.Enabled = cash;
        chkReceived.Visible = !cash;
        chkReceived.Checked = false;
        lblTender.Text = cash ? "Tiền khách đưa (đ)" : "Số tiền cần xác nhận (đ)";
        SetAmount(cash ? 0 : _due);
        UpdateChange();
    }

    private void EnterAmount(Button key)
    {
        var digits = txtTender.Text;
        if (key == btnBackspace)
            txtTender.Text = digits.Length > 1 ? digits[..^1] : "0";
        else if (digits.TrimStart('0').Length + key.Text.Length <= txtTender.MaxLength)
            txtTender.Text = digits.TrimStart('0') + key.Text;
    }

    private void UpdateChange()
    {
        decimal received = ReadAmount();
        bool cash = _method == btnCash;
        btnConfirm.Enabled = _due > 0 && (cash ? received >= _due : chkReceived.Checked);
        lblChange.BackColor = btnConfirm.Enabled ? Color.Honeydew : Color.SeaShell;
        lblChange.Text = !cash ? $"Thanh toán qua {_method.Text}: {Money(_due)}"
            : received < 0 ? "Nhập số tiền bằng chữ số."
            : received < _due ? $"Còn thiếu     {Money(_due - received)}"
            : $"Tiền thừa trả khách     {Money(received - _due)}";
    }
}
