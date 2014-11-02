using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    public interface ITestBadgeRules
    {
        IBadge TestPassedBadge(IContestant contestant);
    }
}
