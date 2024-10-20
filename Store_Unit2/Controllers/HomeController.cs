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


    }
}