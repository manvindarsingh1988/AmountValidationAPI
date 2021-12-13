using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public IList<ProjectMiles> Miles { get; set; }
    }
}