using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtoTypePattern
{
    // Follow pluralsight video.
    // Learn more  on : http://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-prototype-pattern/

    // This structure can be followed to make framewokr or library.
    public class ComplicatedUnstableObject : ICloneable
    {
        // User should not be allowed to use this constructors. But i need these constructors to build a framework
        // this is the reason why these four ctors are marked as internal
        internal ComplicatedUnstableObject(string a, int b, int c, char d)
        {

        }

        internal ComplicatedUnstableObject(int a, int b, char c)
        {

        }

        internal ComplicatedUnstableObject(string a, string b)
        {

        }

        // User should only be allowed to call this function to get a copy of the framework
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
