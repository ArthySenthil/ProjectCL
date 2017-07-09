using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCL.Models
{
    public enum Level
    {
        A,B,C,D,E,F
    }
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public int BookID { get; set; }
        public int StudentID { get; set; }
        public Level? Level { get; set; }

        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
    }
}