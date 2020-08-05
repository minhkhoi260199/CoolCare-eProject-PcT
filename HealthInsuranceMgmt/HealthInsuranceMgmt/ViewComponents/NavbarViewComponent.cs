using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HealthInsuranceMgmt.ViewComponents
{
    [ViewComponent(Name = "Navbar")]
    public class NavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Check session for information
            if(HttpContext.Session.GetString("userId") == null){
                return View("Index");
            } else {
                return View("EmployeeNav");
            }
            
        }
    }
    [ViewComponent(Name = "AdNavbar")]
    public class AdNavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Check session for information
            return View("AdminNav");
        }
    }
}