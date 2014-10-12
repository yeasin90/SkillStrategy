using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class ExtraSkillRepository : IExtraSkillRepository
    {
        public ICollection<IExtraSkill> GetAll()
        {
            return new List<IExtraSkill>()
            {
                new ExtraSkill{ Name = "Public Speaking", DisplayName = "Public Speaking"},
                new ExtraSkill{ Name = "Contribution", DisplayName = "Contribution"},
                new ExtraSkill{ Name = "Team Leading", DisplayName = "Team Leading"},
                new ExtraSkill{ Name = "Event Organizing", DisplayName = "Event Organizing"},
                new ExtraSkill{ Name = "Team Work", DisplayName = "Team Work"}
            };
        }
    }
}
