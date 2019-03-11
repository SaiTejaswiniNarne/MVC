using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        public List<Student> GetStudentList()
        {
      return new List<Student>{
      new Student{
         StudentID = 533726,
         Family="Narne",
         Given = "Sai Tejaswini",
         Snumber = 533726,
         number_919 = 919571565,
    },
     new Student{
         StudentID = 533490,
         Family="Gadekari",
         Given = "Sonam",
         Snumber = 533490,
         number_919 = 919568899,
      },

      new Student{
         StudentID = 533711,
         Family="Naidu",
         Given = "Harika",
         Snumber = 533711,
         number_919 = 919570594,
      },

       
   };
        }
    }
}