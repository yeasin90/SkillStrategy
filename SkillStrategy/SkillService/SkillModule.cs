using Ninject.Modules;
using SkillService.Entities;
using SkillService.Repository;
using SkillService.SkillCriteria;
using SkillService.SkillEvaluation;
using SkillService.SkillReference;
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
            Bind<ISkills>().To<PlatformStrengthSkill>().Named("PlatformStrength");
            Bind<ISkills>().To<ExtraSkillStrengthSkill>().Named("ExtraSkillStrength");
            Bind<ISkills>().To<ProgrammingLanguageStrengthSkill>().Named("ProgrammingLanguageStrength");
            Bind<ISkills>().To<SpecialSkillStrengthSkill>().Named("SpecialSkillStrength");
            Bind<ISkills>().To<TechnologyStrengthSkill>().Named("TechnologyStrength");
            Bind<ISkills>().To<ToolStrengthSkill>().Named("ToolStrength");
            Bind<ISkills>().To<TrackInfluenceSkill>().Named("TrackInfluence");
            Bind<ISkillEvaluationContext>().To<SkillEvaluationContext>();

            Bind<IExtraSkill>().To<ExtraSkill>();
            Bind<IPlatform>().To<Platform>();
            Bind<IProgrammingLanguage>().To<ProgrammingLanguage>();
            Bind<ISpecialSkill>().To<SpecialSkill>();
            Bind<ITechnology>().To<Technology>();
            Bind<ITrack>().To<Track>();
            Bind<ITool>().To<Tool>();

            Bind<IExtraSkillRepository>().To<ExtraSkillRepository>();
            Bind<IPlatformRepository>().To<PlatformRepository>();
            Bind<IProgrammingLanguageRepository>().To<ProgrammingLanguageRepository>();
            Bind<ISpecialSkillRepository>().To<SpecialSkillRepository>();
            Bind<ITechnologyRepository>().To<TechnologyRepository>();
            Bind<ITrackRespotiroy>().To<TrackRespotiroy>();
            Bind<IToolRepository>().To<ToolRepository>();

            Bind<IEntity>().To<Entity>();
            Bind<IGithubDetail>().To<GithubDetail>();
            Bind<IStackOverflowDetail>().To<StackOverflowDetail>();
            Bind<IUVADetail>().To<UVADetail>();
            Bind<IScore>().To<Score>();
        }
    }
}
