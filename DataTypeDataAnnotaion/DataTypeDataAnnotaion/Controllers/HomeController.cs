using DataTypeDataAnnotaion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataTypeDataAnnotaion.Controllers
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
        public IActionResult Index(SignUpPage signupData)
        {
            ViewBag.EmpName = signupData.EmpName;
            ViewBag.EmpAddress = signupData.EmpAddress;
            ViewBag.EmpPassword = signupData.EmpPassword;
            ViewBag.EmpJoiningDate = signupData.EmpJoiningDate;
            ViewBag.EmpWorkStaringTime = signupData.EmpWorkStaringTime;


            if (ModelState.IsValid == true)
            {
                ViewData["SuccessageMessage"] = "<script>alert('Data Has Been SuccessageFully')</script>";
                ModelState.Clear();
            }
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
