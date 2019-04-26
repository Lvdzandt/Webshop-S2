using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop_S2.Models
{
    public class LoginViewModel
    {   
        [Required(ErrorMessage = "Email was incorrect or has not been registered")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password was incorrect")]
        public string Password { get; set; }
    }
}
