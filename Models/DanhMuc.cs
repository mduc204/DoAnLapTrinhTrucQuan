namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Danh mục món
    /// </summary>
    public class DanhMuc
    {
        public string MaDanhMuc { get; set; } = string.Empty;
        public string TenDanhMuc { get; set; } = string.Empty;
        public int SoLuongMon { get; set; }
    }
}
