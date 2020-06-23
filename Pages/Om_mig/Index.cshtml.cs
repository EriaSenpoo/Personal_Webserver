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


        public string banner { get; set; }
        public string Index_title { get; private set; }
        public Data_Info_Service Om_mig_service_text { get; set; }
        //public Tuple<List<string>, List<JToken>> Tuuple { get; set; }
        //public List<Tuple<List<string>, List<JToken>>> tuple_list { get; set; }

        public IndexModel(ILogger<IndexModel> logger, Data_Info_Service Om_mig_service_text)
        {
            _logger = logger;
            this.Om_mig_service_text = Om_mig_service_text;
        }

        public void OnGet()
        {
            banner = Url.Content("~/images/om_mig_banner.png");
            ViewData["Banner"] = banner;
            var source = Om_mig_service_text.get_data_om_mig_info_data();
            foreach (var aaa in source)
            {
                ViewData["data"] = string.Join(" ", aaa.subjects); // NEED TO RETURN BOTH
            }

            //ViewData["data_text"] = a;
            //ViewData["data_text"] = string.Join(",", a.text);

            //ViewData["data"] = source;
            ////ViewData["data_text"] = a;
            //ViewData["data"] = string.Join(" ", source);
            ////ViewData["data_text"] = string.Join(",", a.text);

            //Tuuple = Om_mig_service_text.get_data_om_mig_info_data();
            ////ViewData["data_text"] = Tuuple;
            ////aaa = Tuuple;
            //tuple_list = new List<Tuple<List<string>, List<JToken>>>();
            //tuple_list.Add(Tuuple);
            //ViewData["data_text"] = tuple_list;
            //aaa = ViewData["data_text"];
            //Index_title = "Om mig";
        }
    }
}