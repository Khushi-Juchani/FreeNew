using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace ADPRepository
{
    interface IAvailability
    {
        IEnumerable<Availability> GetAll();
        List<Availability> GetByEventID(int eventID);
        void Insert(Availability availability);
        void Update(Availability adpEvent);
        void Delete(int eventID);
        void Save();
    }
}
