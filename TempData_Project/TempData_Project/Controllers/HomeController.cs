using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TempData_Project.Models;

namespace TempData_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["CarData"] = "Harrier Is My Fav Car It Is SUV Car";
            string[] Games = { "Cricket", "Hockey", "VollyBall", "FootBall" };
            TempData["GamesArr"] = Games;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()

        {
            if (TempData["GamesArr"] != null)
            {
                TempData.Keep("GamesArr");

            }
            if (TempData["CarData"] != null)
            {
                TempData.Keep("CarData");  
            }
            return View();
        }

        public IActionResult Career()
        {
            if (TempData["GamesArr"] != null)
            {
                TempData.Keep("GamesArr");
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
