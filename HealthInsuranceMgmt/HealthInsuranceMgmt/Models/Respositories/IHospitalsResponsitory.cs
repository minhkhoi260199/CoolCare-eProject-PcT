using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public interface IHospitalsResponsitory : IGenericRepository<Hospitals>
    {
        public List<Hospitals> SearchName(string name);
    }
}
