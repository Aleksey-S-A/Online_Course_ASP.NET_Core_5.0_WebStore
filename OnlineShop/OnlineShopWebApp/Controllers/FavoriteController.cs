using Microsoft.AspNetCore.Mvc;
using System;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShopWebApp.Controllers
{
    [Authorize]
    public class FavoriteController : Controller
    {
        private readonly IFavoriteRepository _favoriteRepository;
        private readonly IProductRepository _productsRepository;
        public FavoriteController(IFavoriteRepository favoriteRepository, IProductRepository productsRepository)
        {
            _favoriteRepository = favoriteRepository;
            _productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
            var products = _favoriteRepository.GetAll(Constants.UserId);
            return View(Mapping.ToProductViewModels(products));
        }
        public IActionResult Add(Guid productId)
        {
            var product = _productsRepository.GetProductById(productId);
            _favoriteRepository.Add(Constants.UserId, product.Id);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(Guid productId)
        {
            _favoriteRepository.Remove(Constants.UserId, productId);
            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            _favoriteRepository.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
