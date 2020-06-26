using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Website.Models;
using Personal_Website.Services;

namespace Personal_Website.Pages.Projekter
{
    public class Hjemmelavede_projekterModel : PageModel
    {
        public List<Data_text_object> list = new List<Data_text_object>();
        public Data_Info_Service Service_text { get; set; }
        //public string banner { get; set; }

        public Hjemmelavede_projekterModel(Data_Info_Service Service_text)
        {
            this.Service_text = Service_text;
        }

        public void OnGet()
        {
            //banner = Url.Content("~/images/projekter_banner.png");
            //ViewData["Banner"] = banner;
            list = Service_text.get_data("hjemmelavede_projekter");
        }
    }
}