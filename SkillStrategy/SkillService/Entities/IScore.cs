using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Entities
{
    public interface IScore
    {
        Dictionary<string, int> TrackInfluence { get; set; }
        Dictionary<string, int> ProgrammingLanguageStrength { get; set; }
        Dictionary<string, int> PlatformStrength { get; set; }
        Dictionary<string, int> ToolStrength { get; set; }
        Dictionary<string, int> TechnologyStrength { get; set; }
        Dictionary<string, int> SpecialSkillStrength { get; set; }
        Dictionary<string, int> ExtraSkillStrength { get; set; }
        Dictionary<string, int> Activity { get; set; }
        IGithubDetail Github { get; set; }
        IUVADetail UVA { get; set; }
        IStackOverflowDetail StackOverflow { get; set; }
    }
}
