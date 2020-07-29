using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceMgmt.Models
{
    public partial class Medicals : IEntity
    {
        public Medicals()
        {
            Policies = new HashSet<Policies>();
        }

        public int Id { get; set; }
        [Required]
        public string MedicalName { get; set; }
        public string MedicalDescription { get; set; }
        [Required]
        public int? CompanyId { get; set; }
        [Required]
        public int? HospitalId { get; set; }

        public virtual CompanyDetails Company { get; set; }
        public virtual Hospitals Hospital { get; set; }
        public virtual ICollection<Policies> Policies { get; set; }
    }
}
