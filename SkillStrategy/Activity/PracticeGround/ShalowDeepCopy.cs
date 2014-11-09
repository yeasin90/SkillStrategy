using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.PracticeGround
{
    // Difference between Shallow and Deep copy
    // http://www.c-sharpcorner.com/UploadFile/56fb14/shallow-copy-and-deep-copy-of-instance-using-C-Sharp/
    // Prototype pattern : 
    // http://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-prototype-pattern/

    public class AuthorForShallowCopy : ICloneable
    {
        public string Name { get; set; }
        public AddressShallow HomeAddress { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class AddressShallow
    {
        public string State{ get; set; }
        public string City{ get; set; }
    }


    public class AuthorForDeepCopy : ICloneable
    {
        public string Name { get; set; }
        public AddressDeep HomeAddress { get; set; }

        public object Clone()
        {
            AuthorForDeepCopy objPriCopy = (AuthorForDeepCopy)this.MemberwiseClone();
            objPriCopy.HomeAddress = (AddressDeep)this.HomeAddress.Clone();
            return objPriCopy;
        }
    }

    public class AddressDeep : ICloneable
    {
        public string State{ get; set; }
        public string City{ get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        } 
    }
}
