using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class PolicyApprovalDetails
    {
        public int PolicyId { get; set; }
        public int? RequestId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? Amount { get; set; }
        public bool? Status { get; set; }
        public string Reason { get; set; }
    }
}
