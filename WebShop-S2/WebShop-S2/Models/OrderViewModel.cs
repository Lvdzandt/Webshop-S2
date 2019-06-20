using System.ComponentModel.DataAnnotations;
using Model;

namespace WebShop_S2.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        [Required(ErrorMessage = "Adress required")]
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
