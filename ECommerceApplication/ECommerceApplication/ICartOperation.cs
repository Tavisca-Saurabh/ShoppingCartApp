using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    interface ICartOperation
    {
        void Add(List<Product> AllProductsObject, int id, List<Product> CartData, int Quantity);
        void DisplayCart(List<Product> CartData);
        void ClearCart(List<Product> CartData);
        void RemoveParticularProductFromCart(List<Product> CartData, int id);
        void TotalAmountOfCart(List<Product> CartData);
    }
}
