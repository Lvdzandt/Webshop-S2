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

        public IActionResult GamePage(int id)
        {
            GameViewModel model = new GameViewModel();
            model.Game = _logic.GetGame(id);
            return View(model);
        }

        public IActionResult AllGames()
        {
            AllGameViewModel model = new AllGameViewModel();
            model.Games = _logic.GetAllGames();
            return View(model);
        }

        
        
    }
}