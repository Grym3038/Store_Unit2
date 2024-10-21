using Ganss.XSS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Store_Unit2.Models;
using System.Diagnostics;

namespace Store_Unit2.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext context { get; set; }
        public HomeController(ProductContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var Products = context.Products.OrderBy(m => m.Name).ToList();
            return View(Products);
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




        [HttpGet]
        public IActionResult ProductView(int id)
        {
            var product = context.Products.Find(id); 
            return View("ProductView", product); 
        }

        public IActionResult Delete(int id)
        {
            Product del = context.Products.Find(id);
            context.Products.Remove(del);
            context.SaveChanges();
            var c = context.Products.ToList();
            return View("Index", c);    
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("ProductForm");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var c = context.Products.Find(id);
            return View("ProductForm", c);

        }
        [HttpPost]
        public IActionResult Edit(Product c)
        {
            if (ModelState.IsValid)
            {
                var sanitizer = new HtmlSanitizer();
                product.Name = sanitizer.Sanitize(product.Name);
                product.Description = sanitizer.Sanitize(product.Description);

                if (c.Id == 0)
                {
                    context.Products.Add(c);
                }
                else
                {
                    context.Products.Update(c);

                }
                context.SaveChanges();
                var chars = context.Products.ToList();
                return View("Index", chars);
            }
            else { return View("ProductForm", c); }
        }
    }
}