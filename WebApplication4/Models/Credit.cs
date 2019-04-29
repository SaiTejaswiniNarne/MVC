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
        [StringLength(50, MinimumLength = 3)]
        public string CreditAbbrev { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string CreditName { get; set; }
        [Range(0, 20)]
        public int IsSummer { get; set; }
        [Range(0, 20)]
        public int IsSpring { get; set; }
        [Range(0,20)]
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
