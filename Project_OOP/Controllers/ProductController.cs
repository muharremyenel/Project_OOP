using Microsoft.AspNetCore.Mvc;
using Project_OOP.Entity;
using Project_OOP.ProjectContext;
using System.Security.Cryptography.Xml;

namespace Project_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = context.Products.Where(x => x.ProductID == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateProduct(int id)
        {
            var value = context.Products.Where(x => x.ProductID == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateProduct(Product p)
        {
            var value = context.Products.Where(x => x.ProductID == p.ProductID).FirstOrDefault();
            value.ProductName = p.ProductName;
            value.ProductPrice = p.ProductPrice;
            value.ProductStock = p.ProductStock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
