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
        public IActionResult OrderPage(ShoppingListViewModel cart)
        {
            OrderViewModel model = new OrderViewModel {Order = {GameList = cart.ShoppingList}};
            return View(model);
        }

        public IActionResult ShoppingList()
        {
            ShoppingListViewModel model = new ShoppingListViewModel {ShoppingList = _logic.GetShoppingList()};
            model.TotalPrice = _logic.GetTotalPrice(model.ShoppingList);
            return View(model);
        }

        [HttpPost]
        public IActionResult AddShoppinglist(int id)
        {
            var logic = new GameLogic();
            var game = logic.GetGame(id);
            ShoppingCart.AddGame(game);
            return RedirectToAction("GamePage", "Game", new {id });
        }

        [HttpPost]
        public IActionResult AddWishList(int id)
        {
            var logic = new GameLogic();
            var game = logic.GetGame(id);
            WishList.AddGame(game);
            return RedirectToAction("GamePage", "Game", new {id });
        }
    }
}