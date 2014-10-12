using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillParameter
{
    public interface IUVADetail : IEntity
    {
        string OnlineJudgeID { get; set; }
        int OfflineSolveCount { get; set; }
        int Rank { get; set; }
        string UvaUsername { get; set; }
    }
}
