using Ninject;
using SkillService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public class SkillEvaluationContext : ISkillEvaluationContext
    {
        private ISkills _PlatformStrength;
        private ISkills _ExtraSkillStrength;
        private ISkills _ProgrammingLanguageStrength;
        private ISkills _SpecialSkillStrength;
        private ISkills _TechnologyStrength;
        private ISkills _ToolStrength;
        private ISkills _TrackInfluence;
        private IScore _score;

        [Inject]
        public SkillEvaluationContext([Named("PlatformStrength")]ISkills PlatformStrength,
                                    [Named("ExtraSkillStrength")]ISkills ExtraSkillStrength,
                                    [Named("ProgrammingLanguageStrength")]ISkills ProgrammingLanguageStrength,
                                    [Named("SpecialSkillStrength")]ISkills SpecialSkillStrength,
                                    [Named("TechnologyStrength")]ISkills TechnologyStrength,
                                    [Named("ToolStrength")]ISkills ToolStrength,
                                    [Named("TrackInfluence")]ISkills TrackInfluence,
                                    IScore score)
        {
            _PlatformStrength = PlatformStrength;
            _ExtraSkillStrength = ExtraSkillStrength;
            _ProgrammingLanguageStrength = ProgrammingLanguageStrength;
            _SpecialSkillStrength = SpecialSkillStrength;
            _TechnologyStrength = TechnologyStrength;
            _ToolStrength = ToolStrength;
            _TrackInfluence = TrackInfluence;
            _score = score;
        }

        public IScore EvaluateGithub(IGithubDetail githubDetail)
        {
            IScore result = _score;
            result.Github = githubDetail;

            result.ProgrammingLanguageStrength = _ProgrammingLanguageStrength.FormulateScore(githubDetail);
            

            return result;
        }

        public IScore EvaluateStackOverflow(IStackOverflowDetail stackOverflow)
        {
            throw new NotImplementedException();
        }

        public IScore EvaluateUVA(IUVADetail uva)
        {
            IScore result = _score;
            result.UVA = uva;

            result.SpecialSkillStrength = _SpecialSkillStrength.FormulateScore(uva);
            throw new NotImplementedException();
        }
    }
}
