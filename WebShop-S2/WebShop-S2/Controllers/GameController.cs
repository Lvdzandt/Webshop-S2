using System.Data;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebShop_S2.Models;
using WebShop_S2S2.Models;

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

        public IActionResult AddGame()
        {
            AddGameViewModel model = new AddGameViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddGames(AddGameViewModel model)
        {
            Game game = new Game();
            game.Name = model.GameName;
            game.Price = model.Price;
            game.GameTag = model.GameTag;
            game.Description = model.Description;
            game.ReleaseDate = model.ReleaseDate;
            Logic.AddGame(game);
            return RedirectToAction("AllGames","Game");
        }

        public IActionResult AllGames()
        {
            AllGameViewModel model = new AllGameViewModel {Games = Logic.GetAllGames()};
            model.TagCount = Logic.GetGameCount();
            return View(model);
        }

        
        
    }
}