using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.NonVisitor
{
    public class Client
    {
        public void Get()
        {
            Person person = new Person();
            person.BankAccount.Add(new BankAccount { Amount = 100, MonthlyInterest = 1 });
            person.RealEstate.Add(new RealEstate { EstimatedValue = 100, MonthlyRent = 1 });
            person.Loan.Add(new Loan { Owed = 100, MonthlyPayment = 1 });

            int total = 0;
            foreach (BankAccount item in person.BankAccount)
                total += item.Amount;

            foreach (RealEstate item in person.RealEstate)
                total += item.EstimatedValue;

            foreach (Loan item in person.Loan)
                total -= item.Owed;
        }
    }

    public class Person
    {
        public List<BankAccount> BankAccount = new List<BankAccount>();
        public List<RealEstate> RealEstate = new List<RealEstate>();
        public List<Loan> Loan = new List<Loan>();
    }


    public class Loan 
    {
        public int Owed { get; set; }
        public int MonthlyPayment { get; set; }

    }

    public class BankAccount
    {
        public int Amount { get; set; }
        public int MonthlyInterest { get; set; }

    }

    public class RealEstate
    {
        public int EstimatedValue { get; set; }
        public int MonthlyRent { get; set; }

    }
}
