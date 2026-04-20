using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UserRegistrationWithEF_EDM_DB_First_CRUD.Models;

namespace UserRegistrationWithEF_EDM_DB_First_CRUD.Controllers
{
    public class UsersController : Controller
    {
        private EXAMPLE_28_DBEntities db = new EXAMPLE_28_DBEntities();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Country);
            return View(users.ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public JsonResult CheckUserName(string username, int? id)
        {
            var existingUsername = db.Users.SingleOrDefault<User>(u => u.Username == username && u.Id != id);
            bool isValid = existingUsername == null ? true : false;
            return Json(isValid, JsonRequestBehavior.AllowGet);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Firstname,Lastname,Password,Gender,Phone,Email,Age,State,ReceiveNewsLetters,Hobbies,DateOfSubscription,CountryId,MaritalStatus,Address,RegistrationFee")] User user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Password))
                {
                    ModelState.AddModelError("Password", "Password is required");
                    ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", user.CountryId);
                    return View(user);
                }

                if (ModelState.IsValid)
                {
                    System.Diagnostics.Debug.WriteLine("Form is valid...");
                    user.Hobbies = string.Join(",", user.Hobbies);
                    db.Users.Add(user);
                    db.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("User created in db...");
                    return RedirectToAction("Index");
                }

                ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", user.CountryId);
                return View(user);
            }
            catch (Exception ex)
            {
                ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", user.CountryId);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                var sqlExc = ex.InnerException.InnerException as System.Data.SqlClient.SqlException;

                if (sqlExc != null && sqlExc.Message.Contains("UQ_USER_EMAIL"))
                {
                    ModelState.AddModelError("Email", "Duplicate email");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong");
                }

                return View(user);
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            ViewBag.Hobbies = string.IsNullOrEmpty(user.Hobbies) ? new string[] { } : user.Hobbies.Split(',');
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", user.CountryId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Username,Firstname,Lastname,Password,Gender,Phone,Email,Age,State,ReceiveNewsLetters,Hobbies,DateOfSubscription,CountryId,MaritalStatus,Address,RegistrationFee")] User user, string[] Hobbies)
        {
            if (ModelState.IsValid)
            {
                user.Hobbies = Hobbies != null ? string.Join(",", Hobbies) : "";
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Hobbies = Hobbies ?? new string[] { };
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", user.CountryId);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
