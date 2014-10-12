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
    public class ProgrammingLanguageStrengthSkill : ISkills//Skills
    {
        private IProgrammingLanguageRepository _programmingLanguageRepository;

        [Inject]
        public ProgrammingLanguageStrengthSkill(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            if (entity is GithubDetail)
                return GithubFormula((IGithubDetail)entity);

            throw new NotImplementedException();
        }

        private Dictionary<string, int> GithubFormula(IGithubDetail githubDetail)
        {
            ICollection<IProgrammingLanguage> languages = _programmingLanguageRepository.GetAll();

            foreach (IProgrammingLanguage item in languages)
            {

            }

            throw new NotImplementedException();
        }
    }
}
