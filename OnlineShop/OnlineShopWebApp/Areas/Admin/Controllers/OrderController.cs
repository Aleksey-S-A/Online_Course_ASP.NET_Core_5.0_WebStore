using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class OrderController : Controller
    {
        private readonly IOrderedRepository _ordersRepository;
        public OrderController(IOrderedRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }
        public IActionResult Orders()
        {
            var orders = _ordersRepository.GetAll();
            return View(Mapping.OrdersViewModelToList(orders));
        }
        public IActionResult Detail(Guid orderId)
        {
            var order = _ordersRepository.TryGetById(orderId);
            return View(Mapping.ToOrderViewModel(order));
        }
        public IActionResult UpdateOrderStatus(Guid orderId, OrderStatusViewModel status)
        {
            _ordersRepository.UpdateStatus(orderId, (int)status);
            return RedirectToAction("Orders");
        }
    }
}