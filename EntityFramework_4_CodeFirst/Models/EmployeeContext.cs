using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramework_4_CodeFirst.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("DB_CONNECTION_STRING") {}
        
        public DbSet<Employee> Employees { get; set; }
    }
}