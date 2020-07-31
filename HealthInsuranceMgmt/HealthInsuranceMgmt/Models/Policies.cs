using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Policies
    {
        public Policies()
        {
            PoliciesOnEmployees = new HashSet<PoliciesOnEmployees>();
        }

        public int Id { get; set; }
        public string PolicyName { get; set; }
        public string PolicyDesc { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Emi { get; set; }
        public int? PolicyDuration { get; set; }
        public int MedicalId { get; set; }

        public virtual Medicals Medical { get; set; }
        public virtual ICollection<PoliciesOnEmployees> PoliciesOnEmployees { get; set; }
    }
}
