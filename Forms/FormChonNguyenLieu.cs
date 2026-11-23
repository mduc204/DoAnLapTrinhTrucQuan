using DoAnLapTrinhTrucQuan.Dialogs;

namespace DoAnLapTrinhTrucQuan.Forms
{
    /// <summary>
    /// Wrapper tương thích ngược cho Dialog dlgSelectIngredient theo quy ước tiền tố dlg
    /// </summary>
    public partial class FormChonNguyenLieu : dlgSelectIngredient
    {
        public FormChonNguyenLieu(string maMonHienTai = "") : base(maMonHienTai)
        {
        }
    }
}
