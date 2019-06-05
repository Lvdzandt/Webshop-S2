using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class OrderController : Controller
    {
        public readonly OrderLogic OrderLogic = new OrderLogic();

        public readonly GameLogic GameLogic = new GameLogic();

        public readonly AccountLogic AccountLogic = new AccountLogic();

        [HttpPost]
        public IActionResult Order(int orderId)
        {
            OrderViewModel model = new OrderViewModel {Order = OrderLogic.GetOrder(orderId)};
            foreach (var item in OrderLogic.GetAllGames())
            {
                if (item.Item2 == orderId)
                {
                    Game game = GameLogic.GetGame(item.Item1);
                    model.Order.GameList.Add(game);
                    model.TotalPrice += game.Price;
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult OrderPage()
        {
            if (OrderLogic.GetShoppingList().Count != 0)
            {
                OrderViewModel model = new OrderViewModel();
                Order order = new Order();
                var email = HttpContext.Session.GetString("_Name");
                order.GameList = OrderLogic.GetShoppingList();
                model.Order = order;
                model.TotalPrice = OrderLogic.GetTotalPrice(model.Order.GameList);
                model.Order.UserId = AccountLogic.GetUser(email).Id;

                return View(model);
            }

            return RedirectToAction("ShoppingList", "Order");
        }
        [HttpPost]
        public IActionResult Checkout(OrderViewModel model)
        {
            Order order = new Order
            {
                GameList = OrderLogic.GetShoppingList(),
                OrderStatus = OrderStatus.Waiting,
                Address = model.Order.Address,
                OrderDate = model.Order.OrderDate
            };
            var email = HttpContext.Session.GetString("_Name");
            order.UserId = AccountLogic.GetUser(email).Id;

            OrderLogic.AddOrder(order);
            int orderId = OrderLogic.GetOrderId();
            OrderLogic.AddGamesOrder(order.GameList, orderId);
            OrderLogic.ClearShoppingList();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult AddWishListItem(int gameId)
        {
            var email = HttpContext.Session.GetString("_Name");
            int userId = AccountLogic.GetUser(email).Id;
            OrderLogic.AddWishListItem(gameId, userId);
            return RedirectToAction("GamePage", "Game", new { Id = gameId });
        }

        public IActionResult ShoppingList()
        {
            ShoppingListViewModel model = new ShoppingListViewModel { ShoppingList = OrderLogic.GetShoppingList() };
            model.TotalPrice = OrderLogic.GetTotalPrice(model.ShoppingList);
            if (OrderLogic.GetShoppingList().Count == 0)
            {
                ModelState.AddModelError("CustomError", "Cart is empty, please add an order before you checkout");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult ShoppingList(int id)
        {
            OrderLogic.RemoveShoppingCartGame(id);
            ShoppingListViewModel model = new ShoppingListViewModel { ShoppingList = OrderLogic.GetShoppingList() };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddShoppinglist(int id)
        {
            var game = GameLogic.GetGame(id);
            OrderLogic.AddShoppingCartGame(game);
            return RedirectToAction("GamePage", "Game", new { id });
        }


        [HttpPost]
        public IActionResult RemoveWishList(int gameId)
        {
            var email = HttpContext.Session.GetString("_Name");
            int userId = AccountLogic.GetUser(email).Id;
            OrderLogic.RemoveWishListItem(gameId, userId);
            return RedirectToAction("Account", "Account");
        }
    }
}