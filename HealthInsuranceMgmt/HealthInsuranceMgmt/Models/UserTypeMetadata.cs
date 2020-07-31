using HealthInsuranceMgmt.Models.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthInsuranceMgmt.Models
{
    public class UserTypeMetadata
    {
    }
    [ModelMetadataType(typeof(UserTypeMetadata))]
    public partial class UserType : IEntity
    {

    }
}
