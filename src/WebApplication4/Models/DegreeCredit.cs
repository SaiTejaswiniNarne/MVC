using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class DegreeCredit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditID { get; set; }
        public int DegreeID { get; set; }
        [ForeignKey("DegreeID")]
        public Degree Degree { get; set; }
        public int CreditID { get; set; }
        [ForeignKey("CreditID")]
        public Credit Credit { get; set; }
       

    }
}
