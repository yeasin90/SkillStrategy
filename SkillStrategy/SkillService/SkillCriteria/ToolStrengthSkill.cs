using Ninject;
using SkillService.Repository;
using SkillService.SkillParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillCriteria
{
    public class ToolStrengthSkill : ISkills//Skills
    {
        private IToolRepository _toolRepository;

        [Inject]
        public ToolStrengthSkill(IToolRepository toolRepository)
        {
            _toolRepository = toolRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
