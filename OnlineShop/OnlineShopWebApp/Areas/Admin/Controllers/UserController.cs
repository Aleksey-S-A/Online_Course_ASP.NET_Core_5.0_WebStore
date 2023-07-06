using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Areas.Admin.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _rolesManager;
        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _rolesManager = roleManager;
        }
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users.Select(x => x.ToUserViewModel()).ToList());
        }
        public IActionResult Detail(string name)
        {
            var user = _userManager.FindByNameAsync(name).Result;
            return View(user.ToUserViewModel());
        }
        public IActionResult ChangePassword(string name)
        {
            var changePassword = new ChangePassword()
            {
                Name = name,
            };
            return View(changePassword);
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePassword changePassword)
        {
            var user = _userManager.FindByNameAsync(changePassword.Name).Result;
            if (changePassword.Name == changePassword.Password)
            {
                ModelState.AddModelError("", "Имя и пароль не должны совпадать");
            }
            if (!_userManager.CheckPasswordAsync(user, changePassword.OldPassword).Result)
            {
                ModelState.AddModelError("", "Неверно указан старый пароль");
            }
            if (ModelState.IsValid)
            {
                _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.Password).Wait();
                return RedirectToAction("Index");
            }
            return View(changePassword);
        }
        public IActionResult Edit(string name)
        {
            var user = _userManager.FindByNameAsync(name).Result;
            return View(user.ToUserViewModel());
        }
        [HttpPost]
        public IActionResult Edit(UserViewModel newUser)
        {
            var user = _userManager.FindByNameAsync(newUser.Name).Result;
            if (ModelState.IsValid)
            {
                _userManager.UpdateAsync(Mapping.EditUser(user, newUser)).Wait();
                return RedirectToAction("Index");
            }
            return View(user);
        }
        public IActionResult Remove(string name)
        {
            var user = _userManager.FindByNameAsync(name).Result;
            try
            {
                _userManager.DeleteAsync(user).Wait();
            }
            catch (Exception)
            {
                return View("Mistake");
            }
            return RedirectToAction("Index");
        }
        public IActionResult EditRights(string name)
        {
            var user = _userManager.FindByNameAsync(name).Result;
            var userRoles = _userManager.GetRolesAsync(user).Result;
            var roles = _rolesManager.Roles.ToList();
            var model = new EditRightsViewModel
            {
                UserName = user.UserName,
                UserRoles = userRoles.Select(x => new RoleViewModel { Name = x }).ToList(),
                AllRoles = roles.Select(x => new RoleViewModel { Name = x.Name }).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditRights(string name, Dictionary<string, string> userRolesViewModel)
        {
            var userSelectedRoles = userRolesViewModel.Select(x => x.Key);
            var user = _userManager.FindByNameAsync(name).Result;
            var userRoles = _userManager.GetRolesAsync(user).Result;

            _userManager.RemoveFromRolesAsync(user, userRoles).Wait();
            try
            {
                _userManager.AddToRolesAsync(user, userSelectedRoles).Wait();
            }
            catch
            {
                _userManager.AddToRolesAsync(user, userRoles).Wait();
                return Redirect($"?name={name}");
            }
            return Redirect($"/Admin/User/Detail?name={name}");
        }
    }
}