using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample7.Controllers
{
    public class StandardViewsController : Controller
    {
        // GET: StandardViews
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult UserData()
        {
            return View();
        }
    }
}