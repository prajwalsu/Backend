using EmptyAspProject.Modal;
using EmptyAspProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyAspProject.controller {
    //add mvc but where as in add mvc core u can use only core methods 
    public class HomeController : Controller  {
        //action metrhod which returns a string
        //constructor dependency injuction
        public IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        //public string Index() {
        //    return _employeeRepository.GetEmployee(1).email;
        //}
        //viewData
        //public  ViewResult Details() {
        //  Employee modal = _employeeRepository.GetEmployee(2);
        //ViewData["Employee"] = modal;
        //ViewData["Title"] = "Details of Employee";
        //return View(); // action method name as parameter
        //}
        //the view which bnds a specific type of viewModel

        public ViewResult Details() {
            {
                HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                    Employee = _employeeRepository.GetEmployee(2),
                    Title = "Details of Employee"

                };
                return View(homeDetailsViewModel); }

            //passing the view(html page name) directly  witnout mentioning the extention
            //Relative Path (no need of file extentions)
            //absulate path (where the file is in the different folder) we need to mention the file extention
            public IActionResult Index() {
                return View("MyViews/Test.cshtml");
            }
            public IActionResult employee() {
                return View();
            }

        }
    }
}
