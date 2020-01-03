using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace ADPRepository
{
    interface IEventRepository
    {
        IEnumerable<Event> GetAll();
        Event GetByName(string eventNumber);
        void Insert(Event adpEvent);
        Event getEventByName(string eventName);
        void Update(Event adpEvent);
        void Delete(string adpEventNumber);
        void Save();
    }
}
