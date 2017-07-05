using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message ="Our Program";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact us for more information";

            return View();
        }
    }
}