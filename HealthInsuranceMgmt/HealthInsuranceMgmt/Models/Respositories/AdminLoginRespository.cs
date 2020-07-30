using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class AdminLoginRespository : GenericRepository<AdminLogin>, IAdminLoginResponsitory
    {
        public AdminLoginRespository(DatabaseContext dbContext) : base(dbContext)
        {

        }

        public AdminLogin CheckLogin(string username, string password)
        {
            return GetAll().Where(p => p.UserName.Equals(username) && p.Password.Equals(password)).SingleOrDefault();
        }

    }
}
