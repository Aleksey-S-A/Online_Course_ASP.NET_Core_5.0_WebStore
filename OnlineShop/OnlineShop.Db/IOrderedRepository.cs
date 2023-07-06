using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Db
{
    public interface IOrderedRepository
    {
        void Add(Order order);
        List<Order> GetAll();
        Order TryGetById(Guid id);
        void UpdateStatus(Guid orderId, int newStatus);
    }
}