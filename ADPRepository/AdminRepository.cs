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
    public class AdminRepository : IAdminRepository
    {
        private readonly ADP_DB_New1Entities _context;
        public AdminRepository()
        {
            _context = new ADP_DB_New1Entities();
        }
        public AdminRepository(ADP_DB_New1Entities context)
        {
            _context = context;
        }


        public IEnumerable<Admin> GetAll()
        {
            var adminList = _context.Admins.ToList();
            return adminList;
        }

        public Admin GetById(int adminID)
        {
            var admin = _context.Admins.Find(adminID);
            return admin;
        }

        public void Insert(Admin admin)
        {
            _context.Admins.Add(admin);

        }
        public void Delete(int admin)
        {
            Admin curr_admin = _context.Admins.Find(admin);
            _context.Admins.Remove(curr_admin);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Admin admin)
        {
            _context.Entry(admin).State = EntityState.Modified;
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
