using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class PoliciesOnEmployeesResponsitory : GenericRepository<PoliciesOnEmployees>, IPoliciesOnEmployeesResponsitory
    {
        public PoliciesOnEmployeesResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
