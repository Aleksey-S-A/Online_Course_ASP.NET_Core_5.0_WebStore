using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Не указана роль")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Длина роли от 5 до 25 символов")]
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            var role = (RoleViewModel)obj;
            return Name == role.Name;
        }
    }
}
