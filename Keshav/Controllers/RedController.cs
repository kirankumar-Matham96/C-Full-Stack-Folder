using Keshav.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keshav.Controllers
{
    public class RedController : Controller
    {
        List<Keshavaaaaa> list = new List<Keshavaaaaa>();


        // GET: Redirect
        [OutputCache(Duration =60*24)]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Keshavaaaaa k)
        {
            if (ModelState.IsValid)
            {
                AddToList(k);

                AddToDb(k);


                //Client Side with cookies
                //HttpCookie cookie1 = new HttpCookie("id");
                //HttpCookie cookie2 = new HttpCookie("name");
                //HttpCookie cookie3 = new HttpCookie("age");
                //HttpCookie cookie4 = new HttpCookie("loc");

                //cookie1.Value = k.Id.ToString();
                //cookie2.Value = k.Name;
                //cookie3.Value = k.Age.ToString();
                //cookie4.Value = k.Location;

                //cookie1.Expires = DateTime.Now.AddDays(1);

                //Response.Cookies.Add(cookie1);
                //Response.Cookies.Add(cookie2);
                //Response.Cookies.Add(cookie3);
                //Response.Cookies.Add(cookie4);

                //Session Storage
                //Session["id"] = k.Id;
                //Session["name"] = k.Name;
                //Session["age"] = k.Age;
                //Session["loc"] = k.Location;

                // Server Side
                //TempData["id"] = k.Id;
                //TempData.Keep("id");

                //TempData["name"] = k.Name;
                //TempData.Keep("name");

                //TempData["age"] = k.Age;
                //TempData.Keep("age");

                //TempData["loc"] = k.Location;
                //TempData.Keep("loc");

                // Application Storage
                //System.Web.HttpContext.Current.Application.Lock();

                //System.Web.HttpContext.Current.Application["id"] = k.Id;
                //System.Web.HttpContext.Current.Application["name"] = k.Name;
                //System.Web.HttpContext.Current.Application["age"] = k.Age;
                //System.Web.HttpContext.Current.Application["loc"] = k.Location;

                //System.Web.HttpContext.Current.Application.UnLock();


                return RedirectToAction("KeshavChanged");
            }
            return View(k);

        }

        public ActionResult KeshavChanged() {

            //ViewBag.id = Request.Cookies.Get("id").Value;
            //ViewBag.name = Request.Cookies.Get("name").Value;
            //ViewBag.age = Request.Cookies.Get("age").Value;
            //ViewBag.loc = Request.Cookies.Get("loc").Value;

            return View();
        }

        public ActionResult NewLayout() {
            return View();
        }

        [NonAction]
        public void AddToList(Keshavaaaaa k) {
            list.Add(k);
        }

        [NonAction]
        public void AddToDb(Keshavaaaaa k) {
            KeshavaaaaaRepository repo = new KeshavaaaaaRepository();
            repo.InsertUser(k);
        }

    }
}