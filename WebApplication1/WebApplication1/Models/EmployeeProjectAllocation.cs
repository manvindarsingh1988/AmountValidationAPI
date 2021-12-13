using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeProjectAllocation
    {
        public int Id { get; set; }

        public Employee Employee { get; set; }

        public Project Project { get; set; }

        public int AllocationInPercentage { get; set; }
    }
}