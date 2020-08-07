using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/medicals")]
    public class MedicalsController : Controller
    {
        IMedicalsResponsitory imedicalsResponsitory;
        IHospitalsResponsitory ihospitalsResponsitory;
        ICompanyDetailsResponsitory icompanyDetailsResponsitory;

        public MedicalsController(IMedicalsResponsitory _imedicalsResponsitory, IHospitalsResponsitory _ihospitalsResponsitory, ICompanyDetailsResponsitory _icompanyDetailsResponsitory)
        {
            imedicalsResponsitory = _imedicalsResponsitory;
            icompanyDetailsResponsitory = _icompanyDetailsResponsitory;
            ihospitalsResponsitory = _ihospitalsResponsitory;
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("listData")]
        public IActionResult ShowData(int fromNum, int limitNum, string searchData)
        {
            var medicals = new List<Medicals>();
            var medicalsGetAllData = new List<Medicals>();

            var companiesGetAllData = new List<CompanyDetails>();
            var companies = new List<CompanyDetails>();
            if (searchData != "" && searchData != null)
            {
                medicalsGetAllData = imedicalsResponsitory.GetAllWithoutTracking().Where(p => p.MedicalName.Contains(searchData)).ToList();
                medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).Where(p => p.MedicalName.Contains(searchData)).Skip(fromNum).Take(limitNum).ToList();
            }
            else
            {
                medicalsGetAllData = imedicalsResponsitory.GetAllWithoutTracking().ToList();
                medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).Skip(fromNum).Take(limitNum).ToList();
            }

            var html = "";
            var count = 0;
            foreach (var medical in medicals)
            {
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + medical.MedicalName + "</td>" +
                    "<td>" + medical.MedicalDescription + "</td>" +
                    "<td>" + medical.Company.CompanyName + "</td>" +
                    "<td>" + medical.Hospital.HospitalName + "</td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail(" + medical.Id.ToString() + ")' style='font-weight:bold'>More Details</a>" +
                    "</td></tr>";
                if (count < medicals.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }

            var totalPage = 0;
            if (companiesGetAllData.Count() % 5 == 0)
            {
                totalPage = medicalsGetAllData.Count() / 5;
            }
            else
            {
                totalPage = (medicalsGetAllData.Count() / 5) + 1;
            }
            if (totalPage == 0)
            {
                totalPage = 1;
            }

            return Json(new[] { new
                {
                    status = true,
                    data = html,
                     pageTotal = totalPage
                }});
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {
            var medical = await imedicalsResponsitory.GetById(id);
            ViewBag.hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).ToList();
            ViewBag.companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).ToList();
            return View("detail", medical);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("edit")]
        public async Task<IActionResult> Edit(Medicals medical)
        {
            var oldMedical = await imedicalsResponsitory.GetById(medical.Id);
            if (ModelState.IsValid)
            {
                await imedicalsResponsitory.Update(medical.Id, medical);
                return RedirectToAction("index", "medicals");
            }
            ViewBag.hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).ToList();
            ViewBag.companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).ToList();
            return View("detail", medical);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).ToList();
            ViewBag.companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).ToList();
            return View("create");
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(Medicals medical)
        {
            if (ModelState.IsValid)
            {
                await imedicalsResponsitory.Create(medical);
                return RedirectToAction("index", "medicals");
            }
            foreach (var modelStateKey in ModelState.Keys)
            {
                var modelStateVal = ModelState[modelStateKey];
                foreach (var error in modelStateVal.Errors)
                {
                    var key = modelStateKey;
                    var errorMessage = error.ErrorMessage;
                    Debug.WriteLine(key);
                    Debug.WriteLine(errorMessage);
                }
            }
            Debug.WriteLine("LOI");
            ViewBag.hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).ToList();
            ViewBag.companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).ToList();
            return View("create");
        }
    }
}