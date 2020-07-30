using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Status : IEntity
    {
        public Status()
        {
            PoliciesOnEmployees = new HashSet<PoliciesOnEmployees>();
        }

        public int Id { get; set; }
        public string Status1 { get; set; }

        public virtual ICollection<PoliciesOnEmployees> PoliciesOnEmployees { get; set; }
    }
}
