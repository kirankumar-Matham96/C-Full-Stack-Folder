using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 120)]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 120)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [OutputCache(Duration = 120)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}