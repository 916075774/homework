using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class LogoffModel : _LayoutModel
    {
        public override void OnGet()
        {
            Response.Cookies.Delete(_userIdKey);
            Response.Cookies.Delete(_userMd5PassWord);
        }
    }
}