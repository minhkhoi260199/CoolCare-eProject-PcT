using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using HealthInsuranceMgmt.Models.Respositories;


namespace HealthInsuranceMgmt.Controllers
{
    [Route("policiesOnEmployees")]
    public class PoliciesOnEmployeesController : Controller
    {
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;
        private IPoliciesResponsitory ipoliciesResponsitory;
        private IEmployeesResponsitory iemployeeResponsitory;

        public PoliciesOnEmployeesController(IEmployeesResponsitory _iEmployeesResponsitory, IPoliciesResponsitory _ipoliciesResponsitory, IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory)
        {
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
            ipoliciesResponsitory = _ipoliciesResponsitory;
            iemployeeResponsitory = _iEmployeesResponsitory;
        }

        //Requisition Form
        [Route("")]
        [Route("index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.pageTitle = "Requisition Form";
            ViewBag.policie = await ipoliciesResponsitory.GetByIdHavingTracking(id);
            var empId = int.Parse(HttpContext.Session.GetString("userId"));
            ViewBag.employee = await iemployeeResponsitory.GetByIdHavingTracking(empId);
            
            return View("Index");
        }

        // Add register info to DB
        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(PoliciesOnEmployees policiesOnEmployees)
        {
            policiesOnEmployees.StatusId = 1;

            DateTime date = DateTime.Now;
            policiesOnEmployees.EndDate = date.AddYears(1);

            ipoliciesOnEmployeesResponsitory.Create(policiesOnEmployees);

            return View("success");
        }

        [Route("success")]
        public IActionResult Success(PoliciesOnEmployees policiesOnEmployees)
        {
            return RedirectToAction("index", "employee");
        }
    }
}
