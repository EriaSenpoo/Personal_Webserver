using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Personal_Website.Pages.Projekter
{
    public class IndexModel : PageModel
    {
        public string Projekter_text { get; private set; }
        public string banner { get; set; }

        public void OnGet()
        {
            banner = Url.Content("~/images/projekter_banner.png");
            ViewData["Banner"] = banner;
            Projekter_text = "insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here ";
        }
    }
}