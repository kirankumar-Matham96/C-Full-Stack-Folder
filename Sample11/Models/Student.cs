using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample11.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MathsMarks { get; set; }
        public int ScienceMarks { get; set; }
        public int SocialMarks { get; set; }
        public int TotalMarks { get; set; }
        public int AverageMarks { get; set; }
        public int Percentage { get; set; }
    }
}