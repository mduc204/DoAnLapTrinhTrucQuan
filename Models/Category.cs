namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Danh mục món (singular: Category, Table: Categories)
    /// </summary>
    public class Category
    {
        public string CategoryId { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int ProductCount { get; set; }

        public string MaDanhMuc { get => CategoryId; set => CategoryId = value; }
        public string TenDanhMuc { get => CategoryName; set => CategoryName = value; }
        public int SoLuongMon { get => ProductCount; set => ProductCount = value; }
    }
}
