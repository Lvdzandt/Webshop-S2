using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interface
{
    public interface IOrderContext
    {
        void AddOrder(Order order);
        List<Order> GetAllOrdersById(int id);
        //void AddGamesOrder(List<Game> games, int orderId);
    }
}
