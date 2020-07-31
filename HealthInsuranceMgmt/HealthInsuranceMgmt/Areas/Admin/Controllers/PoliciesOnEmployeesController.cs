﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/policiesonemployees")]
    public class PoliciesOnEmployeesController : Controller
    {
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;
        public PoliciesOnEmployeesController(IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory)
        {
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
        }
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("listData")]
        public IActionResult ShowData()
        {
            var policiesList = ipoliciesOnEmployeesResponsitory.GetAll().OrderBy(p => p.Status).ThenBy(p => p.Emp.FirstName).ToList();

            var html = "";
            var count = 0;
            foreach (var policy in policiesList)
            {
                var color = "green";
                if (policy.StatusId == 1)
                {
                    color = "orange";
                }
                else if (policy.StatusId == 4 || policy.StatusId == 3)
                {
                    color = "red";
                }
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + policy.Emp.FirstName + "</td>" +
                    "<td>" + policy.Emp.LastName + "</td>" +
                    "<td>" + policy.Policy.PolicyName + "</td>" +
                    "<td>" + policy.Policy.Medical.MedicalName + "</td>" +
                    "<td>" + policy.Policy.Medical.Hospital.HospitalName + "</td>" +
                    "<td>" + policy.Policy.Medical.Company.CompanyName + "</td>" +
                    "<td style='color:" + color + "; font-weight:bold'>" + policy.Status.Status1 + "</td>" +
                    "<td><a href='#' onclick='getDetail("+ policy.Id.ToString() + ")' style='font-weight:bold;'>View Detail</a> | ";
                if(policy.StatusId == 1)
                {
                    html += "<a href='#' onclick='acceptedBtn(" + policy.Id.ToString() + ")' style='font-weight:bold;color:green'>Accepted</a>" +
                    " | <a href='#' style='color:red;font-weight:bold' id='blockBtn' onclick='deniedBtn(" + policy.Id.ToString() + ")'>Block</a>" +
                    "</td></tr>";
                }else if (policy.StatusId == 2)
                {
                    html +="<a href='#' style='color:red;font-weight:bold' id='blockBtn' onclick='deniedBtn(" + policy.Id.ToString() + ")'>Block</a>" +
                  "</td></tr>";
                }
                else
                {
                    html += "<a href='#' onclick='acceptedBtn(" + policy.Id.ToString() + ")' style='font-weight:bold;color:green'>Accepted</a></td></tr>";
                }
                if (count < policiesList.Count())
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

        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {
            ViewBag.policy = await ipoliciesOnEmployeesResponsitory.GetByIdHavingTracking(id);
            return View("detail");
        }

        [Route("accept")]
        public async Task<IActionResult> Accept(int id)
        {
            var oldPolicy = await ipoliciesOnEmployeesResponsitory.GetById(id);
            oldPolicy.StatusId = 2;
            await ipoliciesOnEmployeesResponsitory.Update(id, oldPolicy);
            return Json(new[] { new
                {
                    data = true
                }});
        }

        [Route("deny")]
        public async Task<IActionResult> Deny(int id)
        {
            var oldPolicy = await ipoliciesOnEmployeesResponsitory.GetById(id);
            oldPolicy.StatusId = 4;
            await ipoliciesOnEmployeesResponsitory.Update(id, oldPolicy);
            return Json(new[] { new
                {
                    data = true
                }});
        }
    }
}