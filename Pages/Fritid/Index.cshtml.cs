using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Personal_Website.Pages.Fritid
{
    public class IndexModel : PageModel
    {
        public string aaa { get; set; }
        public void OnGet()
        {
            aaa = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        }
    }
}