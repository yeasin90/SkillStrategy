using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public interface ICustomerFullNameBuilder
    {
        string From(string firstname, string lastname);
    }
}
