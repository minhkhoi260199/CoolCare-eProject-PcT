using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class CompanyDetailsMetadata
    {
        [Required]
        public string CompanyName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Url]
        public string CompanyUrl { get; set; }
    }
    [ModelMetadataType(typeof(CompanyDetailsMetadata))]
    public partial class CompanyDetails : IEntity
    {

    }
}
