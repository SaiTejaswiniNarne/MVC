using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DegreeController : Controller
    {
        public List<Degree> GetDegreeList()
        {
            return new List<Degree>{
      new Degree{
         DegreeID = 1,
         DegreeAbbrev="ACS+2",
         DegreeName = "MS ACS+2",
         NumberOfTerms = 5,
      },
      new Degree{
         DegreeID = 2,
         DegreeAbbrev="ACS+DB",
         DegreeName = "MS ACS+DB",
         NumberOfTerms = 5,
      },
       new Degree{
         DegreeID = 1,
         DegreeAbbrev="ACS+NF",
         DegreeName = "MS ACS+NF",
         NumberOfTerms = 5,
      },
        new Degree{
         DegreeID = 1,
         DegreeAbbrev="ACS",
         DegreeName = "MS ACS",
         NumberOfTerms = 5,
      },
   };
     }
    }
}