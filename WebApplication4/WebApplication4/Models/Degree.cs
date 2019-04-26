using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Degree 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int DegreeID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DegreeAbbrev { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string DegreeName { get; set; }
        [Range(0, 20)]
        public int NumberOfTerms { get; set; }
        public ICollection<DegreeCredit> DegreeCredits { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "DegreeId = " + DegreeID +
              ", DegreeAbbrev = " + DegreeAbbrev +
              ", DegreeName = " + DegreeName +
              "";
        }
    }
}
