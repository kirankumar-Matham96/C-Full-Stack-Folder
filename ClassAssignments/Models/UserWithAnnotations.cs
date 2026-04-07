using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ClassAssignments.Models
{
    public class UserWithAnnotations
    {
        [Required]
        [Display(Name="User Id: ")]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength =3)]
        [Display(Name = "User Name: ")]
        public string Name { get; set; }


        // here, either regex or attribute is sufficient
        [Required]
        [Display(Name = "Email Id: ")]
        //[EmailAddress] //[DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-zA-Z0-9._]+@[a-zA-Z0-9._]+[a-zA-Z]", ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required]
        //[DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage ="Invalid Password: password must contain at least 1 uppercase, 1 lower case, 1 digit, 1 symbl and min length of 8 characters")]
        public string Password { get; set; }

        [Required]
        [Display(Name="Confirm Password: ")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(22, 60)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth: ")]
        public DateTime DateOfBirth { get; set; }

        public enum GenderType
        {
            Male, Female, Others
        }

        [Required]
        public GenderType Gender { get; set; }

        public List<string> Hobbies { get; set; }

        [Required]
        [Phone] // [DataType(DataType.PhoneNumber)] // <-- older
        [StringLength(10, MinimumLength =10)]
        public string MobileNumber { get; set; }

        [Required]
        public string City { get; set; }
    }
}