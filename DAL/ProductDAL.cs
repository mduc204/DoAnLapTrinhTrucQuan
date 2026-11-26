using System.Collections.Generic;
using System.Linq;
using DoAnLapTrinhTrucQuan.Data;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.DAL
{
    /// <summary>
    /// Data Access Layer cho Quản lý Món / Sản phẩm (ProductDAL)
    /// </summary>
    public class ProductDAL
    {
        public List<Product> GetAll()
        {
            return MockDataService.Instance.DanhSachMon.Cast<Product>().ToList();
        }

        public Product? GetById(string productId)
        {
            return MockDataService.Instance.DanhSachMon.FirstOrDefault(m => m.ProductId == productId);
        }

        public bool Insert(Product product)
        {
            if (MockDataService.Instance.DanhSachMon.Any(m => m.ProductId == product.ProductId))
            {
                return false;
            }
            MockDataService.Instance.DanhSachMon.Add(product as Mon ?? new Mon
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                CategoryName = product.CategoryName,
                Price = product.Price,
                CostPrice = product.CostPrice,
                Description = product.Description,
                Status = product.Status,
                HasRecipe = product.HasRecipe,
                Image = product.Image,
                ImagePath = product.ImagePath
            });
            MockDataService.Instance.SapXepDanhSachMon();
            return true;
        }

        public bool Update(Product product)
        {
            var existing = MockDataService.Instance.DanhSachMon.FirstOrDefault(m => m.ProductId == product.ProductId);
            if (existing == null) return false;

            existing.ProductName = product.ProductName;
            existing.CategoryId = product.CategoryId;
            existing.CategoryName = product.CategoryName;
            existing.Price = product.Price;
            existing.CostPrice = product.CostPrice;
            existing.Description = product.Description;
            existing.Status = product.Status;
            existing.HasRecipe = product.HasRecipe;
            existing.ImagePath = product.ImagePath;
            existing.Image = product.Image;

            return true;
        }

        public bool Delete(string productId)
        {
            var item = MockDataService.Instance.DanhSachMon.FirstOrDefault(m => m.ProductId == productId);
            if (item != null)
            {
                MockDataService.Instance.DanhSachMon.Remove(item);
                if (MockDataService.Instance.DinhLuongMap.ContainsKey(productId))
                {
                    MockDataService.Instance.DinhLuongMap.Remove(productId);
                }
                return true;
            }
            return false;
        }

        public List<RecipeBOM> GetBOM(string productId)
        {
            if (MockDataService.Instance.DinhLuongMap.TryGetValue(productId, out var list))
            {
                return list.Cast<RecipeBOM>().ToList();
            }
            return new List<RecipeBOM>();
        }

        public bool SaveBOM(string productId, List<RecipeBOM> bomList)
        {
            MockDataService.Instance.DinhLuongMap[productId] = bomList.Select(b => new DinhLuongBOM
            {
                ProductId = b.ProductId,
                IngredientId = b.IngredientId,
                IngredientName = b.IngredientName,
                WarehouseLocation = b.WarehouseLocation,
                Quantity = b.Quantity,
                Unit = b.Unit,
                UnitPrice = b.UnitPrice
            }).ToList();
            return true;
        }

        public List<Category> GetCategories()
        {
            return MockDataService.Instance.DanhSachDanhMuc.Cast<Category>().ToList();
        }

        public List<Ingredient> GetIngredients()
        {
            return MockDataService.Instance.DanhSachNguyenLieu.Cast<Ingredient>().ToList();
        }
    }
}
