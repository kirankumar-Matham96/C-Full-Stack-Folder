using EF_JQUER_AJAX_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_JQUER_AJAX_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        EMPLOYEE_WITH_JQUERY_DBEntities1 db;
        public EmployeeController()
        {
            db = new EMPLOYEE_WITH_JQUERY_DBEntities1();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployees()
        {
            List<Employee> employees = db.Employees.ToList();

            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetEmployeeById(int id)
        {
            Employee employee = db.Employees.FirstOrDefault(e => e.id == id);

            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddEmployee(Employee emp)
        {
            try
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return Json(new { success = true, message = "User added successfully" });
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            Employee emp = db.Employees.FirstOrDefault(e => e.id == id);
            return View();
        }

        [HttpPost]
        public JsonResult UpdateEmployee(Employee emp)
        {
            try
            {
                Employee employee = db.Employees.FirstOrDefault(e => e.id == emp.id);
                if (employee != null)
                {
                    employee.name = emp.name;
                    employee.salary = emp.salary;
                    db.SaveChanges();
                    return Json(new { success = true, message = "User updated successfully" });
                }
                else
                {
                    return Json(new { success = true, message = "User not found!" });
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        [HttpPost]
        public JsonResult DeleteEmployee(int id)
        {
            try
            {
                Employee emp = db.Employees.FirstOrDefault(e => e.id == id);
                if (emp != null)
                {
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    return Json(new { success = true, message = "User deleted successfully" });
                }
                return Json(new { success = false, message = "User not found" });
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}