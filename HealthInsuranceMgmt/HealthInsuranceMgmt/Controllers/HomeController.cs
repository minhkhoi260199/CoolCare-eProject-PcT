using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;

using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {    
        private IEmployeesResponsitory iemployeesResponsitory;
        private DatabaseContext db;

        public HomeController(DatabaseContext _db)
        {
            db = _db;
        }
        [Route("")]
        [Route("~/")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            var employees = new Employees();
            return View("index");
        }        
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create(Employees employee)
        {
            
            if(employee.Address is null && employee.FirstName is null &&employee.LastName is null && employee.Phone is null && employee.State is null && employee.City is null )
            {         
                ModelState.AddModelError("Address", "Please enter your address");  
            }
            else
            {
                employee.JoinDate = DateTime.Now;
                employee.Status = 3;
                employee.Country = "VietNam";
                db.Employees.Add(employee);
                db.SaveChanges();
            }
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
            return View("index");


        }
    }
}