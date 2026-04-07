using ClassAssignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments.Controllers
{
    public class ActionFiltersController : Controller
    {
        // GET: ActionFilters
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student student) {
            TempData["id"] = student.Id;
            TempData["name"] = student.Name;
            TempData["email"] = student.Email;
            //TempData["password"] = student.Password;
            TempData["maths"] = student.Maths;
            TempData["phsics"] = student.Physics;
            TempData["chemistry"] = student.Chemistry;

            CalculateTotal(student);
            
            return RedirectToAction("StudentDetails");
        }

        [NonAction]
        public void CalculateTotal(Student student) { 
            student.Total = student.Physics + student.Maths + student.Chemistry;
            TempData["total"] = student.Total;
        }

        public ActionResult StudentDetails() {
            return View();
        }
    }
}