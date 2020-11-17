using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsRazorages.Models;

namespace NewsRazorages.Pages
{
    public class NewsModel : PageModel
    {
        [BindProperty]
        public News news { get; set; }
        public void OnGet()
        {
            news = new News();
          
        }
        public void OnPost()
        {

        }
    }
}
