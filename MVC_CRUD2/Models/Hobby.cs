using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD2.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; } = false;
    }
}