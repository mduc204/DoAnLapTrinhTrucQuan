using System;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Định lượng công thức pha chế (BOM - Bill of Materials)
    /// </summary>
    public class DinhLuongBOM
    {
        public string MaMon { get; set; } = string.Empty;
        public string MaNL { get; set; } = string.Empty;
        public string TenNL { get; set; } = string.Empty;
        public string ViTriKho { get; set; } = string.Empty;
        public decimal DinhLuong { get; set; }
        public string DVT { get; set; } = "gram (g)";
        public decimal DonGiaQuyDoi { get; set; } // Giá vốn của 1 đơn vị

        /// <summary>
        /// Thành tiền = Định lượng * Đơn giá quy đổi
        /// </summary>
        public decimal ThanhTienGiaVon
        {
            get => Math.Round(DinhLuong * DonGiaQuyDoi, 0);
        }
    }
}
