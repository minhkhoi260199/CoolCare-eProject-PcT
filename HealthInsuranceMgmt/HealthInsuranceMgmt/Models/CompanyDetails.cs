using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class CompanyDetails
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CompanyUrl { get; set; }
    }
}
