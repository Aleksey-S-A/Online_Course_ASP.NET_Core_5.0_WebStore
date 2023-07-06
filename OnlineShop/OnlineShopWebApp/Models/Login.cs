using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени от 2 до 25 символов")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Длина имени от 5 до 25 символов")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
