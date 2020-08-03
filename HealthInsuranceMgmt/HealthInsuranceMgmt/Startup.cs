using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthInsuranceMgmt
{
    public class Startup
    {
        private IConfiguration configuration;
        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DatabaseContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionString));
            services.AddScoped<IAdminLoginResponsitory, AdminLoginRespository>();
            services.AddScoped<IEmployeesResponsitory, EmployeesResponsitory>();
            services.AddScoped<IPoliciesOnEmployeesResponsitory, PoliciesOnEmployeesResponsitory>();

            services.AddScoped<ICompanyDetailsResponsitory, CompanyDetailsResponsitory>();
            services.AddScoped<IMedicalsResponsitory, MedicalsResponsitory>();
            services.AddScoped<IPoliciesResponsitory, PoliciesResponsitory>();

            services.AddScoped<IHospitalsResponsitory, HospitalsResponsitory>();
            services.AddScoped<IPolicyRequestDetailsResponsitory, PolicyRequestDetailsResponsitory>();

            services.AddSession();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
                options.LoginPath = "/admin/login";
                options.LogoutPath = "/admin/login/logout";
                options.AccessDeniedPath = "/admin/login/acceccDenied";
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
