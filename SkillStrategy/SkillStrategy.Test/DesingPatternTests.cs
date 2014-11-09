using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.ProxyPattern.NonProxy;
using DesignPatterns.ProxyPattern.Proxy;

namespace SkillStrategy.Test
{
    [TestClass]
    public class DesingPatternTests
    {
        [TestMethod]
        public void NonProxy()
        {
            Order order = new Order(1);
            Console.WriteLine("Customer name : " + order.Customer.Name + " Order date : " + order.OrderDate);
        }

        [TestMethod]
        public void Proxy()
        {
            OrderProxy order = new OrderProxy(1);
            Console.WriteLine("Customer name : " + order.Customer.Name + " Order date : " + order.OrderDate);
        }

        [TestMethod]
        public void LazyProxy()
        {
            OrderProxy order = new OrderProxy(1);
            Console.WriteLine("Customer name : " + order.Customer.Name + " Order date : " + order.OrderDate);
        }
    }
}
