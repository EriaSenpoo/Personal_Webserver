using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Website.Models;
using Personal_Website.Services;

namespace Personal_Website.Pages.Kontakt
{
    public class IndexModel : PageModel
    {
        public List<Data_text_object> list = new List<Data_text_object>();
        public Data_Info_Service Service_text { get; set; }
        public string Title_text { get; set; }

        public IndexModel(Data_Info_Service Service_text)
        {
            this.Service_text = Service_text;
        }

        public void OnGet()
        {
            Title_text = "Kontakt";
            list = Service_text.get_kontakt_data();
        }
    }
}