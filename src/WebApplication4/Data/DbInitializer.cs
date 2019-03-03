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

            if (context.Credits.Any())
            {
                Console.WriteLine("Credit Already exists:");
            }
            else
            {
                var credits = new Credit[]
            {
                new Credit{CreditID = 460 , CreditAbbrev = "DB" ,CreditName = "Databases", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 356 , CreditAbbrev = "NF" ,CreditName = "Network Fundamentals", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 542 , CreditAbbrev = "542" ,CreditName = "OOP with Java", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 563 , CreditAbbrev = "563" ,CreditName = "Web Apps", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 560 , CreditAbbrev = "560" ,CreditName = "Advanced Databases", IsSummer = 1 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 664 , CreditAbbrev = "664-UX" ,CreditName = "User Experience", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 618 , CreditAbbrev = "618-PM" ,CreditName = "Project Management", IsSummer = 1 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 555 , CreditAbbrev = "555-NS" ,CreditName = "Network Security", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 691 , CreditAbbrev = "691-GDP1" ,CreditName = "GDP-1", IsSummer = 1 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 692 , CreditAbbrev = "692-GDP2" ,CreditName = "GDP-2", IsSummer = 1 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 6 , CreditAbbrev = "Mobile" ,CreditName = "643 or 644 Mobile", IsSummer = 0 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 1 , CreditAbbrev = "E1" ,CreditName = "Elective1", IsSummer = 1 , IsSpring = 1, IsFall = 1},
                new Credit{CreditID = 2 , CreditAbbrev = "E2" ,CreditName = "Elective2", IsSummer = 1 , IsSpring = 1, IsFall = 1},
           };
                Console.WriteLine($"Inserted {credits.Length} new credits.");

                foreach (Credit d in credits)
                {
                    context.Credits.Add(d);
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
            if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlans Already exists:");
            }
            else
            {
                var degreeplans = new DegreePlan[]
            {
                new DegreePlan{DegreePlanID = 7250, StudentID = 533726, DegreePlanAbbrev = "Slow and Easy", DegreePlanName = "Take a Summer off"},
                new DegreePlan{DegreePlanID = 7251, StudentID = 533726, DegreePlanAbbrev = "Super Fast", DegreePlanName = "As fast as I can"},
                new DegreePlan{DegreePlanID = 7252, StudentID = 533490, DegreePlanAbbrev = "Spring Super Slow", DegreePlanName = "As slow as it could be with a Summer off"},
                new DegreePlan{DegreePlanID = 7253, StudentID = 533490, DegreePlanAbbrev = "Spring Super fast", DegreePlanName = "As fast as it could be"},
                new DegreePlan{DegreePlanID = 7254, StudentID = 533711, DegreePlanAbbrev = "Early completion", DegreePlanName = "Fall 2018 fast track"},
                new DegreePlan{DegreePlanID = 7255, StudentID = 533711, DegreePlanAbbrev = "Slow and Easy", DegreePlanName = "Take a Summer off"},
           };
                Console.WriteLine($"Inserted {degreeplans.Length} new degrees.");

                foreach (DegreePlan dp in degreeplans)
                {
                    context.DegreePlans.Add(dp);
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


