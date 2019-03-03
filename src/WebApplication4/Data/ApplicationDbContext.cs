using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Data
{   
    public class ApplicationDbContext : IdentityDbContext
    {
        //private object modelBuilder;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Credit> Credit { get; set; }
        public DbSet<DegreeCredit> DegreeCredit { get; set; }
        public DbSet<DegreePlan> DegreePlan { get; set; }
        public DbSet<Slot> Slot { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Student> StudentTerm { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredit");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");

        }


    }
    
}
