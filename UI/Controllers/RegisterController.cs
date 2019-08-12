using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Register;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Index(int? id)
        {

            RegisterModel model = new RegisterModel
            {
                UserName = "你好",
                IsMale = true
            };
            ViewBag.Id = id;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string username, RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ViewBag.UserName = username;

            return Redirect("/Register/Failed");
        }

        [ChildActionOnly]
        public PartialViewResult Reminder(int? id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        public ActionResult Failed()
        {
            return View();
        }
    }
}