using System;

namespace CoffeeShop.API.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public bool? IsFeatured { get; set; }
        public string SeoAlias { set; get; }
    }
}
