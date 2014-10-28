using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Badge
{
    public interface IBadgeEngine
    {
        IBadge GetBadge(string username);
    }
}
