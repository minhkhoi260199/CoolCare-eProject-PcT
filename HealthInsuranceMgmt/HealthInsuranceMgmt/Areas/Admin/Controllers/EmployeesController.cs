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
    [Route("admin/employees")]
    public class EmployeesController : Controller
    {
        private IEmployeesResponsitory iemployeesResponsitory;
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;
        public EmployeesController(IEmployeesResponsitory _iemployeesResponsitory, IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory)
        {
            iemployeesResponsitory = _iemployeesResponsitory;
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
        }
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("listData")]
        public IActionResult ShowData()
        {
            var employees = iemployeesResponsitory.GetAll().OrderByDescending(p => p.Status).ThenBy(p => p.FirstName).ToList();

            var html = "";
            var count = 0;
            foreach (var employee in employees)
            {
                var color = "green";
                if(employee.Status == 3)
                {
                    color = "orange";
                }else if(employee.Status == 1)
                {
                    color = "red";
                }
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' "+colorBackground+">"+
                    "<td>" + count + "</td>" +
                    "<td>" + employee.FirstName.ToString() + "</td>" +
                    "<td>" + employee.LastName.ToString() + "</td>" +
                    "<td>" + employee.Address + "</td>" +
                    "<td>" + employee.Phone + "</td>" +
                    "<td>" + employee.State + "</td>" +
                    "<td>" + employee.City + "</td>" +
                    "<td>" + employee.Country + "</td>" +
                    "<td style='color:"+color+"; font-weight:bold'>" + employee.StatusNavigation.StatusName+ "</td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail("+employee.Id.ToString()+")' style='font-weight:bold'>More Details</a>" +
                    " | <a href='#' style='color:red;font-weight:bold' id='blockBtn' onclick='blockBtn("+employee.Id.ToString()+")'>Block</a>" +
                    "</td></tr>";
                if(count < employees.Count())
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
            var employee = await iemployeesResponsitory.GetById(id);
            var policies = ipoliciesOnEmployeesResponsitory.GetAll().Where(p => p.EmpId.Equals(id)).ToList();
            ViewBag.policies = policies;
            return View("detail", employee);
        }
        
        [Route("edit")]
        public async Task<IActionResult> Edit(Employees employee)
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
                return RedirectToAction("index", "employees");
            }
            //return RedirectToAction("showdetail", "employees", new { id = employee.Id });
            var policies = ipoliciesOnEmployeesResponsitory.GetAll().Where(p => p.EmpId.Equals(employee.Id)).ToList();
            ViewBag.policies = policies;
            return View("detail", employee);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(Employees employee)
        {
            employee.Status = 1;
            if (employee.Password != "" && employee.Password != null)
            {
                employee.Status = 2;
            }
            else
            {
                employee.Status = 3;
            }
            try
            {
                var checkSal = decimal.Parse(employee.Salary.ToString());
            }catch (Exception e)
            {
                ModelState.AddModelError("salary", "Please enter a number.");
            }
            employee.JoinDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                await iemployeesResponsitory.Create(employee);
                return RedirectToAction("index", "employees");
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
           
            return View("create");
        }

        [Route("block")]
        public async Task<IActionResult> Block(int id)
        {
            var employee = await iemployeesResponsitory.GetById(id);
            employee.Status = 1;
            await iemployeesResponsitory.Update(id, employee);
            return Json(new[] { new
                {
                    data = true
                }});
        }
    }
}