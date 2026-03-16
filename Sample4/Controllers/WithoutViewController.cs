using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample4.Controllers
{
    public class WithoutViewController : Controller
    {
        // GET: WithoutView
        public string WelcomeMessage()
        {
            return "Welcome to my Web App";
        }

        public string Greet(string name)
        {
            return $"Hello {name}";
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add2(int a, int b)
        {
            return $"Sum of {a} and {b} is: {a+b}";
        }

        public string OptionalParam(int? age)
        {
            return $"your age is: {age}";
        }

        public JsonResult GetJson()
        {
            List<string> list = new List<string>();
            list.Add("My");
            list.Add("name");
            list.Add("is");
            list.Add("Kiran");

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetJson2(string name, int age, string gender)
        {
            Hashtable ht = new Hashtable();
            ht["name"] = name;
            ht["age"] = age;
            ht["gender"] = gender;
            return Json(ht, JsonRequestBehavior.AllowGet);
        }

        public string ShowHTMLTag(string name)
        {
            return $"<h1>Hello {name}</h1>";
        }


    }
}