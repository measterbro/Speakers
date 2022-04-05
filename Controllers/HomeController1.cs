using Microsoft.AspNetCore.Mvc;

namespace Security2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
