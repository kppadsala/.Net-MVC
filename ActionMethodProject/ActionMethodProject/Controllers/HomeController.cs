using ActionMethodProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionMethodProject.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public int  AboutUs(int id)
        {
            return id;
        }

        public IActionResult Career()
        {
            return View();
        }
        public  string show()
        {
            return "Page Is Not Found Move On Next Page";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
