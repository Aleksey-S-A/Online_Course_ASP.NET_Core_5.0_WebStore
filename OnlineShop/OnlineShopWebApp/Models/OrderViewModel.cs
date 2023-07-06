using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Models
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public UserDeliveryInfoViewModel User { get; set; }
        public List<CartItemViewModel> Items { get; set; }
        public DateTime CreateDateTime { get; set; }
        public OrderStatusViewModel Status { get; set; }

        public OrderViewModel(UserDeliveryInfoViewModel deliveryInfoUser, List<CartItemViewModel> cartItems) : this()
        {
            Status = OrderStatusViewModel.Created;
            User = deliveryInfoUser;
            Items = cartItems;
        }
        public OrderViewModel()
        {
            Status = OrderStatusViewModel.Created;
            CreateDateTime = DateTime.Now;
        }

        public decimal Cost
        {
            get
            {
                return Items?.Sum(x => x.Cost) ?? 0;
            }
        }
    }
}

