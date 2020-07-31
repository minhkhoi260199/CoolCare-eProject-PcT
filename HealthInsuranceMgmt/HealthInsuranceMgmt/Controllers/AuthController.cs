using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthInsuranceMgmt.Models.Respositories;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private IEmployeesResponsitory iEmployeesResponsitory;
        public AuthController(IEmployeesResponsitory _iEmployeesResponsitory)
        {
            iEmployeesResponsitory = _iEmployeesResponsitory;
        }
        [Route("")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View("Login");
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            var userCheck = iEmployeesResponsitory.Login(userName, password);
            if(userCheck != null)
            {
                return RedirectToAction("index","company");
            }
            return View();
        }
    }
}