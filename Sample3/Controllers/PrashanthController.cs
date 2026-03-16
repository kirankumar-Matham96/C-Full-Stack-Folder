using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3.Controllers
{
    public class PrashanthController : Controller
    {
        // GET: Prashanth
        public ActionResult Index()
        {
            int num1 = 25, num2 = 30;
            return View(num1+num2);
        }

        public ActionResult PrashanthPageDefault()
        {
            return View("Index");
        }

        public ActionResult PrashanthNewPage()
        {
            return View("~/Views/Prashanth/PrashanthNew.cshtml");
        }
    }
}