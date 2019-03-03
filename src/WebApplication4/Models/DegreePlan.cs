using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class DegreePlan
    {
        public int DegreePlanID;
        //Foreign key is StudentID
        public int StudentID;
        public String DegreePlanAbbrev;
        public String DegreePlanName;
    }
}
