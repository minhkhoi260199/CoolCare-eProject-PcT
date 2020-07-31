using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class PoliciesOnEmployees
    {
        public PoliciesOnEmployees()
        {
            Bill = new HashSet<Bill>();
        }

        public int EmpId { get; set; }
        public int PolicyId { get; set; }
        public int Id { get; set; }
        public int StatusId { get; set; }

        public virtual Employees Emp { get; set; }
        public virtual Policies Policy { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
    }
}
