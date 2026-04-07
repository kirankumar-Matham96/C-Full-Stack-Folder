using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassAssignments.Models;

namespace ClassAssignments.Controllers
{
    public class Assignment1Controller : Controller
    {
        // GET: Assignment1
        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(Calculator calc, string btn)
        {
            if (btn == "add")
            {
                calc.Result = calc.First + calc.Second;
            }

            switch (btn)
            {
                case "add":
                    calc.Result = calc.First + calc.Second;
                    break;
                case "sub":
                    calc.Result = calc.First - calc.Second;
                    break;
                case "mul":
                    calc.Result = calc.First * calc.Second;
                    break;
                case "div":
                    calc.Result = calc.First / calc.Second;
                    break;

                default:
                    calc.Result = 0;
                    break;

            }

            return View(calc);
        }
    }
}