using ClassAssignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments.Controllers
{
    public class Assignment3Controller : Controller
    {
        // GET: Assignment3
        public ActionResult ServerStateManagement()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ServerStateManagement(User user)
        {
            System.Web.HttpContext.Current.Application.Lock();
            if (System.Web.HttpContext.Current.Application["count"] == null)
            {
                System.Web.HttpContext.Current.Application["count"] = 1;
            }
            else
            {
                System.Web.HttpContext.Current.Application["count"] = (int)System.Web.HttpContext.Current.Application["count"] + 1;
            }
            System.Web.HttpContext.Current.Application["uname"] = user.Username;
            System.Web.HttpContext.Current.Application["email"] = user.Email;
            System.Web.HttpContext.Current.Application.UnLock();

            return RedirectToAction("UserManagement");
        }

        public ActionResult UserManagement()
        {
            return View();
        }
    }
}