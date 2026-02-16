using Microsoft.AspNetCore.Mvc;

namespace Student_Controller.cs.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() 
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
