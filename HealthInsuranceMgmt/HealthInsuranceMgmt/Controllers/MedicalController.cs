using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("medical")]
    public class MedicalController : Controller
    {
        private IMedicalsResponsitory iMedicalsResponsitory;
        public MedicalController(IMedicalsResponsitory _iMedicalsResponsitory)
        {
            iMedicalsResponsitory = _iMedicalsResponsitory;
        }

        //View the medicals
        [Route("")]
        [Route("index")]
        public IActionResult Index(int id)
        {
            ViewBag.pageTitle = "Medicals provide by Company";
            ViewBag.medicals = iMedicalsResponsitory.GetAll().Where(d => d.CompanyId.Equals(id)).ToList();
            return View("Index");
        }

        [Route("hospitalMed/{id}")]
        public IActionResult ListCompanyByIDHospital(int id)
        {
            ViewBag.pageTitle = "Medicals provide by Hospital";
            ViewBag.medicals = iMedicalsResponsitory.GetAll().Where(d => d.HospitalId.Equals(id)).ToList();
            return View("Index");
        }

    }
}
