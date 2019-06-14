using Logic;
using Microsoft.AspNetCore.Http;
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
            if (HttpContext.Session.GetString("_IsAdmin") != "1")
            {
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult AddGames(AddGameViewModel model)
        {
            Game game = new Game
            {
                Name = model.GameName,
                Price = model.Price,
                GameTag = model.GameTag,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate
            };
            Logic.AddGame(game);
            return RedirectToAction("Index","Home");
        }

    }
}