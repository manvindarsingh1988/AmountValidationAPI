using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public interface IRepository
    {
        IList<PaidAmountDetail> GetPaidAmountDetailsAgainstProjects(IEnumerable<int> ids);

        IList<Employee> GetEmployeesLinkedwithProject(int projectId);

        IList<EmployeeLoggedDetail> GetLoggedHours(int EmployeeId, DateTime startDate, DateTime endDate);        
    }
}
