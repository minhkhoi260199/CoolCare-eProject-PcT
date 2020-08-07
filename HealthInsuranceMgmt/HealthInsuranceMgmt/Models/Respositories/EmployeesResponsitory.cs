using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public class EmployeesResponsitory : GenericRepository<Employees>, IEmployeesResponsitory
    {
        public EmployeesResponsitory(DatabaseContext dbContext) : base(dbContext)
        {

        }
        public Employees Login(string username)
        {
            return GetAll().Where(p => p.Username.Equals(username)).SingleOrDefault();
        }
    }
}
