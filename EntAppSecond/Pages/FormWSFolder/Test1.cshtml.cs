using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.FormWSFolder
{
    public class Test1Model : PageModel
    {
        [BindProperty]
        public string ProductCode { get; set; }


        [BindProperty]
        public string RadioColour { get; set; }


        [BindProperty]
        public bool Consent { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}