using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillCriteria
{
    public interface IPlatform
    {
        string Name { get; set; }
        string DisplayName { get; set; }
    }
}
