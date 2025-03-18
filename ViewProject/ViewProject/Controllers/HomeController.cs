using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewProject.Models;

namespace ViewProject.Controllers
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
        public IActionResult About()

        {
            ViewData["Date"] = DateTime.Today.ToString();

            string[] Fruits = { "Apple", "Mango", "Banana", "Orange" };
            ViewData["FruitsArrary"] = Fruits;

            Employee krunal = new Employee();
            krunal.EmpId = 1;
            krunal.EmpName = "krunal padsala";
            krunal.EmpCity = "surat";

            ViewData["Employee"] = krunal;

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
