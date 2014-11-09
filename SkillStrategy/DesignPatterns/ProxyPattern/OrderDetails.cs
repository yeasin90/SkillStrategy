using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class OrderDetails
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int orderDetailId;

        public OrderDetails()
        {

        }

        public OrderDetails(int orderDetailId)
        {
            Console.WriteLine("---> Fetching Order Details " + orderDetailId);
            this.orderDetailId = orderDetailId;
            var oderDetailsEntity = new OrderDetailsRepository().GetById(orderDetailId);
            this.Name = oderDetailsEntity.Name;
            this.Price = oderDetailsEntity.Price;
        }
    }
}
