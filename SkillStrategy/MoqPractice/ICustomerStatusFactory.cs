using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public interface ICustomerStatusFactory
    {
        CustomerStatus CreateFrom(CustomerToCreateDto customerToCreate);
    }
}
