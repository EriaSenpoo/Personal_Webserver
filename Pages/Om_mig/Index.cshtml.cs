using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Personal_Website.Models;
using Personal_Website.Services;

namespace Personal_Website.Pages.Om_mig
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Data_text_object> list = new List<Data_text_object>();

        public string banner { get; set; }
        public string Index_title { get; private set; }
        public Data_Info_Service Service_text { get; set; }

        public IndexModel(ILogger<IndexModel> logger, Data_Info_Service Service_text)
        {
            _logger = logger;
            this.Service_text = Service_text;
        }

        public void OnGet()
        {
            Index_title = "Om mig";
            banner = Url.Content("~/images/om_mig_banner.png");
            ViewData["Banner"] = banner;
            list = Service_text.get_data("om_mig");
        }
    }
}