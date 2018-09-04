using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalAssessmentPart1.Models
{
    public class Calculator
    {
        [Required]
        [Display(Name = "First Number")]
        [Range(1, 1000)]
        public double FirstNum { get; set; }

        [Required]
        [Display(Name = "Second Number")]
        [Range(1, 1000)]
        public double SecondNum { get; set; }
    }
}