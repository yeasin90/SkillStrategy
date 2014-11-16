using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NullObjectPattern
{
    public abstract class PersonBase
    {
        public abstract string Name { get; }
        public abstract int Age { get; }
        public abstract void Talk();
        public abstract void ShutUp();

        #region Null implementation

        // Singleton
        static readonly NullPerson nullPerson = new NullPerson();
        public static NullPerson Null { get { return nullPerson; } }

        // Embedded Null Object class
        public class NullPerson : PersonBase
        {
            public override string Name { get { return string.Empty; } }
            public override int Age { get { return 0; } }
            public override void Talk() { }
            public override void ShutUp() { }
        }

        #endregion
    }

    public class OldPerson : PersonBase
    {
        public override string Name { get { return "Grandpa"; } }
        public override int Age { get { return 80; } }

        public override void Talk()
        {
            Console.WriteLine(
                "Bladibla uche uche bla... I'm {0} years old", this.Age);
        }

        public override void ShutUp()
        {
            Console.WriteLine("{0} stopped talking", this.Name);
        }
    }

    public class YoungPerson : PersonBase
    {
        public override string Name { get { return "Little girl"; } }
        public override int Age { get { return 7; } }

        public override void Talk()
        {
            Console.WriteLine(
                "Bladibla hihihihihi bla... I'm {0} years old", this.Age);
        }

        public override void ShutUp()
        {
            Console.WriteLine("{0} stopped talking", this.Name);
        }
    }

    public class PersonRepository
    {
        public PersonBase Find(string name)
        {
            if (name.Contains("Old"))
            {
                return new OldPerson();
            }
            else if (name.Contains("Young"))
            {
                return new YoungPerson();
            }

            return PersonBase.Null;
        }
    }
}

