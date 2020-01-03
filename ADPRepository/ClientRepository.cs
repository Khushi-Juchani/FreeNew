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

    public class ClientRepository : IClientRepository
    {
        private readonly ADP_DB_New1Entities _context;

        public ClientRepository()
        {
            _context = new ADP_DB_New1Entities();
        }
        public ClientRepository(ADP_DB_New1Entities context)
        {
            _context = context;
        }

        public void Delete(int clientID)
        {
            Client client = _context.Clients.Find(clientID);
            _context.Clients.Remove(client);
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client GetById(int clientID)
        {
            return _context.Clients.Find(clientID);
        }

        public void Insert(Client client)
        {
            _context.Clients.Add(client);
        }
        public void Update(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
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
