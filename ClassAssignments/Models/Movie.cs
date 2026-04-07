using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassAssignments.Models
{
    public class Movie
    {
        [Required]
        [Display(Name ="Movie ID: ")]

        public int Id { get; set; }

        [Required]
        [Display(Name ="Title: ")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Description: ")]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "RealeaseDate: ")]
        [DataType(DataType.Date)]
        public DateTime RealeaseDate { get; set; }

        [Required]
        [Display(Name = "Genre: ")]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Rating: ")]
        [Range(0.0,5.0)]
        public double Rating { get; set; }
    }
}