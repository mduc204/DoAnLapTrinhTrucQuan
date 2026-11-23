using System;
using System.Drawing;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Sản phẩm / Món ăn / Đồ uống (singular: Product, Table: Products)
    /// </summary>
    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Đang bán";
        public bool HasRecipe { get; set; } = true;
        public Image? Image { get; set; }
        public string ImagePath { get; set; } = string.Empty;

        // Các thuộc tính tiếng Việt ánh xạ tương thích 100% với code cũ
        public string MaMon { get => ProductId; set => ProductId = value; }
        public string TenMon { get => ProductName; set => ProductName = value; }
        public string MaDanhMuc { get => CategoryId; set => CategoryId = value; }
        public string TenDanhMuc { get => CategoryName; set => CategoryName = value; }
        public decimal GiaBan { get => Price; set => Price = value; }
        public decimal GiaVonBOM { get => CostPrice; set => CostPrice = value; }
        public string MoTa { get => Description; set => Description = value; }
        public string TrangThai { get => Status; set => Status = value; }
        public bool CoDinhLuong { get => HasRecipe; set => HasRecipe = value; }
        public Image? HinhAnh { get => Image; set => Image = value; }
        public string HinhAnhPath { get => ImagePath; set => ImagePath = value; }

        public int ProfitMargin
        {
            get
            {
                if (Price <= 0) return 0;
                decimal profit = ((Price - CostPrice) / Price) * 100m;
                return (int)Math.Round(profit);
            }
        }

        public int TyLeLai => ProfitMargin;
    }
}
