using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class OrderEntity
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public int[] OrderDetails { get; set; }
    }
}
