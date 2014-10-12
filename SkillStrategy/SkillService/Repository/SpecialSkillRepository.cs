using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class SpecialSkillRepository : ISpecialSkillRepository
    {
        public ICollection<ISpecialSkill> GetAll()
        {
            return new List<ISpecialSkill>()
            {
                new SpecialSkill(){ Name = "system designing", DisplayName = "system designing"},
                new SpecialSkill(){ Name = "UX Expertise", DisplayName = "UX Expertise"},
                new SpecialSkill(){ Name = "UML designing", DisplayName = "UML designing"},
                new SpecialSkill(){ Name = "problem solving", DisplayName = "problem solving"},
                new SpecialSkill(){ Name = "debugging", DisplayName = "debugging"},
                new SpecialSkill(){ Name = "coding", DisplayName = "coding"},
                new SpecialSkill(){ Name = "designing", DisplayName = "designing"}
            };
        }
    }
}
