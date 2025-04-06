using Microsoft.AspNetCore.Mvc;
using SessionProject.Models;
using System.Diagnostics;

namespace SessionProject.Controllers
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
            ViewData["var1"] = "Data Come From ViewData";
            ViewBag.var2 = "Data Come From ViewBag";
            TempData["var3"] = "Data Come From TempData";
            Session["var4"] = "Data Come From Session";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
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
