using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Areas.Admin.Models;
using System.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _rolesManager;
        public RoleController(RoleManager<IdentityRole> rolesManager)
        {
            _rolesManager = rolesManager;
        }
        public IActionResult Roles()
        {
            var roles = _rolesManager.Roles.ToList();
            return View(roles.Select(x => new RoleViewModel { Name = x.Name }).ToList());
        }
        public IActionResult Remove(string roleName)
        {
            var role = _rolesManager.FindByNameAsync(roleName).Result;
            if (role != null)
            {
                _rolesManager.DeleteAsync(role).Wait();
            }
            return RedirectToAction("Roles");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(RoleViewModel role)
        {
            var result = _rolesManager.CreateAsync(new IdentityRole(role.Name)).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("Roles");
            }
            return View(role);
        }
    }
}
