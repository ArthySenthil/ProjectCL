using ProjectCL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCL.Controllers
{
    public class HomeController : Controller
    {
        private ClubContext db = new ClubContext();
        //Home Page
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }
        //About Page
        public ActionResult About()
        {
            ViewBag.Message ="Our Program";

            return View();
        }
        //Contact Page
        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact us for more information";

            return View();
        }
    }
}