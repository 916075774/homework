using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class IndexModel : _LayoutModel
    {
        public override void OnGet()
        {
            base.OnGet();

            ViewData["title"] = "一起帮·首页";
        }
    }
}
