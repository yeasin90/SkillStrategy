using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    public interface ITestBadges
    {
        IBadge GetBadgeForTestCompletion(IContestant contestant);
    }
}
