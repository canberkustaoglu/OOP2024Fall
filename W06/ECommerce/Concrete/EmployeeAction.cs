﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.ECommerce.Abstract;

namespace W06.ECommerce.Concrete
{
    public class EmployeeAction : IEmployeeAction
    {
        public void AddNewProduct(string productId, string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(string productId, string name)
        {
            throw new NotImplementedException();
        }

        public void SearchProduct(string keywords)
        {
            throw new NotImplementedException();
        }

        public void ViewProduct(string productId)
        {
            throw new NotImplementedException();
        }

        public void AddToCart(string productId)
        {
            throw new NotImplementedException();
        }

        public void Checkout()
        {
            throw new NotImplementedException();
        }
    }
}