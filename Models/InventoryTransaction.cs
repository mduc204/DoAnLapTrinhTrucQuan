using System;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Lịch sử nhập / xuất kho (Thẻ kho)
    /// </summary>
    public class InventoryTransaction
    {
        public string TransactionId { get; set; } = string.Empty;
        public string IngredientId { get; set; } = string.Empty;
        public DateTime TransactionTime { get; set; } = DateTime.Now;
        public string DisplayTime { get; set; } = string.Empty;
        public string TransactionType { get; set; } = "Nhập kho"; // Bán hàng, Xuất hủy (ẩm mốc), Nhập kho, Xuất quầy pha chế...
        public decimal Quantity { get; set; } // +1500 or -40
        public decimal BalanceAfter { get; set; } // 1200
        public string PerformedBy { get; set; } = "Nguyễn Văn Hưng";
        public string Note { get; set; } = string.Empty;

        // Tương thích ngược tiếng Việt
        public string MaPhieu { get => TransactionId; set => TransactionId = value; }
        public string MaNL { get => IngredientId; set => IngredientId = value; }
        public DateTime ThoiGian { get => TransactionTime; set => TransactionTime = value; }
        public string ThoiGianHienThi { get => DisplayTime; set => DisplayTime = value; }
        public string LoaiPhieu { get => TransactionType; set => TransactionType = value; }
        public decimal SoLuong { get => Quantity; set => Quantity = value; }
        public decimal TonSau { get => BalanceAfter; set => BalanceAfter = value; }
        public string NguoiThucHien { get => PerformedBy; set => PerformedBy = value; }
        public string GhiChu { get => Note; set => Note = value; }
    }

    /// <summary>
    /// Alias tiếng Việt tương thích ngược
    /// </summary>
    public class LichSuKho : InventoryTransaction
    {
    }
}
