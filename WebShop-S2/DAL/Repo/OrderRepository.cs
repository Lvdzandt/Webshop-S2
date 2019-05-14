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

        public void AddOrder(Order order)
        {
            OrderContext.AddOrder(order);
        }

        public List<Order> GetAllOrderById(int id)
        {
            return OrderContext.GetAllOrdersById(id);
        }
    }
}
