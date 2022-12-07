using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartStrongPrac.modal;

namespace ShoppingCartStrongPrac.ViewModels
{
    public class HomeDetailsViewModel
    {
        public string Title { get; set; }

        public Cart cart { get; set; }
    }
}
