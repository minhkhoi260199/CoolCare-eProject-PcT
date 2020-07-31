using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Medicals
    {
        public Medicals()
        {
            Policies = new HashSet<Policies>();
        }

        public int Id { get; set; }
        public string MedicalName { get; set; }
        public string MedicalDescription { get; set; }
        public int CompanyId { get; set; }
        public int HospitalId { get; set; }

        public virtual CompanyDetails Company { get; set; }
        public virtual Hospitals Hospital { get; set; }
        public virtual ICollection<Policies> Policies { get; set; }
    }
}
