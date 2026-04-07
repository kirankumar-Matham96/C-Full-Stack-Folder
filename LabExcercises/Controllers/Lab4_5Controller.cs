using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab4_5Controller : Controller
    {
        [NonAction]
        public void LoadCourses()
        {
            ViewBag.courses = new List<string>() {
                "C(750/-)",
                ".Net(3000/-)",
                "Java(3000/-)",
                "MVC(700/-)"
            };
        }
        public ActionResult Index()
        {
            LoadCourses();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab4_5 course)
        {
            if (ModelState.IsValid)
            {
                TempData["course"] = course;
                TempData.Keep("cname");

                return RedirectToAction("welcome");
            }

            LoadCourses();
            return View(course);
        }

        public ActionResult welcome()
        {
            var course = TempData["course"] as Lab4_5;
            return View(course);
        }

    }
}