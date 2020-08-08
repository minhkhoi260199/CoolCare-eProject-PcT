using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {    
        private IEmployeesResponsitory iemployeesResponsitory;
        private DatabaseContext db;

        public HomeController(DatabaseContext _db, IEmployeesResponsitory _iemployeesResponsitory)
        {
            db = _db;
            iemployeesResponsitory = _iemployeesResponsitory;
        }
        [Route("")]
        [Route("~/")]
        [Route("index")]
        public IActionResult Index()
        {
            // HttpContext.Session.SetString("userId", "1");
            // HttpContext.Session.SetString("userName", "Tester");
            return View();
        }
        
        [Route("aboutus")]
        public IActionResult AboutUs()
        {
            return View("Aboutus");
        }

        [Route("contactus")]
        public IActionResult ContactUs()
        {
            return View("ContactUs");
        }
        
        [HttpGet]
        [Route("register")]
        public IActionResult Create()
        {
            var employees = new Employees();
            return View("Register");
        }        
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Create(Employees employee)
        {
            employee.JoinDate = DateTime.Now;
            employee.Status = 3;
            employee.Country = "VietNam";
            if (ModelState.IsValid)
            {            
                await iemployeesResponsitory.Create(employee);
                return View("success");
            }
            foreach(var e in ModelState.Keys)
            {
                var modelState = ModelState[e];
                foreach(var i in modelState.Errors)
                {
                    var key = e;
                    var error = i.ErrorMessage;
                    Debug.WriteLine(key);
                    Debug.WriteLine(error);
                }
            }
            return View("Register");
        }
    }
}