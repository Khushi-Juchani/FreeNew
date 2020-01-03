//using ADPDataAccess;
using ADPRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADPDataAccessProj;

namespace AwayDayPlanner.Model
{
    class Book
    {

        int EventID { set; get; }
        int ClientID { get; set; }
        string ClientName { get; set; }
        DateTime AvailabilityDate { get; set; }

        int AddtionalCost { get; set; }
        bool isComplete { get; set; }
        ClientEventRepository clienteventRep = new ClientEventRepository();
        public bool BookEvent(int ClientID, int EventID, DateTime eventDate, bool iscomplete, int AdditionalCost, string AdditionalComments)
        {
            ClientEvent clientEvent = new ClientEvent();
            clientEvent.AdditionalCost = AdditionalCost;
            clientEvent.Client_ID = ClientID;
            clientEvent.Event_ID = EventID;
            clientEvent.isCompleted = false;
            clientEvent.AdditionalComment = AdditionalComments;
            clientEvent.EventDate = eventDate;
            try
            {
                clienteventRep.Insert(clientEvent);
                clienteventRep.Save();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public List<ClientEvent> GetClientEvent(int ClientID)
        {
            var clienteventList = clienteventRep.GetAll().Where(x => x.Client_ID == ClientID).ToList();
            return clienteventList;
        }
    }
}
