using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace ADPRepository
{
    public interface IAdminRepository
    {
        IEnumerable<Admin> GetAll();
        Admin GetById(int adminID);
        void Insert(Admin admin);
        void Update(Admin admin);
        void Delete(int admin);
        void Save();
    }
}
