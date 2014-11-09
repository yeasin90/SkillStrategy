using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.PracticeGround
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Lazy<List<Order>> _lazyOrders { get; set; }
        public List<Order> Orders { get { return _lazyOrders.Value; } }

        public Customer()
        {
            this.Name = "Yeasin";
            this.Age = 25;
            //_lazyOrders = new Lazy<List<Order>>(PopulateOrders);
            _lazyOrders = new Lazy<List<Order>>(() => new List<Order>
            {
                new Order{ ID = 1, OrderName = "Order 1"},
                new Order{ ID = 2, OrderName = "Order 2"},
                new Order{ ID = 3, OrderName = "Order 3"}
            });
        }

        private List<Order> PopulateOrders()
        {
            return new List<Order>
            {
                new Order{ ID = 1, OrderName = "Order 1"},
                new Order{ ID = 2, OrderName = "Order 2"},
                new Order{ ID = 3, OrderName = "Order 3"}
            };
        }
    }

    public class Order
    {
        public string OrderName { get; set; }
        public int ID { get; set; }
    }
}
