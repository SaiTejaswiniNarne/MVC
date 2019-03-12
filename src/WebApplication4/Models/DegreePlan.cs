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
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student Student { get; set; }
        public String DegreePlanAbbrev { get; set; }
        public String DegreePlanName { get; set; }
        public int DegreeID { get; set; }
        [ForeignKey("DegreeID")]
        public Degree Degree { get; set; }

    }

}
