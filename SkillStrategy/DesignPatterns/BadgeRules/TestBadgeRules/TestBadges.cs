using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    public class TestBadges: ITestBadges
    {
        private ICompleteEvaluator _testCompleteEvaluator = new TestCompleteEvaluator();

        public IBadge GetBadgeForTestCompletion(IContestant contestant)
        {
            return _testCompleteEvaluator.EvaluateCompletion(contestant);
        }
    }

    
}
