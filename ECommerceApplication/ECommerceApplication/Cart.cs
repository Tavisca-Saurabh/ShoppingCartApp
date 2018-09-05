using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    class Cart: ICartOperation
    {
        public void Add(List<Product> AllProductsObject, int id , List<Product> CartData, int currentQuantity) //Product Added to Cart
        {
            if (AllProductsObject[id].Quantity >= currentQuantity)
            {
                CartData.Add(AllProductsObject[id]);
                Console.WriteLine("Product Added Successfully");
            }
            else
            {
                Console.WriteLine("Quantity is Larger than available");
            }
        }
        public void DisplayCart(List<Product> CartData)
        {
            if (CartData.Count > 0)
            {
                CartData.ForEach(item => Console.WriteLine("ID: " + item.ProductId + " Name: " + item.ProductName + " Price: " + item.ProductPrice + "Quantity: " + item.Quantity));
            }
            else
            {
                Console.WriteLine("Cart is Empty");
            }
        }
        public void ClearCart(List<Product> CartData)
        {
            CartData.Clear();
            Console.WriteLine("Cart is Clear Successfully");
        }
        public void RemoveParticularProductFromCart(List<Product> CartData, int id)
        {
            var found = CartData.Find(item => item.ProductId == id);
            if (found != null) CartData.Remove(found); Console.WriteLine(found.ProductName + "is Successfully Removed ");
        }
        public void TotalAmountOfCart(List<Product> CartData)
        {
            decimal Total = 0;
            CartData.ForEach(item => Total += item.ProductPrice);
            Console.WriteLine("Total Amount: " + Total);
        }
    }
}
