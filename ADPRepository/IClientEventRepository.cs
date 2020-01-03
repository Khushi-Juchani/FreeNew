using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace ADPRepository
{
    interface IClientEventRepository
    {
        IEnumerable<ClientEvent> GetAll();
        ClientEvent GetByID(int eventID, int ClientID);
        void Insert(ClientEvent adpClientEvent);
        void Update(ClientEvent adpClientEvent);
        void Delete(int eventID, int ClientID);
        void Save();
    }
}
