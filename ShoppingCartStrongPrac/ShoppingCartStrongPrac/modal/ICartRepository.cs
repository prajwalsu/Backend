using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartStrongPrac.modal
{
    public interface ICartRepository
    {
        Cart GetCart(int id);

        IEnumerable<Cart> GetAllCart();
    }
}
