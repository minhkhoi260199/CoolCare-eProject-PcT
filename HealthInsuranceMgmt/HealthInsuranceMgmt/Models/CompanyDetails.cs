using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HealthInsuranceMgmt.Models
{
    public partial class CompanyDetails:IEntity
    {
        public CompanyDetails()
        {
            Medicals = new HashSet<Medicals>();
        }

        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Url]
        public string CompanyUrl { get; set; }

        public virtual ICollection<Medicals> Medicals { get; set; }
    }
}
