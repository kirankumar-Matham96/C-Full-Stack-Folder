using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample2.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyName() {
            return View("Index");
        }

        public ActionResult YourName() {
            ViewBag.Name = "Kiran";
            return View("~/Views/My/Keshav.cshtml");
        }

        public ActionResult Add() {
            //string firstName = "Kiran";
            //string lastName = "Kumar";
            //string fullName = firstName + lastName;

            //return View(fullName); // cannot pass strings here. Onl integers and objects can be passed*

            int num1 = 20;
            int num2 = 47;
            int result = num1 + num2;
            return View(result);
        }
    }
}