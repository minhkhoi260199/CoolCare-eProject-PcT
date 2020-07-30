using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/policies")]
    public class PoliciesController : Controller
    {

        IMedicalsResponsitory imedicalsResponsitory;
        IHospitalsResponsitory ihospitalsResponsitory;
        ICompanyDetailsResponsitory icompanyDetailsResponsitory;
        IPoliciesResponsitory ipoliciesResponsitory;

        public PoliciesController(IPoliciesResponsitory _ipoliciesResponsitory, IMedicalsResponsitory _imedicalsResponsitory, IHospitalsResponsitory _ihospitalsResponsitory, ICompanyDetailsResponsitory _icompanyDetailsResponsitory)
        {
            imedicalsResponsitory = _imedicalsResponsitory;
            icompanyDetailsResponsitory = _icompanyDetailsResponsitory;
            ihospitalsResponsitory = _ihospitalsResponsitory;
            ipoliciesResponsitory = _ipoliciesResponsitory;
        }
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("listData")]
        public IActionResult ShowData()
        {
            var policies = ipoliciesResponsitory.GetAll().OrderBy(p => p.PolicyName).ToList();

            var html = "";
            var count = 0;
            foreach (var policy in policies)
            {
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + policy.PolicyName + "</td>" +
                    "<td>" + policy.PolicyDesc + "</td>" +
                    "<td>" + policy.Medical.MedicalName + "</td>" +
                    "<td>" + policy.Medical.Company.CompanyName + "</td>" +
                    "<td>" + policy.Medical.Hospital.HospitalName + "</td>" +
                    "<td>" + policy.Amount + "</td>" +
                    "<td>" + policy.Emi + "</td>" +
                    "<td>" + policy.PolicyDuration + "</td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail(" + policy.Id.ToString() + ")' style='font-weight:bold'>More Details</a>" +
                    "</td></tr>";
                if (count < policies.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }
            return Json(new[] { new
                {
                    status = true,
                    data = html
                }});
        }

        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {
            var policy = await ipoliciesResponsitory.GetById(id);
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("detail", policy);
        }

        [Route("edit")]
        public async Task<IActionResult> Edit(Policies policy)
        {
            var oldPolicy = await imedicalsResponsitory.GetById(policy.Id);
            if (ModelState.IsValid)
            {
                await ipoliciesResponsitory.Update(policy.Id, policy);
                return RedirectToAction("index", "policies");
            }
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("detail", policy);
        }
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("create");
        }

        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(Policies policy)
        {
            if (ModelState.IsValid)
            {
                await ipoliciesResponsitory.Create(policy);
                return RedirectToAction("index", "policies");
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
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("create");
        }
    }
}