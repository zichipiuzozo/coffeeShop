using CoffeeShop.API.Models;
using CoffeeShop.Data.Entities;
using System.Collections.Generic;

namespace CoffeeShop.API.Services
{
    public interface IProductReponsitory
    {
        List<ProductVM> GetAll();
        ProductVM GetById(int id);
        ProductVM Add(Product Products);
        void Update(ProductVM Products);
        void Delete(int id);
    }
}
