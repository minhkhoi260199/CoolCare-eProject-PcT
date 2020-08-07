using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HealthInsuranceMgmt.Models.Respositories;
using HealthInsuranceMgmt.Models;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("request")]
    public class RequestController : Controller
    {
        private IPolicyRequestDetailsResponsitory ipolicyRequestDetailsResponsitory;
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;

        public RequestController(IPolicyRequestDetailsResponsitory _ipolicyRequestDetailsResponsitory, IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory)
        {
            ipolicyRequestDetailsResponsitory = _ipolicyRequestDetailsResponsitory;
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
        }

        [Route("index")]
        public IActionResult Index()
        {
            var id = int.Parse(HttpContext.Session.GetString("userId"));
            ViewBag.emppolicies = ipoliciesOnEmployeesResponsitory.GetAll().Where(p => p.EmpId.Equals(id)).OrderBy(p => p.StatusId).ToList();
            return View();
        }

        [Route("create/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.polOnEmp = await ipoliciesOnEmployeesResponsitory.GetByIdHavingTracking(id);
            return View("create");
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(PolicyRequestDetails policyRequestDetails)
        {
            DateTime date = DateTime.Now;
            policyRequestDetails.RequestDate = date;
            policyRequestDetails.Status = 1;
            ipolicyRequestDetailsResponsitory.Create(policyRequestDetails);

            return View("success");
        }

        [Route("cancel/{id}")]
        public async Task<IActionResult> Cancel(int id)
        {
            var oldRequest = await ipolicyRequestDetailsResponsitory.GetById(id);
            oldRequest.Status = 3;
            ipolicyRequestDetailsResponsitory.Update(id, oldRequest);
            return View("success");
        }

    }
}