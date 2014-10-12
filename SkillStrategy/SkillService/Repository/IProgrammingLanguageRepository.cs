using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public interface IProgrammingLanguageRepository
    {
        ICollection<IProgrammingLanguage> GetAll();
    }
}
