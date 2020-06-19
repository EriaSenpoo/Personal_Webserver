using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Personal_Website.Pages.Fritid
{
    public class GodotModel : PageModel
    {
        public string Godot_title { get; set; }
        public string Godot_text { get; set; }
        public void OnGet()
        {
            Godot_title = "Godot";
            Godot_text = "insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here insert data here ";
        }
    }
}