using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        public ICollection<IProgrammingLanguage> GetAll()
        {
            return new List<IProgrammingLanguage>()
            {
                new ProgrammingLanguage(){ Name = "C", DisplayName = "C"},
                new ProgrammingLanguage(){ Name = "C++", DisplayName = "C++"},
                new ProgrammingLanguage(){ Name = "Java", DisplayName = "Java"},
                new ProgrammingLanguage(){ Name = "C#", DisplayName = "C#"}
            };
        }
    }
}
