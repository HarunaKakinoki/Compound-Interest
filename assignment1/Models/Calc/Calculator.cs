using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace assignment1.Models.Calc
{
    public class Calculator
    {
        [Required]
        [BindProperty]
        public double PrincipalRate { get; set; }
        [Required]
        [BindProperty]
        public double InterestRate { get; set; }
        [Required]
        [BindProperty]
        public double TimePerYear { get; set; }
        [Required]
        [BindProperty]
        public double Years { get; set; }
        [Required]
        [BindProperty]
        public double Total { get; set; }

    }
}