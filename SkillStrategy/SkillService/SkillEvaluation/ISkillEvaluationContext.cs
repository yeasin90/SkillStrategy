using SkillService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public interface ISkillEvaluationContext
    {
        IScore EvaluateGithub(IGithubDetail githubDetail);
        IScore EvaluateStackOverflow(IStackOverflowDetail stackOverflow);
        IScore EvaluateUVA(IUVADetail uva);
    }
}
