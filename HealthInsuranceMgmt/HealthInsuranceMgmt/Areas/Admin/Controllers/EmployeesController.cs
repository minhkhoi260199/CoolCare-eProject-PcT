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
        //function load index page
        [Authorize(Roles = "Admin")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        //function load data into index page from ajax
        [Authorize(Roles = "Admin")]
        [Route("listData")]
        public IActionResult ShowData(int fromNum, int limitNum, string searchData)
        {
            if(fromNum < 0)
            {
                fromNum = 0;
            }
            if(limitNum != 5)
            {
                limitNum = 5;
            }
            var employeesGetAllData = new List<Employees>();
            var employees = new List<Employees>();
            if (searchData != "" && searchData != null)
            {
                employeesGetAllData = iemployeesResponsitory.GetAllWithoutTracking().Where(p => p.FirstName.Contains(searchData)).ToList();
                employees = iemployeesResponsitory.GetAll().Where(p => p.FirstName.Contains(searchData)).OrderByDescending(p => p.Status).ThenBy(p => p.FirstName).Skip(fromNum).Take(limitNum).ToList();
            }
            else
            {
                employeesGetAllData = iemployeesResponsitory.GetAllWithoutTracking().ToList();
                employees = iemployeesResponsitory.GetAll().OrderByDescending(p => p.Status).ThenBy(p => p.FirstName).Skip(fromNum).Take(limitNum).ToList();  
            }
            var html = "";
            var count = 0;
            //the loop to create the table row
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
            //calculate the total pages
            var totalPage = 0;
            if (employeesGetAllData.Count() % 5 == 0)
            {
                totalPage = employeesGetAllData.Count() / 5;
            }
            else
            {
                totalPage = (employeesGetAllData.Count() / 5) + 1;
            }     
            if(totalPage == 0)
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

        //function show data detail by id
        [Authorize(Roles = "Admin")]
        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {
            var employee = await iemployeesResponsitory.GetById(id);
            var policies = ipoliciesOnEmployeesResponsitory.GetAll().Where(p => p.EmpId.Equals(id)).ToList();
            ViewBag.policies = policies;
            return View("detail", employee);
        }

        //function updating data
        [Authorize(Roles = "Admin")]
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

        //function load create page
        [Authorize(Roles = "Admin")]
        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

        //function create new data
        [Authorize(Roles = "Admin")]
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

        //function edit data ( block employee )
        [Authorize(Roles = "Admin")]
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