using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddController.Modal;

namespace AddControllermpty.controller
{
    public class HomeController : Controller
    {
        //public string Index() {
        //    return "action controller";
        //}

        //dependency injection
        public IEmployRepository _employRepository;
        public HomeController(IEmployRepository employRepository) {
            _employRepository = employRepository;
        }

        public string Index() {
            return _employRepository.GetEmployee(2).name;
        }









        //public IActionResult Index() { //view 

        //     return View();
        // }
        public IActionResult employee() { //view 

            return View();
        }
    }
}
//}

//    public class HomeController : Controller //add mvc core use only for core methods
//    {
//        public JsonResult Index() {
//            return Json(new { foo = "shreyas" });
//        }
//    }
//}