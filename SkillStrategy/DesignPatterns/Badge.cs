using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Badge : IBadge
    {
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
