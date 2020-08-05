using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class HospitalsResponsitory : GenericRepository<Hospitals>, IHospitalsResponsitory
    {
        public HospitalsResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }

        public List<Hospitals>SearchName(string name)
        {
            return GetAll().Where(p => p.HospitalName.Contains(name)).ToList();
        }
    }
}
