using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.AppEnum;

namespace WebApplication1.Models
{

    public class TransactionDetail
    {
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public TransactionType TransactionType { get; set; }

        public IList<Project> ProjectList { get; set; }

        public CustomerDetail Customer { get; set; }

        public ValidationStatus ValidationStatus { get; set; }

    }
}