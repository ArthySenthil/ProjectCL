using ProjectCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCL.DAL
{
    public class ClubInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClubContext>
    {
        protected override void Seed(ClubContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",AssignmentDate=DateTime.Parse("2017-06-01")},
            new Student{FirstName="Meredith",LastName="Alonso",AssignmentDate=DateTime.Parse("2017-06-05")},
            new Student{FirstName="Arturo",LastName="Anand",AssignmentDate=DateTime.Parse("2017-06-07")},
            new Student{FirstName="Gytis",LastName="Barzdukas",AssignmentDate=DateTime.Parse("2017-06-09")},
            new Student{FirstName="Yan",LastName="Li",AssignmentDate=DateTime.Parse("2017-06-11")},
            new Student{FirstName="Peggy",LastName="Justice",AssignmentDate=DateTime.Parse("2017-06-21")},
            new Student{FirstName="Laura",LastName="Norman",AssignmentDate=DateTime.Parse("2017-06-25")},
            new Student{FirstName="Nino",LastName="Olivetto",AssignmentDate=DateTime.Parse("2017-06-22")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var books = new List<Book>
            {
            new Book{BookID=1050,Title="Goldilocks and the 3 bears",Description="Little girl lost in the woods and the 3 bears",},
             new Book{BookID=4022,Title="The hungry caterpillar",Description="Story of a tiny caterpillar who is very very hungry",},
             new Book{BookID=4041,Title="Goldilocks and the 3 bears",Description="Little girl lost in the woods and the 3 bears",},
            new Book{BookID=1045,Title="Goldilocks and the 3 bears",Description="Little girl lost in the woods and the 3 bears",},
            
            };
            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
            var assignments = new List<Assignment>
            {
            new Assignment{StudentID=1,BookID=1050,Level=Level.A},
            new Assignment{StudentID=1,BookID=4022,Level=Level.C},
            new Assignment{StudentID=1,BookID=4041,Level=Level.B},
            new Assignment{StudentID=2,BookID=1045,Level=Level.B},
            
            };
            assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();
        }
    }


}