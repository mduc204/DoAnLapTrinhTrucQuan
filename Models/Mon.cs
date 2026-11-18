using System;
using System.Drawing;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Thực đơn Món ăn / Đồ uống (M01)
    /// </summary>
    public class Mon
    {
        public string MaMon { get; set; } = string.Empty;
        public string TenMon { get; set; } = string.Empty;
        public string MaDanhMuc { get; set; } = string.Empty;
        public string TenDanhMuc { get; set; } = string.Empty;
        public decimal GiaBan { get; set; }
        public decimal GiaVonBOM { get; set; }
        public string MoTa { get; set; } = string.Empty;
        public string TrangThai { get; set; } = "Đang bán"; // "Đang bán" hoặc "Tạm ngưng"
        public bool CoDinhLuong { get; set; } = true;
        public Image? HinhAnh { get; set; }
        public string HinhAnhPath { get; set; } = string.Empty;

        /// <summary>
        /// Tỷ lệ lợi nhuận gộp tính theo % = ((Giá bán - Giá vốn) / Giá bán) * 100
        /// </summary>
        public int TyLeLai
        {
            get
            {
                if (GiaBan <= 0) return 0;
                decimal lai = ((GiaBan - GiaVonBOM) / GiaBan) * 100m;
                return (int)Math.Round(lai);
            }
        }
    }
}
