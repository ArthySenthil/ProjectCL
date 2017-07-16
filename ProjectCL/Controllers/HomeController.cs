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
        //Instantiate a database context object
        private ClubContext db = new ClubContext();
        //Home Page
        public ActionResult Index()
        {
            return View(db.Books.ToList()); // return home page and get a list of books from the book entity
        }
        //About Page
        public ActionResult About()
        {
            ViewBag.Message ="Our Program";

            return View();// return about page
        }
        //Contact Page
        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to contact us for more information";

            return View(); //return contact page
        }
    }
}