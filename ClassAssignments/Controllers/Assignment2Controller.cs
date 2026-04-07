using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassAssignments.Models;

namespace ClassAssignments.Controllers
{
    public class Assignment2Controller : Controller
    {
        // GET: Assignment2
        public ActionResult ClientStateManagement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClientStateManagement(User user)
        {
            Session["uname"] = user.Username;
            Session["email"] = user.Email;

            return RedirectToAction("UserDetails");
        }

        public ActionResult UserDetails()
        {
            return View();
        }
    }
}