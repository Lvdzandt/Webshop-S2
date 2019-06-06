using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    [SuppressMessage("ReSharper", "SuggestVarOrType_SimpleTypes")]
    public class AccountController : Controller
    {
        readonly AccountLogic _accountLogic = new AccountLogic();
        readonly OrderLogic _orderLogic = new OrderLogic();
        readonly GameLogic _gameLogic = new GameLogic();

        public const string SessionKeyName = "_Name";



        public IActionResult Account()
        {
            var model = new AccountViewModel();
            var email = HttpContext.Session.GetString(SessionKeyName);
            var user = _accountLogic.GetUser(email);
            model.Id = user.Id;
            model.Email = user.Email;
            model.Username = user.Username;
            model.Birthday = user.Birthday;
            model.Orders = _orderLogic.GetAllOrderById(user.Id);
            foreach (var order in model.Orders)
            {
                foreach (var item in _orderLogic.GetAllGames())
                {
                    if (item.Item2 == order.Id)
                    {
                        Game game = _gameLogic.GetGame(item.Item1);
                        order.GameList.Add(game);
                        order.TotalPrice += game.Price;
                    }
                }
            }
            model.Reviews = new List<Review>();
            model.WishList = _orderLogic.GetWishList(user.Id);
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
            if (_accountLogic.CheckLogin(model.Email, model.Password))
            {
                HttpContext.Session.SetString(SessionKeyName, model.Email);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Password was incorrect");
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            _orderLogic.ClearShoppingList();
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
            if (!_accountLogic.CheckAccountTaken(model.Email))
            {
                User user = new User(model.Email, model.Username, model.Birthday, model.Password);
                _accountLogic.RegisterAccount(user);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Email has already been taken");
            return View(model);
        }

        

        public IActionResult Edit(int id)
        {
            EditAccountModel model = new EditAccountModel();
            User user = _accountLogic.GetUser(id);
            model.Id = id;
            model.Username = user.Username;
            model.Birthday = user.Birthday;
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditAccountModel model)
        {
            User user = new User() { Id = model.Id, Username = model.Username, Birthday = model.Birthday };
            _accountLogic.UpdateUser(user);
            return RedirectToAction("Account", "Account");
        }
    }
}