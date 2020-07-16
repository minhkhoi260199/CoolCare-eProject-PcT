using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class CompanyDetails:IEntity
    {
        public CompanyDetails()
        {
            Medicals = new HashSet<Medicals>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CompanyUrl { get; set; }

        public virtual ICollection<Medicals> Medicals { get; set; }
    }
}
