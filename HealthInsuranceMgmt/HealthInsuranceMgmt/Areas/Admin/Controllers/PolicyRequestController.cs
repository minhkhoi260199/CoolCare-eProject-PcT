using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/policyrequest")]
    public class PolicyRequestController : Controller
    {

        private IPolicyRequestDetailsResponsitory ipolicyRequestDetailsResponsitory;
        private IPoliciesOnEmployeesResponsitory ipoliciesOnEmployeesResponsitory;
        public PolicyRequestController(IPolicyRequestDetailsResponsitory _ipolicyRequestDetailsResponsitory, IPoliciesOnEmployeesResponsitory _ipoliciesOnEmployeesResponsitory)
        {
            ipolicyRequestDetailsResponsitory = _ipolicyRequestDetailsResponsitory;
            ipoliciesOnEmployeesResponsitory = _ipoliciesOnEmployeesResponsitory;
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("listData")]
        public IActionResult ShowData(int fromNum, int limitNum, string searchData)
        {
            var requestList = new List<PolicyRequestDetails>();
            var requestListGetAllData = new List<PolicyRequestDetails>();

            if (searchData != "" && searchData != null)
            {
                requestListGetAllData = ipolicyRequestDetailsResponsitory.GetAllWithoutTracking().Where(p => p.Emp.FirstName.Contains(searchData)).ToList();
                requestList = ipolicyRequestDetailsResponsitory.GetAll().Where(p => p.Emp.FirstName.Contains(searchData)).OrderBy(p => p.Status).ThenByDescending(p => p.RequestDate).ThenBy(p => p.Emp.FirstName).Skip(fromNum).Take(limitNum).ToList();
            }
            else
            {
                requestListGetAllData = ipolicyRequestDetailsResponsitory.GetAllWithoutTracking().ToList();
                requestList = ipolicyRequestDetailsResponsitory.GetAll().OrderBy(p => p.Status).ThenByDescending(p => p.RequestDate).ThenBy(p => p.Emp.FirstName).Skip(fromNum).Take(limitNum).ToList();
            }

            var html = "";
            var count = 0;
            foreach (var request in requestList)
            {
                var policyCheck = ipoliciesOnEmployeesResponsitory.SearchByEmpIdAndPoliId(request.EmpId, request.PolicyId);

                if(policyCheck.StatusId != 2)
                {
                    continue;
                }
                var color = "green";
                if (request.Status == 1)
                {
                    color = "orange";
                }
                else if (request.Status == 4 || request.Status == 3)
                {
                    color = "red";
                }
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }

                var approveDate = "";
                if(request.ApprovedDate != null)
                {
                    approveDate = request.ApprovedDate?.ToString("dd/MM/yyyy");
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + request.RequestDate.ToString("dd/MM/yyyy") + "</td>" +
                    "<td>" + request.Emp.FirstName + "</td>" +
                    "<td>" + request.Emp.LastName + "</td>" +
                    "<td>" + request.Policy.PolicyName + "</td>" +
                    "<td>" + request.Reason + "</td>" +
                    "<td>" + approveDate + "</td>" +
                    "<td style='color:" + color + "; font-weight:bold'>" + request.StatusNavigation.Status1 + "</td>" +
                    "<td><a href='#' onclick='getDetail(" + request.Id.ToString() + ")' style='font-weight:bold;'>View Detail</a> | ";
                if (request.Status == 1)
                {
                    html += "<a href='#' onclick='acceptedBtn(" + request.Id.ToString() + ")' style='font-weight:bold;color:green'>Accepted</a>" +
                    " | <a href='#' style='color:red;font-weight:bold' id='blockBtn' onclick='deniedBtn(" + request.Id.ToString() + ")'>Block</a>" +
                    "</td></tr>";
                }
                else if (request.Status == 2)
                {
                    html += "<a href='#' style='color:red;font-weight:bold' id='blockBtn' onclick='deniedBtn(" + request.Id.ToString() + ")'>Block</a>" +
                  "</td></tr>";
                }
                else
                {
                    html += "<a href='#' onclick='acceptedBtn(" + request.Id.ToString() + ")' style='font-weight:bold;color:green'>Accepted</a></td></tr>";
                }
                if (count < requestList.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }

            var totalPage = 0;
            if (requestListGetAllData.Count() % 5 == 0)
            {
                totalPage = requestListGetAllData.Count() / 5;
            }
            else
            {
                totalPage = (requestListGetAllData.Count() / 5) + 1;
            }
            if (totalPage == 0)
            {
                totalPage = 1;
            }

            return Json(new[] { new
                {
                    status = true,
                    data = html,
                    pageTotal = totalPage
                }});
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("accept")]
        public async Task<IActionResult> Accept(int id)
        {
            var oldReq = await ipolicyRequestDetailsResponsitory.GetById(id);
            if (oldReq.Status != 2)
            {
                oldReq.ApprovedDate = DateTime.Now;
            }
            oldReq.Status = 2;
            await ipolicyRequestDetailsResponsitory.Update(id, oldReq);
            return Json(new[] { new
                {
                    data = true
                }});
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("deny")]
        public async Task<IActionResult> Deny(int id)
        {
            var oldReq = await ipolicyRequestDetailsResponsitory.GetById(id);
            oldReq.Status = 4;
            oldReq.ApprovedDate = null;
            await ipolicyRequestDetailsResponsitory.Update(id, oldReq);
            return Json(new[] { new
                {
                    data = true
                }});
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {      
            var request = await ipolicyRequestDetailsResponsitory.GetByIdHavingTracking(id);
            ViewBag.request = request;
            ViewBag.policy = ipoliciesOnEmployeesResponsitory.SearchByEmpIdAndPoliId(request.EmpId, request.PolicyId);
            return View("detail");
        }
    }
}