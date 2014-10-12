using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class TechnologyRepository : ITechnologyRepository
    {
        public ICollection<ITechnology> GetAll()
        {
            return new List<ITechnology>()
            {
                new Technology(){ Name = "node.js", DisplayName = "node.js"},
                new Technology(){ Name = "jquery", DisplayName = "jquery"},
                new Technology(){ Name = "nhibernet", DisplayName = "nhibernet"},
                new Technology(){ Name = "Entity framework", DisplayName = "Entity framework"}
            };
        }
    }
}
