using MVC_CRUD.Models;
using System.Web.Mvc;

namespace MVC_CRUD.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Register user)
        {
            if (ModelState.IsValid)
            {
                RegisterRepository regRepo = new RegisterRepository();

                if (regRepo.AddUser(user))
                {
                    return View("Success", user);
                }
                return View(user);

            }
            return View(user);
        }

        public ActionResult Success() {
            return View();
        }
    }
}