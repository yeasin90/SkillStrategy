using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern
{
    public class Client
    {
        public void Get()
        {
            Person person = new Person();
            person.assets.Add(new BankAccount { Amount = 100, MonthlyInterest = 1 });
            person.assets.Add(new RealEstate { EstimatedValue = 100, MonthlyRent = 1 });
            person.assets.Add(new Loan {  Owed = 100, MonthlyPayment = 1 });

            NetWorthVisitor visitor = new NetWorthVisitor();
            person.Accept(visitor);

            int total = visitor.Total;
        }
    }

    public class Person : IAsset
    {
        public List<IAsset> assets = new List<IAsset>();

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in assets)
            {
                asset.Accept(visitor);
            }
        }
    }

    public interface IVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan load);
    }

    public class NetWorthVisitor : IVisitor
    {
        public int Total { get; set; }

        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(Loan load)
        {
            Total -= load.Owed;
        }
    }


    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }

    

    public class Loan : IAsset
    {
        public int Owed { get; set; }
        public int MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class BankAccount : IAsset
    {
        public int Amount { get; set; }
        public int MonthlyInterest { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class RealEstate : IAsset
    {
        public int EstimatedValue { get; set; }
        public int MonthlyRent { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
