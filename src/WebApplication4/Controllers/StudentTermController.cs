using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentTermController : Controller
    {
        public List<StudentTerm> GetCreditsList()
        {
            return new List<StudentTerm>{
      new StudentTerm{
         StudentTermID = 1,
         StudentID= 533726,
         Term=1,
         TermAbbrev = "F19",
         TermName= "Fall 2019"
      },
      new StudentTerm{
         StudentTermID = 2,
         StudentID= 533726,
         Term=2,
         TermAbbrev = "S20",
         TermName= "Spring 2020"

      },
     new StudentTerm{
         StudentTermID = 3,
         StudentID= 533726,
         Term=3,
         TermAbbrev = "SU20",
         TermName= "Summer 2020"

      },
     new StudentTerm{
         StudentTermID = 4,
         StudentID= 533726,
         Term=4,
         TermAbbrev = "SU20",
         TermName= "Fall 2020"

      },
     new StudentTerm{
         StudentTermID = 5,
         StudentID= 533726,
         Term=5,
         TermAbbrev = "S21",
         TermName= "Spring 2021"

      },
     new StudentTerm{
         StudentTermID = 6,
         StudentID= 533490,
         Term=1,
         TermAbbrev = "S19",
         TermName= "Spring 2019"

      },
     new StudentTerm{
         StudentTermID = 7,
         StudentID= 533490,
         Term=2,
         TermAbbrev = "Su19",
         TermName= "Summer 2019"

      },
     new StudentTerm{
         StudentTermID = 8,
         StudentID= 533490,
         Term=3,
         TermAbbrev = "F19",
         TermName= "Fall 2019"

      },
     new StudentTerm{
         StudentTermID = 9,
         StudentID= 533490,
         Term=4,
         TermAbbrev = "S20",
         TermName= "Spring 2020"

      },
      new StudentTerm{
         StudentTermID = 10,
         StudentID= 533490,
         Term=5,
         TermAbbrev = "Su20",
         TermName= "Summer 2020"

      },
      new StudentTerm{
         StudentTermID = 11,
         StudentID= 533490,
         Term=6,
         TermAbbrev = "F20",
         TermName= "Fall 2020"

      },
      new StudentTerm{
         StudentTermID = 12,
         StudentID= 533711,
         Term=1,
         TermAbbrev = "F18",
         TermName= "Fall 2018"

      },
      new StudentTerm{
         StudentTermID = 13,
         StudentID= 533711,
         Term=2,
         TermAbbrev = "S19",
         TermName= "Spring 2019"

      },
       new StudentTerm{
         StudentTermID = 14,
         StudentID= 533711,
         Term=3,
         TermAbbrev = "Su19",
         TermName= "Summer 2019"

      },
       new StudentTerm{
         StudentTermID = 15,
         StudentID= 533711,
         Term=4,
         TermAbbrev = "F19",
         TermName= "Fall 2019"

      },
       new StudentTerm{
         StudentTermID = 16,
         StudentID= 533711,
         Term=5,
         TermAbbrev = "S20",
         TermName= "Spring 2020"

      },
       new StudentTerm{
         StudentTermID = 17,
         StudentID= 533711,
         Term=6,
         TermAbbrev = "Su19",
         TermName= "Summer 2020"

      },
   };
        }
    }
}