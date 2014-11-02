using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    internal abstract class TestCompleteHandler
    {
        protected TestCompleteHandler _successor;

        public void SetSuccessor(TestCompleteHandler successor)
        {
            _successor = successor;
        }

        protected IContestant GetPassedTest(string username, int count)
        {
            throw new NotImplementedException();
        }

        public abstract IBadge GetBadge(string username);
    }

    internal class FifteenTestComplete : TestCompleteHandler
    {
        public override IBadge GetBadge(string username)
        {
            return GetPassedTest(username,15) != null ? null : _successor.GetBadge(username);
        }
    }

    internal class SevenTestComplete : TestCompleteHandler
    {
        public override IBadge GetBadge(string username)
        {
            return GetPassedTest(username, 7) != null ? null : _successor.GetBadge(username);
        }
    }

    internal class ThreeTestComplete : TestCompleteHandler
    {
        public override IBadge GetBadge(string username)
        {

            //ToDo:
            // 1. Check if completed 3tests
            // 2. if yes, return badge, else return null
            throw new NotImplementedException();
        }
    }
}
