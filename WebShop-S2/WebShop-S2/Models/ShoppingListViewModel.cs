using Model;
using System.Collections.Generic;

namespace WebShop_S2.Models
{
    public class ShoppingListViewModel
    {
        public List<Game> ShoppingList { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
