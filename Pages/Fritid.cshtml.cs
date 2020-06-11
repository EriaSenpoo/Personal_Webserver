using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Personal_Website.Pages;

namespace Personal_Website
{
    public class FritidModel : PageModel
    {
        private readonly ILogger<FritidModel> _logger;

        public FritidModel(ILogger<FritidModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}