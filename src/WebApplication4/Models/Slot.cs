using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Slot
    {
        public int SlotID;
        //Foreign keys are DegreePlanID,Term,CreditID
        public int DegreePlanID;
        public int Term;
        public int CreditID;
        public string Status;
        public ICollection<DegreePlan> DegreePlans { get; set; }
        public ICollection<StudentTerm> StudentTerms { get; set; }
        public ICollection<Credit> Credits { get; set; }
    }
}
