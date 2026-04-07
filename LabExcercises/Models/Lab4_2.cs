using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabExcercises.Models
{
    public class Lab4_2
    {
        [Required]
        [Display(Name = "Enter Emploee No: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 3)]
        [Display(Name = "Enter Emploee Name: ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Enter Emploee Basic Salary: ")]
        public double BasicSalary { get; set; }

        [Display(Name = "Da: ")]
        public double Da { get; set; }

        [Display(Name = "Hra: ")]
        public double Hra { get; set; }

        [Display(Name = "Total Salary: ")]
        public double TotalSalary { get; set; }

    }
}