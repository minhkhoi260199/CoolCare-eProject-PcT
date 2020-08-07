using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("company")]
    public class CompanyController : Controller
    {
        private ICompanyDetailsResponsitory iCompanyDetailsResponsitory;
        public CompanyController(ICompanyDetailsResponsitory _iCompanyDetailsResponsitory)
        {
            iCompanyDetailsResponsitory = _iCompanyDetailsResponsitory;
        }

        // display the insurance companies
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.pageTitle = "Company List";
            ViewBag.companies = iCompanyDetailsResponsitory.GetAll().ToList();
            return View("Index");
        }

        [HttpPost]
        [Route("search")]
        public IActionResult SearchByName(String keyword)
        {
            ViewBag.pageTitle = "Search company";
            ViewBag.keyword = keyword;
            ViewBag.companies = iCompanyDetailsResponsitory.SearchName(keyword);
            return View("index");
        }    
    }
}
