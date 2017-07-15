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
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Enrollment Date")]
        public DateTime AssignmentDate { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}