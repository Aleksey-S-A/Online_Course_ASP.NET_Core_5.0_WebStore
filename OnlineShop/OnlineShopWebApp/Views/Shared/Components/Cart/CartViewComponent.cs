using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Helpers;

namespace OnlineShopWebApp.Views.Shared.ViewComponents.CartViewComponents
{
    public class Cart : ViewComponent
    {
        private readonly IBasketRepository _basketRepository;

        public Cart(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }
        public IViewComponentResult Invoke()
        {
            var cart = _basketRepository.TryGetByUserId(Constants.UserId);
            var cartViewModel = Mapping.ToCartViewModel(cart);
            var productCounts = cartViewModel?.Amount ?? 0;
            return View("Cart", productCounts);
        }
    }
}
