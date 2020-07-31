using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class UserStatusMetadata
    {
    }
    [ModelMetadataType(typeof(UserStatusMetadata))]
    public partial class UserStatus : IEntity
    {

    }
}
