﻿using SkillService.SkillParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillCriteria
{
    public interface ISkills
    {
        Dictionary<string, int> FormulateScore(IEntity entity);
    }
}
