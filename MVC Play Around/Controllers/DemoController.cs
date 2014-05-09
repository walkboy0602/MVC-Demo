using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Play_Around.Models;

namespace MVC_Play_Around.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/

        public ActionResult Index(int n = 0)
        {
            ListingModels model = new ListingModels();

            model.id = 123;
            model.Title = "Iproperty.com";
            model.Price = 999;

            return View(model);
        }

    }
}
