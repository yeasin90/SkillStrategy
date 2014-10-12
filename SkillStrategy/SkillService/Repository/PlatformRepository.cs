using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class PlatformRepository : IPlatformRepository
    {
        public ICollection<IPlatform> GetAll()
        {
            return new List<IPlatform>()
            {
                new Platform(){ Name = ".net framework", DisplayName = ".net framework"},
                new Platform(){ Name = "Java spring framework", DisplayName = "Java spring framework"},
                new Platform(){ Name = "Asp.net MVC framework", DisplayName = "Asp.net MVC framework"},
                new Platform(){ Name = "Android developement", DisplayName = "Android developement"}
            };
        }
    }
}
