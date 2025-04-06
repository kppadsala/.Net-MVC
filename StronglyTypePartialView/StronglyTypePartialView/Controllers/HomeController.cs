using Microsoft.AspNetCore.Mvc;
using StronglyTypePartialView.Models;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Xml.Linq;

namespace StronglyTypePartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Home

        List<Product> ProductList = new List<Product>()
{
    new Product{id=1, name="SamSung Phone", price=80000, Picture="/Images/Samsung.jpg"},
    new Product{id=2, name="Boat Airbudes", price=8000, Picture="/Images/Boat.jpg"},
    new Product{id=3, name="Volvo Cars", price=12800000, Picture="/Images/Volvo.jpg"}
};

        public IActionResult Index()
        {
            return View(ProductList);
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
