
using System.ComponentModel.DataAnnotations;

namespace LabExcercises.Models
{
    public class Lab3_3
    {
        [Required]
        [Range(1,int.MaxValue)]
        public int ItemNum { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        
        [Required]
        [Range(0,int.MaxValue)]
        public int Qty { get; set; }
        
        [Required]
        [Range(0,int.MaxValue)]
        public double Cost { get; set; }
    }
}