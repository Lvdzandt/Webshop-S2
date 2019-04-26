using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_S2.Models;
using Logic;
using Model;
using Microsoft.AspNetCore.Http;

namespace WebShop_S2.Controllers
{
    public class AccountController : Controller
    {
        AccountLogic _logic = new AccountLogic();

        public const string SessionKeyName = "_Name";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Account()
        {
            AccountViewModel model = new AccountViewModel();
            return View(model);
        }

        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (_logic.CheckLogin(model.Email, model.Password))
            {
                CurrUser.Username = model.Email;
                HttpContext.Session.SetString(SessionKeyName, model.Email);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Password was incorrect");
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!_logic.CheckAccountTaken(model.Email))
            {
                User newuser = new User(model.Email,model.Username,model.Birthday,model.Password);
                _logic.RegisterAccount(newuser);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("","Email has already been taken");
            return View(model);
        }
    }
}