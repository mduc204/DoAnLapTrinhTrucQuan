using System.Collections.Generic;
using System.Linq;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.DAL
{
    /// <summary>
    /// Data Access Layer cho Quản lý Voucher / Khuyến mãi (VoucherDAL)
    /// </summary>
    public class VoucherDAL
    {
        public List<Voucher> GetAll()
        {
            return MockDataService.Instance.DanhSachVoucher;
        }

        public Voucher? GetByCode(string voucherCode)
        {
            return MockDataService.Instance.DanhSachVoucher.FirstOrDefault(v => v.VoucherCode == voucherCode);
        }

        public bool Insert(Voucher voucher)
        {
            if (MockDataService.Instance.DanhSachVoucher.Any(v => v.VoucherCode == voucher.VoucherCode))
            {
                return false;
            }
            MockDataService.Instance.DanhSachVoucher.Insert(0, voucher);
            return true;
        }

        public bool Update(Voucher voucher)
        {
            var existing = MockDataService.Instance.DanhSachVoucher.FirstOrDefault(v => v.VoucherCode == voucher.VoucherCode);
            if (existing == null) return false;

            existing.ProgramName = voucher.ProgramName;
            existing.DiscountType = voucher.DiscountType;
            existing.DiscountValue = voucher.DiscountValue;
            existing.MaxDiscount = voucher.MaxDiscount;
            existing.MinOrder = voucher.MinOrder;
            existing.Scope = voucher.Scope;
            existing.StartDate = voucher.StartDate;
            existing.EndDate = voucher.EndDate;
            existing.TotalUsage = voucher.TotalUsage;
            existing.UsedCount = voucher.UsedCount;
            existing.LimitPerOrder = voucher.LimitPerOrder;
            existing.Status = voucher.Status;
            existing.IsActive = voucher.IsActive;
            existing.Note = voucher.Note;

            return true;
        }

        public bool Delete(string voucherCode)
        {
            var existing = MockDataService.Instance.DanhSachVoucher.FirstOrDefault(v => v.VoucherCode == voucherCode);
            if (existing != null)
            {
                return MockDataService.Instance.DanhSachVoucher.Remove(existing);
            }
            return false;
        }
    }
}
