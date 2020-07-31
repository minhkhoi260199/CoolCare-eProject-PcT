using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class HospitalsMetadata
    {
        [Required]
        public string HospitalName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Url]
        public string HospitalUrl { get; set; }
    }
    [ModelMetadataType(typeof(HospitalsMetadata))]
    public partial class Hospitals : IEntity
    {

    }
}
