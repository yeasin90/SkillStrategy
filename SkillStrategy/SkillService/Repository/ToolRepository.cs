using SkillService.SkillReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class ToolRepository : IToolRepository
    {
        public ICollection<ITool> GetAll()
        {
            return new List<ITool>()
            {
                new Tool(){ Name = "visual studio", DisplayName = "visual studio"},
                new Tool(){ Name = "Flash", DisplayName = "Flash"},
                new Tool(){ Name = "Photoshop", DisplayName = "Photoshop"},
                new Tool(){ Name = "illustrator", DisplayName = "illustrator"}
            };
        }
    }
}
