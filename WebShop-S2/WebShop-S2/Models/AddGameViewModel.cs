using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebShop_S2S2.Models
{
    

    public class AddGameViewModel
    {
        [Required(ErrorMessage = "Required")]
        public string GameName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string GameTag { get; set; }
        [Required(ErrorMessage = "Required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required")]
        public DateTime ReleaseDate { get; set; }
        public List<SelectListItem> TagList { get; } = new List<SelectListItem>()
        {
            new SelectListItem("Action","Action"),
            new SelectListItem("RPG","RPG"),
            new SelectListItem("FPS","FPS"),
            new SelectListItem("Platformer","Platformer")
        };

    }
}
