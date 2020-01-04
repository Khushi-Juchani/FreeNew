using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner.View;
using AwayDayPlanner.Model;
using AwayDayPlanner.Entities;
using System.Data;

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
        
        public DataTable getEventDt()
        {
            var eventlists = getAllEvents();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("EventID");
            dataTable.Columns.Add("EventName");
            dataTable.Columns.Add("EventDetails");
            dataTable.Columns.Add("EventCost");
            dataTable.Columns.Add("EventNumber");
            dataTable.Columns.Add("EventType");



            foreach ( var adpevent in eventlists)
            {
                dataTable.Rows.Add(adpevent.EventID.ToString(), adpevent.EventName, adpevent.EventDetails, adpevent.EventCost, adpevent.EventNumber, adpevent.EventType);
            }
            return dataTable;
        }

        public bool DeleteEvent(string EventID)
        {
            var event_id = Convert.ToInt32(EventID);
            EventModel eventModel = new EventModel();
            return eventModel.DeleteEvent(event_id);
        }
        public bool UpdateEvent(string event_id, string event_name, string event_details, string event_cost, string event_number , string event_type)
        {
            var event_id_num = Convert.ToInt32(event_id);
            var  event_cost_num = Convert.ToInt32(event_cost);

            EventModel eventModel = new EventModel();
            return eventModel.UpdateEvent(event_id_num, event_name, event_details, event_cost_num, event_number, event_type);
        }
        public bool AddEvent( string event_name, string event_details, string event_cost)
        {
            var event_cost_num = Convert.ToInt32(event_cost);

            EventModel eventModel = new EventModel();
            return eventModel.AddEvent(event_name, event_details, event_cost_num);
        }
    }
}
