using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Areas.Admin.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productsRepository;
        private readonly IImagesProvider _imagesProvider;
        public ProductController(IProductRepository productsRepository, IImagesProvider imagesProvider)
        {
            _productsRepository = productsRepository;
            _imagesProvider = imagesProvider;
        }
        public IActionResult Products()
        {
            var products = _productsRepository.GetAllProducts();
            return View(Mapping.ToProductViewModels(products));
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddProductViewModel product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            var imagesPaths = _imagesProvider.SafeFiles(product.UploadedFiles, ImageFolders.Products);

            _productsRepository.Add(product.ToProduct(imagesPaths));
            return RedirectToAction("Products");
        }

        public IActionResult Edit(Guid productId)
        {
            var product = _productsRepository.GetProductById(productId);
            return View(Mapping.ToEditProductViewModel(product));
        }
        [HttpPost]
        public IActionResult Edit(EditProductViewModel product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            var addImagesPaths = _imagesProvider.SafeFiles(product.UploadedFiles, ImageFolders.Products);
            product.ImagesPaths = addImagesPaths;
            _productsRepository.Update(product.ToProduct());
            return RedirectToAction("Products");
        }
        public IActionResult Remove(Guid productId)
        {
            _productsRepository.RemoveProductById(productId);
            return RedirectToAction("Products");
        }
    }
}
