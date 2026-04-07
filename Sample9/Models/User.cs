using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample9.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CPassword { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool Anime { get; set; }
        public bool Gaming { get; set; }
        public bool Movies { get; set; }
        public bool Travel { get; set; }
    }
}