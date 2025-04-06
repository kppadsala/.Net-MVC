using Microsoft.AspNetCore.Mvc;
using StronglyTypeHtmlHelpers.Models;
using System.Diagnostics;

namespace StronglyTypeHtmlHelpers.Controllers
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

        [HttpPost]
        public IActionResult Index(SignUp model)
        {
            ViewBag.Name = model.Name;
            ViewBag.Email = model.Email;
            ViewBag.PhoneNumber = model.PhoneNumber;
            ViewBag.City = model.City;
            ViewBag.Gender = model.Gender;

            return View();
        }


        public IActionResult Privacy()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Privacy(Calculation cal)
        {
            int num1 = cal.num1;
            int num2 = cal.num2;
            int addResult = num1 + num2;
            ViewBag.result = addResult;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
