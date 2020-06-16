using System;
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
        private readonly ILogger<IndexModel> _logger;
        public Data_Info_Service data_info;
        // They called ```public IEnumerable<Product> Products;```

        public string Fritid_text { get; set; }

        public IndexModel(ILogger<IndexModel> logger, Data_Info_Service data_info)
        {
            _logger = logger;
            this.data_info = data_info;
        }
        public void OnGet()
        {
            Fritid_text = "insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here ";
        }
    }
}