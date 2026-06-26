using Microsoft.AspNetCore.Mvc;
using MVCIntro2026VT.Models;
using System.Diagnostics;

namespace MVCIntro2026VT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name = "kalle")
        {
            TempData["Name"] = name;
            ViewBag.Name = name;

            List<string> model = new List<string> { "Hej", "på", "dig" }; 

            return View(model);
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

        [HttpGet]
        public IActionResult GetValues()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult GetValues(string name, int salary)
        {
            return View(); 
        }

        public IActionResult GetValuesWithModel()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult GetValuesWithModel(Employee employee)
        {
            return View(); 
        }

    }
}
