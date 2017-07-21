using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCL.DAL;
using ProjectCL.Models;

namespace ProjectCL.Controllers
{
    public class BookController : Controller
    {
        //Instantiate a database context object
        private ClubContext db = new ClubContext();

        // GET: Book
        public ActionResult Index()
        {
            return View(db.Books.ToList()); // return the list of books from the book enetity
        }

        // GET: Book/Details/5
        //Get the book deails to edit
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest,"Request cannot be completed, delete /Details in the URL and hit enter");
            }
            Book book = db.Books.Find(id);// fing the book using book id
            // Check if book exists.
            if (book == null)
            {
                return HttpNotFound("No Book details found"); // return error message if null
            }
            return View(book); // return book details
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        //Add new nook to database
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookID,Title,Author,ReadingLevel")] Book book)
        {
            // check if the model state is valid.
            if (ModelState.IsValid)
            {
                db.Books.Add(book);  // add the book to database
                db.SaveChanges(); // save the new book to database
                return RedirectToAction("Index");
            }

            return View(book);
        }

        // GET: Book/Edit/5
        //Get the book to edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Request cannot be completed, delete /Edit in the URL and hit enter");
            }
            Book book = db.Books.Find(id);
            // Check if book exists.
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book); // return the book to edit
        }

        // POST: Book/Edit/5
        //Edit the book details and save the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookID,Title,Author,ReadingLevel")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified; // set the state to modified
                db.SaveChanges(); // save changes afer editing
                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Book/Delete/5
        //Get the book to delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            // check if the book exists
            if (book == null)
            {
                return HttpNotFound("Book not found"); // return error message
            }
            return View(book); // return the book to be deleted
        }

        // POST: Book/Delete/5
        //Delete the book record and save the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book); // delete book from database.
            db.SaveChanges(); // save cahnges to database.
            return RedirectToAction("Index");// return to books page
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
