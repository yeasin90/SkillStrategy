using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public class IdFactory : IIdFactory
    {
        public int ID { get; set; }

        public int Creeate()
        {
            return ID++;
        }
    }
}
