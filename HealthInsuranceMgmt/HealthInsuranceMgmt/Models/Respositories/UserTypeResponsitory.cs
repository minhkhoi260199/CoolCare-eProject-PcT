using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class UserTypeResponsitory : GenericRepository<UserType>, IUserTypeResponsitory
    {
        public UserTypeResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
