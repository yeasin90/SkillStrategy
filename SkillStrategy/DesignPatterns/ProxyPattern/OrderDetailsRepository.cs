using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class OrderDetailsRepository
    {
        internal OrderDetails GetById(int orderDetailId)
        {
            return new OrderDetails()
            {
                orderDetailId = orderDetailId,
                Name = "Order " + orderDetailId,
                Price = 10m
            };
        }
    }
}
