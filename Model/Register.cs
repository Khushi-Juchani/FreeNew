using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADPRepository;
using AwayDayPlanner.Entities;
//using ADPDataAccess;
using ADPDataAccessProj;

namespace AwayDayPlanner.Model
{
    public class Register
    {

        public bool RegisterClients(ClientEntity clientEntity)
        {
            var hashedpassword = HashedPassword(clientEntity.ADPPassword);
            ClientRepository client = new ClientRepository();

            Client clientobj = new Client();
            clientobj.ClientName = clientEntity.ADPClientName;

            clientobj.ClientType = clientEntity.ADPClientType;
            clientobj.Email = clientEntity.ADPEmail;
            clientobj.Password = hashedpassword;
            clientEntity.ADPClientNumber = clientEntity.ADPClientNumber;


            try
            {
                client.Insert(clientobj);
                client.Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public int GetClientIDbyName(string Name)
        {
            ClientRepository client = new ClientRepository();

            


            try
            {
                var clientres = client.GetAll().Where(x=>x.ClientName.Contains(Name)).FirstOrDefault();
              
                return clientres.ClientID;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public List<Client> GetClients()
        {
            ClientRepository clientRepository = new ClientRepository();

            var clients = clientRepository.GetAll().ToList();

            return clients;
        }
        private string HashedPassword(string currentPasswordText)
        {
            var sha1 = System.Security.Cryptography.SHA1.Create();
            var inputBytes = Encoding.ASCII.GetBytes(currentPasswordText);
            var hash = sha1.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (var i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }
    }
}
