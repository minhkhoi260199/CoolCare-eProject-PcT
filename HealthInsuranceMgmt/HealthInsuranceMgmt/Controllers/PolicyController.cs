using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using HealthInsuranceMgmt.Models.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("policy")]
    public class PolicyController : Controller
    {
        private IPoliciesResponsitory iPoliciesResponsitory;
        public PolicyController(IPoliciesResponsitory _iPoliciesResponsitory)
        {
            iPoliciesResponsitory = _iPoliciesResponsitory;
        }

        //View policies list
        [Route("")]
        [Route("index")]
        public IActionResult List(int id)
        {
            ViewBag.pageTitle = "Insurance packages";
            ViewBag.policies = iPoliciesResponsitory.GetAll().Where(d => d.MedicalId.Equals(id)).ToList();
            return View("Index");
        }
    }
}
