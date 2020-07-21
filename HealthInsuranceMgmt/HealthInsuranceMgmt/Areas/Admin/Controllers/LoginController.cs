using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/login")]
    public class LoginController : Controller
    {
        private IAdminLoginResponsitory iadminLoginResponsitory;
        public LoginController(IAdminLoginResponsitory _iadminLoginResponsitory)
        {
            iadminLoginResponsitory = _iadminLoginResponsitory;
        }
        [Route("")]
        [Route("~/")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("postLogin")]
        [HttpPost]
        public IActionResult PostLogin(string userName, string password)
        {
            var userCheck = iadminLoginResponsitory.CheckLogin(userName, password);
            Debug.WriteLine(userName);
            if(userCheck != null)
            {
                return new JsonResult(true);
            }
            return new JsonResult(false);
        }
    }
}