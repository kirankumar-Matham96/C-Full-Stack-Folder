using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample6.Controllers
{
    public class MethodsController : Controller
    {
        // GET: Methods
        public int Add(int a, int b)
        {
            return a+b;
        }
    }
}