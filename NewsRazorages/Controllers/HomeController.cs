
using Microsoft.AspNetCore.Mvc;

namespace NewsRazorages.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Users obj = new Users
            {
                Name = "username",
                Password = "password"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(Users obj)
        {
            ViewBag.Name = "name changed";
            ViewBag.Password = "has changed";
            return View(obj);
        }
    }
}
