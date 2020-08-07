using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/hospitals")]
    public class HospitalsController : Controller
    {
        private IHospitalsResponsitory ihospitalsResponsitory;
        private IMedicalsResponsitory imedicalsResponsitory;

        public HospitalsController(IHospitalsResponsitory _ihospitalsResponsitory, IMedicalsResponsitory _imedicalsResponsitory)
        {
            ihospitalsResponsitory = _ihospitalsResponsitory;
            imedicalsResponsitory = _imedicalsResponsitory;
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
            var hospitals = new List<Hospitals>();
            var hospitalsGetAllData = new List<Hospitals>();
            
            if (searchData != "" && searchData != null)
            {
                hospitalsGetAllData = ihospitalsResponsitory.GetAllWithoutTracking().Where(p => p.HospitalName.Contains(searchData)).ToList();
                hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).Where(p => p.HospitalName.Contains(searchData)).Skip(fromNum).Take(limitNum).ToList();
            }
            else
            {
                hospitalsGetAllData = ihospitalsResponsitory.GetAllWithoutTracking().ToList();  
                hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).Skip(fromNum).Take(limitNum).ToList();
            }
            var html = "";
            var count = 0;
            foreach (var hopspital in hospitals)
            {
                count++;
                var colorBackground = "";
                if (count % 2 == 0)
                {
                    colorBackground = "style='background-color:#7bedd1'";
                }
                html += "<tr class='tr-shadow' " + colorBackground + ">" +
                    "<td>" + count + "</td>" +
                    "<td>" + hopspital.HospitalName + "</td>" +
                    "<td>" + hopspital.Location + "</td>" +
                    "<td>" + hopspital.Phone + "</td>" +
                    "<td><a href='" + hopspital.HospitalUrl + "'>" + hopspital.HospitalUrl + "</a></td>" +
                    "<td>" +
                    "<a href='#' onclick='getDetail(" + hopspital.Id.ToString() + ")' style='font-weight:bold'>More Details</a>" +
                    " | <a href='#' onclick='deleteFunction("+ hopspital.Id.ToString() + ")' style='font-weight:bold; color:red'>Delete</a>" + 
                    "</td></tr>";
                if (count < hospitals.Count())
                {
                    html += "</tr><tr class='spacer'></tr>";
                }
            }

            var totalPage = 0;
            if (hospitalsGetAllData.Count() % 5 == 0)
            {
                totalPage = hospitalsGetAllData.Count() / 5;
            }
            else
            {
                totalPage = (hospitalsGetAllData.Count() / 5) + 1;
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
        [Route("detail")]
        public async Task<IActionResult> ShowDetail(int id)
        {
            var hospital = await ihospitalsResponsitory.GetById(id);
            return View("detail", hospital);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("edit")]
        public async Task<IActionResult> Edit(Hospitals hospital)
        {
            var oldHospital = await ihospitalsResponsitory.GetById(hospital.Id);
            if (ModelState.IsValid)
            {
                await ihospitalsResponsitory.Update(hospital.Id, hospital);
                return RedirectToAction("index", "hospitals");
            }
            return View("detail", hospital);
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

        [Authorize(Roles = "Admin, Manager, Financial Manager")]
        [Route("postcreate")]
        public async Task<IActionResult> PostCreate(Hospitals hospital)
        {
            if (ModelState.IsValid)
            {
                await ihospitalsResponsitory.Create(hospital);
                return RedirectToAction("index", "hospitals");
            }
            foreach (var modelStateKey in ModelState.Keys)
            {
                var modelStateVal = ModelState[modelStateKey];
                foreach (var error in modelStateVal.Errors)
                {
                    var key = modelStateKey;
                    var errorMessage = error.ErrorMessage;
                    Debug.WriteLine(key);
                    Debug.WriteLine(errorMessage);
                }
            }
            return View("create");
        }

        [Authorize(Roles = "Admin, Manager")]
        [Route("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var checkMedical = imedicalsResponsitory.GetAllWithoutTracking().Where(p => p.HospitalId.Equals(id)).Count();
                if(checkMedical > 0)
                {
                    return Json(new[] { new
                    {
                        status = false,
                        error = "This hospital has some medical data on it, so please delete the medical before deleting the hospital",
                    }});
                }

                await ihospitalsResponsitory.Delete(id);
                return Json(new[] { new
                {
                    status = true,
                }});
            }
            catch(Exception e)
            {
                return Json(new[] { new
                {
                    status = false,
                    error = "Something went wrong, please contact the admin",
                }});
            }
           
        }

    }
}