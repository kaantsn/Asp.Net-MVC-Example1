using Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 9.99m, CreatedAt = DateTime.Now },
                new Product { Id = 2, Name = "Product 2", Price = 19.99m, CreatedAt = DateTime.Now },
                new Product { Id = 3, Name = "Product 3", Price = 29.99m, CreatedAt = DateTime.Now }
            };

            return View(products);
        }
    }
}