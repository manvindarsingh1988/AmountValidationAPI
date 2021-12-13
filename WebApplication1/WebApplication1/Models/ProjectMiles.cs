using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.AppEnum;

namespace WebApplication1.Models
{
    public class ProjectMiles
    {
        public int Id { get; set; }

        public Project Project { get; set; }

        public decimal CostForMile { get; set; }

        public MilesStatus MilesStatus { get; set; }

        public AmountValidateStatus AmountValidateStatus { get; set; }
    }
}