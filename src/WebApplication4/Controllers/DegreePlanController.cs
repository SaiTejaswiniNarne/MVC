using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DegreePlanController : Controller
    {
        public List<DegreePlan> GetDegreePlanList()
        {
      return new List<DegreePlan>{
      new DegreePlan{
         DegreePlanID = 7250,
         StudentID = 533726,
         DegreePlanAbbrev="Slow and Easy",
         DegreePlanName = "Take a Summer off",
      },
      new DegreePlan{
         DegreePlanID = 7251,
         StudentID = 533726,
         DegreePlanAbbrev="Super Fast",
         DegreePlanName = "As fast as I can",
      },

       new DegreePlan{
         DegreePlanID = 7252,
         StudentID = 533490,
         DegreePlanAbbrev="Spring Super Slow",
         DegreePlanName = "As slow as it could be with a Summer off",
      },

       new DegreePlan{
         DegreePlanID = 7253,
         StudentID = 533490,
         DegreePlanAbbrev="Spring Super fast",
         DegreePlanName = "As fast as it could be",
      },
       new DegreePlan{
         DegreePlanID = 7254,
         StudentID = 533711,
         DegreePlanAbbrev="Early completion",
         DegreePlanName = "Fall 2018 fast track",
      },
       new DegreePlan{
         DegreePlanID = 7255,
         StudentID = 533711,
         DegreePlanAbbrev="Slow and Easy",
         DegreePlanName = "Take a Summer off",
      },
   };
        }
    }
}