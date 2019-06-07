using System.Diagnostics;
using Logic;
using Microsoft.AspNetCore.Mvc;
using WebShop_S2.Models;

namespace WebShop_S2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GameLogic logic = new GameLogic();
            AllGameViewModel model = new AllGameViewModel
            {
                Games = logic.GetAllGames(),
                TagCount = logic.GetGameCount()
            };
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
