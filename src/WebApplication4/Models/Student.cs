using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }
        public string Family { get; set; }
        public string Given { get;  set; }
        public int Snumber { get; set; }
        public int number_919 { get; set; }
      //  public int DegreePlanID { get; set; }
//        public DegreePlan DegreePlan { get; set; }

    }
}
