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
    }
}
