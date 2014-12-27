using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public class Customer
    {
        private string _name;
        private string _city;
        private string _fullname;
        public Address MailingAddress { get; set; }
        public CustomerStatus StatusLevel { get; set; }
        public DateTime WorkStationCreatedOn { get; set; }
        public int ID { get; set; }

        public Customer(string name, string city)
        {
            _name = name;
            _city = city;
        }

        public Customer(string fullname)
        {
            _fullname = fullname;
        }
    }
}
