using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop_S2.Models
{
    public class EditAccountModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime Birthday { get; set; }
    }
}
