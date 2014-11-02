using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RulesPattern.NonRules
{
    public class Person
    {
        public int Salary { get; set; }
        public int Age { get; set; }
    }

    public class Client
    {
        public int AnnualIncome { get; set; }

        public void Get()
        {
            Person person = new Person{ Age = 40, Salary = 2000};

            if(person.Age > 10)
                AnnualIncome = person.Salary * 10;
            else if(person.Age > 20)
                AnnualIncome = person.Salary = 20;
        }
    }
}
