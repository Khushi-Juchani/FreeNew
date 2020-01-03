using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner.View
{
    public interface IDayPlannerView
    {
        string username { get; set; }
        string usertype { get; set; }
        string password { get; set; }
    }
}
