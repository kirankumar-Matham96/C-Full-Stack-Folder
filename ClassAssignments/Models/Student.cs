using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassAssignments.Models
{
    public class Student
    {
        [Required]
        [Display(Name="Student Id: ")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name: ")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email: ")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name= "Password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name="Confirm Password: ")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name="Maths Marks: ")]
        [Range(0, 100)]
        public int Maths { get; set; }

        [Required]
        [Display(Name= "Physics Marks: ")]
        [Range(0, 100)]
        public int Physics { get; set; }

        [Required]
        [Display(Name="Chemistry Marks: ")]
        [Range(0, 100)]
        public int Chemistry { get; set; }

        [Required]
        [Display(Name = "Total Marks: ")]
        public int Total { get; set; }

    }
}