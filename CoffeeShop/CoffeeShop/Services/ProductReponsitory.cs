using CoffeeShop.API.Models;
using CoffeeShop.Data.EF;
using CoffeeShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShop.API.Services
{
    public class ProductReponsitory : IProductReponsitory
    {
        public readonly CoffeeShopDBContext _CoffeeShopContext;
        public ProductReponsitory(CoffeeShopDBContext CoffeeShopContext)
        {
            _CoffeeShopContext = CoffeeShopContext;
        }

        public ProductVM Add(Product Products)
        {
            var _products = new Product
            {
                Price = Products.Price
            };
            _CoffeeShopContext.Add(_products);
            _CoffeeShopContext.SaveChanges();
            return new ProductVM
            {
                Id = _products.Id,
                Price = _products.Price,
                OriginalPrice = _products.OriginalPrice,
                Stock = _products.Stock,
                ViewCount = _products.ViewCount,
                DateCreated = _products.DateCreated,
                IsFeatured = _products.IsFeatured,
                SeoAlias = _products.SeoAlias,
            };
        }

        public void Delete(int id)
        {
            var product = _CoffeeShopContext.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                _CoffeeShopContext.Remove(product);
                _CoffeeShopContext.SaveChanges();
            }
        }

        public List<ProductVM> GetAll()
        {
            var products = _CoffeeShopContext.Products.Select(p => new ProductVM { 
                Id = p.Id,
                Price = p.Price,
                OriginalPrice = p.OriginalPrice,
                Stock = p.Stock,
                ViewCount = p.ViewCount,
                DateCreated = p.DateCreated,
                IsFeatured = p.IsFeatured,
                SeoAlias = p.SeoAlias,
            });
            return products.ToList();
        }

        public ProductVM GetById(int id)
        {
            var product = _CoffeeShopContext.Products.SingleOrDefault(p => p.Id == id);
            if (product != null)
            {
                return new ProductVM
                {
                    Id = product.Id,
                    Price = product.Price,
                    OriginalPrice = product.OriginalPrice,
                    Stock = product.Stock,
                    ViewCount = product.ViewCount,
                    DateCreated = product.DateCreated,
                    IsFeatured = product.IsFeatured,
                    SeoAlias = product.SeoAlias,
                };
            }
            return null;
        }

        public void Update(ProductVM Products)
        {
            var product = _CoffeeShopContext.Products.SingleOrDefault(p => p.Id == Products.Id);
            product.Id = Products.Id;
            _CoffeeShopContext.SaveChanges();
        }
    }
}
