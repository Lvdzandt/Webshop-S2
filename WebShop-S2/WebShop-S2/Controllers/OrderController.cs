using System;
using System.Collections.Generic;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
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
            if (_logic.GetShoppingList().Count != 0)
            {
                AccountLogic logic = new AccountLogic();
                OrderViewModel model = new OrderViewModel();
                Order order = new Order();
                order.GameList = _logic.GetShoppingList();
                model.Order = order;
                model.TotalPrice = _logic.GetTotalPrice(model.Order.GameList);
                model.Order.UserId = logic.GetUser(CurrUser.Username).Id;
                
                return View(model);
            }
            
            return RedirectToAction("ShoppingList", "Order");
        }
        [HttpPost]
        public IActionResult Checkout(OrderViewModel model)
        {
            AccountLogic logic = new AccountLogic();
            Order order = new Order();
            order.GameList = _logic.GetShoppingList();
            order.OrderStatus = OrderStatus.Waiting;
            order.Address = model.Order.Address;
            order.OrderDate = model.Order.OrderDate;
            order.UserId = logic.GetUser(CurrUser.Username).Id;

            _logic.AddOrder(order);
            _logic.ClearShoppinglist();
            return RedirectToAction("Index", "Home");
        }

        
        public IActionResult CheckOut(Order order)
        {
            order.GameList = _logic.GetShoppingList();
            order.OrderStatus = OrderStatus.Waiting;
            _logic.AddOrder(order);
            _logic.ClearShoppinglist();
            return RedirectToAction("Index","Home");
        }

        public IActionResult ShoppingList()
        {
            ShoppingListViewModel model = new ShoppingListViewModel { ShoppingList = _logic.GetShoppingList() };
            model.TotalPrice = _logic.GetTotalPrice(model.ShoppingList);
            if (_logic.GetShoppingList().Count == 0)
            {
                ModelState.AddModelError("CustomError", "Cart is empty, please add an order before you checkout");
            }
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