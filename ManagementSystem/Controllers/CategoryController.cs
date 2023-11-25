using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
