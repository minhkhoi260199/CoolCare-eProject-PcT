using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class EmployeesMetadata
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [MinLength(6)]
        [MaxLength(10)]
        public string Username { get; set; }
        [MinLength(6)]
        [MaxLength(10)]
        public string Password { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Country { get; set; }
    }

    [ModelMetadataType(typeof(EmployeesMetadata))]
    public partial class Employees : IEntity
    {

    }
}
