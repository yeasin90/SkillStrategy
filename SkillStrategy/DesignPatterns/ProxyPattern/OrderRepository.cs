using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class OrderRepository
    {
        internal OrderEntity GetById(int id)
        {
            Console.WriteLine("---> Fetching Order " +id);
            return new OrderEntity()
            {
                Id = id,
                CustomerId = 1,
                OrderDetails = new int[]{1,2,3},
                OrderDate = DateTime.Now
            };
        }
    }
}
