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
    public class AssignmentsController : Controller
    {
        //Instantiate a database context object
        private ClubContext db = new ClubContext();

        // GET: Assignments
        public ActionResult Index()
        {
            var assignments = db.Assignments.Include(a => a.Book).Include(a => a.Student);
            return View(assignments.ToList()); // return list of assignments along with book and student entities
        }

        // GET: Assignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // GET: Assignments/Create
        public ActionResult Create()
        {
            ViewBag.BookID = new SelectList(db.Books, "BookID", "Title"); //populate book title dropdown list
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FullName");// populate full name dropdown list
            return View();
        }

        // POST: Assignments/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentID,BookID,StudentID,CheckOutDate,DueDate")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                db.Assignments.Add(assignment);
                db.SaveChanges(); // save changes to database
                return RedirectToAction("Index");
            }

            ViewBag.BookID = new SelectList(db.Books, "BookID", "Title", assignment.BookID); //populate book title dropdown list
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FullName", assignment.StudentID); // populate full name dropdown list
            return View(assignment);
        }

        // GET: Assignments/Edit/5
        //Get the record to be updated
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookID = new SelectList(db.Books, "BookID", "Title", assignment.BookID); //populate book title dropdown list
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FullName", assignment.StudentID); // populate full name dropdown list
            return View(assignment);
        }

        //Update the record and save changes to database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentID,BookID,StudentID,CheckOutDate,DueDate")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookID = new SelectList(db.Books, "BookID", "Title", assignment.BookID); //populate book title dropdown list
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FullName", assignment.StudentID); // populate full name dropdown list
            return View(assignment);
        }

        // GET: Assignments/Delete/5
        //Get the record to be deleted
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // POST: Assignments/Delete/5
        //Delete record and save changes to database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            db.Assignments.Remove(assignment);
            db.SaveChanges();
            return RedirectToAction("Index");
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
