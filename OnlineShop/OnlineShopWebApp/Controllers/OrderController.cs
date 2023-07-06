using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShopWebApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IOrderedRepository _orderRepository;
        public OrderController(IBasketRepository basketRepository, IOrderedRepository orderRepository)
        {
            _basketRepository = basketRepository;
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(UserDeliveryInfoViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", user);
            }
            var existingCart = _basketRepository.TryGetByUserId(Constants.UserId);

            var order = new Order
            {
                User = Mapping.ToUser(user),
                Items = existingCart.Items
            };
            _orderRepository.Add(order);
            _basketRepository.Clear(Constants.UserId);
            return View();
        }
    }
}
