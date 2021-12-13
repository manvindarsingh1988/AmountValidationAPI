using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public class Repository : IRepository
    {
        public IList<Employee> GetEmployeesLinkedwithProject(int projectId)
        {
            return new List<Employee>();
        }

        public IList<EmployeeLoggedDetail> GetLoggedHours(int EmployeeId, DateTime startDate, DateTime endDate)
        {
            return new List<EmployeeLoggedDetail>();
        }

        public IList<PaidAmountDetail> GetPaidAmountDetailsAgainstProjects(IEnumerable<int> ids)
        {
            return new List<PaidAmountDetail>();
        }
    }
}