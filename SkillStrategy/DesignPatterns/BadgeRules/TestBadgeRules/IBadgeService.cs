using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BadgeRules.TestBadgeRules
{
    public interface IBadgeService
    {
        IBadge GetBadge(int rank);
    }

    public class BadgeService : IBadgeService
    {
        public IBadge GetBadge(int rank)
        {
            return new Badge();
        }
    }
}
