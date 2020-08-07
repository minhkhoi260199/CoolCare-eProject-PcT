using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Areas.Admin.Security;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/login")]
    public class LoginController : Controller
    {
        private SercurityManage securityManager = new SercurityManage();
        private IAdminLoginResponsitory iadminLoginResponsitory;
        public LoginController(IAdminLoginResponsitory _iadminLoginResponsitory)
        {
            iadminLoginResponsitory = _iadminLoginResponsitory;
        }
        [Route("")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }
        //check login function
        [Route("postLogin")]
        [HttpPost]
        public IActionResult PostLogin(string userName, string password)
        {
            var userCheck = iadminLoginResponsitory.CheckLogin(userName, password);
            if(userCheck != null)
            {
                var id = userCheck.Id;
                HttpContext.Session.SetString("user_id", id.ToString());
                securityManager.SignIn(HttpContext, userCheck);
                return new JsonResult(true);
            }
            return new JsonResult(false);
        }
        [Route("logout")]
        public IActionResult LogOut()
        {
            securityManager.SignOut(HttpContext);
            return RedirectToAction("index", "login");
        }

        [Route("acceccDenied")]
        public IActionResult AccessDenied()
        {
            return View("accessDenied");
        }
    }
}