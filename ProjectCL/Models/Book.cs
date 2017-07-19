using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectCL.Models
{
    public enum ReadingLevel
    {
        A, B, C, D, E, F
    }
    // Model Book
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; } 
        public string Title { get; set; }
        public string Author { get; set; }


        [DisplayName("Reading Level(A to F)")] // change the display name
      
        public ReadingLevel? ReadingLevel { get; set; } // ReadingLevel is nullable

        [DisplayName("Books Assigned")] // change the display name
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}