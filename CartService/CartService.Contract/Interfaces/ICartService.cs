using System;
using System.Collections.Generic;
using CartService.Contract.Entities;

namespace CartService.Contract.Interfaces
{
    interface ICartService
    {
        void AddProduct(Product product);
        void ChangeQuantity(Product product);
        void Delete(Product product);
        void ProceedToCheckout(decimal TotalPrice);
    }
}
