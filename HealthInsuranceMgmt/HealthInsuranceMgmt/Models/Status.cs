using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Status
    {
        public Status()
        {
            PoliciesOnEmployees = new HashSet<PoliciesOnEmployees>();
            PolicyRequestDetails = new HashSet<PolicyRequestDetails>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<PoliciesOnEmployees> PoliciesOnEmployees { get; set; }
        public virtual ICollection<PolicyRequestDetails> PolicyRequestDetails { get; set; }
    }
}
