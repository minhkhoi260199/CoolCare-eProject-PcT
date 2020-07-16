using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class BillResponsitory : GenericRepository<Bill>, IBillResponsitory
    {
        public BillResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
