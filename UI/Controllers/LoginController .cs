using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Login;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            LoginModel model = new LoginModel{};
            return View(model);

        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //验证码比较
            if (model.Captcha != Session[CaptchaController.CAPTCHA].ToString())
            {
                ModelState.AddModelError("Captcha", "* 验证码输出错误");
                return View(model);

            }
            return Redirect("/Register/Failed");
        }

    }
}