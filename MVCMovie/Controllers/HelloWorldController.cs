using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        //GET: HelloWorld

        //public string Welcome()
        //{

        //    return "welcome";
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}
        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.Message = "Hello " + name + " <3";
            ViewBag.NumTimes = id;
                return View();
        }
    }
}