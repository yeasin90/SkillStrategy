using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillReference
{
    public interface ITool
    {
        string Name { get; set; }
        string DisplayName { get; set; }
    }
}
