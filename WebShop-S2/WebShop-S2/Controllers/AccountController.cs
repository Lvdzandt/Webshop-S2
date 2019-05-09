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
            string email = HttpContext.Session.GetString(SessionKeyName);
            User curruser = _logic.GetUser(email);
            model.ID = curruser.ID;
            model.Email = curruser.Email;
            model.Username = curruser.Username;
            model.Birthday = curruser.Birthday;
            model.Orders = new List<Order>();
            model.Reviews = new List<Review>();
            model.WishList = WishList.GameList;
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

        public IActionResult Edit(int id)
        {
            EditAccountModel model = new EditAccountModel();
            User curruser = _logic.GetUser(id);
            model.ID = id;
            model.Username = curruser.Username;
            model.Birthday = curruser.Birthday;
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditAccountModel model)
        {
            User user = new User() {ID = model.ID, Username = model.Username, Birthday = model.Birthday };
            _logic.UpdateUser(user);
            return RedirectToAction("Account", "Account");
        }
    }
}