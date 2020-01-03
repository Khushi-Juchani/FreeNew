using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner.Entities
{
    public class EventEntity
    {
        public int EventID { get; set; }
        public string EventName { get; set; }

        public string EventDetails { get; set; }
        public int? EventCost { get; set; }

        public string EventType { get; set; }
        public string EventNumber { get; set; }

       
    }

}
