using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class ChangePassword
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан старый пароль")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Длина имени от 5 до 25 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
