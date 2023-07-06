using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShop.Db.Models;
using Microsoft.AspNetCore.Identity;
using System;
using OnlineShop.Db;

namespace OnlineShopWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new Login() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false).Result;
                if (result.Succeeded)
                {
                    return Redirect(login.ReturnUrl ?? "/Home/Index");
                }
                ModelState.AddModelError("", "Неверно указан логин или пароль");
            }
            return View(login);
        }
        public IActionResult Register(string returnUrl)
        {
            return View(new Register() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (register.UserName.Equals(register.Password))
            {
                ModelState.AddModelError("", "Имя и пароль не должны совпадать");
                return View(register);
            }
            if (ModelState.IsValid)
            {
                var user = new User { Email = register.Mail, UserName = register.UserName, PhoneNumber = register.Phone };
                var result = _userManager.CreateAsync(user, register.Password).Result;
                if (result.Succeeded)
                {
                    _signInManager.SignInAsync(user, false).Wait();

                    TryAssignUserRole(user);

                    return Redirect(register.ReturnUrl ?? "/Home/Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(register);
        }

        private void TryAssignUserRole(User user)
        {
            try
            {
                _userManager.AddToRoleAsync(user, Constants.UserRoleName).Wait();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "не удалось добавить роль");
            }
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");
        }
    }
}
