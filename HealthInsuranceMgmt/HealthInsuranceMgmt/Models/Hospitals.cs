using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceMgmt.Models
{
    public partial class Hospitals : IEntity
    {
        public Hospitals()
        {
            Medicals = new HashSet<Medicals>();
        }

        public int Id { get; set; }
        [Required]
        public string HospitalName { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Location { get; set; }
        [Url]
        public string HospitalUrl { get; set; }

        public virtual ICollection<Medicals> Medicals { get; set; }
    }
}
