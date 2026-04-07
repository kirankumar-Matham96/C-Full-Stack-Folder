using Sample11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample11.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Student(Student student)
        {
            if (ModelState.IsValid)
            {
                student.TotalMarks = student.MathsMarks + student.ScienceMarks + student.SocialMarks;
                student.AverageMarks = student.TotalMarks / 3;
                student.Percentage = student.TotalMarks * 100 / 75;
            }
            return View(student);
        }

    }
}