using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEmpty.Modal;
using WebApplicationEmpty.ViewModels;

namespace WebApplicationEmpty.controller
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




        //public string Index() {
        //    return _employRepository.GetEmployee(1).name;
        //}




        //retrieve data in json format
        //public JsonResult Details() {
        //    Employee modal = _employRepository.GetEmployee(1);
        //    return Json(modal);
        //}




        //public ViewResult Details() {
        //    Employee modal = _employRepository.GetEmployee(1);
        //    ViewData["Employee"] = modal;
        //    ViewData["Title"] = "details of employee";
        //    return View();
        //    //return View(modal);
        //}





        //public ViewResult Details() {
        //    Employee modal = _employRepository.GetEmployee(1);
        //    ViewBag.Employee = modal;
        //    ViewBag.Title = "details of employee";
        //     return View(); //view bag

        //}




        public ViewResult Details() {// fetch details from strongly typed view
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                employee = _employRepository.GetEmployee(2),
                Title = "Details of Employee"
            };
            return View(homeDetailsViewModel);
        }




        //public ViewResult Details() {
        //    Employee modal = _employRepository.GetEmployee(1);
            
        //    ViewBag.Title = "details of employee";
            
        //    return View(modal);         //view modal, stictly typed language
        //}

        //public IActionResult Index() { //view 
        //    return View("Details"); //if parameter is not passed it takes default value
        //}


        //public IActionResult Index() {
        //    //Relative path:no need of file extensions
        //    return View("../Test/Testing");  // specify path
        //}




        public IActionResult Index() {
            //absulate path: need of file extensions
            return View("MyView/View.cshtml");  // specify path
        }





        public IActionResult employee() { //view 

            return View();
        }
    }
}







//public IActionResult Index() { //view 

//     return View();
// }

//}

//    public class HomeController : Controller //add mvc core use only for core methods
//    {
//        public JsonResult Index() {
//            return Json(new { foo = "shreyas" });
//        }
//    }
//}

//



