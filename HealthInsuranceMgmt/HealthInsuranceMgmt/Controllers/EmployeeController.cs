using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthInsuranceMgmt.Models.Respositories;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Http;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("employee")]
    public class EmployeeController : Controller
    {
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;
        private IEmployeesResponsitory iemployeesResponsitory;
        
        public EmployeeController(IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory,IEmployeesResponsitory _iemployeesResponsitory)
        {
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
            iemployeesResponsitory = _iemployeesResponsitory;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.pageTitle = "Wellcome " + HttpContext.Session.GetString("userName");
            var id = int.Parse(HttpContext.Session.GetString("userId"));
            ViewBag.emppolicies = ipoliciesOnEmployeesResponsitory.GetAll().Where(p => p.EmpId.Equals(id)).OrderBy(p => p.StatusId).ToList();
            return View();
        }

        [Route("profile")]
        public async Task<IActionResult> Profile()
        {
            ViewBag.pageTitle = HttpContext.Session.GetString("userName") + " Profile";
            var id = int.Parse(HttpContext.Session.GetString("userId"));
            var employee = await iemployeesResponsitory.GetById(id);
            return View("profile", employee);
        }

        [HttpPost]
        [Route("submitedit")]
        public async Task<IActionResult> SubmitEditProfile(Employees employee)
        {
            var oldEmployee = await iemployeesResponsitory.GetById(employee.Id);
            employee.Status = oldEmployee.Status;
            if (oldEmployee.JoinDate != null && oldEmployee.JoinDate.ToString() != "")
            {
                employee.JoinDate = oldEmployee.JoinDate;
            }
            else
            {
                employee.JoinDate = DateTime.Now;
            }
            if(employee.Password != "" && employee.Status != 1 && employee.Password != null)
            {
                employee.Status = 2;
            }
            else
            {
                if(oldEmployee.Password != "")
                {
                    employee.Password = oldEmployee.Password;
                }
            }
            try {
                var checkSal = decimal.Parse(employee.Salary.ToString());
            } catch(Exception e) {
                ModelState.AddModelError("salary", "Please enter a number.");
            }
            if (ModelState.IsValid)
            {
                await iemployeesResponsitory.Update(employee.Id, employee);
                return View("success");
            }
            return RedirectToAction("profile","employee");
        }
        
    }
}