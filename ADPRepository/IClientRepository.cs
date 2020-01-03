using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ADPDataAccess;
using ADPDataAccessProj;
namespace ADPRepository
{
    interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client GetById(int clientID);
        void Insert(Client client);
        void Update(Client client);
        void Delete(int client);
        void Save();
    }
}
