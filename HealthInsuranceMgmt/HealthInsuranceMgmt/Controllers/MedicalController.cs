using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("medical")]
    public class MedicalController : Controller
    {
        private DatabaseContext db;
        public MedicalController(DatabaseContext _db)
        {
            db = _db;
        }

        //View the medicals
        [Route("")]
        [Route("index")]
        public IActionResult Index(int id)
        {
            ViewBag.medicals = db.CompanyDetails.Find(id).Medicals.ToList();
            ViewBag.hospitals = db.Medicals.Find(id).Hospital.HospitalName;
            return View("Index");
        }
    }
}
