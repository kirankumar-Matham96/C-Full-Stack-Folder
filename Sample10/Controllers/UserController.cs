using Sample10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace Sample10.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                // cookie instances
                HttpCookie cookie1 = new HttpCookie("Uid");
                HttpCookie cookie2 = new HttpCookie("Pwd");

                // cookies assignment
                cookie1.Value = user.Username;
                cookie2.Value = user.Password;

                // cookie expiry time
                cookie1.Expires = DateTime.Now.AddDays(1);
                cookie2.Expires = DateTime.Now.AddDays(1);

                Response.Cookies.Add(cookie1);
                Response.Cookies.Add(cookie2);

                return RedirectToAction("Index3");
            }
            return View();
        }

        public ActionResult Index3()
        {
            HttpCookie c1, c2;

            c1 = Request.Cookies.Get("Uid");
            c2 = Request.Cookies.Get("Pwd");

            ViewBag.uid = c1.Value;
            ViewBag.pwd = c2.Value;

            return View();
        }
    }
}