using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Policies
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDesc { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Emi { get; set; }
        public int? CompanyId { get; set; }
    }
}
