using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskCart.Modal
{
    public class MockCartRepository : ICartRepository
    {
        //private List<Cart> _cart = new List<Cart>();

        //private string[] TypeOfIems = new string[5];


        //public MockCartRepository() {
           // _cart.Add(new Cart() {id =1, CartName = "Amazon", ShoppingType= "E-com", CartType = "COD",NoOfItems= 1,TypeOfItems ="casual"  });
            //_cart.Add(new Cart() { id = 2, CartName = "Neupass", ShoppingType = "E'-com", CartType = "COD", NoOfItems = 1, TypeOfItems = "Casual" });
        //}
        //Cart ICartRepository.GetCart(int id) {   
            //return _cart.FirstOrDefault(e => e.id == id);
        //}

            public string[] TypeOfItems { get; set; }

        _properties.Add(new CartProperty() { id = 1, CartName = "FlipCart", ShoppingType = "Offline", CartType = "plus", NoOfItems = 2, TypeOfItems = new string[] { "Shoe", "Shirt", "jacket", "Mobile" } })

        <ul>  
        @{
            if (ViewBag.CartProperty.TypeOfItems != null) {
                foreach (var pdt in ViewBag.CartProperty.TypeOfItems) {
                    <li>@pdt</li>
    }
}
        }        
 </ ul >



    }
}
