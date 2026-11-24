using System;
using System.Collections.Generic;
using System.Linq;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.DAL
{
    /// <summary>
    /// Data Access Layer cho Quản lý Nguyên vật liệu & Kho (InventoryDAL)
    /// </summary>
    public class InventoryDAL
    {
        public List<Ingredient> GetAll()
        {
            return MockDataService.Instance.LayTatCaNguyenLieu();
        }

        public Ingredient? GetById(string id)
        {
            return MockDataService.Instance.DanhSachNguyenLieu
                .FirstOrDefault(x => x.IngredientId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public bool Update(Ingredient ingredient)
        {
            MockDataService.Instance.CapNhatNguyenLieu(ingredient);
            return true;
        }

        public List<InventoryTransaction> GetHistory(string ingredientId)
        {
            return MockDataService.Instance.LayLichSuTheoMaNL(ingredientId);
        }

        public void ImportStock(string id, decimal quantity, decimal price, string note, string performedBy)
        {
            MockDataService.Instance.GhiNhanNhapKho(id, quantity, price, note, performedBy);
        }

        public void ExportStock(string id, decimal quantity, string reason, string performedBy, string note = "")
        {
            MockDataService.Instance.GhiNhanXuatKho(id, quantity, reason, performedBy, note);
        }

        public bool ToggleActive(string id)
        {
            var item = GetById(id);
            if (item != null)
            {
                item.IsActive = !item.IsActive;
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// Alias tương thích ngược tiếng Việt
    /// </summary>
    public class NguyenLieuDAL : InventoryDAL
    {
    }
}
