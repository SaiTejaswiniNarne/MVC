using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class DegreeCredit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int DegreeCreditID { get; set; }
        [ForeignKey("DegreeID")]
        public int DegreeID { get; set; }
        
        public Degree Degree { get; set; }
        [ForeignKey("CreditID")]
        public int CreditID { get; set; }
     
        public Credit Credit { get; set; }
       

    }
}
