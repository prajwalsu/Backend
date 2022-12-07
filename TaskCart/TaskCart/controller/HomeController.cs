using TaskCart.Modal;
using Microsoft.AspNetCore.Mvc;

namespace TaskCart.controller
{
    //add mvc but where as in add mvc core u can use only core methods 
    public class HomeController : Controller
    {
        //action metrhod which returns a string
        //constructor dependency injuction
        public ICartRepository _cartRepository;
        public HomeController(ICartRepository cartRepository) {
            _cartRepository = cartRepository;
        }
        //public string Index() {
        //    return _employeeRepository.GetEmployee(1).email;
        //}
        //viewData
        public ViewResult Details() {
            Cart modal = _cartRepository.GetCart(2);
            ViewData["Cart"] = modal;
            ViewData["Title"] = "Details of Cart";
            return View(); // action method name as parameter
        }

        //passing the view(html page name) directly  witnout mentioning the extention
        //Relative Path (no need of file extentions)
        //absulate path (where the file is in the different folder) we need to mention the file extention
        public IActionResult Index() {
            return View("MyViews/Test.cshtml");
        }
        public IActionResult cart() {
            return View();
        }
    }
}
