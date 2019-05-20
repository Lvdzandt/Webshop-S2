using System;
using DAL.Repo;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class OrderLogic
    {
        private readonly OrderRepository _repo = new OrderRepository();

        public Order GetOrder(int id)
        {
            return _repo.GetOrder(id);
        }
        public List<Game> GetShoppingList()
        {
            return ShoppingCart.GameList;
        }

        public void AddOrder(Order order)
        {
            _repo.AddOrder(order);
        }

        public void ClearShoppinglist()
        {
            ShoppingCart.ClearList();
        }

        public List<Order> GetAllOrderById(int id)
        {
            return _repo.GetAllOrderById(id);
        }

        public List<Tuple<int, int>> GetAllGames()
        {
            return _repo.GetAllGames();
        }

        public int GetOrderId()
        {
            return _repo.GetOrderId();
        }

        public void AddGamesOrder(List<Game> games, int orderId)
        {
            _repo.AddGamesOrder(games,orderId);
        }

        public decimal GetTotalPrice(List<Game> games)
        {
            decimal totalPrice = 0;
            foreach (var g in games)
            {
                totalPrice += g.Price;
            }
            return totalPrice;
        }


    }
}
