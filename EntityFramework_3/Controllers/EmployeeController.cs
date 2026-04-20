using EntityFramework_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_3.Controllers
{
    public class EmployeeController : Controller
    {
        // initializing db entity class
        EF_DB_2Entities db = new EF_DB_2Entities();

        // GET: Employee
        public ActionResult Read()
        {
            var employeesList = db.Employees.ToList();

            return View(employeesList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Read");
            }

            return View(emp);
        }

        public ActionResult Update(int id)
        {
            var empData = db.Employees.Where(emp => emp.eno == id).SingleOrDefault();
            return View(empData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, Employee emp)
        {
            if (ModelState.IsValid)
            {
                Employee empData = db.Employees.Where(e => e.eno == id).FirstOrDefault();

                if (empData != null)
                {
                    empData.ename = emp.ename;
                    empData.job = emp.job;
                    empData.salary = emp.salary;
                    empData.deptno = emp.deptno;
                    db.SaveChanges();
                    return RedirectToAction("Read");
                }
                return View(emp);

            }
            return View(emp);
        }

        public ActionResult Delete(int id)
        {
            Employee empData = db.Employees.Where(e => e.eno == id).SingleOrDefault();
            if (empData != null) {
                db.Employees.Remove(empData);
                db.SaveChanges();
                return RedirectToAction("Read", db.Employees.ToList());
            }
            return RedirectToAction("Read", db.Employees.ToList());
        }
    }
}