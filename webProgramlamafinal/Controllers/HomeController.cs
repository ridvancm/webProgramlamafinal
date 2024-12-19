using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webProgramlamafinal.Models;  // Doðru namespace

namespace webProgramlamafinal.Controllers
{
    public class HomeController : Controller
    {
        // Tarif ekleme sayfasýný görüntüle
        [HttpGet]
        public IActionResult Add()
        {
            return View();  // "Add.cshtml" sayfasýný render eder
        }

        // Tarif ekleme iþlemi
        [HttpPost]
        public IActionResult Add(Recipe model)
        {
            if (ModelState.IsValid)
            {
                // Tarif veritabanýna kaydedilirse buraya yazýlabilir
                // Örneðin: _context.Recipes.Add(model); _context.SaveChanges();
                return RedirectToAction("Index", "Home");  // Baþka bir sayfaya yönlendirme
            }
            return View(model);  // Hata varsa tekrar formu göster
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
    }
}







