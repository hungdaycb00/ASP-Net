using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TinFactory.Areas.MainArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: MainArea/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}