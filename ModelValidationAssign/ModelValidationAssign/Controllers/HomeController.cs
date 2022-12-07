using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelValidationAssign.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidationAssign.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student) {
            if (ModelState.IsValid) {

            }
            return View();
        }

    }
}