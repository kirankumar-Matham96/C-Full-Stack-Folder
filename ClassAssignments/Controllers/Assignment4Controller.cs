using ClassAssignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments.Controllers
{
    public class Assignment4Controller : Controller
    {
        // GET: Assignment4
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            // using ViewData
            ViewData["uname"] = user.Username;
            ViewData["email"] = user.Email;
            
            // using TempData
            TempData["uname"] = user.Username;
            TempData["email"] = user.Email;
            TempData["user"] = user;
            TempData.Keep("uname");

            return View();
        }

        public ActionResult TempDataView() {

            if (TempData.ContainsKey("uname"))
            {
                ViewBag.uname = TempData["uname"];
            }

            return View();
        }
    }
}