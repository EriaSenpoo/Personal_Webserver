using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Personal_Website.Pages.Fritid
{
    public class BlenderModel : PageModel
    {
        public string Blender_text { get; private set; }
        public string banner { get; set; }

        public void OnGet()
        {
            banner = Url.Content("~/images/blender_banner.png");
            ViewData["Banner"] = banner;
            Blender_text = "insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here ";
        }
    }
}