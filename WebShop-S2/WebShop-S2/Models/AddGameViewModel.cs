using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebShop_S2S2.Models
{
    

    public class AddGameViewModel
    {
        public string GameName { get; set; }
        public string GameTag { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
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
