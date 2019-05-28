using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_S2S2.Models
{
    

    public class AddGameViewModel
    {
        public string GameName { get; set; }
        public string GameTag { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
