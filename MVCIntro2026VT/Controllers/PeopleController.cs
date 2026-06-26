using Microsoft.AspNetCore.Mvc;

namespace MVCIntro2026VT.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
