using Microsoft.AspNetCore.Mvc;
using HelloWorldMC.Models;

namespace HelloWorldMC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage
            {
                Message = "Hello MVC"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message Changed";
            return View(obj);
        }
    }
}
