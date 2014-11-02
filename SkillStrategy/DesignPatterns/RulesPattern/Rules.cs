using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RulesPattern.Rules
{
    public interface ISalaryRules
    {
        int EvaluateSalary(Person person);
    }

    public class AgeOver10Rule : ISalaryRules
    {
        public int EvaluateSalary(Person person)
        {
            int temp = 0;

            if (person.Age > 10)
                temp = person.Age * 10;

            return temp;
        }
    }

    public class AgeOver20Rule : ISalaryRules
    {
        public int EvaluateSalary(Person person)
        {
            int temp = 0;

            if (person.Age > 20)
                temp = person.Age * 20;

            return temp;
        }
    }

    public class Person
    {
        public int Salary { get; set; }
        public int Age { get; set; }
    }

    public class Client
    {
        public void Get()
        {
            List<ISalaryRules> rules = new List<ISalaryRules>();
            rules.Add(new AgeOver10Rule());
            rules.Add(new AgeOver20Rule());

            Person person = new Person { Age = 40, Salary = 2000 };

            int salary;

            foreach (ISalaryRules item in rules)
            {
                salary = item.EvaluateSalary(person);
            }
        }
    }
}
