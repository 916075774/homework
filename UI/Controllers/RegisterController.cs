using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.User;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        SQLContext db = new SQLContext();

        [HttpGet]
        public ActionResult Index(int? id)
        {
            User model = new User
            {
                UserName = "你好",
                IsMale = true
            };
            ViewBag.Id = id;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            db.Users.Add(user);
            db.SaveChanges();

            return Redirect("/Register/Reminder");
        }

        public ActionResult Reminder()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult Failed(int? id)
        {
            ViewBag.Id = id;
            return PartialView();
        }

        //[HttpPost]
        //public ActionResult Index(User user)
        //{
        //    db.Users.Add(user);
        //    db.SaveChanges();
        //    return View();
        //}

    }
}