using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjectCL.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        [DisplayName("Last Name")] // change the display name
        public string LastName { get; set; }
        [DisplayName("First Name")] // change the display name
        public string FirstName { get; set; }

        // Concatenate first and last name and get as read only
        [DisplayName("Student Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [DisplayName("Enrollment Date")] // change the display name
        public DateTime AssignmentDate { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}