using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_S2.Models
{
    public class AccountViewModel
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime Birthday { get; set; }
        public List<Order> Orders { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
