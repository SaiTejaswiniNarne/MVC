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
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DegreeCredit> DegreeCredits { get; set; }
        public DbSet<DegreePlan> DegreePlans { get; set; }
        public DbSet<StudentTerm> StudentTerms { get; set; }
        public DbSet<Slot> Slots { get; set; }
               

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
            modelBuilder.Entity<Degree>().ToTable("Degrees");
            modelBuilder.Entity<Credit>().ToTable("Credits");
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<DegreeCredit>().ToTable("DegreeCredits");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlans");                        
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerms");
            modelBuilder.Entity<Slot>().ToTable("Slots");

        }
               

        public DbSet<WebApplication4.Models.DegreeRequirement> DegreeRequirement { get; set; }


    }
    
}
