using System;

namespace DoAnLapTrinhTrucQuan.Models
{
    /// <summary>
    /// Model Chương trình Khuyến mãi / Voucher (singular: Voucher, Table: Vouchers)
    /// </summary>
    public class Voucher
    {
        public string VoucherCode { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public string ScheduleText { get; set; } = string.Empty;
        public string DiscountType { get; set; } = "PhanTram"; // "PhanTram" (%) hoặc "TienMat" (VNĐ)
        public decimal DiscountValue { get; set; } = 10;
        public decimal MaxDiscount { get; set; } = 30000;
        public decimal MinOrder { get; set; } = 100000;
        public string Scope { get; set; } = "Tất cả";
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(30);
        public int TotalUsage { get; set; } = 200;
        public int UsedCount { get; set; } = 68;
        public int LimitPerOrder { get; set; } = 1;
        public string Status { get; set; } = "Đang hiệu lực";
        public bool IsActive { get; set; } = true;
        public string Note { get; set; } = string.Empty;

        // Tương thích ngược với các tên biến tiếng Việt cũ
        public string MaVoucher { get => VoucherCode; set => VoucherCode = value; }
        public string TenChuongTrinh { get => ProgramName; set => ProgramName = value; }
        public string LichTrinhText { get => ScheduleText; set => ScheduleText = value; }
        public string LoaiGiamGia { get => DiscountType; set => DiscountType = value; }
        public decimal GiaTriGiam { get => DiscountValue; set => DiscountValue = value; }
        public decimal GiamToiDa { get => MaxDiscount; set => MaxDiscount = value; }
        public decimal DonToiThieu { get => MinOrder; set => MinOrder = value; }
        public string PhamVi { get => Scope; set => Scope = value; }
        public DateTime NgayBatDau { get => StartDate; set => StartDate = value; }
        public DateTime NgayKetThuc { get => EndDate; set => EndDate = value; }
        public int TongLuotPhatHanh { get => TotalUsage; set => TotalUsage = value; }
        public int DaDung { get => UsedCount; set => UsedCount = value; }
        public int GioiHanMoiHoaDon { get => LimitPerOrder; set => LimitPerOrder = value; }
        public string TrangThai { get => Status; set => Status = value; }
        public bool KichHoat { get => IsActive; set => IsActive = value; }
        public string GhiChu { get => Note; set => Note = value; }

        // Các thuộc tính tiện ích hiển thị lên DataGridView
        public string UuDaiDisplay => DiscountType == "PhanTram"
            ? (MaxDiscount > 0 ? $"Giảm {DiscountValue:0.##}% (Tối đa {MaxDiscount / 1000:0.##}k)" : $"Giảm {DiscountValue:0.##}%")
            : $"Giảm {DiscountValue:#,##0} đ";

        public string DieuKienDisplay => MinOrder > 0 ? $"Đơn từ {MinOrder:#,##0} đ" : "Không giới hạn đơn";

        public string LuotDungDisplay
        {
            get
            {
                if (TotalUsage <= 0) return "Không giới hạn";
                double pt = Math.Round((double)UsedCount / TotalUsage * 100, 0);
                return $"{UsedCount} / {TotalUsage} ({pt}%)";
            }
        }

        public double PhanTramLuotDung => TotalUsage <= 0 ? 0 : Math.Min(100.0, (double)UsedCount / TotalUsage * 100.0);
    }
}
