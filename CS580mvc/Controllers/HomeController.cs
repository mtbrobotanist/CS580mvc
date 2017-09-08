using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CS580mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "CS580mvc so I can learn about it.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Not sure what this is yet.";

            return View();
        }
    }
}