using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Hospitals : IEntity
    {
        public Hospitals()
        {
            Medicals = new HashSet<Medicals>();
        }

        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string HospitalUrl { get; set; }

        public virtual ICollection<Medicals> Medicals { get; set; }
    }
}
