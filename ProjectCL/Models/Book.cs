using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectCL.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ReadingLevel { get; set; }

        [DisplayName("Books Assigned")]
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}