using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Models;
//using WebApplicationMVC.Data;

namespace WebApplication4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // This section is for Harika: To work on Degree
            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }

            //This section ends
            //This section is for Teja: To work on Credit

            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }

            //This section ends: Credit
            //This section is for Harika: Degree Credit
            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Teja: To work on Degree Plan
            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Sonam: Slot.cs
            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Sonam: Student.cs
            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Sonam: StudentTerm.cs
            if (context.Degrees.Any())
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

           };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends

        }
    }
}


