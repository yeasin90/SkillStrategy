using Ninject;
using SkillService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public class SpecialSkillStrengthSkill : ISkills//Skills
    {
        private ISpecialSkillRepository _specialSkillRepository;

        [Inject]
        public SpecialSkillStrengthSkill(ISpecialSkillRepository specialSkillRepository)
        {
            _specialSkillRepository = specialSkillRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
