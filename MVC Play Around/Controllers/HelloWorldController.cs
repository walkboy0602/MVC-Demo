using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Play_Around.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            ViewBag.Description = "Hello World Index Page.";
            return View();
        }

        public ActionResult Detail(int numTimes)
        {
            ViewBag.Message = "Hellow World Detail Page.";
            ViewBag.NumTimes = numTimes;
            return View();
        }

    }
}
