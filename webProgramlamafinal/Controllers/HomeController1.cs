using Microsoft.AspNetCore.Mvc;

namespace webProgramlamafinal.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
