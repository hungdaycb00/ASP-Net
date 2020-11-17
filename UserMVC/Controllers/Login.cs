using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserMVC.Models;

namespace UserMVC.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            User obj = new User
            {
                Name = "Enter your acount",
                Password = "Enter your password"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(User obj)
        {
            ViewBag.Name = "";
            ViewBag.Password = "";
            return View(obj);
        }
        
        
    }
}
