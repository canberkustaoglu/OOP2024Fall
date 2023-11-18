using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.ECommerce.Abstract;

namespace w06.ECommerce.Abstract
{
    public interface ICustomerAction : IECommerceAction //inheritance (between interfaces)
    {
        void AddToCart(string productId);
        void Checkout();//pay
    }
}