﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillParameter
{
    public class UVADetail : IUVADetail
    {
        public string OnlineJudgeID { get; set; }
        public int OfflineSolveCount { get; set; }
        public int Rank { get; set; }
        public string UvaUsername { get; set; }
    }
}
