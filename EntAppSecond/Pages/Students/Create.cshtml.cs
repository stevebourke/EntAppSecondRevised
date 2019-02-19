using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EntAppSecond.Pages.Students
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Models.Student Student { get; set; }

        public void OnGet()
        {

        }
    }
}