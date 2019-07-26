using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    public class AboutModel : _LayoutModel
    {
        public string Message { get; set; }

        public override void OnGet()
        {
            base.OnGet();
            Message = "Your application description page.";
        }
    }
}
