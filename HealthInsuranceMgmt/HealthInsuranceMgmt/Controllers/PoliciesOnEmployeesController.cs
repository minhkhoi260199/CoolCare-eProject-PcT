using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthInsuranceMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceMgmt.Controllers
{
    [Route("policiesOnEmployees")]
    public class PoliciesOnEmployeesController : Controller
    {
        private DatabaseContext db;
        public PoliciesOnEmployeesController(DatabaseContext _db)
        {
            db = _db;
        }

        //Requisition Form
        [Route("")]
        [Route("index/{id}")]
        public IActionResult Index(int id)
        {
            ViewBag.pageTitle = "Requisition Form";
            ViewBag.requests = db.Policies.Where(p => p.Id == id).ToList();
            ViewBag.employees = db.Employees.Where(p => p.Id == 1).ToList();
            return View("Index");
        }

        // Add register info to DB
        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(string companyInsurance)
        {
           // db.PoliciesOnEmployees.Add(companyInsurance);

            db.SaveChanges();
            return RedirectToAction("home/index");
        }
    }
}
