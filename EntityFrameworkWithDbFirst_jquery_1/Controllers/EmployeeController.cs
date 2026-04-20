using EntityFrameworkWithDbFirst_jquery_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkWithDbFirst_jquery_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SearchEmp(string str)
        {
            EMPLOYEE_WITH_JQUERY_DBEntities1 db = new EMPLOYEE_WITH_JQUERY_DBEntities1();
            List<Employee> empList = db.Employees.Where(e => e.name.ToLower().Contains(str)).ToList();
            return Json(empList, JsonRequestBehavior.AllowGet);
        }
    }
}