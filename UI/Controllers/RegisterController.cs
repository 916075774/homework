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
            ViewData["greet"] = "Hello,小屿";

            IndexModel model = new IndexModel
            {
                UserName = "你好",
                IsMale = true
            };
            ViewBag.Id = id;

            return PartialView(model);
        }

        [HttpPost]
        public ActionResult Index(string username, IndexModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ViewBag.UserName = username;

            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Reminder(int? id)
        {
            ViewBag.Id = id;
            return PartialView();
        }

    }
}