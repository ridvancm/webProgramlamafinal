using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webProgramlamafinal.Models;  // Doðru namespace

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

        // Üye Ol sayfasýný görüntüle
        [HttpGet]
        public IActionResult Register()
        {
            return View();  // "Register.cshtml" sayfasýný render eder
        }

        // Üye Ol iþlemi
        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullanýcýyý veritabanýna kaydedin
                // Örneðin: _context.Users.Add(model); _context.SaveChanges();
                return RedirectToAction("Login");  // Baþarýlý kayýt sonrasý Login sayfasýna yönlendirme
            }
            return View(model);  // Hata varsa tekrar formu göster
        }

        // Giriþ Yap sayfasýný görüntüle
        [HttpGet]
        public IActionResult Login()
        {
            return View();  // "Login.cshtml" sayfasýný render eder
        }

        // Giriþ Yap iþlemi
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullanýcý doðrulama iþlemleri buraya yazýlabilir
                // Örneðin: var user = _context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
                // if (user != null) { return RedirectToAction("Index"); }

                return RedirectToAction("Index", "Home");  // Baþarýlý giriþ sonrasý ana sayfaya yönlendirme
            }
            return View(model);  // Hata varsa tekrar formu göster
        }

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
    }
}
