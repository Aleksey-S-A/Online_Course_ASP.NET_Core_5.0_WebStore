using Microsoft.AspNetCore.Mvc;
using System;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShopWebApp.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;
        public BasketController(IBasketRepository basketRepository, IProductRepository productRepository)
        {
            _basketRepository = basketRepository;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var cart = _basketRepository.TryGetByUserId(Constants.UserId);
            return View(Mapping.ToCartViewModel(cart));
        }
        public IActionResult Add(Guid productId)
        {
            var product = _productRepository.GetProductById(productId);
            _basketRepository.Add(product, Constants.UserId);

            return RedirectToAction("Index");
        }
        public IActionResult Removal(Guid productId)
        {
            var product = _productRepository.GetProductById(productId);
            _basketRepository.Removal(product, Constants.UserId);

            return RedirectToAction("Index");
        }
        public IActionResult Clear(Guid basketId)
        {
            _basketRepository.Clear(Constants.UserId);

            return RedirectToAction("Index");
        }
    }
}
