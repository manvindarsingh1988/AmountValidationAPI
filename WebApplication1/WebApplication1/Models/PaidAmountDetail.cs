using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.AppEnum;

namespace WebApplication1.Models
{
    public class PaidAmountDetail
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public decimal PaidAmount { get; set; }

        public TransactionType TransactionType { get; set; }

    }
}