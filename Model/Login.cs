using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADPRepository;
using System.Security.Cryptography;

namespace AwayDayPlanner.Model
{

    public class Login
    {
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        ClientRepository clientRep = new ClientRepository();

        public int loginUser()
        {
            var clientlist = clientRep.GetAll();

            if (clientlist.Where(x => x.ClientName.ToLower().Contains(LoginUsername.ToLower())).Count() > 0)
            {
                var curr_client = clientlist.Where(x => x.ClientName.ToLower().Contains(LoginUsername.ToLower())).SingleOrDefault();
                var hashedBytesPwd = HashedPassword(LoginPassword);
                if (hashedBytesPwd == curr_client.Password)
                {
                    return curr_client.ClientID;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public string HashedPassword(string currentPasswordText)
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
