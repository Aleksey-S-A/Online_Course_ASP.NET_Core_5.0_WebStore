using System.ComponentModel.DataAnnotations;
namespace OnlineShopWebApp.Models
{
    public class UserAccount
    {
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени от 2 до 25 символов")]
        public string NewName { get; set; }

        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени от 2 до 25 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Длина имени от 5 до 25 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указана почта")]
        public string Mail { get; set; }
    }
}
