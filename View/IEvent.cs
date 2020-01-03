using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner.View
{
    public interface IEvent
    {
        string EventName { get; set; }
        string EventCost { get; set; }
    }
}
