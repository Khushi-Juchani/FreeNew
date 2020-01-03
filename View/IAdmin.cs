using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner.View
{
    public interface IAdmin
    {
        string AdminUsername { get; set; }
        string AdminPassword { get; set; }
    }
}
