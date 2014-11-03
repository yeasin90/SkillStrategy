using Ninject;
using SkillService;
using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillStrategy
{
    public interface A
    {
        void X();
    }

    public interface B
    {
        void Y();
    }

    public class AB : A, B
    {
        public void Y()
        {
            throw new NotImplementedException();
        }

        public void X()
        {
            throw new NotImplementedException();
        }
    }

    public class MyClass
    {
        private void Test(string param)
        {
            if (string.IsNullOrWhiteSpace(param))
                throw new ArgumentNullException("Null Ex");
            else if (param.Length > 1)
                throw new ArgumentException("Arg Excp");
            else if (param.Length > 5)
                throw new OverflowException();
            else if (param.Length < 1)
                throw new FormatException();
        }

        public void Call(string input)
        {
            try
            {
                Test(input);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            ArgumentException argEx;
            OverflowException ovfEx;
            FormatException fmtEx;
            ArgumentNullException argNullExp;

            if ((argNullExp = ex as ArgumentNullException) != null)
            {
                //ToDo..
            }
            else if ((argEx = ex as ArgumentException) != null)
            {
                //ToDo..
            }
            else if ((ovfEx = ex as OverflowException) != null)
            {
                //ToDo..
            }
            else if ((fmtEx = ex as FormatException) != null)
            {
                //ToDo..
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //http://dotnetslackers.com/articles/csharp/Get-Started-with-Ninject-2-0-in-C-sharp-Programming.aspx

            //http://blog.prabir.me/posts/dependency-injection-hello-world-with-ninject

            //IKernel kernel = new StandardKernel(new SkillModule());
            //ISkills skill = kernel.Get<ISkills>("ProgrammingLanguageStrengthSkill");
            //skill.Evaluate();
            //B b = new AB();
            //b.Y();

            MyClass cls = new MyClass();
            cls.Call("TTT");
            cls.Call(string.Empty);
            //cls.Call
        }
    }
}
