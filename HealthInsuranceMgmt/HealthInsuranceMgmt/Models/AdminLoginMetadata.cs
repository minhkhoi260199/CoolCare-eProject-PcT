using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class AdminLoginMetadata
    {
        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string UserName { get; set; }
        [MinLength(6)]
        [MaxLength(10)]
        public string Password { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string LastName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    }

    [ModelMetadataType(typeof(AdminLoginMetadata))]
    public partial class AdminLogin : IEntity
    {

    }
}
