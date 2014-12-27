using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);

        void SaveSpecial(Customer customer);

        string LocalTimeZone { get; set; }
    }
}
