using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Credit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CreditID { get; set; }
        public string CreditAbbrev { get; set; }
        public string CreditName { get; set; }
        public int IsSummer { get; set; }
        public int IsSpring { get; set; }
        public int IsFall   { get; set; }
        public ICollection<DegreeCredit> DegreeCredits { get; set; }
        public override string ToString()
        {
            return base.ToString() + ": " +
              "CreditId = " + CreditID +
              ", CreditAbbrev = " + CreditAbbrev +
              ", CreditName = " + CreditName +
              "";
        }
    }
}
