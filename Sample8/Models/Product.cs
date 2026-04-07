using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample8.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Rating {  get; set; }
    }
}