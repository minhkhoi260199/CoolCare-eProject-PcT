using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Http;

namespace HealthInsuranceMgmt.Areas.Admin.Security
{
    public class SercurityManage
    {
        private IEnumerable<Claim> getClaimOfAccount(AdminLogin adminLogin)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, adminLogin.FirstName));
            claims.Add(new Claim(ClaimTypes.Role, adminLogin.UserTypeNavigation.Name));
            return claims;
        }

        public async void SignIn(HttpContext httpContext, AdminLogin adminLogin)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getClaimOfAccount(adminLogin), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }
    }
}