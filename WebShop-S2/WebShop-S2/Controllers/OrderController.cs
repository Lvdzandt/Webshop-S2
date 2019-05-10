using System.Collections.Generic;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderLogic _logic = new OrderLogic();

        [HttpPost]
        public IActionResult OrderPage()
        {
            OrderViewModel model = new OrderViewModel();
            Order order = new Order();
            order.GameList = _logic.GetShoppingList();
            model.Order = order;
            model.TotalPrice = _logic.GetTotalPrice(model.Order.GameList);
            
            return View(model);
        }

        public IActionResult ShoppingList()
        {
            ShoppingListViewModel model = new ShoppingListViewModel { ShoppingList = _logic.GetShoppingList() };
            model.TotalPrice = _logic.GetTotalPrice(model.ShoppingList);
            return View(model);
        }

        [HttpPost]
        public IActionResult ShoppingList(int id)
        {
            ShoppingCart.RemoveGame(id);
            ShoppingListViewModel model = new ShoppingListViewModel { ShoppingList = _logic.GetShoppingList() };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddShoppinglist(int id)
        {
            var logic = new GameLogic();
            var game = logic.GetGame(id);
            ShoppingCart.AddGame(game);
            return RedirectToAction("GamePage", "Game", new { id });
        }

        [HttpPost]
        public IActionResult AddWishList(int id)
        {
            var logic = new GameLogic();
            var game = logic.GetGame(id);
            WishList.AddGame(game);
            return RedirectToAction("GamePage", "Game", new { id });
        }

        [HttpPost]
        public IActionResult RemoveWishList(int id)
        {
            WishList.RemoveGame(id);
            return RedirectToAction("Account", "Account");
        }
    }
}