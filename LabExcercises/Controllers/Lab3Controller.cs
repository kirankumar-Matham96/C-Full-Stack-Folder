using LabExcercises.Models;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab3Controller : Controller
    {
        // GET: Lab3
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lab3_1 user)
        {
            if (ModelState.IsValid)
            {   
                TempData["fullname"] = $"{user.Firstname} {user.Lastname}";
                TempData.Keep("fullname");
                return View();
                //return RedirectToAction("Index2");
            }

            return View();
        }

        public ActionResult Index2() {
            return View();
        }
    }
}