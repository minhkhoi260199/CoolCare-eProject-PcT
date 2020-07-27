using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HealthInsuranceMgmt.Models
{
    public partial class Employees:IEntity
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal? Salary { get; set; }
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
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        public string City { get; set; }
        public int Status { get; set; }

        public virtual UserStatus StatusNavigation { get; set; }
    }
}
