using System;
using System.Globalization;

namespace DoAnLapTrinhTrucQuan.Helpers
{
    /// <summary>
    /// Định dạng tiền tệ, số lượng và ngày tháng chuẩn hóa
    /// </summary>
    public static class FormatHelper
    {
        private static readonly CultureInfo VnCulture = new CultureInfo("vi-VN");

        public static string FormatVND(decimal amount)
        {
            return $"{amount:#,##0} đ";
        }

        public static string FormatNumber(decimal number)
        {
            return number.ToString("#,##0", VnCulture);
        }

        public static string FormatDecimal(decimal number, int decimals = 2)
        {
            return number.ToString($"N{decimals}", VnCulture);
        }

        public static string FormatDate(DateTime date, string format = "dd/MM/yyyy HH:mm")
        {
            return date.ToString(format, VnCulture);
        }

        public static string FormatShortDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy", VnCulture);
        }
    }
}
