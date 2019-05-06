using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Mvc;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class GameController : Controller
    {
        GameLogic _logic = new GameLogic(); 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GamePage()
        {
            GameViewModel model = new GameViewModel();
            model.Game = _logic.GetGame(1);
            return View(model);
        }

        public IActionResult AllGames()
        {
            AllGameViewModel model = new AllGameViewModel();
            return View(model);
        }

        
    }
}