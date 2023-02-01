using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelValidations_Core.Models;

namespace ModelValidations_Core.Controllers
{
    public class JobApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobApplication ja)        
        {
            if (string.IsNullOrEmpty(ja.Name))
                ModelState.AddModelError(nameof(ja.Name), "Please Enter Your name");
            else if (ja.Name == "Banurekha")
                ModelState.AddModelError("", "You cannot apply for this Job");
            if (ja.DOB == Convert.ToDateTime("01-01-0001 00:00:00"))
                ModelState.AddModelError(nameof(ja.DOB), "Please Enter your Date of Birth");
            else if (ja.DOB > DateTime.Now)
                ModelState.AddModelError(nameof(ja.DOB), "Date of Birth cannot be a future date");
            else if (ja.DOB < new DateTime(1990, 1, 1))
                ModelState.AddModelError(nameof(ja.DOB), "Date of Birth should not be greater than 1990");
            if (string.IsNullOrEmpty(ja.Gender))
                ModelState.AddModelError(nameof(ja.Gender), "Please Select your Gender");
            if (ja.Experience.ToString() == "Select")
                ModelState.AddModelError(nameof(ja.Experience), "Please select your Job experience");
            if (!ja.TermsAccept)
                ModelState.AddModelError(nameof(ja.TermsAccept), "You must accept the terms");
            if (ModelState.IsValid)
                return View("Accepted", ja);
            else
                return View();        
        }
    }
}
