using OnlineShop.Db.Models;
using OnlineShopWebApp.Areas.Admin.Models;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Helpers
{
    public static class Mapping
    {
        public static List<ProductViewModel> ToProductViewModels(List<Product> products)
        {
            return (products.Select(product => ToProductViewModel(product))).ToList();
        }

        public static ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagesPaths = product.Images.Select(x => x.Url).ToArray()
            };
        }

        public static Product ToProduct(this AddProductViewModel addProductViewModel, List<string> imagesPaths)
        {
            return new Product
            {
                Name = addProductViewModel.Name,
                Cost = addProductViewModel.Cost,
                Description = addProductViewModel.Description,
                Images = ToImages(imagesPaths)
            };
        }

        private static List<Image> ToImages(this List<string> paths)
        {
            return paths.Select(x => new Image { Url = x }).ToList();
        }
        private static List<string> ToPaths(this List<Image> paths)
        {
            return paths.Select(x => x.Url).ToList();
        }

        public static CartViewModel ToCartViewModel(Cart cart)
        {
            if (cart == null)
            {
                return null;
            }
            return new CartViewModel
            {
                Id = cart.Id,
                UserId = cart.UserId,
                Items = ToCartItemViewModels(cart.Items)
            };
        }

        private static List<CartItemViewModel> ToCartItemViewModels(List<CartItem> cartDbItems)
        {
            return (from cartDbItem in cartDbItems
                    let cartItem = new CartItemViewModel
                    {
                        Id = cartDbItem.Id,
                        Amount = cartDbItem.Amount,
                        Product = ToProductViewModel(cartDbItem.Product)
                    }
                    select cartItem).ToList();
        }

        public static OrderViewModel ToOrderViewModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CreateDateTime = order.CreateDateTime,
                Status = (OrderStatusViewModel)order.Status,
                User = ToUserDeliveryInfoViewModel(order.User),
                Items = ToCartItemViewModels(order.Items)
            };
        }

        public static List<OrderViewModel> OrdersViewModelToList(List<Order> orders)
        {
            var newOrders = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                newOrders.Add(Mapping.ToOrderViewModel(order));
            }
            return newOrders;
        }

        public static UserDeliveryInfoViewModel ToUserDeliveryInfoViewModel(UserDeliveryInfo deliveryInfo)
        {
            return new UserDeliveryInfoViewModel
            {
                Name = deliveryInfo.Name,
                Address = deliveryInfo.Address,
                Phone = deliveryInfo.Phone,
                Email = deliveryInfo.Email
            };
        }
        public static UserDeliveryInfo ToUser(UserDeliveryInfoViewModel deliveryInfo)
        {
            return new UserDeliveryInfo
            {
                Name = deliveryInfo.Name,
                Address = deliveryInfo.Address,
                Phone = deliveryInfo.Phone,
                Email = deliveryInfo.Email
            };
        }
        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Name = user.UserName,
                Phone = user.PhoneNumber,
                Email = user.Email
            };
        }

        public static User EditUser(User user, UserViewModel newUser)
        {
            user.PhoneNumber = newUser.Phone;
            user.UserName = newUser.NewName;
            user.Email = newUser.Email;
            return user;
        }

        public static EditProductViewModel ToEditProductViewModel(this Product product)
        {
            return new EditProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Cost = product.Cost,
                Description = product.Description,
                ImagesPaths = product.Images.ToPaths()
            };
        }

        public static Product ToProduct(this EditProductViewModel editProduct)
        {
            return new Product
            {
                Id = editProduct.Id,
                Name = editProduct.Name,
                Cost = editProduct.Cost,
                Description = editProduct.Description,
                Images = editProduct.ImagesPaths.ToImages()
            };
        }
    }
}
