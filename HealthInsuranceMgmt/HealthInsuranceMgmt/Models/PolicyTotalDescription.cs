using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class PolicyTotalDescription
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDesc { get; set; }
        public decimal? PolicyAmount { get; set; }
        public decimal? Emi { get; set; }
        public int? PolicyDuration { get; set; }
        public string CompanyName { get; set; }
    }
}
