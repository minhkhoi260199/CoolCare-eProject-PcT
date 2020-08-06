using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/profile")]
    public class ProfileController : Controller
    {
        private IAdminLoginResponsitory iadminLoginResponsitory;
        public ProfileController(IAdminLoginResponsitory _iadminLoginResponsitory)
        {
            iadminLoginResponsitory = _iadminLoginResponsitory;
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("index")]
        [Route("")]
        public async Task<IActionResult> Index()
        {
            var id = int.Parse(User.FindFirst(ClaimTypes.UserData).Value);
            var user = await iadminLoginResponsitory.GetById(id);
            return View("index", user);
        }

        //function updating data
        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("edit")]
        public async Task<IActionResult> Edit(AdminLogin admin)
        {
            var oldAdmin = await iadminLoginResponsitory.GetById(admin.Id);      
            if ((admin.Password == "" || admin.Password == null) && oldAdmin.Password != "")
            {
                admin.Password = oldAdmin.Password;
            }
            admin.UserType = oldAdmin.UserType;
            if (ModelState.IsValid)
            {
                await iadminLoginResponsitory.Update(admin.Id, admin);
                return RedirectToAction("index", "employees");
            }
            return View("index", admin);
        }
    }
}