using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class DegreePlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanID { get; set; }
        [ForeignKey("StudentID")]
        public int StudentID { get; set; }      
        public Student Student { get; set; }
        public String DegreePlanAbbrev { get; set; }
        public String DegreePlanName { get; set; }
        [ForeignKey("DegreeID")]
        public int DegreeID { get; set; }
        public Degree Degree { get; set; }

    }

}
