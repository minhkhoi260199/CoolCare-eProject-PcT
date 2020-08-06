using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("aboutUs")]
    public class AboutUsController : Controller
    {
        [Route("")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
