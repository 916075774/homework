using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using static SRV.UserService;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class LoginModel : PageModel
    {
        private const string _userId = "userId";

        public Login Login { get; set; }

        private UserService _userService;
        public LoginModel()
        {
            _userService = new UserService();
        }

        public void OnGet()
        {
            ViewData["title"] = "登录❤";
        }


        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            UserModel model = _userService.GetLoginInfo(Login.UserName);

            if (model == null)
            {
                ModelState.AddModelError("Login.UserName", "* 用户名不存在");
                return;
            }

            if (!_userService.PasswordCorrect(Login.Password, model.Md5Password))
            {
                ModelState.AddModelError("Login.Password", "* 用户名或密码错误");
                return;
            }

            Response.Cookies.Append(_userId, model.Id.ToString(),
                new CookieOptions
                {
                    IsEssential = true
                }) ;
            Response.Cookies.Append("auth", model.Md5Password);

            Response.Redirect("Index");
        }

    }
}
public class Login
{
    [MaxLength(25, ErrorMessage = "* 用户名必须在2-25之间")]
    [MinLength(2, ErrorMessage = "* 用户名必须在2-25之间")]
    [Required(ErrorMessage = "* 必须填写")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "* 必须填写")]
    [MaxLength(25, ErrorMessage = "* 密码必须在2-25之间")]
    [MinLength(2, ErrorMessage = "* 密码必须在2-25之间")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public bool Remember { get; set; }
}
