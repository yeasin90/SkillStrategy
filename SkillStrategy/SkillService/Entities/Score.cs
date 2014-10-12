using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Entities
{
    public class Score : IScore
    {
        public Dictionary<string, int> TrackInfluence { get; set; }
        public Dictionary<string, int> ProgrammingLanguageStrength { get; set; }
        public Dictionary<string, int> PlatformStrength { get; set; }
        public Dictionary<string, int> ToolStrength { get; set; }
        public Dictionary<string, int> TechnologyStrength { get; set; }
        public Dictionary<string, int> SpecialSkillStrength { get; set; }
        public Dictionary<string, int> ExtraSkillStrength { get; set; }
        public Dictionary<string, int> Activity { get; set; }
        public IGithubDetail Github { get; set; }
        public IUVADetail UVA { get; set; }
        public IStackOverflowDetail StackOverflow { get; set; }
    }
}
