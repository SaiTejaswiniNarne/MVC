using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    /*
    public class CreditsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
*/
    public class CreditsController : Controller
    {
        public List<Credit> GetCreditsList()
        {
      return new List<Credit>{
      new Credit{
         CreditID = 460,
         CreditAbbrev = "CreditAbbrev",
         CreditName="Databases",
         IsSummer = 0,
         IsSpring = 1,
         IsFall=1
      },
      new Credit{
         CreditID = 356,
         CreditAbbrev = "CreditAbbrev",
         CreditName="Databases",
         IsSummer = 0,
         IsSpring = 1,
         IsFall=1
      },

      new Credit{
         CreditID = 542,
         CreditAbbrev = "542",
         CreditName="OOP with Java",
         IsSummer = 0,
         IsSpring = 1,
         IsFall=1
      },
   };
        }
    }
}