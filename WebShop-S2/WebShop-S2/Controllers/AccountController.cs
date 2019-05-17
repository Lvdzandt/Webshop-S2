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
        public readonly AccountLogic Logic = new AccountLogic();

        public const string SessionKeyName = "_Name";



        public IActionResult Account()
        {
            OrderLogic orderLogic = new OrderLogic();
            GameLogic gameLogic = new GameLogic();
            var model = new AccountViewModel();
            var email = HttpContext.Session.GetString(SessionKeyName);
            var user = Logic.GetUser(email);
            model.Id = user.Id;
            model.Email = user.Email;
            model.Username = user.Username;
            model.Birthday = user.Birthday;
            model.Orders = orderLogic.GetAllOrderById(user.Id);
            foreach (var order in model.Orders)
            {
                foreach (var item in orderLogic.GetAllGames())
                {
                    if (item.Item2 == order.Id)
                    {
                        Game game = gameLogic.GetGame(item.Item1);
                        order.GameList.Add(game);
                        order.TotalPrice += game.Price;
                    }
                    
                }
            }
            
            
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
            if (Logic.CheckLogin(model.Email, model.Password))
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
            if (!Logic.CheckAccountTaken(model.Email))
            {
                User user = new User(model.Email, model.Username, model.Birthday, model.Password);
                Logic.RegisterAccount(user);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Email has already been taken");
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            EditAccountModel model = new EditAccountModel();
            User user = Logic.GetUser(id);
            model.Id = id;
            model.Username = user.Username;
            model.Birthday = user.Birthday;
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditAccountModel model)
        {
            User user = new User() { Id = model.Id, Username = model.Username, Birthday = model.Birthday };
            Logic.UpdateUser(user);
            return RedirectToAction("Account", "Account");
        }
    }
}