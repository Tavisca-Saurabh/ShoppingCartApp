﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication
{
    interface IPaymentOperation
    {
        void Cash();
        void Online();
    }
}
