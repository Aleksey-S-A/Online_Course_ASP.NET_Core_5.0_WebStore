using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;

namespace OnlineShopWebApp.Views.Shared.ViewComponents.CalcFavoriteProductsCountViewComponents
{
    public class FavoriteProductsCount : ViewComponent
    {
        private readonly IFavoriteRepository _favoriteRepository;

        public FavoriteProductsCount(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }
        public IViewComponentResult Invoke()
        {
            var productsCount = _favoriteRepository.GetAll(Constants.UserId).Count;
            return View("FavoriteProductsCount", productsCount);
        }
    }
}