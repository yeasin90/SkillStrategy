using Ninject;
using SkillService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public class TechnologyStrengthSkill : ISkills//Skills
    {
        private ITechnologyRepository _technologyRepository;

        [Inject]
        public TechnologyStrengthSkill(ITechnologyRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
