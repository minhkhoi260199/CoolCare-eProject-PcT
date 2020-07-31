using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class BillMetadata
    {
    }
    [ModelMetadataType(typeof(BillMetadata))]
    public partial class Bill : IEntity
    {

    }
}
