using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab4_1Controller : Controller
    {
        // GET: Lab4_1
        [OutputCache(Duration =180)]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab4_1 student)
        {
            student.TotalMarks = student.Marks1 + student.Marks2 + student.Marks3;
            return View(student);
        }
    }
}