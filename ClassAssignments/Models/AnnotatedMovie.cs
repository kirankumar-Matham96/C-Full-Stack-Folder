using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassAssignments.Models
{
    public class AnnotatedMovie
    {
        [Required]
        [Display(Name = "Movie Id: ")]
        public int ID { get;set; }
        
        [Required]
        [Display(Name="Movie Title: ")]
        public string Title { get; set; }
        
        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [Display(Name="Release Date: ")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [Display(Name="Genre: ")]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Price: ")]
        [Range(100, 250)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Currency)]
        public string Price { get; set; }

        [Required]
        [StringLength(5)]
        [Display(Name = "Rating: ")]
        public string Rating { get; set; }
    }
}