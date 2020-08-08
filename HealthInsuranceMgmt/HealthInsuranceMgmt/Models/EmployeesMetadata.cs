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
        [Required(ErrorMessage ="Please enter your Firstname")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Lastname")]
        [MinLength(2)]
        public string LastName { get; set; }
        [MinLength(6)]
        [MaxLength(10)]
        public string Username { get; set; }
        [MinLength(6)]
        [MaxLength(10)]
        public string Password { get; set; }
        [Phone]
        [Required(ErrorMessage = "Please enter your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your City")]
        public string City { get; set; }
    }

    [ModelMetadataType(typeof(EmployeesMetadata))]
    public partial class Employees : IEntity
    {

    }
}
