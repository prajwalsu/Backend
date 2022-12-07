using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartStrongPrac.modal
{
    public class Cart
    {
        public int id { get; set; }
        public string CartName { get; set; }
        public string ShoppingType { get; set; }
        public string CartType { get; set; }
        public int NoOfItems { get; set; }
        public string[] TypeOfItems { get; set; }
    }
}
