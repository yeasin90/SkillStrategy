using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    internal class TestCompleteEvaluator : ICompleteEvaluator
    {
        private TestCompleteHandler _passedThreeTest;
        private TestCompleteHandler _passedSevenTest;
        private TestCompleteHandler _passedFifteenTest;

        public TestCompleteEvaluator()
        {
            _passedThreeTest = new ThreeTestComplete();
            _passedSevenTest = new SevenTestComplete();
            _passedFifteenTest = new FifteenTestComplete();

            _passedFifteenTest.SetSuccessor(_passedSevenTest);
            _passedSevenTest.SetSuccessor(_passedThreeTest);
        }

        public IBadge EvaluateCompletion(IContestant contestant)
        {
            return _passedFifteenTest.GetBadge(string.Empty);
        }
    }
}
