using DesignPatterns.ProxyPattern.NonProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    public class Customer
    {
        public string Name { get; set; }
        private int _cusotmerID;

        public Customer()
        {

        }

        public Customer(int customerID)
        {
            // TODO: Complete member initialization
            Console.WriteLine("---> Fetching Customer " + customerID);
            this._cusotmerID = customerID;
            CustomerEntity customerEntity = new CustomerRepository().GetById(_cusotmerID);
            this.Name = customerEntity.Name;
        }
    }
}
