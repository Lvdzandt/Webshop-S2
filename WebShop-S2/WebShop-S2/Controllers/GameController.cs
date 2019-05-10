using Logic;
using Microsoft.AspNetCore.Mvc;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class GameController : Controller
    {
        public readonly GameLogic Logic = new GameLogic(); 
        

        public IActionResult GamePage(int id)
        {
            GameViewModel model = new GameViewModel {Game = Logic.GetGame(id)};
            return View(model);
        }

        public IActionResult AllGames()
        {
            AllGameViewModel model = new AllGameViewModel {Games = Logic.GetAllGames()};
            return View(model);
        }

        
        
    }
}