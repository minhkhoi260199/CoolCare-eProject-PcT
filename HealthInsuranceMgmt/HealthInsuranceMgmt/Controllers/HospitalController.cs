using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthInsuranceMgmt.Models.Respositories;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("hospital")]
    public class HospitalController : Controller
    {
        private IHospitalsResponsitory ihospitalRepository;

        public HospitalController(IHospitalsResponsitory _ihospitalRepository){
            ihospitalRepository = _ihospitalRepository;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.pageTitle = "Hospital List";
            ViewBag.hospitals = ihospitalRepository.GetAll().ToList();
            return View();
        }

        [HttpPost]
        [Route("searchByName")]
        public IActionResult SearchByName(String keyword)
        {
            ViewBag.pageTitle = "Hospital List";
            ViewBag.hospitals = ihospitalRepository.GetAll().ToList();
            return View();
        }    
    }
}