using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class PoliciesOnEmployees
    {
        public int EmpId { get; set; }
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public decimal PolicyAmount { get; set; }
        public int PolicyDuration { get; set; }
        public decimal Emi { get; set; }
        public DateTime PstartDate { get; set; }
        public DateTime PendDate { get; set; }
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
