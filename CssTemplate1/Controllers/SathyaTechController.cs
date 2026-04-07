using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CssTemplate1.Controllers
{
    public class SathyaTechController : Controller
    {
        // GET: SathyaTech
        [OutputCache(Duration =120)]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 120)]
        public ActionResult About() {
            return View();
        }

        [OutputCache(Duration = 120)]
        public ActionResult Contact()
        {
            return View();
        }

        [OutputCache(Duration = 120)]
        public ActionResult Services()
        {
            return View();
        }
    }
}