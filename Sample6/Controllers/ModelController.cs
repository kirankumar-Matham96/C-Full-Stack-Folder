using Sample6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample6.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult DisplayProduct()
        {

            Product p1 = new Product() { Id = 120, Name = "Prod1", Price = 4120.325, Quantity = 96 };
            Product p2 = new Product() { Id = 121, Name = "Prod2", Price = 5120.35, Quantity = 3 };
            Product p3 = new Product() { Id = 122, Name = "Prod3", Price = 120.32, Quantity = 16 };

            List<Product> list = new List<Product>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            return View(list);
        }
    }
}