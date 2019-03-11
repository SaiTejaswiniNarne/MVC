using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class Degree 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeID { get; set; }
        public string DegreeAbbrev { get; set; }
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }
    }
}
