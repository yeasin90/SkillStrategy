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
    class Program
    {
        static void Main(string[] args)
        {
            //http://dotnetslackers.com/articles/csharp/Get-Started-with-Ninject-2-0-in-C-sharp-Programming.aspx

            //http://blog.prabir.me/posts/dependency-injection-hello-world-with-ninject

            IKernel kernel = new StandardKernel(new SkillModule());
            ISkills skill = kernel.Get<ISkills>("ProgrammingLanguageStrengthSkill");
            skill.Evaluate();
        }
    }
}
