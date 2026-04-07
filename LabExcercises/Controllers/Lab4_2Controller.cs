using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab4_2Controller : Controller
    {
        // GET: Lab4_2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab4_2 emp)
        {
            if (ModelState.IsValid)
            {
                CalcDa(emp);
                CalcHra(emp);
                CalcTotal(emp);
                return View(emp);
            }
            return View(emp);
        }

        [NonAction]
        public void CalcDa(Lab4_2 emp)
        {
            emp.Da = 0.2 * emp.BasicSalary;
        }

        [NonAction]
        public void CalcHra(Lab4_2 emp)
        {
            emp.Hra = 0.4 * emp.BasicSalary;
        }

        [NonAction]
        public void CalcTotal(Lab4_2 emp)
        {
            emp.TotalSalary = emp.BasicSalary + emp.Hra + emp.Da;
        }


    }
}