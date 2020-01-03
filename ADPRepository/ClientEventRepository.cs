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
    public class ClientEventRepository : IClientEventRepository
    {
        private readonly ADP_DB_New1Entities _context;
        public ClientEventRepository()
        {
            _context = new ADP_DB_New1Entities();
        }
        public ClientEventRepository(ADP_DB_New1Entities context)
        {
            _context = context;
        }
        public void Delete(int eventID, int ClientID)
        {
            var curr_event = _context.ClientEvents.Where(x=>x.Event_ID == eventID && x.Client_ID == ClientID).FirstOrDefault();
            _context.ClientEvents.Remove(curr_event);
        }

        public IEnumerable<ClientEvent> GetAll()
        {
            var clientEvents = _context.ClientEvents.ToList();
            return clientEvents;
        }

        public ClientEvent GetByID(int eventID, int ClientID)
        {
            var curr_event = _context.ClientEvents.Where(x => x.Event_ID == eventID && x.Client_ID == ClientID).FirstOrDefault();
            return curr_event;
        }

        public void Insert(ClientEvent adpClientEvent)
        {
            _context.ClientEvents.Add(adpClientEvent);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(ClientEvent adpClientEvent)
        {
            _context.Entry(adpClientEvent).State = EntityState.Modified;
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
