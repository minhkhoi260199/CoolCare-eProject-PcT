using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Http;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;
        private IPoliciesResponsitory ipoliciesResponsitory;
        
        public EmployeeController(IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory)
        {
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Title = "Wellcome" + HttpContext.Session.GetString("userId");
            var id = int.Parse(HttpContext.Session.GetString("userId"));
            ViewBag.emppolicies = ipoliciesOnEmployeesResponsitory.GetAll().Where(p => p.EmpId.Equals(id)).OrderBy(p => p.StatusId).ToList();
            return View();
        }
    }
}