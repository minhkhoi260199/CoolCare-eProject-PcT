using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthInsuranceMgmt.Models.Respositories;
using HealthInsuranceMgmt.Models;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.pageTitle = "Home Page";
                return View();
        }
    }
}