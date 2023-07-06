using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class BasketDbRepository : IBasketRepository
    {
        private readonly DatabaseContext _databaseContext;

        public BasketDbRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public Cart TryGetByUserId(string userId)
        {
            return _databaseContext.Carts.Include(x => x.Items).ThenInclude(x => x.Product).FirstOrDefault(x => x.UserId == userId);
        }
        public void Add(Product product, string userID)
        {
            var existingCart = TryGetByUserId(userID);
            if (existingCart == null)
            {
                var newCart = new Cart
                {
                    UserId = userID
                };
                newCart.Items = new List<CartItem>
                    {
                        new CartItem
                        {
                            Amount = 1,
                            Product= product,
                            Cart =  newCart
                        }
                    };
                _databaseContext.Carts.Add(newCart);
            }
            else
            {
                var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Amount++;
                }
                else
                {
                    existingCart.Items.Add(new CartItem
                    {
                        Amount = 1,
                        Product = product,
                        Cart = existingCart
                    });
                }
            }
            _databaseContext.SaveChanges();
        }

        public void Removal(Product product, string userID)
        {
            var existingCart = TryGetByUserId(userID);
            var existingCartItem = existingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
            var numberOfPosition = existingCart.Items.IndexOf(existingCartItem);

            if (existingCartItem.Amount == 1)
            {
                existingCart.Items.RemoveAt(numberOfPosition);
            }
            else
            {
                existingCartItem.Amount--;
            }
            _databaseContext.SaveChanges();
        }
        public void Clear(string userID)
        {
            var existingCart = TryGetByUserId(userID);
            _databaseContext.Carts.Remove(existingCart);
            _databaseContext.SaveChanges();
        }
    }
}
