using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample6.Controllers
{
    public class RoutesController : Controller
    {
        // GET: Routes
        public ActionResult Display(int num)
        {
            return View(num);
        }
    }
}