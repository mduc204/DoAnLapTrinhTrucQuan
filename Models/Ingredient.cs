namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Nguyên vật liệu kho (singular: Ingredient, Table: Ingredients)
    /// </summary>
    public class Ingredient
    {
        public string IngredientId { get; set; } = string.Empty;
        public string IngredientName { get; set; } = string.Empty;
        public string GroupName { get; set; } = "Cà phê";
        public string Unit { get; set; } = "gram (g)";
        public decimal ImportPrice { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal MinStock { get; set; }
        public string WarehouseLocation { get; set; } = "Kho mát quầy Bar";
        public bool IsActive { get; set; } = true;

        public string StockStatus
        {
            get
            {
                if (!IsActive) return "Ngừng sử dụng";
                if (StockQuantity <= 0) return "Hết hàng";
                if (StockQuantity <= MinStock) return "Sắp hết";
                return "An toàn";
            }
        }

        // Tương thích ngược với NguyenLieu
        public string MaNL { get => IngredientId; set => IngredientId = value; }
        public string TenNL { get => IngredientName; set => IngredientName = value; }
        public string NhomNL { get => GroupName; set => GroupName = value; }
        public string DVT { get => Unit; set => Unit = value; }
        public decimal DonGiaNhap { get => ImportPrice; set => ImportPrice = value; }
        public decimal TonKhoHienTai { get => StockQuantity; set => StockQuantity = value; }
        public decimal DinhMucToiThieu { get => MinStock; set => MinStock = value; }
        public string ViTriKho { get => WarehouseLocation; set => WarehouseLocation = value; }
        public bool DangSuDung { get => IsActive; set => IsActive = value; }
        public string TrangThaiTonKho => StockStatus;
    }
}
