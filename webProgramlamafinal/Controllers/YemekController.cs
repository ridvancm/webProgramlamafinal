using Microsoft.AspNetCore.Mvc;
using WebProgramlamaFinal.Models;
using System.Collections.Generic;

namespace WebProgramlamaFinal.Controllers
{
    public class YemekController : Controller
    {
        private static List<Yemek> akdenizYemekleri = new List<Yemek>
        {
            new Yemek { Id = 1, Ad = "Zeytinyağlı Yaprak Sarma", Malzemeler = "500 gr asma yaprağı, 2 su bardağı pirinç, 2 soğan, 1 yemek kaşığı dolmalık fıstık, 1 yemek kaşığı kuş üzümü, 1/2 su bardağı zeytinyağı, 1/2 su bardağı su, Tuz, Karabiber, Nane, Limon suyu", Tarif = "Soğanı zeytinyağında kavurun. Pirinç, dolmalık fıstık ve kuş üzümünü ekleyip karıştırın. Baharat ve su ekleyip pirinçleri pişirin. Yapraklara harcı koyup sarın ve tencerede pişirin. ...", ResimUrl = "https://d17wu0fn6x6rgz.cloudfront.net/img/w/tarif/mgt/zeytinyagli_sarma.webp" }, 
            new Yemek { Id = 2, Ad = "İmam Bayıldı", Malzemeler = "4 patlıcan, 2 soğan, 3 domates, 4 diş sarımsak, 1/2 su bardağı zeytinyağı, 1 çay kaşığı şeker, Tuz, Karabiber, Maydanoz", Tarif = "Patlıcanları alacalı soyup kızartın. Soğanı zeytinyağında kavurun, doğranmış domates, sarımsak ve baharatları ekleyip pişirin. Harcı patlıcanların içine doldurup fırında pişirin. ...", ResimUrl = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/573e05a2-e4f0-4c0f-927d-011dd75b23e0/Derivates/2a1d0b57-fea5-452c-a29c-bf792673fc13.jpg" }, 
            new Yemek { Id = 3, Ad = "Fırında Sebzeli Balık", Malzemeler = "4 fileto balık, 2 patates, 2 havuç, 2 kabak, 2 domates, 1 limon, 1/4 su bardağı zeytinyağı, Tuz, Karabiber, Kekik", Tarif = "Sebzeleri doğrayıp tepsiye dizin. Üzerine balıkları yerleştirip baharat ve zeytinyağı ekleyin. Dilimlenmiş limonla süsleyip fırında pişirin. ...", ResimUrl = "https://cdn.kisikates.com.tr/image-cache/cache/recipe_main_image_large/https---cdn.kisikates.com.tr/recipe-media/8f2d42c422b1cf276b75beadd04010215991691a.jpeg" },
        };

        private static List<KullaniciTarifi> kullaniciAkdenizTarifleri = new List<KullaniciTarifi>
        {
            new KullaniciTarifi { Id = 1, Ad = "Fattoush", Malzemeler = "2 domates, 1 salatalık, 1 kırmızı soğan, 1 demet maydanoz, 2 dilim bayat ekmek, 1 limon suyu, 2 yemek kaşığı zeytinyağı, Tuz", Tarif = "Domates, salatalık, soğan ve maydanozu doğrayın. Bayat ekmeği kızartıp küçük parçalara ayırın. Limon suyu ve zeytinyağı ile karıştırıp servis yapın. ...", ResimUrl = "/images/fattoush.jpg" }
        };

        public IActionResult Akdeniz()
        {
            ViewBag.VideoUrl = "/videos/akdeniz.mp4";
            ViewBag.MusicUrl = "/music/akdeniz.mp3";
            ViewBag.KullaniciTarifleri = kullaniciAkdenizTarifleri;
            return View(akdenizYemekleri);
        }

        private static List<Yemek> turkYemekleri = new List<Yemek>
        {
            new Yemek { Id = 1, Ad = "Kebap", Malzemeler = "500 gr kuzu eti, 1 baş soğan, 2 domates, 2 biber, Tuz, Karabiber, Kimyon", Tarif = "Eti ve sebzeleri şişe dizin ve közde pişirin. ...", ResimUrl = "https://sehzademdoner.com/wp-content/uploads/2022/05/karisik-kebab.jpg" },
            new Yemek { Id = 2, Ad = "Mantı", Malzemeler = "2 su bardağı un, 1 yumurta, 1 çay bardağı su, 200 gr kıyma, 1 soğan, Tuz, Karabiber", Tarif = "Hamuru hazırlayıp küçük kareler kesin. Kıymalı harcı koyup kapatın ve haşlayın. ...", ResimUrl = "https://www.koylummantievi.com/wp-content/uploads/2021/12/maltepede-mantici-ko%CC%88ylu%CC%88m-manti-evi.jpeg" },
            new Yemek { Id = 3, Ad = "Baklava", Malzemeler = "500 gr baklavalık yufka, 250 gr tereyağı, 400 gr ceviz, 2 su bardağı şeker, 1.5 su bardağı su, 1 yemek kaşığı limon suyu", Tarif = "Yufkaları tereyağı ile yağlayıp üst üste dizin. Ceviz serpip tekrar yufka dizin ve fırında pişirin. Şerbet döküp servis yapın. ...", ResimUrl = "https://media.istockphoto.com/id/1195774604/tr/foto%C4%9Fraf/cevizli-antep-f%C4%B1st%C4%B1%C4%9F%C4%B1-t%C3%BCrk-usul%C3%BC-antep-baklavas%C4%B1-sunusu-t%C3%BCrk-mutfa%C4%9F%C4%B1ndan-baklava.jpg?s=612x612&w=0&k=20&c=u-K1GP_8bUwQDbP7C_XiJ2-3gsheeOXNcTOAJEm044U=" }
        };

        private static List<KullaniciTarifi> kullaniciTurkTarifleri = new List<KullaniciTarifi>
        {
            new KullaniciTarifi { Id = 1, Ad = "İçli Köfte", Malzemeler = "500 gr köftelik bulgur, 250 gr ince çekilmiş kıyma, 2 baş soğan, 1 yemek kaşığı biber salçası, 1 yemek kaşığı domates salçası, Tuz, Karabiber, Kırmızı biber, Tereyağı", Tarif = "Bulgur ve kıymayı yoğurun. İç harcı için soğan ve kıymayı kavurun. Hamuru açıp iç harcı koyup şekil verin ve haşlayın. ...", ResimUrl = "/images/icli_kofte.jpg" }
        };

        public IActionResult Turk()
        {
            ViewBag.VideoUrl = "/videos/turk.mp4";
            ViewBag.MusicUrl = "/music/turk.mp3";
            ViewBag.KullaniciTarifleri = kullaniciTurkTarifleri;
            return View(turkYemekleri);
        }

        private static List<Yemek> uzakDoguYemekleri = new List<Yemek>
        {
            new Yemek { Id = 1, Ad = "Sushi", Malzemeler = "2 su bardağı sushi pirinci, 3 su bardağı su, 1/2 su bardağı pirinç sirkesi, 1/4 su bardağı şeker, 1 çay kaşığı tuz, Nori yaprakları, Taze balık", Tarif = "Pirinci haşlayın, sirke, şeker ve tuz ekleyip karıştırın. Norileri pirinç ve balık ile sarın. ...", ResimUrl = "https://www.allrecipes.com/thmb/XT7-9MROYJZvNyQR4J40HGOVDmQ=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/19511smoked-salmon-sushi-rollfabeveryday4x3-159a22b4d3ac49fe9a146db94b53c930.jpg" },
            new Yemek { Id = 2, Ad = "Ramen", Malzemeler = "200 gr ramen eriştesi, 1 litre et suyu, 1 yumurta, 1 soğan, 2 diş sarımsak, 1 yemek kaşığı soya sosu, 1 çay kaşığı zencefil, Taze soğan", Tarif = "Erişteleri haşlayın. Et suyuna soğan, sarımsak ve zencefil ekleyip kaynatın. Erişte ve yumurta ekleyip servis yapın. ...", ResimUrl = "https://d3s8tbcesxr4jm.cloudfront.net/recipe-images/v0/japanese-naruto-ramen_large.jpg" },
            new Yemek { Id = 3, Ad = "Spring Roll", Malzemeler = "10 adet pirinç kağıdı, 2 havuç, 1 salatalık, 1 kırmızı biber, 1 demet nane, 1 demet kişniş, 100 gr pirinç eriştesi, Tatlı ekşi sos", Tarif = "Sebzeleri ince doğrayın. Pirinç kağıdını ıslatıp sebzeleri ve erişteleri içine sarın. Sos ile servis yapın. ...", ResimUrl = "https://saltedmint.com/wp-content/uploads/2024/01/Vegetable-Spring-Rolls-4.jpg" }
        };

        private static List<KullaniciTarifi> kullaniciUzakDoguTarifleri = new List<KullaniciTarifi>
        {
            new KullaniciTarifi { Id = 1, Ad = "Pho", Malzemeler = "200 gr pirinç eriştesi, 1 litre et suyu, 1 soğan, 1 çubuk tarçın, 2 yıldız anason, 2 yemek kaşığı balık sosu, Taze soğan, Kişniş", Tarif = "Et suyuna soğan, tarçın, anason ve balık sosunu ekleyip kaynatın. Pirinç eriştesi ve taze malzemeler ile servis yapın. ...", ResimUrl = "/images/pho.jpg" }
        };

        public IActionResult UzakDogu()
        {
            ViewBag.VideoUrl = "/videos/uzakdogu.mp4";
            ViewBag.MusicUrl = "/music/uzakdogu.mp3";
            ViewBag.KullaniciTarifleri = kullaniciUzakDoguTarifleri;
            return View(uzakDoguYemekleri);
        }
    }
}
