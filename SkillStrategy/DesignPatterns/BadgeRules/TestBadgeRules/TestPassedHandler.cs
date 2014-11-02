using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    internal interface ITestPassEvaluator
    {
        IBadge EvaluateBadgeForTest(IContestant contestant);
    }

    internal class TestPassEvaluator : ITestPassEvaluator
    {
        private TestPassedHandler _testPassHandler1;
        private TestPassedHandler _testPassHandler2;
        private TestPassedHandler _testPassHandler3;

        public TestPassEvaluator()
        {
            _testPassHandler1 = new ThreeTestHandler();
            _testPassHandler2 = new SevenTestHandler();
            _testPassHandler3 = new FifteenTestHandler();

            _testPassHandler3.SetSuccessor(_testPassHandler2);
            _testPassHandler2.SetSuccessor(_testPassHandler1);
        }

        public IBadge EvaluateBadgeForTest(IContestant contestant)
        {
            return _testPassHandler3.EvaluateBadge(contestant);
        }
    }


    internal abstract class TestPassedHandler
    {
        protected TestPassedHandler _successor;

        public void SetSuccessor(TestPassedHandler successor)
        {
            _successor = successor;
        }

        public IContestant GetPassedTests(int number)
        {
            return null;
        }

        public abstract IBadge EvaluateBadge(IContestant contestant);
    }

    internal class ThreeTestHandler : TestPassedHandler
    {
        public override IBadge EvaluateBadge(IContestant contestant)
        {
            if (GetPassedTests(3) == null)
                _successor.EvaluateBadge(contestant);

            throw new NotImplementedException();
        }
    }

    internal class SevenTestHandler : TestPassedHandler
    {
        public override IBadge EvaluateBadge(IContestant contestant)
        {
            throw new NotImplementedException();
        }
    }

    internal class FifteenTestHandler : TestPassedHandler
    {
        public override IBadge EvaluateBadge(IContestant contestant)
        {
            throw new NotImplementedException();
        }
    }
}
