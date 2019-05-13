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
        public readonly IOrderContext OrderContext = new OrderSqlContext();

        public void AddOrder(Order order)
        {
            OrderContext.AddOrder(order);
        }
    }
}
