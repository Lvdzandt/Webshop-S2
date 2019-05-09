using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class OrderController : Controller
    {
        OrderLogic _logic = new OrderLogic();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderPage()
        {
            OrderViewModel model = new OrderViewModel();
            return View(model);
        }

        public IActionResult ShoppingList()
        {
            ShoppingListViewModel model = new ShoppingListViewModel();
            model.ShoppingList = ShoppingCart.GameList;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddShoppinglist(int id)
        {
            GameLogic logic = new GameLogic();
            Game game = logic.GetGame(id);
            ShoppingCart.AddGame(game);
            return RedirectToAction("GamePage", "Game", new { @id = id });
        }

        [HttpPost]
        public IActionResult AddWishList(int id)
        {
            GameLogic logic = new GameLogic();
            Game game = logic.GetGame(id);
            WishList.AddGame(game);
            return RedirectToAction("GamePage", "Game", new { @id = id });
        }
    }
}