using LabExcercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabExcercises.Controllers
{
    public class Lab3_2Controller : Controller
    {
        // GET: Lab3_2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Numbers nums, string btn)
        {
            if (ModelState.IsValid) {
                switch (btn) {
                    case "add": ViewBag.result = nums.Num1 + nums.Num2;
                        break;
                    case "sub": ViewBag.result = nums.Num1 - nums.Num2;
                        break;
                    case "mul": ViewBag.result = nums.Num1 * nums.Num2;
                        break;
                    case "div": ViewBag.result = nums.Num1 / (double) nums.Num2;
                        break;
                    default: ViewBag.result = "Please enter the values";
                        break;

                }
                return View(nums);
            }
            
            return View(nums);
        }
    }
}