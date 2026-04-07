using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabExcercises.Models
{
    public class Lab4_4
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        
        [Required]
        [Range(18,25)]
        public int Age { get; set; }
        
        [Required]
        [StringLength(10, MinimumLength =10)]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}