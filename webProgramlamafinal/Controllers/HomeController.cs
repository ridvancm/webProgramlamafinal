using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webProgramlamafinal.Models;  // Do�ru namespace

namespace webProgramlamafinal.Controllers
{
    public class HomeController : Controller
    {
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

        // �ye Ol sayfas�n� g�r�nt�le
        [HttpGet]
        public IActionResult Register()
        {
            return View();  // "Register.cshtml" sayfas�n� render eder
        }

        // �ye Ol i�lemi
        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullan�c�y� veritaban�na kaydedin
                // �rne�in: _context.Users.Add(model); _context.SaveChanges();
                return RedirectToAction("Login");  // Ba�ar�l� kay�t sonras� Login sayfas�na y�nlendirme
            }
            return View(model);  // Hata varsa tekrar formu g�ster
        }

        // Giri� Yap sayfas�n� g�r�nt�le
        [HttpGet]
        public IActionResult Login()
        {
            return View();  // "Login.cshtml" sayfas�n� render eder
        }

        // Giri� Yap i�lemi
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullan�c� do�rulama i�lemleri buraya yaz�labilir
                // �rne�in: var user = _context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
                // if (user != null) { return RedirectToAction("Index"); }

                return RedirectToAction("Index", "Home");  // Ba�ar�l� giri� sonras� ana sayfaya y�nlendirme
            }
            return View(model);  // Hata varsa tekrar formu g�ster
        }

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
    }
}
