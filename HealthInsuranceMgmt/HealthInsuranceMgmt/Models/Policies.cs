using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceMgmt.Models
{
    public partial class Policies : IEntity
    {
        public Policies()
        {
            PoliciesOnEmployees = new HashSet<PoliciesOnEmployees>();
        }

        public int Id { get; set; }
        [Required]
        public string PolicyName { get; set; }
        public string PolicyDesc { get; set; }
        [Required]
        public decimal? Amount { get; set; }
        [Required]
        public decimal? Emi { get; set; }
        [Required]
        public int? PolicyDuration { get; set; }
        [Required]
        public int MedicalId { get; set; }

        public virtual Medicals Medical { get; set; }
        public virtual ICollection<PoliciesOnEmployees> PoliciesOnEmployees { get; set; }
    }
}
