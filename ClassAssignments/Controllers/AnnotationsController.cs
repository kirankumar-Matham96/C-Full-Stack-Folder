using ClassAssignments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassAssignments.Controllers
{
    public class AnnotationsController : Controller
    {
        // GET: Annotations
        public ActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Movies(Movie movie)
        {
            TempData["id"] = movie.Id;
            TempData["title"] = movie.Title;
            TempData["desc"] = movie.Description;
            TempData["dor"] = movie.RealeaseDate;
            TempData["genre"] = movie.Genre;
            TempData["rating"] = movie.Rating;

            return RedirectToAction("MoviesData");
        }

        public ActionResult MoviesData()
        {
            return View();
        }
    }
}