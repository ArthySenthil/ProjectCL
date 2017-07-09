using System;
using System.Collections.Generic;
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
        public string Description { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}