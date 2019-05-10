using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum OrderStatus
    {
        Delivered,
        Shipped,

    }

    public class Order
    {
        public int Id { get; set; }
        public List<Game> GameList { get; set; }
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
