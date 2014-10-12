using Ninject.Modules;
using SkillService.SkillCriteria;
using SkillService.SkillParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService
{
    public class SkillModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISkills>().To<PlatformStrengthSkill>().Named("PlatformStrengthSkill");
            Bind<ISkills>().To<ExtraSkillStrengthSkill>().Named("ExtraSkillStrengthSkill");
            Bind<ISkills>().To<ProgrammingLanguageStrengthSkill>().Named("ProgrammingLanguageStrengthSkill");
            Bind<ISkills>().To<SpecialSkillStrengthSkill>().Named("SpecialSkillStrengthSkill");
            Bind<ISkills>().To<TechnologyStrengthSkill>().Named("TechnologyStrengthSkill");
            Bind<ISkills>().To<ToolStrengthSkill>().Named("ToolStrengthSkill");
            Bind<ISkills>().To<TrackInfluenceSkill>().Named("TrackInfluenceSkill");

            Bind<IGithubDetail>().To<GithubDetail>();
            Bind<IStackOverflowDetail>().To<StackOverflowDetail>();
            Bind<IUVADetail>().To<UVADetail>();
        }
    }
}
