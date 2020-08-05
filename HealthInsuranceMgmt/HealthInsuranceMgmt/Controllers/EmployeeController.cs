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
        public IActionResult Index()
        {
            var id = Int16.Parse(HttpContext.Session.GetString("userId"));
            ViewBag.emppolicies = ipoliciesOnEmployeesResponsitory.GetAll().Where(d => d.EmpId == id).OrderBy(p => p.StatusId).ToList();
            return View();
        }
    }
}