using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class FavoriteDbRepository : IFavoriteRepository
    {
        private readonly DatabaseContext _databaseContext;
        public FavoriteDbRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Add(string userId, Guid id)
        {
            var existingProduct = _databaseContext.FavoriteProducts.FirstOrDefault(x => x.UserId == userId && x.Product.Id == id);
            if (existingProduct == null)
            {
                var product = _databaseContext.Products.FirstOrDefault(x => x.Id== id);
                _databaseContext.FavoriteProducts.Add(new FavoriteProduct { Product = product, UserId = userId });
                _databaseContext.SaveChanges();
            }
        }
        public void Clear(string userId)
        {
            var products = _databaseContext.FavoriteProducts.Where(u => u.UserId == userId);
            _databaseContext.FavoriteProducts.RemoveRange(products);
            _databaseContext.SaveChanges();
        }
        public List<Product> GetAll(string userId)
        {
            return _databaseContext.FavoriteProducts.Where(x => x.UserId == userId)
                .Include(x => x.Product)
                .Select(x => x.Product)
                .ToList();
        }
        public void Remove(string userId, Guid productId)
        {
            var product = _databaseContext.FavoriteProducts.FirstOrDefault(x => x.UserId == userId && x.Product.Id == productId);
            _databaseContext.FavoriteProducts.Remove(product);
            _databaseContext.SaveChanges();
        }
    }
}
