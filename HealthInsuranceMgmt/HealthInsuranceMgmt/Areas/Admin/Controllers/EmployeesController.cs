using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/employees")]
    public class EmployeesController : Controller
    {
        private IEmployeesResponsitory iemployeesResponsitory;
        public EmployeesController(IEmployeesResponsitory _iemployeesResponsitory)
        {
            iemployeesResponsitory = _iemployeesResponsitory;
        }
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("listData")]
        public IActionResult ShowData()
        {
            var employees = iemployeesResponsitory.GetAll().OrderByDescending(p => p.Status).ThenBy(p => p.FirstName).ToList();

            var html = "";
            var count = 0;
            foreach (var employee in employees)
            {
                var color = "";
                if(employee.Status == 2)
                {
                    color = "red";
                }
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' "+colorBackground+">"+
                    "<td>" + count + "</td>" +
                    "<td>" + employee.FirstName.ToString() + "</td>" +
                    "<td>" + employee.LastName.ToString() + "</td>" +
                    "<td>" + employee.Address.ToString() + "</td>" +
                    "<td>" + employee.Phone + "</td>" +
                    "<td>" + employee.State + "</td>" +
                    "<td>" + employee.City + "</td>" +
                    "<td>" + employee.Country + "</td>" +
                    "<td style='color:"+color+"; font-weight:bold'>" + employee.StatusNavigation.StatusName+ "</td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail("+employee.Id.ToString()+")' style='font-weight:bold'>More Details</a>" +
                    "</td></tr>";
                if(count < employees.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }
            return Json(new[] { new
                {
                    status = true,
                    data = html
                }});
        }
    }
}