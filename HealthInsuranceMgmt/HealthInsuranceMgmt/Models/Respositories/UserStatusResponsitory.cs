using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class UserStatusResponsitory : GenericRepository<UserStatus>, IUserStatusResponsitory
    {
        public UserStatusResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
    }
}
