using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Badge
{
    public interface IBadgeClient
    {
        IBadge GetBadge(IBadgeEngine badgeFor, string username);
    }
}
