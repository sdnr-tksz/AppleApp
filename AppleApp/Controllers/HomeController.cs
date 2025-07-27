using Microsoft.AspNetCore.Mvc;

namespace AppleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
