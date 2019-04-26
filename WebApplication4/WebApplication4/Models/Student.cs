using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Student
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int StudentID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Family { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Given { get;  set; }
        [Range(0, 20)]
        public int Snumber { get; set; }
        [Range(0, 20)]
        public int number_919 { get; set; }
        public ICollection<DegreePlan> DegreePlans { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "StudentId = " + StudentID +
              "GivenName = " + Given +
              ", FamilyName = " + Family +
              "";
        }


    }
}
