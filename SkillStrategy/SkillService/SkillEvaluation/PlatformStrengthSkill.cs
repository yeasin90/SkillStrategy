using Ninject;
using SkillService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public class PlatformStrengthSkill : ISkills//Skills
    {
        private IPlatformRepository _platformRepository;

        [Inject]
        public PlatformStrengthSkill(IPlatformRepository platformRepository)
        {
            _platformRepository = platformRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
