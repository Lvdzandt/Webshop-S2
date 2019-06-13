using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public enum OrderStatus
    {
        Delivered,
        Shipped,
        Waiting
    }

    public class Order
    {
        public int Id { get; set; }
        public List<Game> GameList { get; set; }
        [Required(ErrorMessage = "Adress required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Date required")]
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }

        public Order()
        {
            GameList = new List<Game>();
        }
    }
}
