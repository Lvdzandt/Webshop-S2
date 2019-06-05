using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop_S2.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birthday { get; set; }
    }
}
