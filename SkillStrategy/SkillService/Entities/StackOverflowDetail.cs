using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Entities
{
    public class StackOverflowDetail : Entity, IStackOverflowDetail
    {
        public string StackOverflowID { get; set; }
        public int ViewCount { get; set; }
        public int DownVoteCount { get; set; }
        public int UpVoteCount { get; set; }
        public int AnswerCount { get; set; }
        public int QuestionCount { get; set; }
        public string AccountID { get; set; }
        public int Reputation { get; set; }
        public string UserType { get; set; }
        public decimal AcceptRate { get; set; }
        public string DisplayName { get; set; }
        public int BronzeCount { get; set; }
        public int SilverCount { get; set; }
        public int GoldCount { get; set; }
    }
}
