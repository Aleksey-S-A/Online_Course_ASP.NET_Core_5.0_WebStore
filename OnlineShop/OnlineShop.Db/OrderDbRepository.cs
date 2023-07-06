using Microsoft.EntityFrameworkCore;
using OnlineShop.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Db
{
    public class OrderDbRepository : IOrderedRepository
    {
        private readonly DatabaseContext _databaseContext;
        public OrderDbRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Add(Order order)
        {
            _databaseContext.Orders.Add(order);
            _databaseContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _databaseContext.Orders.Include(x => x.User)
                .Include(x => x.Items).ThenInclude(x => x.Product).ToList();
        }

        public Order TryGetById(Guid id)
        {
            return _databaseContext.Orders.Include(x => x.User)
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.Id == id);
        }
        public void UpdateStatus(Guid orderId, int status)
        {
            var order = TryGetById(orderId);
            if (order != null)
            {
                order.Status = (OrderStatus)status;
                _databaseContext.SaveChanges();
            }
        }
    }
}
