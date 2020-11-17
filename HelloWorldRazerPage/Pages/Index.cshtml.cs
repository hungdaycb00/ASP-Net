using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWorldRazerPage.Models;

namespace HelloWorldRazerPage.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AppMessage Heading { get; set; }
        public string SubHeading { get; set; }
        public void OnGet()
        {
            this.Heading = new AppMessage();
            this.Heading.Message = "Hello World Razor Page!";
        }

        public void OnPost()
        {
            this.SubHeading = "Message Changed";
        }
    }
}
