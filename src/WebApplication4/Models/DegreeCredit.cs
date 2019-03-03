using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class DegreeCredit
    {
        //Primarykey is DegreeCreditID
        public int DegreeCreditID { get; set; }
        //Foreign keys are DegreeID and CreditID
        public int DegreeID { get; set; }
        public int CreditID { get; set; }


        //public Credit Credit { get; set}
        //public Degree Degree{ get; set}

    }
}
