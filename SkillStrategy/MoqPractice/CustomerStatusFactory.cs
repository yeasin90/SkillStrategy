﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public class CustomerStatusFactory : ICustomerStatusFactory
    {
        public CustomerStatus CreateFrom(CustomerToCreateDto customerToCreate)
        {
            return CustomerStatus.Platinum;
        }
    }
}
