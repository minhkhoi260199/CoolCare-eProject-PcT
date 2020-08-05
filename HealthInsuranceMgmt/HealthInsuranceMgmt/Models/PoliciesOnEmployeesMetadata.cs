using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class PoliciesOnEmployeesMetadata
    {
    }

    [ModelMetadataType(typeof(PoliciesOnEmployeesMetadata))]
    public partial class PoliciesOnEmployees : IEntity
    {

    }
}
