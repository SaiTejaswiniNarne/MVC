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
            if (context.DegreeCredits.Any())
            {
                Console.WriteLine("Degree Credit Already exists:");
            }
            else
            {
                var degreesCredits = new DegreeCredit[]
            {
                new DegreeCredit{DegreeCreditID = 1 , DegreeID = 1 ,CreditID =460},
                new DegreeCredit{DegreeCreditID = 2 , DegreeID = 1 ,CreditID =356},
                new DegreeCredit{DegreeCreditID = 3 , DegreeID = 1 ,CreditID =542},
                new DegreeCredit{DegreeCreditID = 4 , DegreeID = 1 ,CreditID =563},
                new DegreeCredit{DegreeCreditID = 5 , DegreeID = 1 ,CreditID =560},
                new DegreeCredit{DegreeCreditID = 6 , DegreeID = 1 ,CreditID =664},
                new DegreeCredit{DegreeCreditID = 7 , DegreeID = 1 ,CreditID =618},
                new DegreeCredit{DegreeCreditID = 8 , DegreeID = 1 ,CreditID =555},
                new DegreeCredit{DegreeCreditID = 9 , DegreeID = 1 ,CreditID =691},
                new DegreeCredit{DegreeCreditID = 10 , DegreeID = 1 ,CreditID =692},
                new DegreeCredit{DegreeCreditID = 11 , DegreeID = 1 ,CreditID =6},
                new DegreeCredit{DegreeCreditID = 12 , DegreeID = 1 ,CreditID =1},
                new DegreeCredit{DegreeCreditID = 13 , DegreeID = 1 ,CreditID =2},
                new DegreeCredit{DegreeCreditID = 14 , DegreeID = 2 ,CreditID =460},
                new DegreeCredit{DegreeCreditID = 15 , DegreeID = 2 ,CreditID =542},
                new DegreeCredit{DegreeCreditID = 16 , DegreeID = 2 ,CreditID =563},
                new DegreeCredit{DegreeCreditID = 17 , DegreeID = 2 ,CreditID =560},
                new DegreeCredit{DegreeCreditID = 18 , DegreeID = 2 ,CreditID =664},
                new DegreeCredit{DegreeCreditID = 19 , DegreeID = 2 ,CreditID =618},
                new DegreeCredit{DegreeCreditID = 20 , DegreeID = 2 ,CreditID =555},
                new DegreeCredit{DegreeCreditID = 21 , DegreeID = 2 ,CreditID =691},
                new DegreeCredit{DegreeCreditID = 22 , DegreeID = 2 ,CreditID =692},
                new DegreeCredit{DegreeCreditID = 23 , DegreeID = 2 ,CreditID =6},
                new DegreeCredit{DegreeCreditID = 24 , DegreeID = 2 ,CreditID =1},
                new DegreeCredit{DegreeCreditID = 25 , DegreeID = 2 ,CreditID =2},
                new DegreeCredit{DegreeCreditID = 26 , DegreeID = 3 ,CreditID =356},
                new DegreeCredit{DegreeCreditID = 27 , DegreeID = 3 ,CreditID =542},
                new DegreeCredit{DegreeCreditID = 28 , DegreeID = 3 ,CreditID =563},
                new DegreeCredit{DegreeCreditID = 29 , DegreeID = 3 ,CreditID =560},
                new DegreeCredit{DegreeCreditID = 30 , DegreeID = 3 ,CreditID =664},
                new DegreeCredit{DegreeCreditID = 31 , DegreeID = 3 ,CreditID =618},
                new DegreeCredit{DegreeCreditID = 32 , DegreeID = 3 ,CreditID =555},
                new DegreeCredit{DegreeCreditID = 33 , DegreeID = 3 ,CreditID =691},
                new DegreeCredit{DegreeCreditID = 34 , DegreeID = 3 ,CreditID =692},
                new DegreeCredit{DegreeCreditID = 35 , DegreeID = 3 ,CreditID =6},
                new DegreeCredit{DegreeCreditID = 36 , DegreeID = 3 ,CreditID =1},
                new DegreeCredit{DegreeCreditID = 37 , DegreeID = 3 ,CreditID =2},
                new DegreeCredit{DegreeCreditID = 38 , DegreeID = 4 ,CreditID =542},
                new DegreeCredit{DegreeCreditID = 39 , DegreeID = 4 ,CreditID =563},
                new DegreeCredit{DegreeCreditID = 40 , DegreeID = 4 ,CreditID =560},
                new DegreeCredit{DegreeCreditID = 41 , DegreeID = 4 ,CreditID =664},
                new DegreeCredit{DegreeCreditID = 42 , DegreeID = 4 ,CreditID =618},
                new DegreeCredit{DegreeCreditID = 43 , DegreeID = 4 ,CreditID =555},
                new DegreeCredit{DegreeCreditID = 44 , DegreeID = 4 ,CreditID =691},
                new DegreeCredit{DegreeCreditID = 45 , DegreeID = 4 ,CreditID =692},
                new DegreeCredit{DegreeCreditID = 46 , DegreeID = 4 ,CreditID =6},
                new DegreeCredit{DegreeCreditID = 47 , DegreeID = 4 ,CreditID =1},
                new DegreeCredit{DegreeCreditID = 48 , DegreeID = 4 ,CreditID =2},
           };
                Console.WriteLine($"Inserted {degreesCredits.Length} new degreesCredits.");

                foreach(DegreeCredit d in degreesCredits)
                {
                    context.DegreeCredits.Add(d);
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
                Console.WriteLine($"Inserted {degreeplans.Length} new degreePlans.");

                foreach (DegreePlan dp in degreeplans)
                {
                    context.DegreePlans.Add(dp);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Sonam: Slot.cs
            if (context.Slots.Any())
            {
                Console.WriteLine("Slots Already exists:");
            }
            else
            {
                var slots = new Slot[]
            {
                      new Slot{SlotID = 1 , DegreePlanID = 7251 ,Term =1, CreditID =460, Status ="C" },
                     new Slot{SlotID = 2 , DegreePlanID = 7251 ,Term =1, CreditID =542, Status ="C" },
                     new Slot{SlotID = 3 , DegreePlanID = 7251 ,Term =1, CreditID =563, Status ="C" },
                     new Slot{SlotID = 4 , DegreePlanID = 7251 ,Term =2, CreditID =560, Status ="A" },
                     new Slot{SlotID = 5 , DegreePlanID = 7251 ,Term =2, CreditID =664, Status ="A" },
                     new Slot{SlotID = 6 , DegreePlanID = 7251 ,Term =2, CreditID =6, Status ="A" },
                     new Slot{SlotID = 7 , DegreePlanID = 7251 ,Term =3, CreditID =618, Status ="P" },
                     new Slot{SlotID = 8 , DegreePlanID = 7251 ,Term =3, CreditID =691, Status ="P" },
                     new Slot{SlotID = 9 , DegreePlanID = 7251 ,Term =4, CreditID =692, Status ="P" },
                     new Slot{SlotID = 10 , DegreePlanID = 7251 ,Term =4, CreditID =1, Status ="P" },
                     new Slot{SlotID = 11 , DegreePlanID = 7251 ,Term =4, CreditID =2, Status ="P" },
                     new Slot{SlotID = 12 , DegreePlanID = 7251 ,Term =5, CreditID =555, Status ="P" },
                     new Slot{SlotID = 13 , DegreePlanID = 7252 ,Term =1, CreditID =460, Status ="C" },
                     new Slot{SlotID = 14 , DegreePlanID = 7252 ,Term =1, CreditID =542, Status ="C" },
                     new Slot{SlotID = 15 , DegreePlanID = 7252 ,Term =1, CreditID =563, Status ="C" },
                     new Slot{SlotID = 16 , DegreePlanID = 7252 ,Term =3, CreditID =560, Status ="C" },
                     new Slot{SlotID = 17 , DegreePlanID = 7252 ,Term =3, CreditID =664, Status ="A" },
                     new Slot{SlotID = 18 , DegreePlanID = 7252 ,Term =3, CreditID =6, Status ="A" },
                     new Slot{SlotID = 19 , DegreePlanID = 7252 ,Term =4, CreditID =691, Status ="A" },
                     new Slot{SlotID = 20 , DegreePlanID = 7252 ,Term =4, CreditID =618, Status ="P" },
                     new Slot{SlotID = 21 , DegreePlanID = 7252 ,Term =5, CreditID =692, Status ="P" },
                     new Slot{SlotID = 22 , DegreePlanID = 7252 ,Term =5, CreditID =1, Status ="P" },
                     new Slot{SlotID = 23 , DegreePlanID = 7252 ,Term =6, CreditID =555, Status ="P" },
                     new Slot{SlotID = 24 , DegreePlanID = 7252 ,Term =6, CreditID =2, Status ="P" },
                     new Slot{SlotID = 25 , DegreePlanID = 7255 ,Term =1, CreditID =460, Status ="C" },
                     new Slot{SlotID = 26 , DegreePlanID = 7255 ,Term =1, CreditID =542, Status ="C" },
                     new Slot{SlotID = 27 , DegreePlanID = 7255 ,Term =1, CreditID =563, Status ="C" },
                     new Slot{SlotID = 28 , DegreePlanID = 7255 ,Term =2, CreditID =6, Status ="A" },
                     new Slot{SlotID = 29 , DegreePlanID = 7255 ,Term =2, CreditID =618, Status ="A" },
                     new Slot{SlotID = 30 , DegreePlanID = 7255 ,Term =2, CreditID =560, Status ="A" },
                     new Slot{SlotID = 31 , DegreePlanID = 7255 ,Term =4, CreditID =691, Status ="P" },
                     new Slot{SlotID = 32 , DegreePlanID = 7255 ,Term =4, CreditID =1, Status ="P" },
                     new Slot{SlotID = 33 , DegreePlanID = 7255 ,Term =4, CreditID =2, Status ="P" },
                     new Slot{SlotID = 34 , DegreePlanID = 7255 ,Term =5, CreditID =555, Status ="P" },
                     new Slot{SlotID = 35 , DegreePlanID = 7255 ,Term =5, CreditID =664, Status ="P" },
                     new Slot{SlotID = 36 , DegreePlanID = 7255 ,Term =6, CreditID =692, Status ="P" },

           };
                Console.WriteLine($"Inserted {slots.Length} new slots.");

                foreach (Slot d in slots)
                {
                    context.Slots.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Sonam: StudentTerms.cs
            if (context.StudentTerms.Any())
            {
                Console.WriteLine("StudentTerms Already exists:");
            }
            else
            {
                var studentterms = new StudentTerm[]
            {
                new StudentTerm{StudentTermID = 1 , StudentID = 533726 ,Term =1, TermAbbrev = "F19",  TermName ="Fall 2019" },
                 new StudentTerm{StudentTermID = 2 , StudentID = 533726 ,Term =2, TermAbbrev = "S20",  TermName ="Spring 2020" },
                 new StudentTerm{StudentTermID = 3 , StudentID = 533726 ,Term =3, TermAbbrev = "Su20",  TermName ="Summer 2020" },
                 new StudentTerm{StudentTermID = 4 , StudentID = 533726 ,Term =4, TermAbbrev = "F20",  TermName ="Fall 2020" },
                 new StudentTerm{StudentTermID = 5 , StudentID = 533726 ,Term =5, TermAbbrev = "S21",  TermName ="Spring 2021" },
                 new StudentTerm{StudentTermID = 6 , StudentID = 533490 ,Term =1, TermAbbrev = "S19",  TermName ="Spring 2019" },
                 new StudentTerm{StudentTermID = 7 , StudentID = 533490 ,Term =2, TermAbbrev = "Su19",  TermName ="Summer 2019" },
                 new StudentTerm{StudentTermID = 8 , StudentID = 533490 ,Term =3, TermAbbrev = "F19",  TermName ="Fall 2019" },
                 new StudentTerm{StudentTermID = 9 , StudentID = 533490 ,Term =4, TermAbbrev = "S20",  TermName ="Spring 2020" },
                 new StudentTerm{StudentTermID = 10 , StudentID = 533490 ,Term =5, TermAbbrev = "Su20",  TermName ="Summer 2020" },
                 new StudentTerm{StudentTermID = 11 , StudentID = 533490 ,Term =6, TermAbbrev = "F20",  TermName ="Fall 2020" },
                 new StudentTerm{StudentTermID = 12 , StudentID = 533711 ,Term =1, TermAbbrev = "F18",  TermName ="Fall 2018" },
                 new StudentTerm{StudentTermID = 13 , StudentID = 533711 ,Term =2, TermAbbrev = "S19",  TermName ="Spring 2019" },
                 new StudentTerm{StudentTermID = 14 , StudentID = 533711 ,Term =3, TermAbbrev = "Su19",  TermName ="Summer 2019" },
                 new StudentTerm{StudentTermID = 15 , StudentID = 533711 ,Term =4, TermAbbrev = "F19",  TermName ="Fall 2019" },
                 new StudentTerm{StudentTermID = 16 , StudentID = 533711 ,Term =5, TermAbbrev = "S20",  TermName ="Spring 2020" },
                 new StudentTerm{StudentTermID = 17 , StudentID = 533711 ,Term =6, TermAbbrev = "Su19",  TermName ="Summer 2020" },



           };
                Console.WriteLine($"Inserted {studentterms.Length} new studentTerms.");

                foreach (StudentTerm d in studentterms)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends
            //This section is for Sonam: Student.cs
            if (context.Students.Any())
            {
                Console.WriteLine("Student Already exists:");
            }
            else
            {
                var students = new Student[]
            {
                new Student{StudentID = 533726 , Family = "Narne" , Given ="Sai Tejaswini", Snumber =533726 , number_919=919571565},
                new Student{StudentID = 533490 , Family = "Gadekari" , Given ="Sonam", Snumber =533490 , number_919=919568899},
                new Student{StudentID = 533711 , Family = "Naidu" , Given ="Harika", Snumber =533711 , number_919=919570594},
           };
                Console.WriteLine($"Inserted {students.Length} new students.");

                foreach (Student d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }
            //This section ends

        }
    }
}


