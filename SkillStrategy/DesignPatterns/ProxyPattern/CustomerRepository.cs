using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class CustomerRepository
    {
        internal CustomerEntity GetById(int _cusotmerID)
        {
            return new CustomerEntity()
            {
                Id = _cusotmerID,
                Name = "Customer 1"
            };
        }
    }
}
