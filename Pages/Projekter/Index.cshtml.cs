using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Website.Models;
using Personal_Website.Services;

namespace Personal_Website.Pages.Projekter
{
    public class IndexModel : PageModel
    {
        public List<Data_text_object> list = new List<Data_text_object>();
        public Data_Info_Service Service_text { get; set; }
        public string Projekter_text { get; private set; }
        public string banner { get; set; }

        public IndexModel(Data_Info_Service Service_text)
        {
            this.Service_text = Service_text;
        }

        public void OnGet()
        {
            banner = Url.Content("~/images/projekter_banner.png");
            ViewData["Banner"] = banner;
            list = Service_text.get_data("projekter");
        }
    }
}