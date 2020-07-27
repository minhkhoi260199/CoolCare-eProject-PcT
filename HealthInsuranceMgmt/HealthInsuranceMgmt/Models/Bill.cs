using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Bill : IEntity
    {
        public int Id { get; set; }
        public int InsuranceId { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }

        public virtual PoliciesOnEmployees Insurance { get; set; }
    }
}
