﻿using Ninject;
using SkillService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public class ExtraSkillStrengthSkill : ISkills//Skills
    {
        private IExtraSkillRepository _extraSkillRepository;

        [Inject]
        public ExtraSkillStrengthSkill(IExtraSkillRepository extraSkillRepository)
        {
            _extraSkillRepository = extraSkillRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
