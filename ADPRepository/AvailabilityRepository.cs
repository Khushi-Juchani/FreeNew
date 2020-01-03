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
    public class AvailabilityRepository : IAvailability
    {
        private readonly ADP_DB_New1Entities _context;
        public AvailabilityRepository()
        {
            _context = new ADP_DB_New1Entities();
        }
        public AvailabilityRepository(ADP_DB_New1Entities context)
        {
            _context = context;
        }
        public void Delete(int eventID)
        {
            Availability curr_event = _context.Availabilities.Find(eventID);
            _context.Availabilities.Remove(curr_event);
        }

        public IEnumerable<Availability> GetAll()
        {
            return _context.Availabilities.ToList();
        }

        public List<Availability> GetByEventID(int eventID)
        {
            var curr_event = _context.Availabilities.Where(x => x.EventID == eventID).ToList();
            return curr_event;
        }

        public void Insert(Availability availability)
        {
            _context.Availabilities.Add(availability);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Availability adpEvent)
        {
            _context.Entry(adpEvent).State = EntityState.Modified;
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
