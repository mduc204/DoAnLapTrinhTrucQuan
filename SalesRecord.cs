using System.Globalization;

namespace DoAnLapTrinhTrucQuan.Models;

internal sealed record Invoice(string Code, Order Order, string Table, string Method, decimal Received, DateTime PaidAt, string Cashier)
{
    internal static string Money(decimal amount) => amount.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
}

internal sealed record SalesRecord(Order Order, string Table, DiningTable? ActiveTable, string PaymentStatus, bool Cancelled = false);
