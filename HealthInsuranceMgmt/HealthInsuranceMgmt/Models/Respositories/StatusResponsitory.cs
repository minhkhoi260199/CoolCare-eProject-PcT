using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class StatusResponsitory : GenericRepository<Status>, IStatusResponsitory
    {
        public StatusResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
