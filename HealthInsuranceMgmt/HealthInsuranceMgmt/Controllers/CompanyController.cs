using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("company")]
    public class CompanyController : Controller
    {
        private DatabaseContext db;
        public CompanyController(DatabaseContext _db)
        {
            db = _db;
        }

        // display the insurance companies
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.companies = db.CompanyDetails.ToList();
            return View("Index");
        }
    }
}
