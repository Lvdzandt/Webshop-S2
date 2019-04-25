using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_S2.Models;
using Logic;


namespace WebShop_S2.Controllers
{
    public class AccountController : Controller
    {
        AccountLogic _logic = new AccountLogic();
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
            _logic.CheckLogin(model.Email, model.Password);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}