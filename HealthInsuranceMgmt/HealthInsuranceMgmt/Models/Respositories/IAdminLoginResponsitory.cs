using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public interface IAdminLoginResponsitory : IGenericRepository<AdminLogin>
    {
        public AdminLogin CheckLogin(string username, string password);
    }
}
