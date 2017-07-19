using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCL.Models
{
  
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int BookID { get; set; } // Foreign Key for Book
        public int StudentID { get; set; } // Foreign Key for student

        [DisplayName("Check Out Date")] // change the display name
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckOutDate { get; set; }
        [DisplayName("Due Date")] // change the display name
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }

        // public Level? Level { get; set; } // Grade Level. Seed Method uses it but may be changed in the future

        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
    }
}