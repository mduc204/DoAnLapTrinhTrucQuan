using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan;

public partial class FrmMain
{
    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        var tables = new UcS01();
        var pos = new UcS02();
        var orders = new UcS03();
        var invoices = new UcS05();

        void ShowTables()
        {
            tables.RefreshOrders();
            LoadControl(tables);
        }

        void OpenSale(DiningTable? table, bool pay)
        {
            pos.Cashier = currentUsername;
            pos.OpenSale(tables.Tables, table);
            LoadControl(pos);
            if (pay) pos.PayOrder();
        }

        void ShowOrders()
        {
            orders.LoadOrders(pos.GetOrders(tables.Tables));
            LoadControl(orders);
        }

        tables.SaleRequested += OpenSale;
        pos.ReturnRequested += ShowTables;
        orders.SaleRequested += table => OpenSale(table, false);
        orders.CancelRequested += record =>
        {
            pos.CancelOrder(record);
            ShowOrders();
        };
        btnSodoban.Click += (_, _) => ShowTables();
        btnBanhang.Click += (_, _) => OpenSale(null, false);
        btnDonhang.Click += (_, _) => ShowOrders();
        btnHoadon.Click += (_, _) =>
        {
            invoices.LoadInvoices(pos.Invoices);
            LoadControl(invoices);
        };

        Disposed += (_, _) =>
        {
            tables.Dispose();
            pos.Dispose();
            orders.Dispose();
            invoices.Dispose();
        };
    }
}
