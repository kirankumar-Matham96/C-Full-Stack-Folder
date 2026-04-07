using System.Security.RightsManagement;
using System.Web.Mvc;
using System.Collections.Generic;
using ClassAssignments.Models;

namespace ClassAssignments.Controllers
{
    public class UserController : Controller
    {

        public void LoadHobbies() {
            ViewBag.Hobbies = new List<string>() { "Reading", "Coding", "Movies" };
        }

        // GET: User
        public ActionResult User()
        {
            LoadHobbies();
            return View();
        }

        [HttpPost]
        public ActionResult User(UserWithAnnotations user)
        {
            if (ModelState.IsValid)
            {
                TempData["user"] = user;
                TempData.Keep("user");
                return RedirectToAction("UserDetails");
            }

            LoadHobbies();
            return View(user); // *** if the view is StronglyTyped, always pass the object in View() ***
        }

        public ActionResult UserDetails()
        {
            var user = TempData["user"] as UserWithAnnotations;

            return View(user);
        }
    }
}