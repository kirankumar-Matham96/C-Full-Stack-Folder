using MVC_CRUD2.DataAccess;
using MVC_CRUD2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD2.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userRepo;

        public UserController()
        {
            IDBHelper helper = new DBHelper();
            userRepo = new UserRepository(helper);
        }



        // GET: User
        public ActionResult Index()
        {
            User model = new User();

            try
            {
                model.Hobbies = userRepo.GetAllHobbies();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                model.Hobbies = new List<Hobby>();
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(User userModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int userId = userRepo.AddUser(userModel);
                    return RedirectToAction("GetUserData", new { id = userId});
                }
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            userModel.Hobbies = userRepo.GetAllHobbies();
            return View(userModel);
        }

        public ActionResult GetUserData(int id)
        {
            var user = userRepo.GetUsersWithHobbies(id);
            return View(user);
        }
    }
}