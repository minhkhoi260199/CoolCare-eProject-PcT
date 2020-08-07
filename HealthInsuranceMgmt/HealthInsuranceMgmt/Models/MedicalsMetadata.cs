using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class MedicalsMetadata
    {
        [Required]
        public string MedicalName { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public int HospitalId { get; set; }
    }
    [ModelMetadataType(typeof(MedicalsMetadata))]
    public partial class Medicals : IEntity
    {

    }
}
