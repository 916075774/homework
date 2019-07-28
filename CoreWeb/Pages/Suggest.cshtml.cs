using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class SuggestModel : _LayoutModel
    {
        public Suggest Suggest { get; set; }

        public override void OnGet()
        {
            base.OnGet();
        }

        public void OnPost()
        {

        }
    }

    public class Suggest
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}