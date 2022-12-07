using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3LoseCouplingP

{
    public class Shopping1
    {

        public float price = 20;
        public int quantity = 2;

        public float GetItemTotal() {
            return price * quantity;
        }
    }
    public class ShoppingCart1
    {
        public Shopping1[] items;
        public float GetCartItemsTotal() {
            float CartTotal = 0;
            foreach (Shopping1 item in items) {
                CartTotal += item.GetItemTotal();
            }
            return CartTotal;
        }
    }

    public class Order1
    {
        private ShoppingCart1 cart1;
        private float salesTax1;
        public Order1(ShoppingCart1 cart1, float salesTax1) {
            this.cart1 = cart1;
            this.salesTax1 = salesTax1;
        }
        public float OrderTotal1() {
            return cart1.GetCartItemsTotal() * salesTax1;
        }
    }
}