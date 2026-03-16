using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample6.Controllers
{
    public class RazorStatementsController : Controller
    {
        // GET: RazorStatements
        public ActionResult RazorPage()
        {
            List<string> list = new List<string>();

            list.Add("Keshav");
            list.Add("Kiran");
            list.Add("Sujaath");

            return View(list);
        }

        public ActionResult PrintNumbers()
        {
            return View();
        }
    }
}