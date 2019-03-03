using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Models
{
    public class StudentTerm
    {
        public int StudentTermID;
        public int StudentID;
        public int Term;
        public string TermAbbrev;
        public string TermName;
    }
}
