using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationMessageSummaryMethods.Models;

namespace ValidationMessageSummaryMethods.Controllers
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
        public IActionResult Index(LoginForm loginData, string Name, string Email, string Password)
        {
            if (Name == null)
            {
                ModelState.AddModelError("Name", "Name Is Required");
            }
            if (Email == null)
            {
                ModelState.AddModelError("Email", "Email Is Required");
            }
            if (Password == null)
            {
                ModelState.AddModelError("Password", "Password Is Required");
            }
            if(ModelState.IsValid == true)
            {
                ModelState.Clear();
            }
            ViewBag.Name = loginData.Name;
            ViewBag.Email = loginData.Email;
            ViewBag.Password = loginData.Password;

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
