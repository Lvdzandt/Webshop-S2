using System;
using Model;
using System.Collections.Generic;

namespace WebShop_S2.Models
{
    public class AllGameViewModel
    {
       public List<Game> Games { get; set; }
       public List<Tuple<string,int>> TagCount { get; set; }
        
    }
}
