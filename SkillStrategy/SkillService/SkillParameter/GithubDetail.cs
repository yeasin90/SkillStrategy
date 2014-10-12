﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillParameter
{
    public class GithubDetail : IGithubDetail
    {
        public int Followers { get; set; }
        public int PublicRepoCount { get; set; }
        public int PrivateRepoCount { get; set; }
        public string GithubUsername { get; set; }
        public string Languages { get; set; }
    }
}
