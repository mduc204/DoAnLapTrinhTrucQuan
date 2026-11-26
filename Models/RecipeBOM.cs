using System;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Định lượng công thức pha chế (singular: RecipeBOM, Table: RecipeBOMs)
    /// </summary>
    public class RecipeBOM
    {
        public string ProductId { get; set; } = string.Empty;
        public string IngredientId { get; set; } = string.Empty;
        public string IngredientName { get; set; } = string.Empty;
        public string WarehouseLocation { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public string Unit { get; set; } = "gram (g)";
        public decimal UnitPrice { get; set; }

        public decimal CostPrice => Math.Round(Quantity * UnitPrice, 0);

        // Tương thích ngược với DinhLuongBOM
        public string MaMon { get => ProductId; set => ProductId = value; }
        public string MaNL { get => IngredientId; set => IngredientId = value; }
        public string TenNL { get => IngredientName; set => IngredientName = value; }
        public string ViTriKho { get => WarehouseLocation; set => WarehouseLocation = value; }
        public decimal DinhLuong { get => Quantity; set => Quantity = value; }
        public string DVT { get => Unit; set => Unit = value; }
        public decimal DonGiaQuyDoi { get => UnitPrice; set => UnitPrice = value; }
        public decimal ThanhTienGiaVon => CostPrice;
    }
}
