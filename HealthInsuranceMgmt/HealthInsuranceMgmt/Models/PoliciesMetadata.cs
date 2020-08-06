using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class PoliciesMetadata
    {
        [Required]
        public string PolicyName { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal Emi { get; set; }
        [Required]
        public int PolicyDuration { get; set; }
        [Required]
        public int MedicalId { get; set; }
    }
    [ModelMetadataType(typeof(PoliciesMetadata))]
    public partial class Policies : IEntity
    {

    }
}
