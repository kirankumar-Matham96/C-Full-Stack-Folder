using ClassAssignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments.Controllers
{
    public class Assignment5Controller : Controller
    {
        // GET: Assignment5: Annotations
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AnnotatedMovie movie)
        {
            if (ModelState.IsValid) { 

                TempData["id"] = movie.ID;
                TempData["title"] = movie.Title;
                TempData["dor"] = movie.ReleaseDate;
                TempData["genre"] = movie.Genre;
                TempData["price"] = movie.Price;
                TempData["rating"] = movie.Rating;

                return RedirectToAction("Index2");
            }

            return View();
        }

        public ActionResult Index2() {
            return View();
        }
    }
}