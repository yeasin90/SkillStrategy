using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    public class TestBadges: ITestBadges
    {
        private ITestCompleteEvaluator _testCompleteEvaluator = new TestCompleteEvaluator();

        public IBadge GetBadgeForTestCompletion(IContestant contestant)
        {
            return _testCompleteEvaluator.EvaluateBadgeForTestCompletion(contestant);
        }
    }
}
