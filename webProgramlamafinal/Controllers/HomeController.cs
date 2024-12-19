using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webProgramlamafinal.Models;  // Do�ru namespace

namespace webProgramlamafinal.Controllers
{
    public class HomeController : Controller
    {
        // Tarif ekleme sayfas�n� g�r�nt�le
        [HttpGet]
        public IActionResult Add()
        {
            return View();  // "Add.cshtml" sayfas�n� render eder
        }

        // Tarif ekleme i�lemi
        [HttpPost]
        public IActionResult Add(Recipe model)
        {
            if (ModelState.IsValid)
            {
                // Tarif veritaban�na kaydedilirse buraya yaz�labilir
                // �rne�in: _context.Recipes.Add(model); _context.SaveChanges();
                return RedirectToAction("Index", "Home");  // Ba�ka bir sayfaya y�nlendirme
            }
            return View(model);  // Hata varsa tekrar formu g�ster
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







