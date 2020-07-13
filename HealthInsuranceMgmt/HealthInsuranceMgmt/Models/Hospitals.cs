using System;
using System.Collections.Generic;

namespace HealthInsuranceMgmt.Models
{
    public partial class Hospitals
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string HospitalUrl { get; set; }
    }
}
