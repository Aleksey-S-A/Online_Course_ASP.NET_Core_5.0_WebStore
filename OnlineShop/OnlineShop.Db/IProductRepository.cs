using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(Guid productId);
        void Add(Product product);
        void Update(Product product);
        void RemoveProductById(Guid productId);
    }
}