using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabExcercises.Models
{
    public class Numbers
    {
        [Required]
        [Range(0,int.MaxValue)]
        public int Num1 { get; set; }
        
        [Required]
        [Range(1,int.MaxValue)]
        public int Num2 { get; set; }
    }
}