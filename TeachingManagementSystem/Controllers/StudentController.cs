using Microsoft.AspNetCore.Mvc;

namespace TeachingManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
