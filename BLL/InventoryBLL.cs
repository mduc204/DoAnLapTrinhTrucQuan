using System;
using System.Collections.Generic;
using System.Linq;
using DoAnLapTrinhTrucQuan.DAL;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.BLL
{
    /// <summary>
    /// Business Logic Layer cho Quản lý Nguyên vật liệu & Tồn kho (InventoryBLL)
    /// </summary>
    public class InventoryBLL
    {
        private readonly InventoryDAL _dal;

        public InventoryBLL()
        {
            _dal = new InventoryDAL();
        }

        public List<Ingredient> LoadIngredients()
        {
            return _dal.GetAll();
        }

        public Ingredient? GetIngredientById(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return null;
            return _dal.GetById(id);
        }

        public bool SaveIngredient(Ingredient ingredient, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(ingredient.IngredientId))
            {
                errorMessage = "Mã nguyên liệu không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(ingredient.IngredientName))
            {
                errorMessage = "Tên nguyên liệu không được để trống!";
                return false;
            }
            if (ingredient.ImportPrice < 0)
            {
                errorMessage = "Giá vốn không được âm!";
                return false;
            }
            if (ingredient.MinStock < 0)
            {
                errorMessage = "Mức tồn tối thiểu không được âm!";
                return false;
            }

            return _dal.Update(ingredient);
        }

        public List<InventoryTransaction> LoadHistory(string ingredientId)
        {
            if (string.IsNullOrWhiteSpace(ingredientId)) return new List<InventoryTransaction>();
            return _dal.GetHistory(ingredientId);
        }

        public bool ProcessImport(string id, decimal quantity, decimal price, string note, string performedBy, out string error)
        {
            error = string.Empty;
            if (quantity <= 0)
            {
                error = "Số lượng nhập phải lớn hơn 0!";
                return false;
            }
            if (price < 0)
            {
                error = "Đơn giá nhập không được âm!";
                return false;
            }

            _dal.ImportStock(id, quantity, price, note, performedBy);
            return true;
        }

        public bool ProcessExport(string id, decimal quantity, string reason, string performedBy, string note, out string error)
        {
            error = string.Empty;
            if (quantity <= 0)
            {
                error = "Số lượng xuất phải lớn hơn 0!";
                return false;
            }

            var item = _dal.GetById(id);
            if (item == null)
            {
                error = "Không tìm thấy nguyên liệu!";
                return false;
            }

            if (item.StockQuantity < quantity)
            {
                error = $"Tồn kho không đủ để xuất! Tồn hiện tại: {item.StockQuantity:N0} {item.Unit}, yêu cầu xuất: {quantity:N0} {item.Unit}.";
                return false;
            }

            _dal.ExportStock(id, quantity, reason, performedBy, note);
            return true;
        }

        public bool ToggleActive(string id)
        {
            return _dal.ToggleActive(id);
        }

        public List<string> GetCategories()
        {
            return _dal.GetAll().Select(x => x.GroupName).Distinct().OrderBy(x => x).ToList();
        }
    }

    /// <summary>
    /// Alias tương thích ngược tiếng Việt
    /// </summary>
    public class NguyenLieuBLL : InventoryBLL
    {
    }
}
