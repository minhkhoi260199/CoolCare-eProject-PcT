using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/hospitals")]
    public class HospitalsController : Controller
    {
        private IHospitalsResponsitory ihospitalsResponsitory;

        public HospitalsController(IHospitalsResponsitory _ihospitalsResponsitory)
        {
            ihospitalsResponsitory = _ihospitalsResponsitory;
        }
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("listData")]
        public IActionResult ShowData()
        {
            var hospitals = ihospitalsResponsitory.GetAll().OrderBy(p => p.HospitalName).ToList();

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
                    "</td></tr>";
                if (count < hospitals.Count())
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
            var hospital = await ihospitalsResponsitory.GetById(id);
            return View("detail", hospital);
        }

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

        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

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
            Debug.WriteLine("LOI");
            return View("create");
        }

    }
}