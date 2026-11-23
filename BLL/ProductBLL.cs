using System;
using System.Collections.Generic;
using System.Linq;
using DoAnLapTrinhTrucQuan.DAL;
using DoAnLapTrinhTrucQuan.Models;

namespace DoAnLapTrinhTrucQuan.BLL
{
    /// <summary>
    /// Business Logic Layer cho Quản lý Món / Sản phẩm (ProductBLL)
    /// </summary>
    public class ProductBLL
    {
        private readonly ProductDAL _productDAL;

        public ProductBLL()
        {
            _productDAL = new ProductDAL();
        }

        public List<Product> LoadProducts()
        {
            return _productDAL.GetAll();
        }

        public List<Category> LoadCategories()
        {
            return _productDAL.GetCategories();
        }

        public List<Ingredient> LoadIngredients()
        {
            return _productDAL.GetIngredients();
        }

        public Product? GetProductById(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId)) return null;
            return _productDAL.GetById(productId);
        }

        public bool SaveProduct(Product product, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(product.ProductId))
            {
                errorMessage = "Mã món không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.ProductName))
            {
                errorMessage = "Tên món không được để trống!";
                return false;
            }

            if (product.Price < 0)
            {
                errorMessage = "Giá bán không được âm!";
                return false;
            }

            var existing = _productDAL.GetById(product.ProductId);
            if (existing != null)
            {
                return _productDAL.Update(product);
            }
            else
            {
                return _productDAL.Insert(product);
            }
        }

        public bool ToggleProductStatus(string productId)
        {
            var product = _productDAL.GetById(productId);
            if (product == null) return false;

            product.Status = product.Status == "Đang bán" ? "Tạm ngưng" : "Đang bán";
            return _productDAL.Update(product);
        }

        public List<RecipeBOM> LoadBOM(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId)) return new List<RecipeBOM>();
            return _productDAL.GetBOM(productId);
        }

        public bool SaveBOM(string productId, List<RecipeBOM> bomList)
        {
            if (string.IsNullOrWhiteSpace(productId)) return false;

            bool result = _productDAL.SaveBOM(productId, bomList);
            if (result)
            {
                decimal cogs = bomList.Sum(b => b.CostPrice);
                var product = _productDAL.GetById(productId);
                if (product != null)
                {
                    product.CostPrice = cogs;
                    _productDAL.Update(product);
                }
            }
            return result;
        }

        public decimal CalculateCOGS(string productId)
        {
            var bomList = LoadBOM(productId);
            return bomList.Sum(b => b.CostPrice);
        }
    }
}
