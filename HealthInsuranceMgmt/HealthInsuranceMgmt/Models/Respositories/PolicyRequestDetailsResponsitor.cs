using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class PolicyRequestDetailsResponsitor : GenericRepository<PolicyRequestDetails>, IPolicyRequestDetailsResponsitory
    {
        public PolicyRequestDetailsResponsitor(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
