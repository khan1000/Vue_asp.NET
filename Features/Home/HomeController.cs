using Microsoft.AspNetCore.Mvc;

namespace BionicalTechTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Features/Home/Index.cshtml");
            
        }
    }
}
