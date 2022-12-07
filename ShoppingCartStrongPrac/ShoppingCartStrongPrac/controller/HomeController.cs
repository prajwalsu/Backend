using Microsoft.AspNetCore.Mvc;
using ShoppingCartStrongPrac.modal;
using ShoppingCartStrongPrac.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartStrongPrac.controller
{
    public class HomeController : Controller
    {
        public ICartRepository _cartRepository;

        public HomeController(ICartRepository cartRepository) {
            _cartRepository = cartRepository;
        }

        public ViewResult Details() {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                cart = _cartRepository.GetCart(2),
                Title = "Details of ShopCart"
            };
            return View(homeDetailsViewModel);
        }


        public IActionResult Index() {
            var modal = _cartRepository.GetAllCart();
            return View();
        }
    }
}
