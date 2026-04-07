using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab4_4Controller : Controller
    {
        // GET: Lab4_4
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab4_4 user)
        {
            TempData["username"] = user.Username;
            if(ModelState.IsValid) return RedirectToAction("welcome");
            return View(user);
        }

        public ActionResult welcome()
        {
            return View();
        }
    }
}