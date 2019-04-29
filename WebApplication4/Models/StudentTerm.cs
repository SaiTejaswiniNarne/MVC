using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int StudentTermID { get; set; }
        [ForeignKey("StudentID")]
        public int StudentID { get; set; }
        [Range(0, 20)]
        public int Term { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string TermAbbrev { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string TermName { get; set; }
    }
}
