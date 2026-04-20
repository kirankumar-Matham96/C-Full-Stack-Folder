using EntityFramework_4_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_4_CodeFirst.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext context = new EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> empList = context.Employees.ToList();

            return View(empList);
        }
    }
}