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

        [TestMethod]
        public void SHalowCopy()
        {
            DesignPatterns.DeepShalowCopy.ShalowCopy obj1 = new DesignPatterns.DeepShalowCopy.ShalowCopy();
            obj1.x = 10;
            obj1.y = 20;

            DesignPatterns.DeepShalowCopy.ShalowCopy obj2 = new DesignPatterns.DeepShalowCopy.ShalowCopy();
            obj2 = obj1;
            obj2.x = 100;
            obj2.y = 200;

            Console.WriteLine("Original x : {0}, y : {1}", obj1.x, obj1.y);
        }

        [TestMethod]
        public void ShalowCopyCloneble()
        {
            DesignPatterns.DeepShalowCopy.ShalowCopyCloneble obj1 = new DesignPatterns.DeepShalowCopy.ShalowCopyCloneble();
            obj1.x = 10;
            obj1.y = 20;

            DesignPatterns.DeepShalowCopy.ShalowCopyCloneble obj2 = new DesignPatterns.DeepShalowCopy.ShalowCopyCloneble();
            obj2 = (DesignPatterns.DeepShalowCopy.ShalowCopyCloneble)obj1.Clone();
            obj2.x = 100;
            obj2.y = 200;

            Console.WriteLine("Original x : {0}, y : {1}", obj1.x, obj1.y);
        }

        [TestMethod]
        public void ShalowCopyCloneble_WithReferenceType()
        {
            DesignPatterns.DeepShalowCopy.ShalowCopyClonebleWithReferenceType obj1 = new DesignPatterns.DeepShalowCopy.ShalowCopyClonebleWithReferenceType();
            obj1.x = 10;
            obj1.y = 20;
            obj1.AddressDetails = new DesignPatterns.DeepShalowCopy.Details();
            obj1.AddressDetails.Name = "Yeasin";
            obj1.AddressDetails.City = "Dhaka";

            DesignPatterns.DeepShalowCopy.ShalowCopyClonebleWithReferenceType obj2 = new DesignPatterns.DeepShalowCopy.ShalowCopyClonebleWithReferenceType();
            obj2 = (DesignPatterns.DeepShalowCopy.ShalowCopyClonebleWithReferenceType)obj1.Clone();
            obj2.x = 100;
            obj2.y = 200;
            obj2.AddressDetails.Name = "Jubair";
            obj2.AddressDetails.City = "Khulna";

            Console.WriteLine("Original x : {0}, y : {1}, Name : {2}, City : {3}", obj1.x, obj1.y, obj1.AddressDetails.Name, obj1.AddressDetails.City);
        }

        [TestMethod]
        public void DeepCopy()
        {
            DesignPatterns.DeepShalowCopy.DeepCopy obj1 = new DesignPatterns.DeepShalowCopy.DeepCopy();
            obj1.x = 10;
            obj1.y = 20;
            obj1.AddressDetails = new DesignPatterns.DeepShalowCopy.Details();
            obj1.AddressDetails.Name = "Yeasin";
            obj1.AddressDetails.City = "Dhaka";

            DesignPatterns.DeepShalowCopy.DeepCopy obj2 = new DesignPatterns.DeepShalowCopy.DeepCopy();
            obj2 = (DesignPatterns.DeepShalowCopy.DeepCopy)obj1.Clone();
            obj2.x = 100;
            obj2.y = 200;
            obj2.AddressDetails.Name = "Jubair";
            obj2.AddressDetails.City = "Khulna";

            Console.WriteLine("Original x : {0}, y : {1}, Name : {2}, City : {3}", obj1.x, obj1.y, obj1.AddressDetails.Name, obj1.AddressDetails.City);
        }
    }
}
