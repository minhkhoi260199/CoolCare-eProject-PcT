using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class PoliciesResponsitory : GenericRepository<Policies>, IPoliciesResponsitory
    {
        public PoliciesResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
