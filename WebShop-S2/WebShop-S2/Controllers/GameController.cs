using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Game()
        {
            GameViewModel model = new GameViewModel();
            return View(model);
        }

        public IActionResult AllGames()
        {
            AllGameViewModel model = new AllGameViewModel();
            return View(model);
        }

        
    }
}