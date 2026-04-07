using System.ComponentModel.DataAnnotations;

namespace LabExcercises.Models
{
    public class Lab3_1
    {
        [Required]
        [Display(Name ="Firstname: ")]
        [StringLength(20, MinimumLength = 3)]
        public string Firstname { get; set; }
        
        [Required]
        [Display(Name = "Lastname: ")]
        [StringLength(20, MinimumLength = 3)]
        public string Lastname { get; set; }

        //[Required]
        //[Display(Name = "Fulltname: ")]
        //[StringLength(20, MinimumLength = 3)]
        //public string Fullname { get; set; }
    }
}