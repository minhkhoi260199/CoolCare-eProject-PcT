using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class UserType:IEntity
    {
        public UserType()
        {
            AdminLogin = new HashSet<AdminLogin>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AdminLogin> AdminLogin { get; set; }
    }
}
