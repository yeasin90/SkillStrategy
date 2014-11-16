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
            LazyOrder order = new LazyOrder(1);
            Console.WriteLine("Customer name : " + order.Customer.Name + " Order date : " + order.OrderDate);
        }

        [TestMethod]
        public void NonObserver()
        {
            foreach (DesignPatterns.ObserverPattern.NonObserver.Stock s in DesignPatterns.ObserverPattern.NonObserver.SampleData.getNext())
            {
                if(s.Symbol == "GOOG")
                    Console.WriteLine("Google's new price is : {0}", s.Price);
                if(s.Symbol == "MSFT" && s.Price > 10.00m)
                    Console.WriteLine("Microsoft has reached the target price: {0}", s.Price);
            }
        }

        [TestMethod]
        public void TraditionalObserver()
        {
            DesignPatterns.ObserverPattern.TraditionalObserver.StockTicker subj = new DesignPatterns.ObserverPattern.TraditionalObserver.StockTicker();

            DesignPatterns.ObserverPattern.TraditionalObserver.GoogleObserver gobs = new DesignPatterns.ObserverPattern.TraditionalObserver.GoogleObserver(subj);
            DesignPatterns.ObserverPattern.TraditionalObserver.MicrosoftObserver mobs = new DesignPatterns.ObserverPattern.TraditionalObserver.MicrosoftObserver(subj);

            foreach (var s in DesignPatterns.ObserverPattern.TraditionalObserver.SampleData.getNext())
                subj.Stock = s;
        }

        [TestMethod]
        public void MyMediator()
        {
            DesignPatterns.MyMediator.IMediator mediator = new DesignPatterns.MyMediator.Mediator();
            DesignPatterns.MyMediator.Car bmw = new DesignPatterns.MyMediator.BMW(mediator);
            DesignPatterns.MyMediator.Car audi = new DesignPatterns.MyMediator.Audi(mediator);
            DesignPatterns.MyMediator.BMW bm = (DesignPatterns.MyMediator.BMW)bmw;
            bm.Price = 1000;
        }
    }
}
