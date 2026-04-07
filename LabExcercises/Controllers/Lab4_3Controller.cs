using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab4_3Controller : Controller
    {
        // GET: Lab4_3
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab4_3 user)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(user))
                {
                    TempData["msg"] = $"Welcome {user.Username}";
                    return RedirectToAction("Welcome");
                }

                TempData["msg"] = "Invalid User";
                return RedirectToAction("Welcome");
            }

            return View(user);
        }

        [NonAction]
        public bool ValidateUser(Lab4_3 user)
        {
            return user.Username.ToLower() == "sathya" && user.Password == "sathya";
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}