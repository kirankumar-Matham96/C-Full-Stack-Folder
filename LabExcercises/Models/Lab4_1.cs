using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabExcercises.Models
{
    public class Lab4_1
    {
        [Required]
        [Display(Name="Student Id: ")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Student Name: ")]
        [StringLength(120, MinimumLength =3)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name="Marks1: ")]
        [Range(0,100)]
        public int Marks1 { get; set; }
        
        [Required]
        [Display(Name="Marks2: ")]
        [Range(0,100)]
        public int Marks2 { get; set; }
        
        [Required]
        [Display(Name= "Marks3: ")]
        [Range(0,100)]
        public int Marks3 { get; set; }

        [Required]
        [Display(Name = "Total Marks: ")]
        public int TotalMarks { get; set; }

    }
}