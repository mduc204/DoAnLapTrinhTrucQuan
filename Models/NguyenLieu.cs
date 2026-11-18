namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Nguyên vật liệu kho (M02, M03)
    /// </summary>
    public class NguyenLieu
    {
        public string MaNL { get; set; } = string.Empty;
        public string TenNL { get; set; } = string.Empty;
        public string DVT { get; set; } = "gram (g)";
        public decimal DonGiaNhap { get; set; } // Đơn giá theo ĐVT
        public decimal TonKhoHienTai { get; set; }
        public decimal DinhMucToiThieu { get; set; }
        public string ViTriKho { get; set; } = "Kho mát quầy Bar";
        public string TrangThaiTonKho
        {
            get
            {
                if (TonKhoHienTai <= 0) return "Hết hàng";
                if (TonKhoHienTai <= DinhMucToiThieu) return "Sắp hết";
                return "An toàn";
            }
        }
    }
}
