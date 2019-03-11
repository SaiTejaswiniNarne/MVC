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
        //Foreign keys are DegreePlanID,Term,CreditID
        public int DegreePlanID { get; set; }
        public int Term { get; set; }
        public int CreditID { get; set; }
        public string Status { get; set; }
        public DegreePlan DegreePlan { get; set; }
        public Credit Credit { get; set; }
        // public ICollection<DegreePlan> DegreePlans { get; set; }
        //public ICollection<StudentTerm> StudentTerms { get; set; }
        //public ICollection<Credit> Credits { get; set; }
    }
}
