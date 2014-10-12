using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillParameter
{
    public interface IGithubDetail
    {
        int Followers { get; set; }
        int PublicRepoCount { get; set; }
        int PrivateRepoCount { get; set; }
        string GithubUsername { get; set; }
        string Languages { get; set; }
    }
}
