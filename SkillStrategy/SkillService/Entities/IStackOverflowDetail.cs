using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Entities
{
    public interface IStackOverflowDetail : IEntity
    {
        string StackOverflowID { get; set; }
        int ViewCount { get; set; }
        int DownVoteCount { get; set; }
        int UpVoteCount { get; set; }
        int AnswerCount { get; set; }
        int QuestionCount { get; set; }
        string AccountID { get; set; }
        int Reputation { get; set; }
        string UserType { get; set; }
        decimal AcceptRate { get; set; }
        string DisplayName { get; set; }
        int BronzeCount { get; set; }
        int SilverCount { get; set; }
        int GoldCount { get; set; }
    }
}
