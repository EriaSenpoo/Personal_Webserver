﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Personal_Website.Models;
using Personal_Website.Services;

namespace Personal_Website.Pages.Fritid
{
    public class IndexModel : PageModel
    {
        public List<Data_text_object> list = new List<Data_text_object>();
        public Data_Info_Service Service_text;
        // They called ```public IEnumerable<Product> Products;```

        public string Fritid_text { get; set; }

        public IndexModel(Data_Info_Service Service_text)
        {
            this.Service_text = Service_text;
        }
        public void OnGet()
        {
            list = Service_text.get_fritid_data();
        }
    }
}