using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class ProductsDbRepository : IProductRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ProductsDbRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Add(Product product)
        {
            _databaseContext.Products.Add(product);
            _databaseContext.SaveChanges();
        }
        public List<Product> GetAllProducts()
        {
            return _databaseContext.Products.Include(x => x.Images).ToList();
        }
        public Product GetProductById(Guid productId)
        {
            return _databaseContext.Products.Include(x => x.Images).FirstOrDefault(product => product.Id == productId);
        }
        public void Update(Product product)
        {
            var existingProduct = _databaseContext.Products.Include(x => x.Images).FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct == null)
            {
                return;
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Cost = product.Cost;
            foreach (var image in product.Images)
            {
                image.ProductId = product.Id;
                _databaseContext.Image.Add(image);
            }
            _databaseContext.SaveChanges();
        }
        public void RemoveProductById(Guid productId)
        {
            var existingProduct = _databaseContext.Products.FirstOrDefault(product => productId == product.Id);
            if (existingProduct == null)
            {
                return;
            }
            _databaseContext.Products.Remove(existingProduct);
            _databaseContext.SaveChanges();
        }
    }
}
