using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class PolicyRequestDetails
    {
        public int Id { get; set; }
        public DateTime? RequestDate { get; set; }
        public int EmpId { get; set; }
        public int? PolicyId { get; set; }
        public bool Status { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Reason { get; set; }
    }
}
