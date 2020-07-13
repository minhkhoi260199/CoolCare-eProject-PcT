using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class PolicyRequestDetails
    {
        public int RequestId { get; set; }
        public DateTime? RequestDate { get; set; }
        public int EmpId { get; set; }
        public int? PolicyId { get; set; }
        public string PolicyName { get; set; }
        public decimal? PolicyAmount { get; set; }
        public decimal? Emi { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public bool Status { get; set; }
    }
}
