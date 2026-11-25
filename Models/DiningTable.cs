namespace DoAnLapTrinhTrucQuan.Models
{
    internal enum Area { Indoor, Garden, AirConditioned }
    internal enum TableState { Empty, Serving, Cleaning, Locked }

    internal sealed class DiningTable(
        string id, int seats, Area area, TableState state,
        string note = "Sẵn sàng đón khách", Order? order = null)
    {
        public string Id { get; } = id;
        public int Seats { get; } = seats;
        public Area Area { get; } = area;
        public TableState State { get; set; } = state;
        public string Note { get; set; } = note;
        public Order? Order { get; set; } = order;
    }

    internal sealed record Order(string Code, string OpenedAt, int Guests, OrderLine[] Lines, string Voucher = "")
    {
        public decimal Subtotal => Lines.Sum(line => line.Amount);
        public decimal Discount => Voucher == "MOC10" ? Math.Min(30_000m, Subtotal * 0.1m) : 0;
        public decimal Total => Subtotal - Discount;
    }

    internal sealed record OrderLine(string Name, int Quantity, decimal UnitPrice)
    {
        public decimal Amount => Quantity * UnitPrice;
    }
}
