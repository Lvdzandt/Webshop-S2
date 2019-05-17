using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface;
using DAL.SQLContext;
using Model;

namespace DAL.Repo
{
    public class OrderRepository
    {
        public  IOrderContext OrderContext = new OrderSqlContext();
        public OrderRepository()
        {

        }


        public Order GetOrder(int id)
        {
            return OrderContext.GetOrder(id);
        }
        public void AddOrder(Order order)
        {
            OrderContext.AddOrder(order);
        }

        public List<Order> GetAllOrderById(int id)
        {
            return OrderContext.GetAllOrdersById(id);
        }

        public List<Tuple<int, int>> GetAllGames()
        {
            return OrderContext.GetAllGames();
        }

        public void AddGamesOrder(List<Game> games, int orderId)
        {
            OrderContext.AddGamesOrder(games,orderId);
        }

        public int GetOrderId()
        {
            return OrderContext.GetOrderId();
        }

    }
}
