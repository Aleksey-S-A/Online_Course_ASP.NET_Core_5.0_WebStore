using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени от 2 до 25 символов")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        [RegularExpression("[+0-9]{11,12}", ErrorMessage = "Некорректный номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указана почта")]
        [EmailAddress(ErrorMessage = "Некорректный адрес эл. почты")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Длина имени от 5 до 25 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
        public string ReturnUrl { get; set; }
    }
}
