using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class CompanyDetailsResponsitory : GenericRepository<CompanyDetails>, ICompanyDetailsResponsitory
    {
        public CompanyDetailsResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
