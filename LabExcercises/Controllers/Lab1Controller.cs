using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab1Controller : Controller
    {
        // GET: Lab1
        public ActionResult Exce3()
        {
            Employee employee = new Employee();

            employee.Name = "Kirankumar";
            employee.Gender = "Male";
            employee.Age = 30;

            return View(employee);
        }

        public ActionResult Exce4_1(string topic)
        {
            ViewBag.Topic = topic;
            return View();
        }
        public ActionResult Exce4_2(string student, string subject)
        {
            ViewBag.Student = student;
            ViewBag.Subject = subject;
            return View();
        }

        public JsonResult Exce5()
        {
            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("This");
            list.Add("Is");
            list.Add("Kiran");

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public string Exce6()
        {
            //return Content("<h1>Hello!</h1>"); // can be used when return type is ActionResult
            return "<h1>Hello!</h1>";
        }


    }
}