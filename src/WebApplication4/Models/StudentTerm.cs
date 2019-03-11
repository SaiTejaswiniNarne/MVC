using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermID { get; set; }
        public int StudentID { get; set; }
        public int Term { get; set; }
        public string TermAbbrev { get; set; }
        public string TermName { get; set; }
    }
}
