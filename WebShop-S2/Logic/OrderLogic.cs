using DAL.Repo;
using Model;
using System.Collections.Generic;

namespace Logic
{
    public class OrderLogic
    {
        private OrderRepository _repo = new OrderRepository();

        public List<Game> GetShoppingList()
        {
            return ShoppingCart.GameList;
        }

        public double GetTotalPrice(List<Game> games)
        {
            double totalPrice = 0;
            foreach (var g in games)
            {
                totalPrice += g.Price;
            }
            return totalPrice;
        }


    }
}
