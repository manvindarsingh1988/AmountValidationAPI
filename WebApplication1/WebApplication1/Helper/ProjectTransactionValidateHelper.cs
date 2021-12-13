using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.AppEnum;
using WebApplication1.DataAccess;
using WebApplication1.Models;

namespace WebApplication1.Helper
{
    public interface IProjectTransactionValidateHelper
    {
        bool Validate(IList<TransactionDetail> transactionDetails);
    }
    public class ProjectTransactionValidateHelper : IProjectTransactionValidateHelper
    {
        private readonly IRepository repository;
        public ProjectTransactionValidateHelper(IRepository repository)
        {
            this.repository = repository;
        }
        public bool Validate(IList<TransactionDetail> transactionDetails)
        {
            foreach(var td in transactionDetails)
            {
                var paidAmountDetails = repository.GetPaidAmountDetailsAgainstProjects(td.ProjectList.Select(x => x.Id));
                foreach(var pad in paidAmountDetails)
                {
                    if(pad.Project.Miles != null && pad.Project.Miles.Any())
                    {
                        var notValidatedDetail = pad.Project.Miles.Where(x => x.AmountValidateStatus == AmountValidateStatus.NotValidated && x.MilesStatus == MilesStatus.Completed);
                        var totalPaidCost = notValidatedDetail.Sum(x => x.CostForMile);
                        if(totalPaidCost == pad.PaidAmount)
                        {
                            foreach(var item in notValidatedDetail)
                            {
                                item.AmountValidateStatus = AmountValidateStatus.Validated;
                            }
                            td.ValidationStatus = ValidationStatus.Matched;
                        }
                        else
                        {
                            td.ValidationStatus = ValidationStatus.Mismatched;
                        }
                    } 
                    else
                    {
                        decimal totalPaidCost = 0;
                        var employeeDeta = repository.GetEmployeesLinkedwithProject(pad.Project.Id);
                        var loggedHoursList = new List<EmployeeLoggedDetail>();
                        foreach(var item in employeeDeta)
                        {
                            var loggedhours = repository.GetLoggedHours(item.Id, DateTime.Now, DateTime.Now);
                            foreach(var lh in loggedhours)
                            {
                                totalPaidCost += lh.LoggedHours * item.CostPerHour;
                            }
                            loggedHoursList.AddRange(loggedhours);
                        }
                        if (totalPaidCost == pad.PaidAmount)
                        {
                            foreach (var lhl in loggedHoursList)
                            {
                                lhl.AmountValidateStatus = AmountValidateStatus.Validated;
                            }
                            td.ValidationStatus = ValidationStatus.Matched;
                        }
                        else
                        {
                            td.ValidationStatus = ValidationStatus.Mismatched;
                        }
                    }
                }
            }
            return transactionDetails.All(x => x.ValidationStatus == ValidationStatus.Matched);
        }


    }
}