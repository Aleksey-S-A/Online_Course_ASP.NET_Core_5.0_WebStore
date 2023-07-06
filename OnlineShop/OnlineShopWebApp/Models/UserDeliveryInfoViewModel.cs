using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public class UserDeliveryInfoViewModel
    {
        [Required(ErrorMessage = "Не указано ФИО")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени от 2 до 25 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указана почта")]
        [EmailAddress(ErrorMessage = "Некорректный адрес эл. почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан телефон")]
        [RegularExpression("[+0-9]{11,12}", ErrorMessage = "Некорректный номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Не указан адрес")]
        public string Address { get; set; }
    }
}
