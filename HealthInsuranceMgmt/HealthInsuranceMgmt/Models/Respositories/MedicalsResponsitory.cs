using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class MedicalsResponsitory : GenericRepository<Medicals>, IMedicalsResponsitory
    {
        public MedicalsResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
