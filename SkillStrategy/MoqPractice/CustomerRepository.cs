using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Save(Customer customer)
        {
            
        }

        public void SaveSpecial(Customer customer)
        {

        }


        public string LocalTimeZone { get; set; }
    }
}
