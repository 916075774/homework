using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{

    public class LoginModel : PageModel
    {
        public void OnGet()
        {
            ViewData["title"] = "登录❤";
        }
    }
}