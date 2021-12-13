using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.AppEnum;

namespace WebApplication1.Models
{
    public class EmployeeLoggedDetail
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int LoggedHours { get; set; }

        public AmountValidateStatus AmountValidateStatus { get; set; }
    }
}