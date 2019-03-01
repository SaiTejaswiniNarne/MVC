using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
//using WebApplication4.Models;
using WebApplicationMVC.Models;

namespace WebApplication4.Data
{   
    public class ApplicationDbContext : IdentityDbContext
    {
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            modelBuilder.Entity<Degree>().ToTable("Degree");

        }


    }
    
    /*
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {

        }
        if(Context.Degree.Any())
            {
            Console.WriteLine("Degree Already exists:");
            }
        else
          {
            var degrees = new Degree[]
            {
                new Degree{DegreeID = 1, DegreeAbbrev = "ACS+2", DegreeName ="MS ACS+2", NumberOfTerms = 5},
                new Degree{DegreeID = 2, DegreeAbbrev = "ACS+DB", DegreeName ="MS ACS + DB", NumberOfTerms = 5},
                new Degree{DegreeID = 3, DegreeAbbrev = "ACS+NF", DegreeName ="MS ACS + NF", NumberOfTerms = 5},
                new Degree{DegreeID = 4, DegreeAbbrev = "ACS", DegreeName ="MS ACS", NumberOfTerms = 5},
            }
           };
            Console.WriteLine($"Inserted {degrees.Length} new degrees.");
      
             foreach(Degree d in degrees)
               {
                    context.Degrees.Add(d);
               }
    context.SaveChanges();
    }
    */

}
