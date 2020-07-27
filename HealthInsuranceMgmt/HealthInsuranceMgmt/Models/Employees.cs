using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Employees : IEntity
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal? Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Status { get; set; }

        public virtual UserStatus StatusNavigation { get; set; }
    }
}
