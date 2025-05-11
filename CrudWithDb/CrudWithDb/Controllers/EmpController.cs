using CrudWithDb.Src;
using Microsoft.AspNetCore.Mvc;

namespace CrudWithDb.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationContext context;
        public EmpController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result=context.Emp.ToList();
            return View(result);
        }
    }
}
