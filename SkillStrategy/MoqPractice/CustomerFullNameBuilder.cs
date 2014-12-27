using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public class CustomerFullNameBuilder : ICustomerFullNameBuilder
    {
        public string From(string firstname, string lastname)
        {
            return firstname + " " + lastname;
        }
    }
}
