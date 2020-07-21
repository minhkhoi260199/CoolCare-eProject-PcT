using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Medicals:IEntity
    {
        public int Id { get; set; }
        public string MedicalName { get; set; }
        public string MedicalDescription { get; set; }
        public int? CompanyId { get; set; }
        public int? HospitalId { get; set; }

        public virtual CompanyDetails Company { get; set; }
        public virtual Hospitals Hospital { get; set; }
    }
}
