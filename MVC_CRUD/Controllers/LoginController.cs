using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login user)
        {
            LoginRepository loginRepository = new LoginRepository();

            if (ModelState.IsValid)
            {
                if (loginRepository.VerifyUser(user.Username, user.Password))
                {
                    return View("Success", user);
                }
                ViewBag.message = "Invalid username or password";
                return View();
            }
            return View(user);
        }

        public ActionResult Success() {
            return View();
        }

    }
}