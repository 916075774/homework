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
        public ActionResult Login(string username, LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ViewBag.UserName = username;

            return Redirect("/Register/Failed");
        }

    }
}