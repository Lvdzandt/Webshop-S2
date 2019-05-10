using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_S2.Models
{
    public class ShoppingListViewModel
    {
        public List<Game> ShoppingList { get; set; }
        public Double TotalPrice { get; set; }
    }
}
