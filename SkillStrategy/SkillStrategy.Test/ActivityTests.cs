using Activity.PracticeGround;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillStrategy.Test
{
    [TestClass]
    public class ActivityTests
    {
        [TestMethod]
        public void LazyTestOrderNotAccessed()
        {
            Customer customer = new Customer();
            Console.WriteLine("Name : " +customer.Name + " Age : " + customer.Age + " Orders : " + customer._lazyOrders.IsValueCreated);
        }

        [TestMethod]
        public void LazyTestOrderAccessed()
        {
            Customer customer = new Customer();
            var x = customer.Orders;
            //x.Add(new Order { ID = 3, OrderName = "New Order" });
            Console.WriteLine("Name : " + customer.Name + " Age : " + customer.Age + " Orders : " + customer._lazyOrders.IsValueCreated);
        }

        [TestMethod]
        public void ShallowCopyTest()
        {
            AuthorForShallowCopy o = new AuthorForShallowCopy()
            {
                Name = "Yeasin",
                HomeAddress = new AddressShallow() { City = "Dhaka", State = "Bangladesh" }
            };

            Console.WriteLine("Original Copy");
            Console.WriteLine("Name : " + o.Name + "\nCity : " + o.HomeAddress.City + "\nState : " + o.HomeAddress.State);

            AuthorForShallowCopy clonedObject = (AuthorForShallowCopy)o.Clone();
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine("Name : " + clonedObject.Name + "\nCity : " + clonedObject.HomeAddress.City + "\nState : " + clonedObject.HomeAddress.State);

            Console.WriteLine("\nMake Changes to clone copy address");
            clonedObject.Name = "Mr.Changer";
            clonedObject.HomeAddress.State = "Comilla";
            clonedObject.HomeAddress.City = "Kandir par";

            Console.WriteLine("\nCloned Copy");
            Console.WriteLine("Name : " + clonedObject.Name + "\nCity : " + clonedObject.HomeAddress.City + "\nState : " + clonedObject.HomeAddress.State);

            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine("Name : " + o.Name + "\nCity : " + o.HomeAddress.City + "\nState : " + o.HomeAddress.State);
        }

        [TestMethod]
        public void DeepCopyTest()
        {
            AuthorForDeepCopy o = new AuthorForDeepCopy()
            {
                Name = "Yeasin",
                HomeAddress = new AddressDeep() { City = "Dhaka", State = "Bangladesh" }
            };


            Console.WriteLine("Original Copy");
            Console.WriteLine("Name : " + o.Name + "\nCity : " + o.HomeAddress.City + "\nState : " + o.HomeAddress.State);

            AuthorForDeepCopy clonedObject = (AuthorForDeepCopy)o.Clone();
            Console.WriteLine("\nCloned Copy");
            Console.WriteLine("Name : " + clonedObject.Name + "\nCity : " + clonedObject.HomeAddress.City + "\nState : " + clonedObject.HomeAddress.State);

            Console.WriteLine("\nMake Changes to clone copy address");
            clonedObject.Name = "Mr.Changer";
            clonedObject.HomeAddress.State = "Comilla";
            clonedObject.HomeAddress.City = "Kandir par";

            Console.WriteLine("\nCloned Copy");
            Console.WriteLine("Name : " + clonedObject.Name + "\nCity : " + clonedObject.HomeAddress.City + "\nState : " + clonedObject.HomeAddress.State);

            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine("Name : " + o.Name + "\nCity : " + o.HomeAddress.City + "\nState : " + o.HomeAddress.State);
        }
    }
}
