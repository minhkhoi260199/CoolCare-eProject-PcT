using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{   [Route("contactUs")]
    public class ContactUsController : Controller
    {
        [Route("")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
