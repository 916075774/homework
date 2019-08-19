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
        //public ActionResult Index(string username, User model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    //验证码比较
        //    if (model.Captcha != Session[CaptchaController.CAPTCHA].ToString())
        //    {
        //        ModelState.AddModelError("Captcha", "* 验证码输出错误");
        //        return View(model);
        //    }

        //    return Redirect("/Register/Failed");
        //}

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

        [HttpPost]
        public ActionResult Index(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return View();
        }
        
    }
}