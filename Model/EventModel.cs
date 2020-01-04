using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPRepository;
using ADPDataAccessProj;

namespace AwayDayPlanner.Model
{
    
    class EventModel
    {
        
        public int Event_ID { get; set; }
        public string EventName { get; set; }
        AvailabilityRepository availabilityRepository = new AvailabilityRepository();
        EventRepository eventRepository = new EventRepository();
        public Event getEventByName(string eventName)
        {
            var current_Event = eventRepository.getEventByName(eventName);
            return current_Event;
        }
        public Event GetEventbyID(int EventID)
        {
            var current_Event = eventRepository.GetAll().Where(x=>x.EventID == EventID).FirstOrDefault();
            return current_Event;
        }
        public List<Event> GetEvents()
        {
            
            var allEvents = eventRepository.GetAll();
           
            return allEvents.ToList();
        }
        public List<Availability> GetAvailabilities(int EventID)
        {
            var availabilities = availabilityRepository.GetByEventID(EventID);
            return availabilities;
            
        }
        public bool DeleteEvent(int EventID)
        {
            try
            {
                eventRepository.Delete(EventID);
                eventRepository.Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdateEvent(int event_id, string event_name, string event_details, int event_cost, string event_number, string event_type)
        {
            try
            {
                Event evts = new Event();
                evts.EventID = event_id;
                evts.EventName = event_name;
                evts.EventDetails = event_details;
                evts.Cost = event_cost;
                evts.EventNumber = event_number;
                evts.EventType = event_type;
                eventRepository.Update(evts);
                eventRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddEvent(string event_name, string event_details, int event_cost)
        {
            try
            {

                Event evts = new Event();
                evts.EventName = event_name;
                evts.EventDetails = event_details;
                evts.Cost = event_cost;
                evts.EventNumber = "10";
                evts.EventType = "Package";
                eventRepository.Insert(evts);
                eventRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
