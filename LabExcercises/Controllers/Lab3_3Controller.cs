using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab3_3Controller : Controller
    {
        // GET: Lab3_3
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab3_3 prod)
        {
            if (ModelState.IsValid) {
                ViewBag.totalBill = prod.Cost * prod.Qty;
                return View(prod);
            }

            return View(prod);
        }
    }
}