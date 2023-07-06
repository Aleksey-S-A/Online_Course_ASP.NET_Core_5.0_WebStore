using OnlineShop.Db.Models;
using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;

namespace OnlineShopWebApp.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени от 2 до 25 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указана почта")]
        public string Email { get; set; }
        public string NewName { get; set; }
    }
}
