using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
            var userCheck = iEmployeesResponsitory.Login(userName);
            if(userCheck != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, userCheck.Password))
                {
                    HttpContext.Session.SetString("userId", userCheck.Id.ToString());
                    HttpContext.Session.SetString("userName", userCheck.FirstName + " " + userCheck.LastName);

                    return RedirectToAction("index", "employee");
                }
            }
            return View("fail");
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userId");
            HttpContext.Session.Remove("userName");

            return RedirectToAction("index","home");
        }
    }
}