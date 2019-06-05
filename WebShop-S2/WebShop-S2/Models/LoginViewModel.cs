using System.ComponentModel.DataAnnotations;

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
