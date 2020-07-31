using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class UserStatus : IEntity
    {
        public UserStatus()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
