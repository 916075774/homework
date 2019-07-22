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
        private const string _userIdKey = "userId";
        private const string _userMd5PassWord = "_userMd5PassWord";

        public virtual void OnGet()
        {
            string userIdValue;
            string userMd5PassWordValue;
            if (HttpContext.Request.Cookies.TryGetValue(_userIdKey, out userIdValue))
            {
                if (HttpContext.Request.Cookies.TryGetValue(_userMd5PassWord, out userMd5PassWordValue))
                {
                    UserModel model = new UserService().GetById(Convert.ToInt32(userIdValue));
                    if (model.Md5PassWord==userMd5PassWordValue)
                    {
                        ViewData["UserStatus"] = model.Name;
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