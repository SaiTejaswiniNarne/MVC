using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
     public class DegreeRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeRequirementId { get; set; }

        public int DegreeId { get; set; }

        // required not needed - ints will always have a value
        [Display(Name = "Requirement Number (used for sorting)")]
        public int RequirementNumber { get; set; }

        [Required]
        [Display(Name = "Requirement Abbreviation")]
        [StringLength(10, ErrorMessage = "Abbreviation cannot be longer than 10 characters.")]
        public string RequirementAbbrev { get; set; }

        [Required]
        [Display(Name = "Requirement Name")]
        [StringLength(60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string RequirementName { get; set; }

        // Add navigation property for each related entity

        // each degree requirement points to exactly one degree
        public Degree Degree { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "DegreeRequirementId = " + DegreeRequirementId +
              "DegreeId = " + DegreeId +
              ", RequirementNumber = " + RequirementNumber +
              ", RequirementAbbrev = " + RequirementAbbrev +
              ", RequirementName = " + RequirementName +
              ", Degree = {" + Degree.ToString() +
                           "}";
        }
    }
}
