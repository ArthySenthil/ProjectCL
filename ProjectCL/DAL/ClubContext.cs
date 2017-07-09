using ProjectCL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjectCL.DAL
{
    public class ClubContext : DbContext
    {

        public ClubContext() : base("ClubContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}