using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() =>  View(); 

        public IActionResult SongForm() => View(); 

        [HttpPost]
        public IActionResult Sing() {
            HttpContext.Session.SetString("Bottles", Request.Form["Bottles"]);
            return View();
        }

        [HttpGet]
        public IActionResult CreateStudent() =>  View(); 

        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            return View(student);
        }

        public IActionResult Error() {
            return View();
        }
    }
}