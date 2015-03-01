using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DeepShalowCopy
{
    public class DeepCopy
    {
        public int x { get; set; }
        public int y { get; set; }
        public Details AddressDetails { get; set; }

        public object Clone()
        {
            DeepCopy cloned = this.MemberwiseClone() as DeepCopy;
            cloned.AddressDetails = new Details();
            cloned.AddressDetails.Name = this.AddressDetails.Name;
            cloned.AddressDetails.City = this.AddressDetails.City;

            return cloned;
        }
    }
}
