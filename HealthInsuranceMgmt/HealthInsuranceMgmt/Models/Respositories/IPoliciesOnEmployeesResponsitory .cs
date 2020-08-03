using HealthInsuranceMgmt.Models.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models.Respositories
{
    public interface IPoliciesOnEmployeesResponsitory : IGenericRepository<PoliciesOnEmployees>
    {
        public PoliciesOnEmployees SearchByEmpIdAndPoliId(int empId, int policyId);
    }
}
