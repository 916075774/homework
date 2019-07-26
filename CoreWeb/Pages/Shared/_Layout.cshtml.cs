using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using SRV.Model;
using static SRV.UserService;

namespace CoreWeb.Pages.Shared
{
    public class _LayoutModel : PageModel
    {
        public const string _userIdKey = "userId";
        public const string _userMd5PassWord = "userMd5PassWord";

        private string userIdValue;
        private string userMd5PassWordValue;

        public virtual void OnGet()
        {
            if (HttpContext.Request.Cookies.TryGetValue(_userIdKey, out userIdValue))
            {
                if (HttpContext.Request.Cookies.TryGetValue(_userMd5PassWord, out userMd5PassWordValue))
                {
                    UserModel model = new UserService().GetById(Convert.ToInt32(userIdValue));
                    if (model.Md5PassWord==userMd5PassWordValue)
                    {
                        ViewData["UserStatus"] = model.Name;
                    }
                    else
                    {
                        Response.Cookies.Delete(_userIdKey);
                        Response.Cookies.Delete(_userMd5PassWord);
                    }
                }
            }
            else
            {
                ViewData["UserStatus"] = null;
            }           

        }
    }
}