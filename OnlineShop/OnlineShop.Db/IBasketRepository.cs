using OnlineShop.Db.Models;

namespace OnlineShop.Db
{
    public interface IBasketRepository
    {
        void Add(Product product, string userID);
        void Clear(string userId);
        void Removal(Product product, string userID);
        Cart TryGetByUserId(string userId);
    }
}