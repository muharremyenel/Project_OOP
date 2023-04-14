using Microsoft.AspNetCore.Mvc;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void Topla() 
        //{
          //  int sayi1 = 4;
            //int sayi2 = 5;
            //int toplam = sayi1 + sayi2;
        //}

        void messages()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Proje çok iyi duruyor";
            ViewBag.m3 = "Hello";
        }



        public IActionResult Index()
        {
            messages();
            return View();
        }

        public IActionResult Urunler()
        {
            messages();
            return View();
        }
    }
}
