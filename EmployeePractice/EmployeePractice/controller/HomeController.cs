using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePractice.Modal;

namespace EmployeePractice.controller
{
    public class HomeController : Controller
    {
        public IEmployeRepository _employRepository;

        public HomeController(IEmployeRepository employRepository) {

        }

        public IActionResult Index() {
            return View();
        }
    }
}
