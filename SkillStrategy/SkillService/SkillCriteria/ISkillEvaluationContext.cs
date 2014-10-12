using SkillService.SkillParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillCriteria
{
    public interface ISkillEvaluationContext
    {
        IScore EvaluateGithub(IGithubDetail githubDetail);
        IScore EvaluateStackOverflow(IStackOverflowDetail stackOverflow);
        IScore EvaluateUVA(IUVADetail uva);
    }
}
