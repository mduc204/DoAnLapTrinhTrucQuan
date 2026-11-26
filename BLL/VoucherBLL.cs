using System;
using System.Collections.Generic;
using System.Linq;
using DoAnLapTrinhTrucQuan.DAL;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.BLL
{
    /// <summary>
    /// Business Logic Layer cho Quản lý Voucher / Khuyến mãi (VoucherBLL)
    /// </summary>
    public class VoucherBLL
    {
        private readonly VoucherDAL _voucherDAL;

        public VoucherBLL()
        {
            _voucherDAL = new VoucherDAL();
        }

        public List<Voucher> LoadVouchers()
        {
            return _voucherDAL.GetAll();
        }

        public Voucher? GetVoucherByCode(string voucherCode)
        {
            if (string.IsNullOrWhiteSpace(voucherCode)) return null;
            return _voucherDAL.GetByCode(voucherCode);
        }

        public bool SaveVoucher(Voucher voucher, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(voucher.VoucherCode))
            {
                errorMessage = "Mã voucher không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(voucher.ProgramName))
            {
                errorMessage = "Tên chương trình khuyến mãi không được để trống!";
                return false;
            }

            if (voucher.DiscountValue <= 0)
            {
                errorMessage = "Mức giảm giá phải lớn hơn 0!";
                return false;
            }

            if (voucher.EndDate < voucher.StartDate)
            {
                errorMessage = "Thời gian kết thúc phải sau thời gian bắt đầu!";
                return false;
            }

            var existing = _voucherDAL.GetByCode(voucher.VoucherCode);
            if (existing != null)
            {
                return _voucherDAL.Update(voucher);
            }
            else
            {
                return _voucherDAL.Insert(voucher);
            }
        }

        public bool ToggleVoucherStatus(string voucherCode)
        {
            var voucher = _voucherDAL.GetByCode(voucherCode);
            if (voucher == null) return false;

            if (voucher.Status == "Tạm dừng")
            {
                voucher.Status = "Đang hiệu lực";
                voucher.IsActive = true;
            }
            else
            {
                voucher.Status = "Tạm dừng";
                voucher.IsActive = false;
            }

            return _voucherDAL.Update(voucher);
        }

        public bool DeleteVoucher(string voucherCode)
        {
            return _voucherDAL.Delete(voucherCode);
        }
    }
}
