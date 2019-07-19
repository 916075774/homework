﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["title"] = "一起帮·首页";
        }
    }
}