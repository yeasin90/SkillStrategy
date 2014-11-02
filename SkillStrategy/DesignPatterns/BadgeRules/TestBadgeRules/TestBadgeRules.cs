using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    public class TestBadgeRules : ITestBadgeRules
    {
        public IBadge TestPassedBadge(IContestant contestant)
        {
            throw new NotImplementedException();
        }
    }
}
