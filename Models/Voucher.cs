using System;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model đại diện cho Chương trình Khuyến mãi / Mã Voucher (Module M04)
    /// </summary>
    public class Voucher
    {
        public string MaVoucher { get; set; } = string.Empty;
        public string TenChuongTrinh { get; set; } = string.Empty;
        public string LichTrinhText { get; set; } = string.Empty;

        /// <summary>
        /// Cơ chế giảm giá: "PhanTram" (%) hoặc "TienMat" (VNĐ)
        /// </summary>
        public string LoaiGiamGia { get; set; } = "PhanTram";

        /// <summary>
        /// Mức giảm: ví dụ 10 (%) hoặc 20.000 (đ)
        /// </summary>
        public decimal GiaTriGiam { get; set; } = 10;

        /// <summary>
        /// Mức giảm tối đa (Trần) khi áp dụng theo % (0 nếu không giới hạn hoặc khi giảm tiền mặt)
        /// </summary>
        public decimal GiamToiDa { get; set; } = 30000;

        /// <summary>
        /// Giá trị đơn hàng tối thiểu để áp dụng voucher
        /// </summary>
        public decimal DonToiThieu { get; set; } = 100000;

        /// <summary>
        /// Phạm vi áp dụng: "Tất cả", "Tại quán", "Mang về"
        /// </summary>
        public string PhamVi { get; set; } = "Tất cả";

        public DateTime NgayBatDau { get; set; } = DateTime.Now;
        public DateTime NgayKetThuc { get; set; } = DateTime.Now.AddDays(30);

        /// <summary>
        /// Tổng số lượt phát hành (0 nghĩa là Không giới hạn)
        /// </summary>
        public int TongLuotPhatHanh { get; set; } = 200;

        /// <summary>
        /// Số lượt đã sử dụng
        /// </summary>
        public int DaDung { get; set; } = 68;

        /// <summary>
        /// Giới hạn lượt dùng trên mỗi hóa đơn (mặc định 1)
        /// </summary>
        public int GioiHanMoiHoaDon { get; set; } = 1;

        /// <summary>
        /// Trạng thái: "Đang hiệu lực", "Sắp diễn ra", "Hết lượt", "Tạm dừng"
        /// </summary>
        public string TrangThai { get; set; } = "Đang hiệu lực";

        /// <summary>
        /// Toggle kích hoạt bật/tắt
        /// </summary>
        public bool KichHoat { get; set; } = true;

        /// <summary>
        /// Ghi chú / Điều kiện áp dụng
        /// </summary>
        public string GhiChu { get; set; } = string.Empty;

        // Các thuộc tính tiện ích hiển thị lên DataGridView
        public string UuDaiDisplay => LoaiGiamGia == "PhanTram"
            ? (GiamToiDa > 0 ? $"Giảm {GiaTriGiam:0.##}% (Tối đa {GiamToiDa / 1000:0.##}k)" : $"Giảm {GiaTriGiam:0.##}%")
            : $"Giảm {GiaTriGiam:#,##0} đ";

        public string DieuKienDisplay => DonToiThieu > 0 ? $"Đơn từ {DonToiThieu:#,##0} đ" : "Không giới hạn đơn";

        public string LuotDungDisplay
        {
            get
            {
                if (TongLuotPhatHanh <= 0) return "Không giới hạn";
                double pt = Math.Round((double)DaDung / TongLuotPhatHanh * 100, 0);
                return $"{DaDung} / {TongLuotPhatHanh} ({pt}%)";
            }
        }

        public double PhanTramLuotDung => TongLuotPhatHanh <= 0 ? 0 : Math.Min(100.0, (double)DaDung / TongLuotPhatHanh * 100.0);
    }
}
