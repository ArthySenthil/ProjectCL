using ProjectCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCL.DAL
{
    //Drop and re-create the database whenever the model changes.
    public class ClubInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClubContext>
    {
        // populate the Seed method with test data
        protected override void Seed(ClubContext context)
        {
            //populate students
            var students = new List<Student>
            {
            new Student{FirstName="Shrinita",LastName="Senthilkumar",AssignmentDate=DateTime.Parse("2017-06-01")},
            new Student{FirstName="Ashrita",LastName="Senthilkumar",AssignmentDate=DateTime.Parse("2017-06-05")},
            new Student{FirstName="Senthil",LastName="Muniyandi",AssignmentDate=DateTime.Parse("2017-06-07")},
            new Student{FirstName="Radha",LastName="Sundar",AssignmentDate=DateTime.Parse("2017-06-09")},
            new Student{FirstName="Vasu",LastName="Sriram",AssignmentDate=DateTime.Parse("2017-06-11")},
            new Student{FirstName="Danvi",LastName="Viswaa",AssignmentDate=DateTime.Parse("2017-06-21")},
            new Student{FirstName="Vishnu",LastName="Viswaa",AssignmentDate=DateTime.Parse("2017-06-25")},
            new Student{FirstName="Praji",LastName="Gopal",AssignmentDate=DateTime.Parse("2017-06-22")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();  // save changes to the database

            // populate books
            var books = new List<Book>
            {
            new Book{BookID=1050,Title="Goldilocks and the 3 bears",Author="xxx",ReadingLevel="A",},
             new Book{BookID=4022,Title="The hungry caterpillar",Author="yyy",ReadingLevel="B",},
             new Book{BookID=4041,Title="Cinderella",Author="zzz",ReadingLevel="C",},
            new Book{BookID=1045,Title="Snow White",Author="aaa",ReadingLevel="D",},
            
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges(); // save changes to the database

            //populate books assigned
            var assignments = new List<Assignment>
            {
            new Assignment{StudentID=1,BookID=1050,Level=Level.A},
            new Assignment{StudentID=1,BookID=4022,Level=Level.C},
            new Assignment{StudentID=1,BookID=4041,Level=Level.B},
            new Assignment{StudentID=2,BookID=1045,Level=Level.B},
            
            };
            assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();  // save changes to the database
        }
    }


}