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

        public HomeController(DatabaseContext _db)
        {
            db = _db;
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
            
            if(employee.Address is null )
            {         
                ModelState.AddModelError("Address", "Please enter your address");  
            }
            if (ModelState.IsValid)
            {
                employee.JoinDate = DateTime.Now;
                employee.Status = 3;
                employee.Country = "VietNam";
                await iemployeesResponsitory.Create(employee);
                return View("success");
            }
            return View("Register");
        }
    }
}