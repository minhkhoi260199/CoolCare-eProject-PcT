using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class PolicyRequestDetailsResponsitory : GenericRepository<PolicyRequestDetails>, IPolicyRequestDetailsResponsitory
    {
        public PolicyRequestDetailsResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
