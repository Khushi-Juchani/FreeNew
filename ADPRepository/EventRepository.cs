using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace ADPRepository
{
    public class EventRepository : IEventRepository
    {
        private readonly ADP_DB_New1Entities _context;
        public EventRepository()
        {
            _context = new ADP_DB_New1Entities();
        }

        public Event getEventByName(string eventName)
        {
            Event curr_event = _context.Events.Where(x => x.EventName == eventName).FirstOrDefault();
            return curr_event;
        }
        public EventRepository(ADP_DB_New1Entities context)
        {
            _context = context;
        }
        public void Delete(string adpEventNumber)
        {
            Event curr_event = _context.Events.Where(x => x.EventNumber == adpEventNumber).FirstOrDefault();
            _context.Events.Remove(curr_event);
        }

        public IEnumerable<Event> GetAll()
        {
            
            return _context.Events.ToList();

        }

        public Event GetByName(string eventNumber)
        {
            Event curr_event = _context.Events.Where(x => x.EventNumber == eventNumber).FirstOrDefault();
            return curr_event;
        }

        public void Insert(Event adpEvent)
        {
            _context.Events.Add(adpEvent);
        }

        public void Update(Event adpEvent)
        {
            _context.Entry(adpEvent).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
