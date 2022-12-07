using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartStrongPrac.modal
{
    public class CartMockData : ICartRepository
    {
        public List<Cart> _cart = new List<Cart>();

        public CartMockData() {
            _cart.Add(new Cart() {
                id = 1,
                CartName = "Amazon",
                ShoppingType = "online",
                CartType = "premium",
                NoOfItems = 1,
                TypeOfItems = new string[] {"shoes","watch"}
            });

            _cart.Add(new Cart() {
                id = 2,
                CartName = "FlipCart",
                ShoppingType = "offline",
                CartType = "premium",
                NoOfItems = 2,
                TypeOfItems = new string[] { "shirt", "Trousers" }
            });

            _cart.Add(new Cart() {
                id = 3,
                CartName = "Shopclues",
                ShoppingType = "online",
                CartType = "premium",
                NoOfItems = 3,
                TypeOfItems = new string[] { "Belt", "Jackets" }
            });

            public IEnumerable<cart> GetAllCart() {
                return _cart;
            }


            Cart ICartRepository.GetCart(int id) {
                return _cart.FirstOrDefault(e => e.id == id);
            }

        }
    }
}
