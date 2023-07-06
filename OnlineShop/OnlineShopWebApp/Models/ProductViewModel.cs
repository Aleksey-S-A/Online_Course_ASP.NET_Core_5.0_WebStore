using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string[] ImagesPaths { get; set; }
        public string ImagePath => ImagesPaths.Length == 0 ? "/images/Products/Image5.png" : ImagesPaths[0];
    }
}