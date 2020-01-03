using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwayDayPlanner.View;
using AwayDayPlanner.Model;
using ADPRepository;
using AwayDayPlanner.Entities;
namespace AwayDayPlanner.Presentation
{
    public class RegisterClient
    {
        IRegister _register;

     
        public RegisterClient(IRegister register)
        {
            _register = register;
        }

        public bool RegisterADPClient(ClientEntity clientEntity)
        {
            Register reg = new Register();

            var isregistered =  reg.RegisterClients(clientEntity);

            return isregistered;
        }
        public int getClientIDbyName(string clientName)
        {
            Register reg = new Register();
            var clientID = reg.GetClientIDbyName(clientName);
            return clientID;
        }


    }
}
