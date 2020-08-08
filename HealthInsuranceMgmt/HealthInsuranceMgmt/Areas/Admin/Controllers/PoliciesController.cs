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
            var policies = new List<Policies>();
            var policiesGetAllData = new List<Policies>();

            if (searchData != "" && searchData != null)
            {
                policiesGetAllData = ipoliciesResponsitory.GetAllWithoutTracking().Where(p => p.PolicyName.Contains(searchData)).ToList();
                policies = ipoliciesResponsitory.GetAll().OrderBy(p => p.PolicyName).Where(p => p.PolicyName.Contains(searchData)).Skip(fromNum).Take(limitNum).ToList();
            }
            else
            {
                policiesGetAllData = ipoliciesResponsitory.GetAllWithoutTracking().ToList();
                policies = ipoliciesResponsitory.GetAll().OrderBy(p => p.PolicyName).Skip(fromNum).Take(limitNum).ToList();
            }

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

            var totalPage = 0;
            if (policiesGetAllData.Count() % 5 == 0)
            {
                totalPage = policiesGetAllData.Count() / 5;
            }
            else
            {
                totalPage = (policiesGetAllData.Count() / 5) + 1;
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
            var policy = await ipoliciesResponsitory.GetById(id);
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("detail", policy);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
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

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("create")]
        public IActionResult Create()
        {
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("create");
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(Policies policy)
        {
            if (ModelState.IsValid)
            {
                await ipoliciesResponsitory.Create(policy);
                return RedirectToAction("index", "policies");
            }
            ViewBag.medicals = imedicalsResponsitory.GetAll().OrderBy(p => p.MedicalName).ToList();
            return View("create");
        }
    }
}