using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    class PaymentMethod : IPaymentOperation
    {
        public void Cash()
        {
            Console.WriteLine("Order Successfull Using Cash");
        }
        public void Online()
        {
            Console.WriteLine("Order Successfull Using Online Transaction");
        }
    }
}
