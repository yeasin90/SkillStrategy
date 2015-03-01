using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DeepShalowCopy
{
    public class ShalowCopy
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class ShalowCopyCloneble : ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class ShalowCopyClonebleWithReferenceType : ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public Details AddressDetails { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Details
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
