using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotID { get; set; }
        public int DegreePlanID { get; set; }
        [ForeignKey("DegreePlanID")]
        public DegreePlan DegreePlan { get; set; }
        public int Term { get; set; }
        public int CreditID { get; set; }
        [ForeignKey("CreditID")]
        public Credit Credit { get; set; }
        public string Status { get; set; }
        
       
        public ICollection<Credit> Credits { get; set; }
    }
}
