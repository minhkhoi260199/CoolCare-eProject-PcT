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
    [Route("admin/companies")]
    public class CompaniesController : Controller
    {
        private ICompanyDetailsResponsitory icompanyDetailsResponsitory;
        private IMedicalsResponsitory imedicalsResponsitory;
        private IPoliciesResponsitory ipoliciesResponsitory;

        public CompaniesController(ICompanyDetailsResponsitory _icompanyDetailsResponsitory, IMedicalsResponsitory _imedicalsResponsitory, IPoliciesResponsitory _ipoliciesResponsitory)
        {
            icompanyDetailsResponsitory = _icompanyDetailsResponsitory;
            imedicalsResponsitory = _imedicalsResponsitory;
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

            var companiesGetAllData = new List<CompanyDetails>();
            var companies = new List<CompanyDetails>();
            if (searchData != "" && searchData != null)
            {
                companiesGetAllData = icompanyDetailsResponsitory.GetAllWithoutTracking().Where(p => p.CompanyName.Contains(searchData)).ToList();
                companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).Where(p => p.CompanyName.Contains(searchData)).Skip(fromNum).Take(limitNum).ToList();
            }
            else
            {
                companiesGetAllData = icompanyDetailsResponsitory.GetAllWithoutTracking().ToList();
                companies = icompanyDetailsResponsitory.GetAll().OrderBy(p => p.CompanyName).Skip(fromNum).Take(limitNum).ToList();
            }

            

            var html = "";
            var count = 0;
            foreach (var company in companies)
            {
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + company.CompanyName + "</td>" +
                    "<td>" + company.Address + "</td>" +
                    "<td>" + company.Phone + "</td>" +
                    "<td><a href='"+ company.CompanyUrl + "'>" + company.CompanyUrl + "</a></td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail(" + company.Id.ToString() + ")' style='font-weight:bold'>More Details</a>" +
                    "</td></tr>";
                if (count < companies.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }

            var totalPage = 0;
            if (companiesGetAllData.Count() % 5 == 0)
            {
                totalPage = companiesGetAllData.Count() / 5;
            }
            else
            {
                totalPage = (companiesGetAllData.Count() / 5) + 1;
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
            var company = await icompanyDetailsResponsitory.GetById(id);
            return View("detail", company);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("edit")]
        public async Task<IActionResult> Edit(CompanyDetails company)
        {
            var oldCompany = await icompanyDetailsResponsitory.GetById(company.Id);
            if (ModelState.IsValid)
            {
                await icompanyDetailsResponsitory.Update(company.Id, company);
                return RedirectToAction("index", "companies");
            }
            return View("detail", company);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(CompanyDetails company)
        {
            if (ModelState.IsValid)
            {
                await icompanyDetailsResponsitory.Create(company);
                return RedirectToAction("index", "companies");
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
            return View("create");
        }
    }
}