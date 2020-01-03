using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner.View;
using AwayDayPlanner.Model;
using AwayDayPlanner.Entities;
namespace AwayDayPlanner.Presentation
{
    class EventsMgr
    {
        IEvent eventView;

        public EventsMgr(IEvent view)
        {
            eventView = view;
        }

        public void getEventbyID(int EventID)
        {
            var eventModel = new EventModel();
            var currentEvent = eventModel.GetEventbyID(EventID);
            eventModel.Event_ID = currentEvent.EventID;
            eventModel.EventName = currentEvent.EventName;
        }

        public List<EventEntity> getAllEvents()
        {
            List<EventEntity> eventEntities = new List<EventEntity>();
            var eventmodel = new EventModel();
            var allevents = eventmodel.GetEvents();
            foreach (var item in allevents)
            {
                EventEntity eventEntity = new EventEntity();
                eventEntity.EventCost = item.Cost;
                eventEntity.EventDetails = item.EventDetails;
                eventEntity.EventNumber = item.EventNumber;
                eventEntity.EventType = item.EventType;
                eventEntity.EventID = item.EventID;
                eventEntity.EventName = item.EventName;

       
                eventEntities.Add(eventEntity);
            }
            return eventEntities;
        }
        

    }
}
