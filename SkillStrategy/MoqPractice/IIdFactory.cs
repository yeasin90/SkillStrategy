using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public interface IIdFactory
    {
        int ID { get; set; }
        int Creeate();
    }
}
