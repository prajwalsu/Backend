using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelValidationAssign2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidationAssign2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger) {
        //    _logger = logger;
        //}

        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobApplication jobApplication) {
            if (string.IsNullOrEmpty(jobApplication.Name))
                ModelState.AddModelError(nameof(jobApplication.Name), "Please enter your name");

            if (jobApplication.DOB == Convert.ToDateTime("01-01-0001 00:00:00"))
                ModelState.AddModelError(nameof(jobApplication.DOB), "Please enter your Date of Birth");
            else if (jobApplication.DOB > DateTime.Now)
                ModelState.AddModelError(nameof(jobApplication.DOB), "Date of Birth cannot be in the future");
            else if (jobApplication.DOB < new DateTime(1980, 1, 1))
                ModelState.AddModelError(nameof(jobApplication.DOB), "Date of Birth should not be before 1980");

            if (string.IsNullOrEmpty(jobApplication.Sex))
                ModelState.AddModelError(nameof(jobApplication.Sex), "Please select your sex");

            if (jobApplication.Experience.ToString() == "Select")
                ModelState.AddModelError(nameof(jobApplication.Experience), "Please select your experience");

            if (!jobApplication.TermsAccepted)
                ModelState.AddModelError(nameof(jobApplication.TermsAccepted), "You must accept the Terms");

            if (ModelState.IsValid)
                return View("Accepted", jobApplication);
            else
                return View();
        }

        //public IActionResult Privacy() {
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error() {
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
