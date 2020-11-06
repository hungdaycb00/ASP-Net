using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Product(int id, string name, string category)
        {
            return "Id: " + id + "<br>Name: " + name + "<br>Category: " + category;
        }
    }
}