using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal CostPerHour { get; set; }

        public IList<EmployeeProjectAllocation> Allocations { get; set; }
    }
}