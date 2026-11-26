using DoAnLapTrinhTrucQuan.Forms;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.Dialogs
{
    /// <summary>
    /// Wrapper alias cho frmPhieuKhoPopup theo quy ước Dialogs: dlg
    /// </summary>
    public class dlgPhieuKhoPopup : frmPhieuKhoPopup
    {
        public dlgPhieuKhoPopup(Ingredient ingredient, bool isImport, string currentUser = "Nguyễn Văn Hưng")
            : base(ingredient, isImport, currentUser)
        {
        }
    }
}
