using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Areas.Admin.Models
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Не указано наименование товара")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Наименование товара должно составлять от 2 до 25 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана стоимость товара")]
        [Range(1, 9999999, ErrorMessage = "Стоимость товара должна составлять от 1 до 9 999 999")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Не указано описание товара")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Описаниие товара должно составлять от 10 до 100 символов")]
        public string Description { get; set; }
        public IFormFile[] UploadedFiles { get; set; }
    }
}