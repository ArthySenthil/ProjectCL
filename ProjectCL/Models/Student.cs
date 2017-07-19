using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCL.Models
{
    public class Student
    {
        
        public int ID { get; set; }
        [DisplayName("Last Name")] // change the display name
        [Required] // Cannot be empty
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters.")] // Maximum of 50 charachters
        public string LastName { get; set; }
        [DisplayName("First Name")] // change the display name
        [Required] // Cannot be empty
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")] // Maximum of 50 charachters
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AssignmentDate { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}