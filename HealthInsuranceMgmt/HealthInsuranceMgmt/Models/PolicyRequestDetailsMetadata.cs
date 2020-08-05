using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class PolicyRequestDetailsMetadata
    {
    }
    [ModelMetadataType(typeof(PolicyRequestDetailsMetadata))]
    public partial class PolicyRequestDetails : IEntity
    {

    }
}
